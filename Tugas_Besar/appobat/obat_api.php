<?php

require_once 'database.php';
require_once 'Obat.php';

$db = new MySQLDatabase();
$obat = new Obat($db);

$id = 0;
$kdobat = 0;

// Check the HTTP request method
$method = $_SERVER['REQUEST_METHOD'];

// Handle the different HTTP methods
switch ($method) {

    case 'GET':
        if (isset($_GET['id'])) {
            $id = $_GET['id'];
        }
        if (isset($_GET['kdobat'])) {
            $kdobat = $_GET['kdobat'];
        }
        if ($id > 0) {
            $result = $obat->get_by_id($id);
        } elseif ($kdobat > 0) {
            $result = $obat->get_by_kdobat($kdobat);
        } else {
            $result = $obat->get_all();
        }

        $val = array();
        while ($row = $result->fetch_assoc()) {
            $val[] = $row;
        }

        header('Content-Type: application/json');
        echo json_encode($val);
        break;

    case 'POST':
        // Add a new obat
        $obat->kdobat = $_POST['kdobat'];
        $obat->nama = $_POST['nama'];
        $obat->jenis_obat = $_POST['jenis_obat'];
        $obat->stok = $_POST['stok'];
        $obat->keterangan = $_POST['keterangan'];

        $obat->insert();
        $a = $db->affected_rows();
        if ($a > 0) {
            $data['status'] = 'success';
            $data['message'] = 'Data Obat created successfully.';
        } else {
            $data['status'] = 'failed';
            $data['message'] = 'Data Obat not created.';
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
        if (isset($_GET['kdobat'])) {
            $kdobat = $_GET['kdobat'];
        }
        parse_str(file_get_contents("php://input"), $_PUT);
        $obat->kdobat = $_PUT['kdobat'];
        $obat->nama = $_PUT['nama'];
        $obat->jenis_obat = $_PUT['jenis_obat'];
        $obat->stok = $_PUT['stok'];
        $obat->keterangan = $_PUT['keterangan'];

        if ($id > 0) {
            $obat->update($id);
        } elseif ($kdobat <> "") {
            $obat->update_by_kdobat($kdobat);
        } else {
        }

        $a = $db->affected_rows();
        if ($a > 0) {
            $data['status'] = 'success';
            $data['message'] = 'Data Obat updated successfully.';
        } else {
            $data['status'] = 'failed';
            $data['message'] = 'Data Obat update failed.';
        }
        header('Content-Type: application/json');
        echo json_encode($data);
        break;

    case 'DELETE':
        // Delete a user
        if (isset($_GET['id'])) {
            $id = $_GET['id'];
        }
        if (isset($_GET['kdobat'])) {
            $kdobat = $_GET['kdobat'];
        }
        if ($id > 0) {
            $obat->delete($id);
        } elseif ($kdobat > 0) {
            $obat->delete_by_kdobat($kdobat);
        } else {
        }

        $a = $db->affected_rows();
        if ($a > 0) {
            $data['status'] = 'success';
            $data['message'] = 'Data obat deleted successfully.';
        } else {
            $data['status'] = 'failed';
            $data['message'] = 'Data obat delete failed.';
        }
        header('Content-Type: application/json');
        echo json_encode($data);
        break;

    default:
        header("HTTP/1.0 405 Method Not Allowed");
        break;
}
$db->close();
