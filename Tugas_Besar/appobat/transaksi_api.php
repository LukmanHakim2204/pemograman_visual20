<?php

require_once 'database.php';
require_once 'Transaksi.php';

$db = new MySQLDatabase();
$transaksi = new Transaksi($db);

$id = 0;
$kode_transaksi = 0;

// Check the HTTP request method
$method = $_SERVER['REQUEST_METHOD'];

// Handle the different HTTP methods
switch ($method) {

    case 'GET':
        if (isset($_GET['id'])) {
            $id = $_GET['id'];
        }
        if (isset($_GET['kode_transaksi'])) {
            $kode_transaksi = $_GET['kode_transaksi'];
        }
        if ($id > 0) {
            $result = $transaksi->get_by_id($id);
        } elseif ($kode_transaksi > 0) {
            $result = $transaksi->get_by_kode_transaksi($kode_transaksi);
        } else {
            $result = $transaksi->get_all();
        }

        $val = array();
        while ($row = $result->fetch_assoc()) {
            $val[] = $row;
        }

        header('Content-Type: application/json');
        echo json_encode($val);
        break;

    case 'POST':
        // Add a new transaksi
        $transaksi->kode_transaksi = $_POST['kode_transaksi'];
        $transaksi->nip = $_POST['nip'];
        $transaksi->kdcustomer = $_POST['kdcustomer'];
        $transaksi->kdobat = $_POST['kdobat'];
        $transaksi->jumlah_obat = $_POST['jumlah_obat'];
        $transaksi->harga_satuan = $_POST['harga_satuan'];
        $transaksi->total_harga = $_POST['total_harga'];

        $transaksi->insert();
        $a = $db->affected_rows();
        if ($a > 0) {
            $data['status'] = 'success';
            $data['message'] = 'Data transaksi created successfully.';
        } else {
            $data['status'] = 'failed';
            $data['message'] = 'Data transaksi not created.';
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
        if (isset($_GET['kode_transaksi'])) {
            $kode_transaksi = $_GET['kode_transaksi'];
        }
        parse_str(file_get_contents("php://input"), $_PUT);
        $transaksi->kode_transaksi = $_PUT['kode_transaksi'];
        $transaksi->nip = $_PUT['nip'];
        $transaksi->kdcustomer = $_PUT['kdcustomer'];
        $transaksi->kdobat = $_PUT['kdobat'];
        $transaksi->jumlah_obat = $_PUT['jumlah_obat'];
        $transaksi->harga_satuan = $_PUT['harga_satuan'];
        $transaksi->total_harga = $_PUT['total_harga'];

        if ($id > 0) {
            $transaksi->update($id);
        } elseif ($kode_transaksi <> "") {
            $transaksi->update_by_kode_transaksi($kode_transaksi);
        } else {
        }

        $a = $db->affected_rows();
        if ($a > 0) {
            $data['status'] = 'success';
            $data['message'] = 'Data transaksi updated successfully.';
        } else {
            $data['status'] = 'failed';
            $data['message'] = 'Data transaksi update failed.';
        }
        header('Content-Type: application/json');
        echo json_encode($data);
        break;

    case 'DELETE':
        // Delete a user
        if (isset($_GET['id'])) {
            $id = $_GET['id'];
        }
        if (isset($_GET['kode_transaksi'])) {
            $kode_transaksi = $_GET['kode_transaksi'];
        }
        if ($id > 0) {
            $transaksi->delete($id);
        } elseif ($kode_transaksi > 0) {
            $transaksi->delete_by_kode_transaksi($kode_transaksi);
        } else {
        }

        $a = $db->affected_rows();
        if ($a > 0) {
            $data['status'] = 'success';
            $data['message'] = 'Data transaksi deleted successfully.';
        } else {
            $data['status'] = 'failed';
            $data['message'] = 'Data transaksi delete failed.';
        }
        header('Content-Type: application/json');
        echo json_encode($data);
        break;

    default:
        header("HTTP/1.0 405 Method Not Allowed");
        break;
}
$db->close();
