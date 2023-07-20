<?php
require_once 'database.php';
require_once 'Apoteker.php';
$db = new MySQLDatabase();
$apoteker = new Apoteker($db);
$id = 0;
$nip = 0;
// Check the HTTP request method
$method = $_SERVER['REQUEST_METHOD'];
// Handle the different HTTP methods
switch ($method) {
    case 'GET':
        if (isset($_GET['id'])) {
            $id = $_GET['id'];
        }
        if (isset($_GET['nip'])) {
            $nip = $_GET['nip'];
        }
        if ($id > 0) {
            $result = $apoteker->get_by_id($id);
        } elseif ($nip > 0) {
            $result = $apoteker->get_by_nip($nip);
        } else {
            $result = $apoteker->get_all();
        }

        $val = array();
        while ($row = $result->fetch_assoc()) {
            $val[] = $row;
        }

        header('Content-Type: application/json');
        echo json_encode($val);
        break;

    case 'POST':
        // Add a new apoteker
        $apoteker->nip = $_POST['nip'];
        $apoteker->nama = $_POST['nama'];
        $apoteker->jk = $_POST['jk'];
        $apoteker->nohp = $_POST['nohp'];

        $apoteker->insert();
        $a = $db->affected_rows();
        if ($a > 0) {
            $data['status'] = 'success';
            $data['message'] = 'Data apoteker created successfully.';
        } else {
            $data['status'] = 'failed';
            $data['message'] = 'Data apoteker not created.';
        }
        header('Content-Type: application/json');
        echo json_encode($data);
        break;
    case 'PUT':
        // Update an existing data
        $_PUT = [];
        if (isset($_GET['id'])) {
            $id = $_GET['id'];
        }
        if (isset($_GET['nip'])) {
            $nip = $_GET['nip'];
        }
        parse_str(file_get_contents("php://input"), $_PUT);
        $apoteker->nip = $_PUT['nip'];
        $apoteker->nama = $_PUT['nama'];
        $apoteker->jk = $_PUT['jk'];
        $apoteker->nohp = $_PUT['nohp'];
        if ($id > 0) {
            $apoteker->update($id);
        } elseif ($nip <> "") {
            $apoteker->update_by_nip($nip);
        } else {
        }

        $a = $db->affected_rows();
        if ($a > 0) {
            $data['status'] = 'success';
            $data['message'] = 'Data Apoteker updated successfully.';
        } else {
            $data['status'] = 'failed';
            $data['message'] = 'Data Apoteker update failed.';
        }
        header('Content-Type: application/json');
        echo json_encode($data);
        break;
    case 'DELETE':
        // Delete a user
        if (isset($_GET['id'])) {
            $id = $_GET['id'];
        }
        if (isset($_GET['nip'])) {
            $nip = $_GET['nip'];
        }
        if ($id > 0) {
            $apoteker->delete($id);
        } elseif ($nip > 0) {
            $apoteker->delete_by_nip($nip);
        } else {
        }

        $a = $db->affected_rows();
        if ($a > 0) {
            $data['status'] = 'success';
            $data['message'] = 'Data apoteker deleted successfully.';
        } else {
            $data['status'] = 'failed';
            $data['message'] = 'Data apoteker delete failed.';
        }
        header('Content-Type: application/json');
        echo json_encode($data);
        break;
    default:
        header("HTTP/1.0 405 Method Not Allowed");
        break;
}
$db->close();
