<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gboDonut = New System.Windows.Forms.GroupBox()
        Me.radFilled = New System.Windows.Forms.RadioButton()
        Me.radChoco = New System.Windows.Forms.RadioButton()
        Me.radSugar = New System.Windows.Forms.RadioButton()
        Me.radGlazed = New System.Windows.Forms.RadioButton()
        Me.gboNum = New System.Windows.Forms.GroupBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblSub = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gboCoffee = New System.Windows.Forms.GroupBox()
        Me.radCappuccino = New System.Windows.Forms.RadioButton()
        Me.radRegular = New System.Windows.Forms.RadioButton()
        Me.radNone = New System.Windows.Forms.RadioButton()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.gboDonut.SuspendLayout()
        Me.gboNum.SuspendLayout()
        Me.gboCoffee.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(388, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Our doughnuts and coffee are the best in town!"
        '
        'gboDonut
        '
        Me.gboDonut.Controls.Add(Me.radFilled)
        Me.gboDonut.Controls.Add(Me.radChoco)
        Me.gboDonut.Controls.Add(Me.radSugar)
        Me.gboDonut.Controls.Add(Me.radGlazed)
        Me.gboDonut.Location = New System.Drawing.Point(57, 60)
        Me.gboDonut.Name = "gboDonut"
        Me.gboDonut.Size = New System.Drawing.Size(162, 163)
        Me.gboDonut.TabIndex = 1
        Me.gboDonut.TabStop = False
        Me.gboDonut.Text = "Doughnut choices"
        '
        'radFilled
        '
        Me.radFilled.AutoSize = True
        Me.radFilled.Location = New System.Drawing.Point(32, 119)
        Me.radFilled.Name = "radFilled"
        Me.radFilled.Size = New System.Drawing.Size(85, 17)
        Me.radFilled.TabIndex = 3
        Me.radFilled.Text = "&Filled ($1.50)"
        Me.radFilled.UseVisualStyleBackColor = True
        '
        'radChoco
        '
        Me.radChoco.AutoSize = True
        Me.radChoco.Location = New System.Drawing.Point(32, 90)
        Me.radChoco.Name = "radChoco"
        Me.radChoco.Size = New System.Drawing.Size(109, 17)
        Me.radChoco.TabIndex = 2
        Me.radChoco.Text = "&Chocolate ($1.25)"
        Me.radChoco.UseVisualStyleBackColor = True
        '
        'radSugar
        '
        Me.radSugar.AutoSize = True
        Me.radSugar.Location = New System.Drawing.Point(32, 61)
        Me.radSugar.Name = "radSugar"
        Me.radSugar.Size = New System.Drawing.Size(89, 17)
        Me.radSugar.TabIndex = 1
        Me.radSugar.Text = "&Sugar ($1.05)"
        Me.radSugar.UseVisualStyleBackColor = True
        '
        'radGlazed
        '
        Me.radGlazed.AutoSize = True
        Me.radGlazed.Checked = True
        Me.radGlazed.Location = New System.Drawing.Point(32, 31)
        Me.radGlazed.Name = "radGlazed"
        Me.radGlazed.Size = New System.Drawing.Size(94, 17)
        Me.radGlazed.TabIndex = 0
        Me.radGlazed.TabStop = True
        Me.radGlazed.Text = "&Glazed ($1.05)"
        Me.radGlazed.UseVisualStyleBackColor = True
        '
        'gboNum
        '
        Me.gboNum.Controls.Add(Me.lblTotal)
        Me.gboNum.Controls.Add(Me.lblTax)
        Me.gboNum.Controls.Add(Me.lblSub)
        Me.gboNum.Controls.Add(Me.Label4)
        Me.gboNum.Controls.Add(Me.Label3)
        Me.gboNum.Controls.Add(Me.Label2)
        Me.gboNum.Location = New System.Drawing.Point(258, 60)
        Me.gboNum.Name = "gboNum"
        Me.gboNum.Size = New System.Drawing.Size(162, 163)
        Me.gboNum.TabIndex = 2
        Me.gboNum.TabStop = False
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Location = New System.Drawing.Point(87, 118)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(54, 26)
        Me.lblTotal.TabIndex = 5
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTax
        '
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTax.Location = New System.Drawing.Point(87, 72)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(54, 26)
        Me.lblTax.TabIndex = 4
        Me.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSub
        '
        Me.lblSub.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSub.Location = New System.Drawing.Point(87, 28)
        Me.lblSub.Name = "lblSub"
        Me.lblSub.Size = New System.Drawing.Size(54, 26)
        Me.lblSub.TabIndex = 3
        Me.lblSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Total due:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Sales tax:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Subtotal:"
        '
        'gboCoffee
        '
        Me.gboCoffee.Controls.Add(Me.radCappuccino)
        Me.gboCoffee.Controls.Add(Me.radRegular)
        Me.gboCoffee.Controls.Add(Me.radNone)
        Me.gboCoffee.Location = New System.Drawing.Point(57, 242)
        Me.gboCoffee.Name = "gboCoffee"
        Me.gboCoffee.Size = New System.Drawing.Size(162, 124)
        Me.gboCoffee.TabIndex = 2
        Me.gboCoffee.TabStop = False
        Me.gboCoffee.Text = "Coffee choices"
        '
        'radCappuccino
        '
        Me.radCappuccino.AutoSize = True
        Me.radCappuccino.Location = New System.Drawing.Point(28, 88)
        Me.radCappuccino.Name = "radCappuccino"
        Me.radCappuccino.Size = New System.Drawing.Size(118, 17)
        Me.radCappuccino.TabIndex = 6
        Me.radCappuccino.Text = "Cap&puccino ($2.75)"
        Me.radCappuccino.UseVisualStyleBackColor = True
        '
        'radRegular
        '
        Me.radRegular.AutoSize = True
        Me.radRegular.Location = New System.Drawing.Point(28, 59)
        Me.radRegular.Name = "radRegular"
        Me.radRegular.Size = New System.Drawing.Size(98, 17)
        Me.radRegular.TabIndex = 5
        Me.radRegular.Text = "&Regular ($1.50)"
        Me.radRegular.UseVisualStyleBackColor = True
        '
        'radNone
        '
        Me.radNone.AutoSize = True
        Me.radNone.Checked = True
        Me.radNone.Location = New System.Drawing.Point(28, 29)
        Me.radNone.Name = "radNone"
        Me.radNone.Size = New System.Drawing.Size(51, 17)
        Me.radNone.TabIndex = 4
        Me.radNone.TabStop = True
        Me.radNone.Text = "&None"
        Me.radNone.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(326, 255)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(94, 33)
        Me.btnCalc.TabIndex = 3
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(326, 301)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(94, 33)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 392)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.gboCoffee)
        Me.Controls.Add(Me.gboNum)
        Me.Controls.Add(Me.gboDonut)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmMain"
        Me.Text = "Main Form"
        Me.gboDonut.ResumeLayout(False)
        Me.gboDonut.PerformLayout()
        Me.gboNum.ResumeLayout(False)
        Me.gboNum.PerformLayout()
        Me.gboCoffee.ResumeLayout(False)
        Me.gboCoffee.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents gboDonut As GroupBox
    Friend WithEvents gboNum As GroupBox
    Friend WithEvents gboCoffee As GroupBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents radChoco As RadioButton
    Friend WithEvents radSugar As RadioButton
    Friend WithEvents radGlazed As RadioButton
    Friend WithEvents radFilled As RadioButton
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblSub As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents radCappuccino As RadioButton
    Friend WithEvents radRegular As RadioButton
    Friend WithEvents radNone As RadioButton
End Class
