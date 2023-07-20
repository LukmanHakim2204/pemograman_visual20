<?php
//Simpanlah dengan nama file : Mahasiswa.php
require_once 'database.php';
class Apoteker
{
    private $db;
    private $table = 'apoteker';
    public $nip = "";
    public $nama = "";
    public $jk = "";
    public $nohp = "";
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
    public function get_by_nip(int $nip)
    {
        $query = "SELECT * FROM $this->table WHERE nip = $nip";
        $result_set = $this->db->query($query);
        return $result_set;
    }
    public function insert(): int
    {
        $query = "INSERT INTO $this->table (`nip`,`nama`,`jk`,`nohp`) VALUES ('$this->nip','$this->nama','$this->jk','$this->nohp')";
        $this->db->query($query);
        return $this->db->insert_id();
    }
    public function update(int $id): int
    {
        $query = "UPDATE $this->table SET nip = '$this->nip', nama = '$this->nama', jk = '$this->jk', nohp = '$this->nohp' 
        WHERE id = $id";
        $this->db->query($query);
        return $this->db->affected_rows();
    }
    public function update_by_nip($nip): int
    {
        $query = "UPDATE $this->table SET nip = '$this->nip', nama = '$this->nama', jk = '$this->jk', nohp = '$this->nohp' 
        WHERE nip = $nip";
        $this->db->query($query);
        return $this->db->affected_rows();
    }
    public function delete(int $id): int
    {
        $query = "DELETE FROM $this->table WHERE id = $id";
        $this->db->query($query);
        return $this->db->affected_rows();
    }
    public function delete_by_nip($nip): int
    {
        $query = "DELETE FROM $this->table WHERE nip = $nip";
        $this->db->query($query);
        return $this->db->affected_rows();
    }
}
