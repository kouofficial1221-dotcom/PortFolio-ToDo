<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        TabControl1 = New TabControl()
        TaskTab = New TabPage()
        Label4 = New Label()
        Label3 = New Label()
        TaskOutBut = New Button()
        TaskStarFill1 = New ComboBox()
        TaskInpTex = New TextBox()
        TaskInpBut = New Button()
        TaskIdFill1 = New ComboBox()
        DataGridView1 = New DataGridView()
        TaskPropTab = New TabPage()
        TaskOutPropBut = New Button()
        TaskpropTex = New TextBox()
        DataGridView2 = New DataGridView()
        TaskInpPropBut = New Button()
        TaskScoreTab = New TabPage()
        DataGridView4 = New DataGridView()
        BindingSource1 = New BindingSource(components)
        PomTimer = New Label()
        RealTimer = New Label()
        PomStartBut = New Button()
        PomFintBut = New Button()
        FirstPomStarTimer = New ComboBox()
        InBreakTimer = New ComboBox()
        TextBox2 = New TextBox()
        FirstTaskIdCom = New ComboBox()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        Label1 = New Label()
        Label2 = New Label()
        ComboBox3 = New ComboBox()
        ComboBox4 = New ComboBox()
        Label5 = New Label()
        Label6 = New Label()
        TabControl1.SuspendLayout()
        TaskTab.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        TaskPropTab.SuspendLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        TaskScoreTab.SuspendLayout()
        CType(DataGridView4, ComponentModel.ISupportInitialize).BeginInit()
        CType(BindingSource1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TaskTab)
        TabControl1.Controls.Add(TaskPropTab)
        TabControl1.Controls.Add(TaskScoreTab)
        TabControl1.Location = New Point(332, 96)
        TabControl1.Margin = New Padding(3, 2, 3, 2)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(440, 454)
        TabControl1.TabIndex = 0
        ' 
        ' TaskTab
        ' 
        TaskTab.AutoScroll = True
        TaskTab.BackColor = SystemColors.ActiveCaption
        TaskTab.Controls.Add(Label6)
        TaskTab.Controls.Add(TaskOutBut)
        TaskTab.Controls.Add(TaskInpTex)
        TaskTab.Controls.Add(TaskInpBut)
        TaskTab.Controls.Add(Label5)
        TaskTab.Controls.Add(DataGridView1)
        TaskTab.Controls.Add(ComboBox4)
        TaskTab.Controls.Add(ComboBox3)
        TaskTab.Location = New Point(4, 24)
        TaskTab.Margin = New Padding(3, 2, 3, 2)
        TaskTab.Name = "TaskTab"
        TaskTab.Padding = New Padding(3, 2, 3, 2)
        TaskTab.Size = New Size(432, 426)
        TaskTab.TabIndex = 0
        TaskTab.Text = "タスク"
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("メイリオ", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label4.Location = New Point(109, 83)
        Label4.Name = "Label4"
        Label4.Size = New Size(131, 16)
        Label4.TabIndex = 10
        Label4.Text = "タスク"
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("メイリオ", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label3.Location = New Point(20, 83)
        Label3.Name = "Label3"
        Label3.Size = New Size(166, 16)
        Label3.TabIndex = 10
        Label3.Text = "タスクID"
        ' 
        ' TaskOutBut
        ' 
        TaskOutBut.Location = New Point(20, 48)
        TaskOutBut.Name = "TaskOutBut"
        TaskOutBut.Size = New Size(83, 25)
        TaskOutBut.TabIndex = 9
        TaskOutBut.Text = "タスク完了"
        TaskOutBut.UseVisualStyleBackColor = True
        ' 
        ' TaskStarFill1
        ' 
        TaskStarFill1.FormattingEnabled = True
        TaskStarFill1.Location = New Point(109, 102)
        TaskStarFill1.Name = "TaskStarFill1"
        TaskStarFill1.Size = New Size(301, 23)
        TaskStarFill1.TabIndex = 16
        ' 
        ' TaskInpTex
        ' 
        TaskInpTex.AcceptsReturn = True
        TaskInpTex.Location = New Point(109, 19)
        TaskInpTex.Multiline = True
        TaskInpTex.Name = "TaskInpTex"
        TaskInpTex.Size = New Size(301, 54)
        TaskInpTex.TabIndex = 10
        ' 
        ' TaskInpBut
        ' 
        TaskInpBut.Location = New Point(20, 19)
        TaskInpBut.Name = "TaskInpBut"
        TaskInpBut.Size = New Size(83, 25)
        TaskInpBut.TabIndex = 8
        TaskInpBut.Text = "タスク追加"
        TaskInpBut.UseVisualStyleBackColor = True
        ' 
        ' TaskIdFill1
        ' 
        TaskIdFill1.FormattingEnabled = True
        TaskIdFill1.Location = New Point(20, 102)
        TaskIdFill1.Name = "TaskIdFill1"
        TaskIdFill1.Size = New Size(83, 23)
        TaskIdFill1.TabIndex = 17
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.Window
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(20, 130)
        DataGridView1.Margin = New Padding(3, 2, 3, 2)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(390, 280)
        DataGridView1.TabIndex = 0
        ' 
        ' TaskPropTab
        ' 
        TaskPropTab.BackColor = SystemColors.GradientActiveCaption
        TaskPropTab.Controls.Add(Label4)
        TaskPropTab.Controls.Add(TaskOutPropBut)
        TaskPropTab.Controls.Add(Label3)
        TaskPropTab.Controls.Add(TaskpropTex)
        TaskPropTab.Controls.Add(DataGridView2)
        TaskPropTab.Controls.Add(TaskStarFill1)
        TaskPropTab.Controls.Add(TaskInpPropBut)
        TaskPropTab.Controls.Add(TaskIdFill1)
        TaskPropTab.Location = New Point(4, 24)
        TaskPropTab.Margin = New Padding(3, 2, 3, 2)
        TaskPropTab.Name = "TaskPropTab"
        TaskPropTab.Padding = New Padding(3, 2, 3, 2)
        TaskPropTab.Size = New Size(432, 426)
        TaskPropTab.TabIndex = 1
        TaskPropTab.Text = "タスク詳細"
        ' 
        ' TaskOutPropBut
        ' 
        TaskOutPropBut.Location = New Point(20, 48)
        TaskOutPropBut.Name = "TaskOutPropBut"
        TaskOutPropBut.Size = New Size(83, 25)
        TaskOutPropBut.TabIndex = 14
        TaskOutPropBut.Text = "削除"
        TaskOutPropBut.UseVisualStyleBackColor = True
        ' 
        ' TaskpropTex
        ' 
        TaskpropTex.AcceptsReturn = True
        TaskpropTex.Location = New Point(109, 21)
        TaskpropTex.Multiline = True
        TaskpropTex.Name = "TaskpropTex"
        TaskpropTex.Size = New Size(301, 54)
        TaskpropTex.TabIndex = 13
        ' 
        ' DataGridView2
        ' 
        DataGridView2.BackgroundColor = SystemColors.Window
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Location = New Point(20, 130)
        DataGridView2.Margin = New Padding(3, 2, 3, 2)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.RowHeadersWidth = 51
        DataGridView2.Size = New Size(390, 280)
        DataGridView2.TabIndex = 11
        ' 
        ' TaskInpPropBut
        ' 
        TaskInpPropBut.Location = New Point(20, 19)
        TaskInpPropBut.Name = "TaskInpPropBut"
        TaskInpPropBut.Size = New Size(83, 25)
        TaskInpPropBut.TabIndex = 11
        TaskInpPropBut.Text = "追加"
        TaskInpPropBut.UseVisualStyleBackColor = True
        ' 
        ' TaskScoreTab
        ' 
        TaskScoreTab.BackColor = Color.DarkSeaGreen
        TaskScoreTab.Controls.Add(Label2)
        TaskScoreTab.Controls.Add(DataGridView4)
        TaskScoreTab.Controls.Add(Label1)
        TaskScoreTab.Controls.Add(ComboBox1)
        TaskScoreTab.Controls.Add(ComboBox2)
        TaskScoreTab.Location = New Point(4, 24)
        TaskScoreTab.Name = "TaskScoreTab"
        TaskScoreTab.Size = New Size(432, 426)
        TaskScoreTab.TabIndex = 2
        TaskScoreTab.Text = "タスク一覧"
        ' 
        ' DataGridView4
        ' 
        DataGridView4.BackgroundColor = SystemColors.Window
        DataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView4.Location = New Point(20, 59)
        DataGridView4.Margin = New Padding(3, 2, 3, 2)
        DataGridView4.Name = "DataGridView4"
        DataGridView4.RowHeadersWidth = 51
        DataGridView4.Size = New Size(390, 351)
        DataGridView4.TabIndex = 14
        ' 
        ' PomTimer
        ' 
        PomTimer.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        PomTimer.Font = New Font("Microsoft Sans Serif", 50.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        PomTimer.ForeColor = Color.Red
        PomTimer.Location = New Point(26, 168)
        PomTimer.Name = "PomTimer"
        PomTimer.Size = New Size(250, 100)
        PomTimer.TabIndex = 1
        PomTimer.Text = "mm:ss"
        PomTimer.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' RealTimer
        ' 
        RealTimer.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        RealTimer.Font = New Font("メイリオ", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        RealTimer.ForeColor = SystemColors.ActiveCaptionText
        RealTimer.Location = New Point(340, 31)
        RealTimer.Name = "RealTimer"
        RealTimer.Size = New Size(432, 50)
        RealTimer.TabIndex = 3
        RealTimer.Text = "yyyy/MM/dd hh:mm"
        RealTimer.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PomStartBut
        ' 
        PomStartBut.Location = New Point(45, 472)
        PomStartBut.Name = "PomStartBut"
        PomStartBut.Size = New Size(91, 38)
        PomStartBut.TabIndex = 4
        PomStartBut.Text = "タイマー開始"
        PomStartBut.UseVisualStyleBackColor = True
        ' 
        ' PomFintBut
        ' 
        PomFintBut.Location = New Point(171, 472)
        PomFintBut.Name = "PomFintBut"
        PomFintBut.Size = New Size(91, 38)
        PomFintBut.TabIndex = 5
        PomFintBut.Text = "タイマー終了"
        PomFintBut.UseVisualStyleBackColor = True
        ' 
        ' FirstPomStarTimer
        ' 
        FirstPomStarTimer.FormattingEnabled = True
        FirstPomStarTimer.Items.AddRange(New Object() {"25分", "30分"})
        FirstPomStarTimer.Location = New Point(171, 360)
        FirstPomStarTimer.Name = "FirstPomStarTimer"
        FirstPomStarTimer.Size = New Size(121, 23)
        FirstPomStarTimer.TabIndex = 6
        ' 
        ' InBreakTimer
        ' 
        InBreakTimer.FormattingEnabled = True
        InBreakTimer.Items.AddRange(New Object() {"15", "20", "25"})
        InBreakTimer.Location = New Point(171, 403)
        InBreakTimer.Name = "InBreakTimer"
        InBreakTimer.Size = New Size(121, 23)
        InBreakTimer.TabIndex = 7
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.White
        TextBox2.Font = New Font("メイリオ", 39.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        TextBox2.ForeColor = Color.Black
        TextBox2.Location = New Point(26, 31)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(266, 87)
        TextBox2.TabIndex = 8
        TextBox2.Text = "トマト君" & vbCrLf
        TextBox2.TextAlign = HorizontalAlignment.Center
        ' 
        ' FirstTaskIdCom
        ' 
        FirstTaskIdCom.FormattingEnabled = True
        FirstTaskIdCom.Location = New Point(171, 315)
        FirstTaskIdCom.Name = "FirstTaskIdCom"
        FirstTaskIdCom.Size = New Size(121, 23)
        FirstTaskIdCom.TabIndex = 9
        ' 
        ' Label7
        ' 
        Label7.Font = New Font("メイリオ", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label7.Location = New Point(42, 403)
        Label7.Name = "Label7"
        Label7.Size = New Size(91, 25)
        Label7.TabIndex = 10
        Label7.Text = "休憩時間"
        ' 
        ' Label8
        ' 
        Label8.Font = New Font("メイリオ", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label8.Location = New Point(42, 360)
        Label8.Name = "Label8"
        Label8.Size = New Size(115, 25)
        Label8.TabIndex = 10
        Label8.Text = "タスク時間"
        ' 
        ' Label9
        ' 
        Label9.Font = New Font("メイリオ", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label9.Location = New Point(42, 315)
        Label9.Name = "Label9"
        Label9.Size = New Size(94, 25)
        Label9.TabIndex = 10
        Label9.Text = "タスクID"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(20, 31)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(180, 23)
        ComboBox1.TabIndex = 17
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(230, 31)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(180, 23)
        ComboBox2.TabIndex = 16
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("メイリオ", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label1.Location = New Point(20, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(156, 16)
        Label1.TabIndex = 10
        Label1.Text = "データを設定してください。"
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("メイリオ", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label2.Location = New Point(230, 12)
        Label2.Name = "Label2"
        Label2.Size = New Size(131, 16)
        Label2.TabIndex = 10
        Label2.Text = "値を設定してください。"
        ' 
        ' ComboBox3
        ' 
        ComboBox3.FormattingEnabled = True
        ComboBox3.Location = New Point(230, 102)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(180, 23)
        ComboBox3.TabIndex = 16
        ' 
        ' ComboBox4
        ' 
        ComboBox4.FormattingEnabled = True
        ComboBox4.Location = New Point(20, 102)
        ComboBox4.Name = "ComboBox4"
        ComboBox4.Size = New Size(180, 23)
        ComboBox4.TabIndex = 17
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("メイリオ", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label5.Location = New Point(20, 83)
        Label5.Name = "Label5"
        Label5.Size = New Size(156, 16)
        Label5.TabIndex = 10
        Label5.Text = "データを設定してください。"
        ' 
        ' Label6
        ' 
        Label6.Font = New Font("メイリオ", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label6.Location = New Point(230, 83)
        Label6.Name = "Label6"
        Label6.Size = New Size(131, 16)
        Label6.TabIndex = 10
        Label6.Text = "値を設定してください。"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(784, 561)
        Controls.Add(FirstTaskIdCom)
        Controls.Add(TextBox2)
        Controls.Add(InBreakTimer)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(FirstPomStarTimer)
        Controls.Add(PomFintBut)
        Controls.Add(PomStartBut)
        Controls.Add(RealTimer)
        Controls.Add(PomTimer)
        Controls.Add(TabControl1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form1"
        Text = "Form1"
        TabControl1.ResumeLayout(False)
        TaskTab.ResumeLayout(False)
        TaskTab.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        TaskPropTab.ResumeLayout(False)
        TaskPropTab.PerformLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        TaskScoreTab.ResumeLayout(False)
        CType(DataGridView4, ComponentModel.ISupportInitialize).EndInit()
        CType(BindingSource1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TaskTab As TabPage
    Friend WithEvents TaskPropTab As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents PomTimer As Label
    Friend WithEvents RealTimer As Label
    Friend WithEvents PomStartBut As Button
    Friend WithEvents PomFintBut As Button
    Friend WithEvents FirstPomStarTimer As ComboBox
    Friend WithEvents InBreakTimer As ComboBox
    Friend WithEvents TaskInpTex As TextBox
    Friend WithEvents TaskInpBut As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents TaskScoreTab As TabPage
    Friend WithEvents TaskpropTex As TextBox
    Friend WithEvents TaskInpPropBut As Button
    Friend WithEvents DataGridView4 As DataGridView
    Friend WithEvents TaskOutBut As Button
    Friend WithEvents TaskOutPropBut As Button
    Friend WithEvents TaskStarFill1 As ComboBox
    Friend WithEvents TaskIdFill1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents FirstTaskIdCom As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox

End Class
