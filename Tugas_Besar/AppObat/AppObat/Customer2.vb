Imports System.Net
Imports System.Text
Imports Newtonsoft.Json
Imports System.Net.Http
Public Class Customer2
    Private Sub GetData()
        Using client As New HttpClient()
            ' Send a GET request to the API endpoint
            Dim response As HttpResponseMessage = client.GetAsync(customer_api & "?kdcustomer=" & txtKode.Text).Result

            ' Check if the request was successful
            If response.IsSuccessStatusCode Then
                ' Read the response content as a string
                Dim jsonString As String = response.Content.ReadAsStringAsync().Result
                Try
                    If (jsonString = "[]") Then
                        customer_baru = True
                        MessageBox.Show("Data Not Found")
                        Exit Sub
                    Else
                        customer_baru = False
                        Exit Sub
                    End If
                Catch ex As Exception

                Finally
                    If (customer_baru = False) Then
                        ' Deserialize the JSON into objects
                        Dim data As List(Of Customer) = JsonConvert.DeserializeObject(Of List(Of Customer))(jsonString)

                        ' Create textboxes dynamically and set their values
                        For Each mydata As Customer In data
                            txtKode.Text = mydata.kdcustomer
                            txtNama.Text = mydata.nama
                            txtJK.Text = mydata.jk
                            txtEmail.Text = mydata.email
                        Next
                    End If

                End Try

            Else
                ' Request failed, handle the error
                MessageBox.Show($"Error: {response.StatusCode} - {response.ReasonPhrase}")

            End If
        End Using
    End Sub
    Private Sub GetClear()
        txtKode.Clear()
        txtNama.Clear()
        txtJK.Clear()
        txtEmail.Clear()
        Reloaded()
        txtKode.Focus()
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        GetClear()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reloaded()
    End Sub

    Private Sub Reloaded()

        ' Create a WebClient instance to make the HTTP request
        Dim client As New WebClient()

        ' Make the GET request and retrieve the response
        Dim response As String = client.DownloadString(customer_api)

        ' Deserialize the JSON response into a list of objects
        Dim data As List(Of Customer) = JsonConvert.DeserializeObject(Of List(Of Customer))(response)

        ' Bind the data to the DataGridView
        dgvData.DataSource = data
    End Sub

    Private Sub txtKode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKode.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            GetData()
        End If
    End Sub
End Class