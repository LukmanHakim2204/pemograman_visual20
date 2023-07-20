Module MyMod
    Public api_folder As String = "appobat"
    Public users_api As String = "http://f0833858.xsph.ru/" & api_folder & "/users_api.php"

    Public apoteker_api As String = "http://f0833858.xsph.ru/" & api_folder & "/apoteker_api.php"
    Public apoteker_baru As Boolean

    Public customer_api As String = "http://f0833858.xsph.ru/" & api_folder & "/customer_api.php"
    Public customer_baru As Boolean

    Public obat_api As String = "http://f0833858.xsph.ru/" & api_folder & "/obat_api.php"
    Public obat_baru As Boolean

    Public transaksi_api As String = "http://f0833858.xsph.ru/" & api_folder & "/transaksi_api.php"
    Public transaksi_baru As Boolean

    Public Dashboard As New Form1
    Public LoginForm As New login
    Public ApotekerForm As New Apoteker
    Public ObatForm As New obat
    Public Obat2Form As New obat2
    Public Customer1Form As New Customer1
    Public Customer2Form As New Customer2
    Public TransaksiForm As New Transaksi
    Public admin_role As Boolean = False
    Public apoteker_role As Boolean = False
    Public customer_role As Boolean = False
    Public login_valid As Boolean = False
End Module
