Public Class Form1
    'Variables to be used in the program; _decPrice changes based on option
    Private _decDayN As Decimal = 74.99D
    Private _decDayU As Decimal = 89.99D
    Private _decDayVIP As Decimal = 99.99D
    Private _decHotelN As Decimal = 109.99D
    Private _decHotelU As Decimal = 124.99D
    Private _decHotelVIP As Decimal = 149.99D
    Private _decPrice As Decimal
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClearForm()
    End Sub
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decTotal As Decimal
        Dim intValue As Integer
        If ValidateInput() = True Then
            intValue = Convert.ToInt32(txtAmount.Text)
            If cboVisit.SelectedIndex = 0 Then
                If radUnlimited.Checked = True Then
                    _decPrice = _decDayU
                ElseIf radVIP.Checked = True Then
                    _decPrice = _decDayVIP
                Else
                    _decPrice = _decDayN
                End If
            Else
                If radUnlimited.Checked = True Then
                    _decPrice = _decHotelU
                ElseIf radVIP.Checked = True Then
                    _decPrice = _decHotelVIP
                Else
                    _decPrice = _decHotelN
                End If
            End If
            decTotal = Calculate(intValue)
            lblCost.Visible = True
            lblCost.Text = "The total cost of your visit is " & decTotal.ToString("C")
        End If
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearForm()
    End Sub
    Private Sub cboVisit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboVisit.SelectedIndexChanged
        If cboVisit.SelectedIndex = 0 Then
            grpOption.Visible = True
            radNormal.Text = "Normal: 15 rides per person (" & _decDayN.ToString("C") & " per person)"
            radUnlimited.Text = "Upgrade: Unlimited rides (" & _decDayU.ToString("C") & " per person)"
            radVIP.Text = "VIP: Unlimited rides and skip the line (" & _decDayVIP.ToString("C") & " per person)"
            radNormal.Checked = True
            radUnlimited.Checked = False
            radVIP.Checked = False
            lblAmount.Visible = True
            lblAmount.Text = "How many people? (Max: 5)"
            txtAmount.Visible = True
            txtAmount.Clear()
            txtAmount.Focus()
            lblCost.Visible = False
            btnCalculate.Visible = True
            btnClear.Visible = True
        End If
        If cboVisit.SelectedIndex = 1 Then
            grpOption.Visible = True
            radNormal.Text = "Normal: 15 rides per person per day (" & _decHotelN.ToString("C") & " per night)"
            radUnlimited.Text = "Upgrade: Unlimited rides (" & _decHotelU.ToString("C") & " per night)"
            radVIP.Text = "VIP: Unlimited rides and skip the line (" & _decHotelVIP.ToString("C") & " per night)"
            radNormal.Checked = True
            radUnlimited.Checked = False
            radVIP.Checked = False
            lblAmount.Visible = True
            lblAmount.Text = "How many nights? (Max: 5)"
            txtAmount.Visible = True
            txtAmount.Clear()
            txtAmount.Focus()
            lblCost.Visible = False
            btnCalculate.Visible = True
            btnClear.Visible = True
        End If
    End Sub
    Private Sub ClearForm()
        'Clears form; called when program loads and when the Clear button is clicked
        cboVisit.SelectedIndex = -1
        cboVisit.Text = "Choose Your Visit"
        grpOption.Visible = False
        lblAmount.Visible = False
        lblCost.Visible = False
        txtAmount.Clear()
        txtAmount.Visible = False
        btnCalculate.Visible = False
        btnClear.Visible = False
        radNormal.Checked = True
        radUnlimited.Checked = False
        radVIP.Checked = False
    End Sub
    Private Function Calculate(ByVal intNum As Integer) As Decimal
        'Calculates cost of visit; takes integer from textbox as input
        Dim decTicketCost As Decimal
        decTicketCost = _decPrice * intNum
        Return decTicketCost
    End Function
    Private Function ValidateInput() As Boolean
        'Validates input; based on Weekly Assignmnet 7; utilizes exceptions
        Dim intNumber As Integer
        Dim blnValid As Boolean = False
        Try
            intNumber = Convert.ToInt32(txtAmount.Text)
            If intNumber > 0D And intNumber <= 5D Then
                blnValid = True
            Else
                MsgBox("Please enter a number greater than 0 and up to 5.", , "Error")
                txtAmount.Focus()
                txtAmount.Clear()
            End If
        Catch Exception As FormatException
            MsgBox("Please enter a valid number.", , "Error")
            txtAmount.Focus()
            txtAmount.Clear()
        Catch Exception As OverflowException
            MsgBox("That number is too big!", , "Error")
            txtAmount.Focus()
            txtAmount.Clear()
        Catch Exception As SystemException
            MsgBox("Entry invalid. Please enter a valid number to be used for calculation.", , "Error")
            txtAmount.Focus()
            txtAmount.Clear()
        End Try
        Return blnValid
    End Function
End Class
