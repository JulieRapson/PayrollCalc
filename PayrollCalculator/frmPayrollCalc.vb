'Author: Julie Rapson
'Date: 2/22/2023
'Program Name: Payroll Calculator / Homework 2
'Program Description: This program will have you enter your gross pay and calculate the Federal, Fica and State taxes against
'your gross pay to produce the NET pay amount and display it on the screen.  You can clear out the amounts by clicking clear and
'exit the program by clicking exit.
Public Class frmPayrollCalc
    'Define the constant variables
    Dim cdecFica As Decimal = 0.0765D
    Dim cdecFed As Decimal = 0.22D
    Dim cdecState As Decimal = 0.04D

    Private Sub frmPayrollCalc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Upon the form loading, all values need to be cleared out and the input box set to the focus.
        'labels that will have calculations are set to false visibility.
        lblFedTaxResult.Text = ""
        lblNetIncomeCalc.Text = ""
        lblFicaResult.Text = ""
        lblStateTaxResult.Text = ""
        txtGrossPay.Text = ""
        txtGrossPay.Focus()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'This button will clear out any calculations done and refocus the gross pay input box.
        lblFedTaxResult.Text = ""
        lblNetIncomeCalc.Text = ""
        lblFicaResult.Text = ""
        lblStateTaxResult.Text = ""
        txtGrossPay.Text = ""
        txtGrossPay.Focus()
    End Sub

    Private Sub btnComputeTaxes_Click(sender As Object, e As EventArgs) Handles btnComputeTaxes.Click
        'Multiple variables created to handle the tax calculations. The entered gross income value is converted to a 
        'decimal so it can be used. Each tax area is multiplied by its related constant variable to calculate 
        'the correct tax associated. Once calculations are done, these are added together but subrtracted from the total
        'income to come back with the net pay amount.
        Dim strIncome As String
        Dim decIncome As Decimal
        Dim decFica As Decimal
        Dim decFederal As Decimal
        Dim decState As Decimal
        Dim decNet As Decimal

        strIncome = txtGrossPay.Text
        decIncome = Convert.ToDecimal(strIncome)
        decFica = decIncome * cdecFica
        decFederal = decIncome * cdecFed
        decState = decIncome * cdecState
        decNet = decIncome - (decFica + decState + decFederal)
        'convert back to string and currency for display
        lblNetIncomeCalc.Text = decNet.ToString("C")
        lblFedTaxResult.Text = decFederal.ToString("C")
        lblStateTaxResult.Text = decState.ToString("C")
        lblFicaResult.Text = decFica.ToString("C")
        'make sure these are all visible
        lblNetIncomeCalc.Visible = True
        lblFicaResult.Visible = True
        lblStateTaxResult.Visible = True
        lblFedTaxResult.Visible = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'When a user clicks on the exit button, the program will close
        Close()
    End Sub
End Class
