<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayrollCalc
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.picPayroll = New System.Windows.Forms.PictureBox()
        Me.lblPayrollTitle = New System.Windows.Forms.Label()
        Me.lblPaycheck = New System.Windows.Forms.Label()
        Me.lblCalculation = New System.Windows.Forms.Label()
        Me.lblGrossPay = New System.Windows.Forms.Label()
        Me.txtGrossPay = New System.Windows.Forms.TextBox()
        Me.btnComputeTaxes = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblFica = New System.Windows.Forms.Label()
        Me.lblFedTax = New System.Windows.Forms.Label()
        Me.lblStateTax = New System.Windows.Forms.Label()
        Me.lblFicaResult = New System.Windows.Forms.Label()
        Me.lblFedTaxResult = New System.Windows.Forms.Label()
        Me.lblStateTaxResult = New System.Windows.Forms.Label()
        Me.lblNetPayIncome = New System.Windows.Forms.Label()
        Me.lblNetIncomeCalc = New System.Windows.Forms.Label()
        CType(Me.picPayroll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picPayroll
        '
        Me.picPayroll.Image = Global.PayrollCalculator.My.Resources.Resources.payroll
        Me.picPayroll.Location = New System.Drawing.Point(-1, 1)
        Me.picPayroll.Name = "picPayroll"
        Me.picPayroll.Size = New System.Drawing.Size(347, 273)
        Me.picPayroll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPayroll.TabIndex = 0
        Me.picPayroll.TabStop = False
        '
        'lblPayrollTitle
        '
        Me.lblPayrollTitle.AutoSize = True
        Me.lblPayrollTitle.Font = New System.Drawing.Font("Georgia", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayrollTitle.Location = New System.Drawing.Point(372, 49)
        Me.lblPayrollTitle.Name = "lblPayrollTitle"
        Me.lblPayrollTitle.Size = New System.Drawing.Size(365, 43)
        Me.lblPayrollTitle.TabIndex = 1
        Me.lblPayrollTitle.Text = "Payroll Calculator"
        '
        'lblPaycheck
        '
        Me.lblPaycheck.AutoSize = True
        Me.lblPaycheck.Font = New System.Drawing.Font("Georgia", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaycheck.Location = New System.Drawing.Point(478, 149)
        Me.lblPaycheck.Name = "lblPaycheck"
        Me.lblPaycheck.Size = New System.Drawing.Size(153, 34)
        Me.lblPaycheck.TabIndex = 2
        Me.lblPaycheck.Text = "Paycheck"
        Me.lblPaycheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCalculation
        '
        Me.lblCalculation.AutoSize = True
        Me.lblCalculation.Font = New System.Drawing.Font("Georgia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalculation.Location = New System.Drawing.Point(468, 201)
        Me.lblCalculation.Name = "lblCalculation"
        Me.lblCalculation.Size = New System.Drawing.Size(172, 31)
        Me.lblCalculation.TabIndex = 3
        Me.lblCalculation.Text = "Calculation"
        '
        'lblGrossPay
        '
        Me.lblGrossPay.AutoSize = True
        Me.lblGrossPay.Font = New System.Drawing.Font("Georgia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrossPay.Location = New System.Drawing.Point(203, 310)
        Me.lblGrossPay.Name = "lblGrossPay"
        Me.lblGrossPay.Size = New System.Drawing.Size(247, 31)
        Me.lblGrossPay.TabIndex = 4
        Me.lblGrossPay.Text = "Enter Gross Pay:"
        '
        'txtGrossPay
        '
        Me.txtGrossPay.Location = New System.Drawing.Point(498, 320)
        Me.txtGrossPay.Name = "txtGrossPay"
        Me.txtGrossPay.Size = New System.Drawing.Size(100, 20)
        Me.txtGrossPay.TabIndex = 5
        '
        'btnComputeTaxes
        '
        Me.btnComputeTaxes.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnComputeTaxes.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComputeTaxes.ForeColor = System.Drawing.Color.White
        Me.btnComputeTaxes.Location = New System.Drawing.Point(112, 366)
        Me.btnComputeTaxes.Name = "btnComputeTaxes"
        Me.btnComputeTaxes.Size = New System.Drawing.Size(120, 35)
        Me.btnComputeTaxes.TabIndex = 6
        Me.btnComputeTaxes.Text = "Compute Taxes"
        Me.btnComputeTaxes.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnClear.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(340, 366)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(120, 35)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnExit.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(568, 366)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(120, 35)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblFica
        '
        Me.lblFica.AutoSize = True
        Me.lblFica.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFica.Location = New System.Drawing.Point(111, 432)
        Me.lblFica.Name = "lblFica"
        Me.lblFica.Size = New System.Drawing.Size(50, 16)
        Me.lblFica.TabIndex = 9
        Me.lblFica.Text = "FICA:"
        '
        'lblFedTax
        '
        Me.lblFedTax.AutoSize = True
        Me.lblFedTax.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFedTax.Location = New System.Drawing.Point(335, 431)
        Me.lblFedTax.Name = "lblFedTax"
        Me.lblFedTax.Size = New System.Drawing.Size(98, 16)
        Me.lblFedTax.TabIndex = 10
        Me.lblFedTax.Text = "Federal Tax:"
        '
        'lblStateTax
        '
        Me.lblStateTax.AutoSize = True
        Me.lblStateTax.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStateTax.Location = New System.Drawing.Point(564, 431)
        Me.lblStateTax.Name = "lblStateTax"
        Me.lblStateTax.Size = New System.Drawing.Size(80, 16)
        Me.lblStateTax.TabIndex = 11
        Me.lblStateTax.Text = "State Tax:"
        '
        'lblFicaResult
        '
        Me.lblFicaResult.AutoSize = True
        Me.lblFicaResult.Location = New System.Drawing.Point(168, 433)
        Me.lblFicaResult.Name = "lblFicaResult"
        Me.lblFicaResult.Size = New System.Drawing.Size(39, 13)
        Me.lblFicaResult.TabIndex = 12
        Me.lblFicaResult.Text = "Label1"
        Me.lblFicaResult.Visible = False
        '
        'lblFedTaxResult
        '
        Me.lblFedTaxResult.AutoSize = True
        Me.lblFedTaxResult.Location = New System.Drawing.Point(437, 433)
        Me.lblFedTaxResult.Name = "lblFedTaxResult"
        Me.lblFedTaxResult.Size = New System.Drawing.Size(39, 13)
        Me.lblFedTaxResult.TabIndex = 13
        Me.lblFedTaxResult.Text = "Label2"
        Me.lblFedTaxResult.Visible = False
        '
        'lblStateTaxResult
        '
        Me.lblStateTaxResult.AutoSize = True
        Me.lblStateTaxResult.Location = New System.Drawing.Point(651, 433)
        Me.lblStateTaxResult.Name = "lblStateTaxResult"
        Me.lblStateTaxResult.Size = New System.Drawing.Size(39, 13)
        Me.lblStateTaxResult.TabIndex = 14
        Me.lblStateTaxResult.Text = "Label3"
        Me.lblStateTaxResult.Visible = False
        '
        'lblNetPayIncome
        '
        Me.lblNetPayIncome.AutoSize = True
        Me.lblNetPayIncome.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetPayIncome.Location = New System.Drawing.Point(224, 497)
        Me.lblNetPayIncome.Name = "lblNetPayIncome"
        Me.lblNetPayIncome.Size = New System.Drawing.Size(287, 29)
        Me.lblNetPayIncome.TabIndex = 15
        Me.lblNetPayIncome.Text = "Net Paycheck Income:"
        '
        'lblNetIncomeCalc
        '
        Me.lblNetIncomeCalc.AutoSize = True
        Me.lblNetIncomeCalc.Location = New System.Drawing.Point(538, 509)
        Me.lblNetIncomeCalc.Name = "lblNetIncomeCalc"
        Me.lblNetIncomeCalc.Size = New System.Drawing.Size(39, 13)
        Me.lblNetIncomeCalc.TabIndex = 16
        Me.lblNetIncomeCalc.Text = "Label1"
        Me.lblNetIncomeCalc.Visible = False
        '
        'frmPayrollCalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 589)
        Me.Controls.Add(Me.lblNetIncomeCalc)
        Me.Controls.Add(Me.lblNetPayIncome)
        Me.Controls.Add(Me.lblStateTaxResult)
        Me.Controls.Add(Me.lblFedTaxResult)
        Me.Controls.Add(Me.lblFicaResult)
        Me.Controls.Add(Me.lblStateTax)
        Me.Controls.Add(Me.lblFedTax)
        Me.Controls.Add(Me.lblFica)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnComputeTaxes)
        Me.Controls.Add(Me.txtGrossPay)
        Me.Controls.Add(Me.lblGrossPay)
        Me.Controls.Add(Me.lblCalculation)
        Me.Controls.Add(Me.lblPaycheck)
        Me.Controls.Add(Me.lblPayrollTitle)
        Me.Controls.Add(Me.picPayroll)
        Me.Name = "frmPayrollCalc"
        Me.Text = "Payroll Every Two Weeks"
        CType(Me.picPayroll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picPayroll As PictureBox
    Friend WithEvents lblPayrollTitle As Label
    Friend WithEvents lblPaycheck As Label
    Friend WithEvents lblCalculation As Label
    Friend WithEvents lblGrossPay As Label
    Friend WithEvents txtGrossPay As TextBox
    Friend WithEvents btnComputeTaxes As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblFica As Label
    Friend WithEvents lblFedTax As Label
    Friend WithEvents lblStateTax As Label
    Friend WithEvents lblFicaResult As Label
    Friend WithEvents lblFedTaxResult As Label
    Friend WithEvents lblStateTaxResult As Label
    Friend WithEvents lblNetPayIncome As Label
    Friend WithEvents lblNetIncomeCalc As Label
End Class
