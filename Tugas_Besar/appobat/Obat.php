<?php

require_once 'database.php';
class Obat
{
    private $db;
    private $table = 'obat';
    public $kdobat = "";
    public $nama = "";
    public $jenis_obat = "";
    public $stok = "";
    public $keterangan = "";
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
    public function get_by_kdobat(int $kdobat)
    {
        $query = "SELECT * FROM $this->table WHERE kdobat = $kdobat";
        $result_set = $this->db->query($query);
        return $result_set;
    }
    public function insert(): int
    {
        $query = "INSERT INTO $this->table (`kdobat`,`nama`,`jenis_obat`,`stok`,`keterangan`) VALUES ('$this->kdobat','$this->nama','$this->jenis_obat','$this->stok','$this->keterangan')";
        $this->db->query($query);
        return $this->db->insert_id();
    }
    public function update(int $id): int
    {
        $query = "UPDATE $this->table SET kdobat = '$this->kdobat', nama = '$this->nama', jenis_obat = '$this->jenis_obat', stok = '$this->stok', keterangan = '$this->keterangan'
        WHERE id = $id";
        $this->db->query($query);
        return $this->db->affected_rows();
    }
    public function update_by_kdobat($kdobat): int
    {
        $query = "UPDATE $this->table SET kdobat = '$this->kdobat', nama = '$this->nama', jenis_obat = '$this->jenis_obat', stok = '$this->stok', keterangan = '$this->keterangan'
        WHERE kdobat = $kdobat";
        $this->db->query($query);
        return $this->db->affected_rows();
    }
    public function delete(int $id): int
    {
        $query = "DELETE FROM $this->table WHERE id = $id";
        $this->db->query($query);
        return $this->db->affected_rows();
    }
    public function delete_by_kdobat($kdobat): int
    {
        $query = "DELETE FROM $this->table WHERE kdobat = $kdobat";
        $this->db->query($query);
        return $this->db->affected_rows();
    }
}
