<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Hoofdmenu
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Spanningsdeler")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Netwerk Analyse 1", New System.Windows.Forms.TreeNode() {TreeNode1})
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("4.2 | Gelijkspanning")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("4.3 | Wisselspanning")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("4.4 | Momentele waarde")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("4.5 | Topwaarde")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("4.6 | Gemiddelde waarde")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("4.7 | Effectieve waarde")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("4.8 | Vormfactor en topfactor")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Hoofdstuk 4", New System.Windows.Forms.TreeNode() {TreeNode3, TreeNode4, TreeNode5, TreeNode6, TreeNode7, TreeNode8, TreeNode9})
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("5.2 | Wijzervoorstellingen van sinusvormige spanningen en stromen")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("5.3 | Optellen en aftrekken van sinusvormige spanningen en stromen")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("5.4 | Spanning-stroomrelaties van de afzonderlijke netwerkelementen")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("5.5.1 | Twee elementen van dezelfde soort")
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("5.5.2 | Serieschakeling van weerstand en spoel")
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("5.5.3 | Serieschakeling van weerstand en condensator")
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("5.5.4 | Parallelschakeling van weerstand en spoel")
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("5.5.5 | Parallelschakeling van weerstand en condensator")
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("5.5 | Combinaties van netwerkelementen", New System.Windows.Forms.TreeNode() {TreeNode14, TreeNode15, TreeNode16, TreeNode17, TreeNode18})
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("5.6 | Vermogen")
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Hoofdstuk 5", New System.Windows.Forms.TreeNode() {TreeNode11, TreeNode12, TreeNode13, TreeNode19, TreeNode20})
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("6.2 | Complexe notatie van een sinusvormig signaal")
        Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("6.3 | Complexe spanning-stroom-relaties")
        Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("6.4 | Combinaties van netwerkelementen")
        Dim TreeNode25 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("6.5 | Netwerkberekeningen")
        Dim TreeNode26 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Hoofdstuk 6", New System.Windows.Forms.TreeNode() {TreeNode22, TreeNode23, TreeNode24, TreeNode25})
        Dim TreeNode27 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Netwerk Analyse 2", New System.Windows.Forms.TreeNode() {TreeNode10, TreeNode21, TreeNode26})
        Dim TreeNode28 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Netwerk Analyse", New System.Windows.Forms.TreeNode() {TreeNode2, TreeNode27})
        Dim TreeNode29 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Elektronica 1")
        Dim TreeNode30 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Elektronica 2")
        Dim TreeNode31 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Elektronica 3")
        Dim TreeNode32 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Elektronica 4")
        Dim TreeNode33 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Elektronica", New System.Windows.Forms.TreeNode() {TreeNode29, TreeNode30, TreeNode31, TreeNode32})
        Dim TreeNode34 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Digitale Techniek")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Hoofdmenu))
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.Location = New System.Drawing.Point(12, 12)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.Name = "NA1_Spanningsdeler"
        TreeNode1.Text = "Spanningsdeler"
        TreeNode2.Name = "Node0"
        TreeNode2.Text = "Netwerk Analyse 1"
        TreeNode3.Name = "Node0"
        TreeNode3.Text = "4.2 | Gelijkspanning"
        TreeNode4.Name = "Node1"
        TreeNode4.Text = "4.3 | Wisselspanning"
        TreeNode5.Name = "Node2"
        TreeNode5.Text = "4.4 | Momentele waarde"
        TreeNode6.Name = "Node3"
        TreeNode6.Text = "4.5 | Topwaarde"
        TreeNode7.Name = "Node9"
        TreeNode7.Text = "4.6 | Gemiddelde waarde"
        TreeNode8.Name = "Node10"
        TreeNode8.Text = "4.7 | Effectieve waarde"
        TreeNode9.Name = "Node11"
        TreeNode9.Text = "4.8 | Vormfactor en topfactor"
        TreeNode10.Name = "Node21"
        TreeNode10.Text = "Hoofdstuk 4"
        TreeNode11.Name = "Node12"
        TreeNode11.Text = "5.2 | Wijzervoorstellingen van sinusvormige spanningen en stromen"
        TreeNode12.Name = "Node13"
        TreeNode12.Text = "5.3 | Optellen en aftrekken van sinusvormige spanningen en stromen"
        TreeNode13.Name = "Node14"
        TreeNode13.Text = "5.4 | Spanning-stroomrelaties van de afzonderlijke netwerkelementen"
        TreeNode14.Name = "Node15"
        TreeNode14.Text = "5.5.1 | Twee elementen van dezelfde soort"
        TreeNode15.Name = "Node17"
        TreeNode15.Text = "5.5.2 | Serieschakeling van weerstand en spoel"
        TreeNode16.Name = "Node16"
        TreeNode16.Text = "5.5.3 | Serieschakeling van weerstand en condensator"
        TreeNode17.Name = "Node19"
        TreeNode17.Text = "5.5.4 | Parallelschakeling van weerstand en spoel"
        TreeNode18.Name = "Node18"
        TreeNode18.Text = "5.5.5 | Parallelschakeling van weerstand en condensator"
        TreeNode19.Name = "Node23"
        TreeNode19.Text = "5.5 | Combinaties van netwerkelementen"
        TreeNode20.Name = "Node20"
        TreeNode20.Text = "5.6 | Vermogen"
        TreeNode21.Name = "Node22"
        TreeNode21.Text = "Hoofdstuk 5"
        TreeNode22.Name = "Node25"
        TreeNode22.Text = "6.2 | Complexe notatie van een sinusvormig signaal"
        TreeNode23.Name = "Node26"
        TreeNode23.Text = "6.3 | Complexe spanning-stroom-relaties"
        TreeNode24.Name = "Node27"
        TreeNode24.Text = "6.4 | Combinaties van netwerkelementen"
        TreeNode25.Name = "Node28"
        TreeNode25.Text = "6.5 | Netwerkberekeningen"
        TreeNode26.Name = "Node24"
        TreeNode26.Text = "Hoofdstuk 6"
        TreeNode27.Name = "Node1"
        TreeNode27.Text = "Netwerk Analyse 2"
        TreeNode28.Name = "Node9"
        TreeNode28.Text = "Netwerk Analyse"
        TreeNode29.Name = "Node3"
        TreeNode29.Text = "Elektronica 1"
        TreeNode30.Name = "Node4"
        TreeNode30.Text = "Elektronica 2"
        TreeNode31.Name = "Node5"
        TreeNode31.Text = "Elektronica 3"
        TreeNode32.Name = "Node6"
        TreeNode32.Text = "Elektronica 4"
        TreeNode33.Name = "Node10"
        TreeNode33.Text = "Elektronica"
        TreeNode34.Name = "Node2"
        TreeNode34.Text = "Digitale Techniek"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode28, TreeNode33, TreeNode34})
        Me.TreeView1.Size = New System.Drawing.Size(260, 501)
        Me.TreeView1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(278, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 500)
        Me.Panel1.TabIndex = 1
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 522)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1090, 26)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(116, 20)
        Me.ToolStripStatusLabel2.Text = "V0.1 Early Alpha"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Letter-D-icon.png")
        Me.ImageList1.Images.SetKeyName(1, "Letter-E-icon.png")
        Me.ImageList1.Images.SetKeyName(2, "Letter-N-icon.png")
        '
        'Hoofdmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1090, 548)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TreeView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Hoofdmenu"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Hoofdmenu - NHL Stenden Elektrotechniek // door Almer de Vries"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents ImageList1 As ImageList
End Class
