<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.lbl_holder_name = New System.Windows.Forms.Label()
        Me.lbl_holder_race = New System.Windows.Forms.Label()
        Me.lbl_holder_alliance = New System.Windows.Forms.Label()
        Me.lbl_holder_age = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.lbl_race = New System.Windows.Forms.Label()
        Me.lbl_alliance = New System.Windows.Forms.Label()
        Me.lbl_age = New System.Windows.Forms.Label()
        Me.pic_apperance = New System.Windows.Forms.PictureBox()
        Me.bttn_first = New System.Windows.Forms.Button()
        Me.bttn_previous = New System.Windows.Forms.Button()
        Me.bttn_next = New System.Windows.Forms.Button()
        Me.bttn_last = New System.Windows.Forms.Button()
        Me.SW_dataDataSet = New SW_metodo_1.SW_dataDataSet()
        Me.CharactersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CharactersTableAdapter = New SW_metodo_1.SW_dataDataSetTableAdapters.CharactersTableAdapter()
        Me.CharactersBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.bttn_exit = New System.Windows.Forms.Button()
        CType(Me.pic_apperance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SW_dataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CharactersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CharactersBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_holder_name
        '
        Me.lbl_holder_name.AutoSize = True
        Me.lbl_holder_name.Location = New System.Drawing.Point(359, 39)
        Me.lbl_holder_name.Name = "lbl_holder_name"
        Me.lbl_holder_name.Size = New System.Drawing.Size(65, 20)
        Me.lbl_holder_name.TabIndex = 0
        Me.lbl_holder_name.Text = "Nombre"
        '
        'lbl_holder_race
        '
        Me.lbl_holder_race.AutoSize = True
        Me.lbl_holder_race.Location = New System.Drawing.Point(358, 74)
        Me.lbl_holder_race.Name = "lbl_holder_race"
        Me.lbl_holder_race.Size = New System.Drawing.Size(47, 20)
        Me.lbl_holder_race.TabIndex = 1
        Me.lbl_holder_race.Text = "Raza"
        '
        'lbl_holder_alliance
        '
        Me.lbl_holder_alliance.AutoSize = True
        Me.lbl_holder_alliance.Location = New System.Drawing.Point(359, 108)
        Me.lbl_holder_alliance.Name = "lbl_holder_alliance"
        Me.lbl_holder_alliance.Size = New System.Drawing.Size(56, 20)
        Me.lbl_holder_alliance.TabIndex = 2
        Me.lbl_holder_alliance.Text = "Bando"
        '
        'lbl_holder_age
        '
        Me.lbl_holder_age.AutoSize = True
        Me.lbl_holder_age.Location = New System.Drawing.Point(359, 140)
        Me.lbl_holder_age.Name = "lbl_holder_age"
        Me.lbl_holder_age.Size = New System.Drawing.Size(47, 20)
        Me.lbl_holder_age.TabIndex = 3
        Me.lbl_holder_age.Text = "Edad"
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CharactersBindingSource, "Nombre", True))
        Me.lbl_name.Location = New System.Drawing.Point(461, 39)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(65, 20)
        Me.lbl_name.TabIndex = 4
        Me.lbl_name.Text = "Nombre"
        '
        'lbl_race
        '
        Me.lbl_race.AutoSize = True
        Me.lbl_race.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CharactersBindingSource, "Raza", True))
        Me.lbl_race.Location = New System.Drawing.Point(461, 74)
        Me.lbl_race.Name = "lbl_race"
        Me.lbl_race.Size = New System.Drawing.Size(47, 20)
        Me.lbl_race.TabIndex = 5
        Me.lbl_race.Text = "Raza"
        '
        'lbl_alliance
        '
        Me.lbl_alliance.AutoSize = True
        Me.lbl_alliance.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CharactersBindingSource, "Bando", True))
        Me.lbl_alliance.Location = New System.Drawing.Point(461, 108)
        Me.lbl_alliance.Name = "lbl_alliance"
        Me.lbl_alliance.Size = New System.Drawing.Size(56, 20)
        Me.lbl_alliance.TabIndex = 6
        Me.lbl_alliance.Text = "Bando"
        '
        'lbl_age
        '
        Me.lbl_age.AutoSize = True
        Me.lbl_age.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CharactersBindingSource, "Edad", True))
        Me.lbl_age.Location = New System.Drawing.Point(461, 140)
        Me.lbl_age.Name = "lbl_age"
        Me.lbl_age.Size = New System.Drawing.Size(47, 20)
        Me.lbl_age.TabIndex = 7
        Me.lbl_age.Text = "Edad"
        '
        'pic_apperance
        '
        Me.pic_apperance.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.CharactersBindingSource, "Imagen", True))
        Me.pic_apperance.Location = New System.Drawing.Point(27, 26)
        Me.pic_apperance.Name = "pic_apperance"
        Me.pic_apperance.Size = New System.Drawing.Size(304, 296)
        Me.pic_apperance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_apperance.TabIndex = 8
        Me.pic_apperance.TabStop = False
        '
        'bttn_first
        '
        Me.bttn_first.Location = New System.Drawing.Point(362, 233)
        Me.bttn_first.Name = "bttn_first"
        Me.bttn_first.Size = New System.Drawing.Size(80, 40)
        Me.bttn_first.TabIndex = 9
        Me.bttn_first.Text = "Primero"
        Me.bttn_first.UseVisualStyleBackColor = True
        '
        'bttn_previous
        '
        Me.bttn_previous.Location = New System.Drawing.Point(448, 233)
        Me.bttn_previous.Name = "bttn_previous"
        Me.bttn_previous.Size = New System.Drawing.Size(80, 40)
        Me.bttn_previous.TabIndex = 10
        Me.bttn_previous.Text = "Anterior"
        Me.bttn_previous.UseVisualStyleBackColor = True
        '
        'bttn_next
        '
        Me.bttn_next.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.bttn_next.Location = New System.Drawing.Point(534, 233)
        Me.bttn_next.Name = "bttn_next"
        Me.bttn_next.Size = New System.Drawing.Size(80, 40)
        Me.bttn_next.TabIndex = 11
        Me.bttn_next.Text = "Siguiente"
        Me.bttn_next.UseVisualStyleBackColor = True
        '
        'bttn_last
        '
        Me.bttn_last.Location = New System.Drawing.Point(620, 233)
        Me.bttn_last.Name = "bttn_last"
        Me.bttn_last.Size = New System.Drawing.Size(80, 40)
        Me.bttn_last.TabIndex = 12
        Me.bttn_last.Text = "Ultimo"
        Me.bttn_last.UseVisualStyleBackColor = True
        '
        'SW_dataDataSet
        '
        Me.SW_dataDataSet.DataSetName = "SW_dataDataSet"
        Me.SW_dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CharactersBindingSource
        '
        Me.CharactersBindingSource.DataMember = "Characters"
        Me.CharactersBindingSource.DataSource = Me.SW_dataDataSet
        '
        'CharactersTableAdapter
        '
        Me.CharactersTableAdapter.ClearBeforeFill = True
        '
        'CharactersBindingSource1
        '
        Me.CharactersBindingSource1.DataMember = "Characters"
        Me.CharactersBindingSource1.DataSource = Me.SW_dataDataSet
        '
        'bttn_exit
        '
        Me.bttn_exit.Location = New System.Drawing.Point(490, 282)
        Me.bttn_exit.Name = "bttn_exit"
        Me.bttn_exit.Size = New System.Drawing.Size(80, 40)
        Me.bttn_exit.TabIndex = 13
        Me.bttn_exit.Text = "Salir"
        Me.bttn_exit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(903, 366)
        Me.Controls.Add(Me.bttn_exit)
        Me.Controls.Add(Me.bttn_last)
        Me.Controls.Add(Me.bttn_next)
        Me.Controls.Add(Me.bttn_previous)
        Me.Controls.Add(Me.bttn_first)
        Me.Controls.Add(Me.pic_apperance)
        Me.Controls.Add(Me.lbl_age)
        Me.Controls.Add(Me.lbl_alliance)
        Me.Controls.Add(Me.lbl_race)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.lbl_holder_age)
        Me.Controls.Add(Me.lbl_holder_alliance)
        Me.Controls.Add(Me.lbl_holder_race)
        Me.Controls.Add(Me.lbl_holder_name)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Cartas"
        CType(Me.pic_apperance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SW_dataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CharactersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CharactersBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_holder_name As Label
    Friend WithEvents lbl_holder_race As Label
    Friend WithEvents lbl_holder_alliance As Label
    Friend WithEvents lbl_holder_age As Label
    Friend WithEvents lbl_name As Label
    Friend WithEvents lbl_race As Label
    Friend WithEvents lbl_alliance As Label
    Friend WithEvents lbl_age As Label
    Friend WithEvents pic_apperance As PictureBox
    Friend WithEvents bttn_first As Button
    Friend WithEvents bttn_previous As Button
    Friend WithEvents bttn_next As Button
    Friend WithEvents bttn_last As Button
    Friend WithEvents SW_dataDataSet As SW_dataDataSet
    Friend WithEvents CharactersBindingSource As BindingSource
    Friend WithEvents CharactersTableAdapter As SW_dataDataSetTableAdapters.CharactersTableAdapter
    Friend WithEvents CharactersBindingSource1 As BindingSource
    Friend WithEvents bttn_exit As Button
End Class
