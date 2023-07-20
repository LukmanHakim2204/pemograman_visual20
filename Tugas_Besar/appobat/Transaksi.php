<?php

require_once 'database.php';
class Transaksi
{
    private $db;
    private $table = 'transaksi';
    public $kode_transaksi = "";
    public $kdobat = "";
    public $nip = "";
    public $kdcustomer = "";
    public $jumlah_obat = "";
    public $harga_satuan = "";
    public $total_harga = "";

    public function __construct(MySQLDatabase $db)
    {
        $this->db = $db;
    }
    public function get_all() 
    {
        $query = "SELECT * FROM $this->table";
        $result_set = $this->db->query($query);
        return $result_set;
    }
    public function get_by_id(int $id)
    {
        $query = "SELECT * FROM $this->table WHERE id = $id";
        $result_set = $this->db->query($query);   
        return $result_set;
    }
    public function get_by_kode_transaksi(int $kode_transaksi)
    {
        $query = "SELECT * FROM $this->table WHERE kode_transaksi = $kode_transaksi";
        $result_set = $this->db->query($query);   
        return $result_set;
    }
    public function insert(): int
    {
        $query = "INSERT INTO $this->table (`kode_transaksi`,`nip`,`kdcustomer`,`kdobat`,`jumlah_obat`,`harga_satuan`,`total_harga`) VALUES ('$this->kode_transaksi','$this->nip','$this->kdcustomer','$this->kdobat','$this->jumlah_obat','$this->harga_satuan','$this->total_harga')";
        $this->db->query($query);
        return $this->db->insert_id();
    }
    public function update(int $id): int
    {
        $query = "UPDATE $this->table SET kode_transaksi = '$this->kode_transaksi', nip = '$this->nip', kdcustomer = '$this->kdcustomer', kdobat = '$this->kdobat', jumlah_obat = '$this->jumlah_obat', harga_satuan = '$this->harga_satuan', total_harga = '$this->total_harga'
        WHERE id = $id";
        $this->db->query($query);
        return $this->db->affected_rows();
    }
    public function update_by_kode_transaksi($kode_transaksi): int
    {
        $query = "UPDATE $this->table SET kode_transaksi = '$this->kode_transaksi', nip = '$this->nip', kdcustomer = '$this->kdcustomer', kdobat = '$this->kdobat', jumlah_obat = '$this->jumlah_obat', harga_satuan = '$this->harga_satuan', total_harga = '$this->total_harga'
        WHERE kode_transaksi = $kode_transaksi";
        $this->db->query($query);
        return $this->db->affected_rows();
    }
    public function delete(int $id): int
    {
        $query = "DELETE FROM $this->table WHERE id = $id";
        $this->db->query($query);
        return $this->db->affected_rows();
    }
    public function delete_by_kode_transaksi($kode_transaksi): int
    {
        $query = "DELETE FROM $this->table WHERE kode_transaksi = $kode_transaksi";
        $this->db->query($query);
        return $this->db->affected_rows();
    }
}
