<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIMain
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
        Me.components = New System.ComponentModel.Container
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Fabric Order")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Finished Order")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Accessories & Trims Order")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Other Order")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Purchase Order", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4})
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Purchase Inward")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Purchase Inward (Against PO)")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Job Work Inward")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Bale Open")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Fabric", New System.Windows.Forms.TreeNode() {TreeNode6, TreeNode7, TreeNode8, TreeNode9})
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Purchase Inward")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Purchase Inward (Against PO)")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Purchase Inward from Barcode")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Purchase Inward from Barcode (PO)")
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Finished", New System.Windows.Forms.TreeNode() {TreeNode11, TreeNode12, TreeNode13, TreeNode14})
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Acc & Trims Purchase Inward")
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Accesssories  & Trims", New System.Windows.Forms.TreeNode() {TreeNode16})
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Other Purchase")
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Purchase Inward", New System.Windows.Forms.TreeNode() {TreeNode10, TreeNode15, TreeNode17, TreeNode18})
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Purchase Invoice")
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Purchase Return")
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Fabric", New System.Windows.Forms.TreeNode() {TreeNode21})
        Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Purchase Return")
        Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Purchase Return from Barcode")
        Dim TreeNode25 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Finished", New System.Windows.Forms.TreeNode() {TreeNode23, TreeNode24})
        Dim TreeNode26 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Purchase Return")
        Dim TreeNode27 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Accesssories  & Trims", New System.Windows.Forms.TreeNode() {TreeNode26})
        Dim TreeNode28 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Other Return")
        Dim TreeNode29 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Purchase Return", New System.Windows.Forms.TreeNode() {TreeNode22, TreeNode25, TreeNode27, TreeNode28})
        Dim TreeNode30 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Quotation")
        Dim TreeNode31 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Revised Quotation")
        Dim TreeNode32 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sales Order Draft")
        Dim TreeNode33 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sales Order")
        Dim TreeNode34 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sales Order From Barcode")
        Dim TreeNode35 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Dispatch List")
        Dim TreeNode36 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Packing Slip (Carton Wise)")
        Dim TreeNode37 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Packing List (Against Packing Slip)")
        Dim TreeNode38 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Packing List")
        Dim TreeNode39 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Packing List Online")
        Dim TreeNode40 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Packing List (Against SO)")
        Dim TreeNode41 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Packing List From Barcode")
        Dim TreeNode42 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Packing List From Barcode (SO)")
        Dim TreeNode43 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Packing Return")
        Dim TreeNode44 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Packing List(Estimate)")
        Dim TreeNode45 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Packing List From Barcode(Estimate)")
        Dim TreeNode46 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sales Invoice")
        Dim TreeNode47 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sales Invoice(Online)")
        Dim TreeNode48 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sales Invoice(Estimate)")
        Dim TreeNode49 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sales Invoice(Showroom)")
        Dim TreeNode50 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Exchange(Showroom)")
        Dim TreeNode51 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sales Return")
        Dim TreeNode52 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sales Return(Estimate)")
        Dim TreeNode53 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sales Return From Barcode")
        Dim TreeNode54 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("GatePass Entry")
        Dim TreeNode55 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Packing Weight Entry")
        Dim TreeNode56 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Lr Entry")
        Dim TreeNode57 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Credit Note (Other)")
        Dim TreeNode58 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sample Packing")
        Dim TreeNode59 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sample Packing Return")
        Dim TreeNode60 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Custom Invoice")
        Dim TreeNode61 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Retail Invoice")
        Dim TreeNode62 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sales And Despatch", 4, 4, New System.Windows.Forms.TreeNode() {TreeNode30, TreeNode31, TreeNode32, TreeNode33, TreeNode34, TreeNode35, TreeNode36, TreeNode37, TreeNode38, TreeNode39, TreeNode40, TreeNode41, TreeNode42, TreeNode43, TreeNode44, TreeNode45, TreeNode46, TreeNode47, TreeNode48, TreeNode49, TreeNode50, TreeNode51, TreeNode52, TreeNode53, TreeNode54, TreeNode55, TreeNode56, TreeNode57, TreeNode58, TreeNode59, TreeNode60, TreeNode61})
        Dim TreeNode63 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Opening Stock (Purchase)")
        Dim TreeNode64 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Opening Stock(Finish)")
        Dim TreeNode65 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Opening Stock (Accessories)")
        Dim TreeNode66 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Opening Stock (Packing Item)")
        Dim TreeNode67 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Opening Stock (Fabric)")
        Dim TreeNode68 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Opening Stock With Jobber(Fabric)")
        Dim TreeNode69 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Opening Stock With Jobber(Accessories)")
        Dim TreeNode70 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Opening Stock With Jobber(Packing)")
        Dim TreeNode71 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Process Stock With Party")
        Dim TreeNode72 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Process Stock With Godown")
        Dim TreeNode73 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Opening Stock", 13, 13, New System.Windows.Forms.TreeNode() {TreeNode63, TreeNode64, TreeNode65, TreeNode66, TreeNode67, TreeNode68, TreeNode69, TreeNode70, TreeNode71, TreeNode72})
        Dim TreeNode74 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Style Transfer")
        Dim TreeNode75 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Product Set Making")
        Dim TreeNode76 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Damage Stock")
        Dim TreeNode77 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stock Transfer")
        Dim TreeNode78 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Set Making New")
        Dim TreeNode79 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Fabric Transfer From Booked To Free")
        Dim TreeNode80 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Fabric Transfer From Free To Booked")
        Dim TreeNode81 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Accessories Transfer From Booked To Free")
        Dim TreeNode82 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Accessories Transfer From Free To Booked ")
        Dim TreeNode83 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Other Transactions", New System.Windows.Forms.TreeNode() {TreeNode74, TreeNode75, TreeNode76, TreeNode77, TreeNode78, TreeNode79, TreeNode80, TreeNode81, TreeNode82})
        Dim TreeNode84 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Job Order")
        Dim TreeNode85 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Delivery Challan")
        Dim TreeNode86 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Invoice")
        Dim TreeNode87 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sales & Services", New System.Windows.Forms.TreeNode() {TreeNode84, TreeNode85, TreeNode86})
        Dim TreeNode88 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Fabric")
        Dim TreeNode89 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Accessories")
        Dim TreeNode90 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stock Transfer", New System.Windows.Forms.TreeNode() {TreeNode88, TreeNode89})
        Dim TreeNode91 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Material Requisition Note")
        Dim TreeNode92 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Material Issue Note")
        Dim TreeNode93 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Material Consumption Note")
        Dim TreeNode94 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Material Return Note")
        Dim TreeNode95 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("MRN", New System.Windows.Forms.TreeNode() {TreeNode91, TreeNode92, TreeNode93, TreeNode94})
        Dim TreeNode96 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stock Issue(Packing)")
        Dim TreeNode97 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stock Receipt(Packing)")
        Dim TreeNode98 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stock Issue Back(Packing)")
        Dim TreeNode99 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stock Packing", New System.Windows.Forms.TreeNode() {TreeNode96, TreeNode97, TreeNode98})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIMain))
        Dim TreeNode100 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Company")
        Dim TreeNode101 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Region")
        Dim TreeNode102 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Country")
        Dim TreeNode103 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Zone")
        Dim TreeNode104 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("State")
        Dim TreeNode105 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("District")
        Dim TreeNode106 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("City")
        Dim TreeNode107 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Station")
        Dim TreeNode108 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Port Of Discharge")
        Dim TreeNode109 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Port Of Loading")
        Dim TreeNode110 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Location", New System.Windows.Forms.TreeNode() {TreeNode101, TreeNode102, TreeNode103, TreeNode104, TreeNode105, TreeNode106, TreeNode107, TreeNode108, TreeNode109})
        Dim TreeNode111 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Location")
        Dim TreeNode112 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Rack")
        Dim TreeNode113 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stock Location", New System.Windows.Forms.TreeNode() {TreeNode111, TreeNode112})
        Dim TreeNode114 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Department")
        Dim TreeNode115 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Designation")
        Dim TreeNode116 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Employee")
        Dim TreeNode117 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Employee1")
        Dim TreeNode118 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Personal Contacts")
        Dim TreeNode119 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Relation Type")
        Dim TreeNode120 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Salesperson")
        Dim TreeNode121 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Personal", New System.Windows.Forms.TreeNode() {TreeNode114, TreeNode115, TreeNode116, TreeNode117, TreeNode118, TreeNode119, TreeNode120})
        Dim TreeNode122 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Customer")
        Dim TreeNode123 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Customer Group")
        Dim TreeNode124 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Customer", New System.Windows.Forms.TreeNode() {TreeNode122, TreeNode123})
        Dim TreeNode125 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Creditors/Suppliers")
        Dim TreeNode126 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Transporter")
        Dim TreeNode127 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Broker")
        Dim TreeNode128 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Creditors/Suppliers Group")
        Dim TreeNode129 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Manufacturer")
        Dim TreeNode130 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Marketed By")
        Dim TreeNode131 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Vendors", New System.Windows.Forms.TreeNode() {TreeNode125, TreeNode126, TreeNode127, TreeNode128, TreeNode129, TreeNode130})
        Dim TreeNode132 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Group")
        Dim TreeNode133 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sub-Group")
        Dim TreeNode134 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Product")
        Dim TreeNode135 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Style")
        Dim TreeNode136 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Type")
        Dim TreeNode137 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Item/BrandWise Discount")
        Dim TreeNode138 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Finish", New System.Windows.Forms.TreeNode() {TreeNode132, TreeNode133, TreeNode134, TreeNode135, TreeNode136, TreeNode137})
        Dim TreeNode139 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Group")
        Dim TreeNode140 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sub-Group")
        Dim TreeNode141 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Fabric Master")
        Dim TreeNode142 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Component")
        Dim TreeNode143 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Fabric", New System.Windows.Forms.TreeNode() {TreeNode139, TreeNode140, TreeNode141, TreeNode142})
        Dim TreeNode144 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Group")
        Dim TreeNode145 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sub-Group")
        Dim TreeNode146 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Accessories Master")
        Dim TreeNode147 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Accessories", New System.Windows.Forms.TreeNode() {TreeNode144, TreeNode145, TreeNode146})
        Dim TreeNode148 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Group")
        Dim TreeNode149 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sub-Group")
        Dim TreeNode150 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Packing Master")
        Dim TreeNode151 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Packing", New System.Windows.Forms.TreeNode() {TreeNode148, TreeNode149, TreeNode150})
        Dim TreeNode152 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sub Group")
        Dim TreeNode153 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Type")
        Dim TreeNode154 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Design Masters")
        Dim TreeNode155 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Print Design", New System.Windows.Forms.TreeNode() {TreeNode152, TreeNode153, TreeNode154})
        Dim TreeNode156 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Other Item")
        Dim TreeNode157 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Group")
        Dim TreeNode158 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sub-Group")
        Dim TreeNode159 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Misc Master")
        Dim TreeNode160 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Miscellaneous", New System.Windows.Forms.TreeNode() {TreeNode157, TreeNode158, TreeNode159})
        Dim TreeNode161 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Product", New System.Windows.Forms.TreeNode() {TreeNode138, TreeNode143, TreeNode147, TreeNode151, TreeNode155, TreeNode156, TreeNode160})
        Dim TreeNode162 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Shade")
        Dim TreeNode163 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Brand")
        Dim TreeNode164 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Unit")
        Dim TreeNode165 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Quality")
        Dim TreeNode166 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Season")
        Dim TreeNode167 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Occassion")
        Dim TreeNode168 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Packing Type")
        Dim TreeNode169 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Rate Category")
        Dim TreeNode170 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Rate Code")
        Dim TreeNode171 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Image Type")
        Dim TreeNode172 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Section")
        Dim TreeNode173 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Category")
        Dim TreeNode174 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Product Expenses")
        Dim TreeNode175 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Miscellaneous")
        Dim TreeNode176 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("EAN Desc")
        Dim TreeNode177 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Reason")
        Dim TreeNode178 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Product References", New System.Windows.Forms.TreeNode() {TreeNode162, TreeNode163, TreeNode164, TreeNode165, TreeNode166, TreeNode167, TreeNode168, TreeNode169, TreeNode170, TreeNode171, TreeNode172, TreeNode173, TreeNode174, TreeNode175, TreeNode176, TreeNode177})
        Dim TreeNode179 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Payment Type")
        Dim TreeNode180 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Deductee Type")
        Dim TreeNode181 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("TDS Details")
        Dim TreeNode182 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("TDS", New System.Windows.Forms.TreeNode() {TreeNode179, TreeNode180, TreeNode181})
        Dim TreeNode183 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tax")
        Dim TreeNode184 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Terms")
        Dim TreeNode185 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Term Discount")
        Dim TreeNode186 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("GST Slab")
        Dim TreeNode187 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tax/Terms", New System.Windows.Forms.TreeNode() {TreeNode183, TreeNode184, TreeNode185, TreeNode186})
        Dim TreeNode188 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Currency")
        Dim TreeNode189 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Remote Report Path")
        Dim TreeNode190 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tally Export Data")
        Dim TreeNode191 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Attachment Type")
        Dim TreeNode192 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Machine Master")
        Dim TreeNode193 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Line Master")
        Dim TreeNode194 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Combination Item")
        Dim TreeNode195 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Miscellaneous", New System.Windows.Forms.TreeNode() {TreeNode188, TreeNode189, TreeNode190, TreeNode191, TreeNode192, TreeNode193, TreeNode194})
        Dim TreeNode196 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Process Group")
        Dim TreeNode197 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Process Name")
        Dim TreeNode198 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Operation Name")
        Dim TreeNode199 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sub Process")
        Dim TreeNode200 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Process", New System.Windows.Forms.TreeNode() {TreeNode196, TreeNode197, TreeNode198, TreeNode199})
        Dim TreeNode201 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Excise Tariff Master")
        Dim TreeNode202 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Excise Trariff Group")
        Dim TreeNode203 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Excise", New System.Windows.Forms.TreeNode() {TreeNode201, TreeNode202})
        Dim TreeNode204 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Scheme Definition")
        Dim TreeNode205 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Scheme")
        Dim TreeNode206 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Scheme", New System.Windows.Forms.TreeNode() {TreeNode204, TreeNode205})
        Dim TreeNode207 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Product Wise Tax")
        Dim TreeNode208 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("EBO System", New System.Windows.Forms.TreeNode() {TreeNode207})
        Dim TreeNode209 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Bill Wise Register")
        Dim TreeNode210 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Date Wise Register")
        Dim TreeNode211 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Supplier Wise Register")
        Dim TreeNode212 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sub-Group Wise Register")
        Dim TreeNode213 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Product Wise Register")
        Dim TreeNode214 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Brand Wise Register")
        Dim TreeNode215 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Order Status Bill Wise")
        Dim TreeNode216 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Order Status Date Wise")
        Dim TreeNode217 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Order Status Supplier Wise")
        Dim TreeNode218 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Order Status Sub-Group Wise")
        Dim TreeNode219 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Order Status Product Wise")
        Dim TreeNode220 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Order Status Brand Wise")
        Dim TreeNode221 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Order Status As Per Purchase(Date Wise)")
        Dim TreeNode222 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Purchase Order Report")
        Dim TreeNode223 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Transaction", New System.Windows.Forms.TreeNode() {TreeNode209, TreeNode210, TreeNode211, TreeNode212, TreeNode213, TreeNode214, TreeNode215, TreeNode216, TreeNode217, TreeNode218, TreeNode219, TreeNode220, TreeNode221, TreeNode222})
        Dim TreeNode224 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cancelled Purchase Order")
        Dim TreeNode225 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Short Close Register")
        Dim TreeNode226 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("All In One Purchase Order")
        Dim TreeNode227 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Analysis", New System.Windows.Forms.TreeNode() {TreeNode224, TreeNode225, TreeNode226})
        Dim TreeNode228 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Fabric", New System.Windows.Forms.TreeNode() {TreeNode223, TreeNode227})
        Dim TreeNode229 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Bill Wise Register")
        Dim TreeNode230 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Date Wise Register")
        Dim TreeNode231 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Supplier Wise Register")
        Dim TreeNode232 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sub-Group Wise Register")
        Dim TreeNode233 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Product Wise Register")
        Dim TreeNode234 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Brand Wise Register")
        Dim TreeNode235 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Order Status Bill Wise")
        Dim TreeNode236 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Order Status Date Wise")
        Dim TreeNode237 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Order Status Supplier Wise")
        Dim TreeNode238 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Order Status Sub-Group Wise")
        Dim TreeNode239 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Order Status Product Wise")
        Dim TreeNode240 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Order Status Brand Wise")
        Dim TreeNode241 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Transactions", New System.Windows.Forms.TreeNode() {TreeNode229, TreeNode230, TreeNode231, TreeNode232, TreeNode233, TreeNode234, TreeNode235, TreeNode236, TreeNode237, TreeNode238, TreeNode239, TreeNode240})
        Dim TreeNode242 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cancelled Purchase Order")
        Dim TreeNode243 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Short Close Register")
        Dim TreeNode244 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("All In One Purchase Order")
        Dim TreeNode245 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Analysis", New System.Windows.Forms.TreeNode() {TreeNode242, TreeNode243, TreeNode244})
        Dim TreeNode246 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Finished", New System.Windows.Forms.TreeNode() {TreeNode241, TreeNode245})
        Dim TreeNode247 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Bill Wise Register")
        Dim TreeNode248 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Date Wise Register")
        Dim TreeNode249 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Supplier Wise Register")
        Dim TreeNode250 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sub-Group Wise Register")
        Dim TreeNode251 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Product Wise Register")
        Dim TreeNode252 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Brand Wise Register")
        Dim TreeNode253 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Order Status Bill Wise")
        Dim TreeNode254 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Order Status Date Wise")
        Dim TreeNode255 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Order Status Supplier Wise")
        Dim TreeNode256 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Order Status Sub-Group Wise")
        Dim TreeNode257 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Order Status Product Wise")
        Dim TreeNode258 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Order Status Brand Wise")
        Dim TreeNode259 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Transaction", New System.Windows.Forms.TreeNode() {TreeNode247, TreeNode248, TreeNode249, TreeNode250, TreeNode251, TreeNode252, TreeNode253, TreeNode254, TreeNode255, TreeNode256, TreeNode257, TreeNode258})
        Dim TreeNode260 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cancelled Purchase Order")
        Dim TreeNode261 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Short Close Register")
        Dim TreeNode262 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("All In One Purchase Order")
        Dim TreeNode263 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Analysis", New System.Windows.Forms.TreeNode() {TreeNode260, TreeNode261, TreeNode262})
        Dim TreeNode264 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Trims/Stores", New System.Windows.Forms.TreeNode() {TreeNode259, TreeNode263})
        Dim TreeNode265 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Purchase Order", New System.Windows.Forms.TreeNode() {TreeNode228, TreeNode246, TreeNode264})
        Dim TreeNode266 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Bill Wise Register")
        Dim TreeNode267 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Date Wise Register")
        Dim TreeNode268 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Location Wise Register")
        Dim TreeNode269 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Supplier Wise Register")
        Dim TreeNode270 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sub-Group Wise Register")
        Dim TreeNode271 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Product Wise Register")
        Dim TreeNode272 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Brand Wise Register")
        Dim TreeNode273 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Product Wise Barcode Purchase")
        Dim TreeNode274 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Transactions", New System.Windows.Forms.TreeNode() {TreeNode266, TreeNode267, TreeNode268, TreeNode269, TreeNode270, TreeNode271, TreeNode272, TreeNode273})
        Dim TreeNode275 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Purchase Doc Wise Stock")
        Dim TreeNode276 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Periodical Purchase")
        Dim TreeNode277 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Excess/Less Qty Recd Against Order")
        Dim TreeNode278 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Monthly")
        Dim TreeNode279 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Monthly - Date Wise")
        Dim TreeNode280 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Date Wise - Product Wise Consolidated")
        Dim TreeNode281 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("All In One Purchase")
        Dim TreeNode282 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Margin Summary On Purchase")
        Dim TreeNode283 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Top N Suppliers")
        Dim TreeNode284 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Top N Purchase")
        Dim TreeNode285 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Analysis", New System.Windows.Forms.TreeNode() {TreeNode275, TreeNode276, TreeNode277, TreeNode278, TreeNode279, TreeNode280, TreeNode281, TreeNode282, TreeNode283, TreeNode284})
        Dim TreeNode286 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Doc Wise")
        Dim TreeNode287 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Date Wise")
        Dim TreeNode288 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tax Summary")
        Dim TreeNode289 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Product Wise")
        Dim TreeNode290 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Supplier Wise")
        Dim TreeNode291 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tax Register", New System.Windows.Forms.TreeNode() {TreeNode286, TreeNode287, TreeNode288, TreeNode289, TreeNode290})
        Dim TreeNode292 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Fabric", New System.Windows.Forms.TreeNode() {TreeNode274, TreeNode285, TreeNode291})
        Dim TreeNode293 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Bill Wise Register")
        Dim TreeNode294 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Date Wise Register")
        Dim TreeNode295 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Location Wise Register")
        Dim TreeNode296 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Supplier Wise Register")
        Dim TreeNode297 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sub-Group Wise Register")
        Dim TreeNode298 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Product Wise Register")
        Dim TreeNode299 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Brand Wise Register")
        Dim TreeNode300 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Product Wise Barcode Purchase")
        Dim TreeNode301 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Transactions", New System.Windows.Forms.TreeNode() {TreeNode293, TreeNode294, TreeNode295, TreeNode296, TreeNode297, TreeNode298, TreeNode299, TreeNode300})
        Dim TreeNode302 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Purchase Doc Wise Stock")
        Dim TreeNode303 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Periodical Purchase")
        Dim TreeNode304 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Excess/Less Qty Recd Against Order")
        Dim TreeNode305 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Monthly")
        Dim TreeNode306 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Monthly - Date Wise")
        Dim TreeNode307 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Date Wise - Product Wise Consolidated")
        Dim TreeNode308 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("All In One Purchase")
        Dim TreeNode309 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Margin Summary On Purchase")
        Dim TreeNode310 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Top N Suppliers")
        Dim TreeNode311 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Top N Purchase")
        Dim TreeNode312 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Analysis", New System.Windows.Forms.TreeNode() {TreeNode302, TreeNode303, TreeNode304, TreeNode305, TreeNode306, TreeNode307, TreeNode308, TreeNode309, TreeNode310, TreeNode311})
        Dim TreeNode313 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Doc Wise")
        Dim TreeNode314 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Date Wise")
        Dim TreeNode315 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tax Summary")
        Dim TreeNode316 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Product Wise")
        Dim TreeNode317 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Supplier Wise")
        Dim TreeNode318 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tax Register", New System.Windows.Forms.TreeNode() {TreeNode313, TreeNode314, TreeNode315, TreeNode316, TreeNode317})
        Dim TreeNode319 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Finished", New System.Windows.Forms.TreeNode() {TreeNode301, TreeNode312, TreeNode318})
        Dim TreeNode320 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Bill Wise Register")
        Dim TreeNode321 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Date Wise Register")
        Dim TreeNode322 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Location Wise Register")
        Dim TreeNode323 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Supplier Wise Register")
        Dim TreeNode324 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sub-Group Wise Register")
        Dim TreeNode325 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Product Wise Register")
        Dim TreeNode326 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Brand Wise Register")
        Dim TreeNode327 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Product Wise Barcode Purchase")
        Dim TreeNode328 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Transactions", New System.Windows.Forms.TreeNode() {TreeNode320, TreeNode321, TreeNode322, TreeNode323, TreeNode324, TreeNode325, TreeNode326, TreeNode327})
        Dim TreeNode329 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Purchase Doc Wise Stock")
        Dim TreeNode330 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Periodical Purchase")
        Dim TreeNode331 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Excess/Less Qty Recd Against Order")
        Dim TreeNode332 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Monthly")
        Dim TreeNode333 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Monthly - Date Wise")
        Dim TreeNode334 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Date Wise - Product Wise Consolidated")
        Dim TreeNode335 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("All In One Purchase")
        Dim TreeNode336 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Margin Summary On Purchase")
        Dim TreeNode337 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Top N Suppliers")
        Dim TreeNode338 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Top N Purchase")
        Dim TreeNode339 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Analysis", New System.Windows.Forms.TreeNode() {TreeNode329, TreeNode330, TreeNode331, TreeNode332, TreeNode333, TreeNode334, TreeNode335, TreeNode336, TreeNode337, TreeNode338})
        Dim TreeNode340 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Doc Wise")
        Dim TreeNode341 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Date Wise")
        Dim TreeNode342 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tax Summary")
        Dim TreeNode343 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Product Wise")
        Dim TreeNode344 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Supplier Wise")
        Dim TreeNode345 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tax Register", New System.Windows.Forms.TreeNode() {TreeNode340, TreeNode341, TreeNode342, TreeNode343, TreeNode344})
        Dim TreeNode346 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Trims/Stores", New System.Windows.Forms.TreeNode() {TreeNode328, TreeNode339, TreeNode345})
        Dim TreeNode347 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Purchase Register (Date Wise)")
        Dim TreeNode348 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Purchase", New System.Windows.Forms.TreeNode() {TreeNode292, TreeNode319, TreeNode346, TreeNode347})
        Dim TreeNode349 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Bill Wise Register")
        Dim TreeNode350 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Date Wise Register")
        Dim TreeNode351 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Location Wise Register")
        Dim TreeNode352 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Supplier Wise Register")
        Dim TreeNode353 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sub-Group Wise Register")
        Dim TreeNode354 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Product Wise Register")
        Dim TreeNode355 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Brand Wise Register")
        Dim TreeNode356 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Transaction", New System.Windows.Forms.TreeNode() {TreeNode349, TreeNode350, TreeNode351, TreeNode352, TreeNode353, TreeNode354, TreeNode355})
        Dim TreeNode357 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Monthly")
        Dim TreeNode358 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Monthly - Date Wise")
        Dim TreeNode359 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Periodical Purchase Rtn")
        Dim TreeNode360 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("All-In-One Purchase Rtn")
        Dim TreeNode361 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Analysis", New System.Windows.Forms.TreeNode() {TreeNode357, TreeNode358, TreeNode359, TreeNode360})
        Dim TreeNode362 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Fabric", New System.Windows.Forms.TreeNode() {TreeNode356, TreeNode361})
        Dim TreeNode363 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Bill Wise Register")
        Dim TreeNode364 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Date Wise Register")
        Dim TreeNode365 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Location Wise Register")
        Dim TreeNode366 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Supplier Wise Register")
        Dim TreeNode367 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sub-Group Wise Register")
        Dim TreeNode368 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Product Wise Register")
        Dim TreeNode369 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Brand Wise Register")
        Dim TreeNode370 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Transactions", New System.Windows.Forms.TreeNode() {TreeNode363, TreeNode364, TreeNode365, TreeNode366, TreeNode367, TreeNode368, TreeNode369})
        Dim TreeNode371 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Monthly")
        Dim TreeNode372 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Monthly - Date Wise")
        Dim TreeNode373 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Periodical Purchase Rtn")
        Dim TreeNode374 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("All-In-One Purchase Rtn")
        Dim TreeNode375 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Analysis", New System.Windows.Forms.TreeNode() {TreeNode371, TreeNode372, TreeNode373, TreeNode374})
        Dim TreeNode376 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Finished", New System.Windows.Forms.TreeNode() {TreeNode370, TreeNode375})
        Dim TreeNode377 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Bill Wise Register")
        Dim TreeNode378 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Date Wise Register")
        Dim TreeNode379 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Location Wise Register")
        Dim TreeNode380 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Supplier Wise Register")
        Dim TreeNode381 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sub-Group Wise Register")
        Dim TreeNode382 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Product Wise Register")
        Dim TreeNode383 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Brand Wise Register")
        Dim TreeNode384 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Transaction", New System.Windows.Forms.TreeNode() {TreeNode377, TreeNode378, TreeNode379, TreeNode380, TreeNode381, TreeNode382, TreeNode383})
        Dim TreeNode385 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Monthly")
        Dim TreeNode386 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Monthly - Date Wise")
        Dim TreeNode387 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Periodical Purchase Rtn")
        Dim TreeNode388 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("All-In-One Purchase Rtn")
        Dim TreeNode389 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Analysis", New System.Windows.Forms.TreeNode() {TreeNode385, TreeNode386, TreeNode387, TreeNode388})
        Dim TreeNode390 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Trims/Stores", New System.Windows.Forms.TreeNode() {TreeNode384, TreeNode389})
        Dim TreeNode391 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Purchase Return", New System.Windows.Forms.TreeNode() {TreeNode362, TreeNode376, TreeNode390})
        Dim TreeNode392 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Date Wise")
        Dim TreeNode393 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Jobber Wise")
        Dim TreeNode394 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sub-Group Wise")
        Dim TreeNode395 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Product Wise")
        Dim TreeNode396 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Brand Wise")
        Dim TreeNode397 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Fabric Issue", New System.Windows.Forms.TreeNode() {TreeNode392, TreeNode393, TreeNode394, TreeNode395, TreeNode396})
        Dim TreeNode398 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Date Wise")
        Dim TreeNode399 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Jobber Wise")
        Dim TreeNode400 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sub-Group Wise")
        Dim TreeNode401 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Product Wise")
        Dim TreeNode402 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Brand Wise")
        Dim TreeNode403 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Fabric Issue Back", New System.Windows.Forms.TreeNode() {TreeNode398, TreeNode399, TreeNode400, TreeNode401, TreeNode402})
        Dim TreeNode404 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Jobber Wise")
        Dim TreeNode405 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Product Wise")
        Dim TreeNode406 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stock Ledger")
        Dim TreeNode407 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Fabric Stock With Party", New System.Windows.Forms.TreeNode() {TreeNode404, TreeNode405, TreeNode406})
        Dim TreeNode408 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Date Wise")
        Dim TreeNode409 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Jobber Wise")
        Dim TreeNode410 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sub-Group Wise")
        Dim TreeNode411 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Product Wise")
        Dim TreeNode412 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stores Issue", New System.Windows.Forms.TreeNode() {TreeNode408, TreeNode409, TreeNode410, TreeNode411})
        Dim TreeNode413 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Date Wise")
        Dim TreeNode414 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Jobber Wise")
        Dim TreeNode415 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sub-Group Wise")
        Dim TreeNode416 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Product Wise")
        Dim TreeNode417 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stores Issue Back", New System.Windows.Forms.TreeNode() {TreeNode413, TreeNode414, TreeNode415, TreeNode416})
        Dim TreeNode418 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Jobber Wise")
        Dim TreeNode419 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Product Wise")
        Dim TreeNode420 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stock Ledger")
        Dim TreeNode421 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stores Stock With Party", New System.Windows.Forms.TreeNode() {TreeNode418, TreeNode419, TreeNode420})
        Dim TreeNode422 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("JobWork PO Status BillWise")
        Dim TreeNode423 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Goods Recv Agst JobWork PO")
        Dim TreeNode424 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("JobWork PO Status")
        Dim TreeNode425 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("JobWork PO Register", New System.Windows.Forms.TreeNode() {TreeNode422, TreeNode423, TreeNode424})
        Dim TreeNode426 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("JobWork Order Status BillWise")
        Dim TreeNode427 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Goods Recv Agst JobWork Order")
        Dim TreeNode428 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("JobWork Order Status")
        Dim TreeNode429 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("JobWork Order Register", New System.Windows.Forms.TreeNode() {TreeNode426, TreeNode427, TreeNode428})
        Dim TreeNode430 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Date Wise")
        Dim TreeNode431 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Job Order Status")
        Dim TreeNode432 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Job Order Register", New System.Windows.Forms.TreeNode() {TreeNode430, TreeNode431})
        Dim TreeNode433 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Date Wise")
        Dim TreeNode434 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Jobber Wise")
        Dim TreeNode435 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Process Wise")
        Dim TreeNode436 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sub-Group Wise")
        Dim TreeNode437 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Product Wise")
        Dim TreeNode438 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Brand Wise")
        Dim TreeNode439 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Job Card Status (Datewise)")
        Dim TreeNode440 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Job Card Register", New System.Windows.Forms.TreeNode() {TreeNode433, TreeNode434, TreeNode435, TreeNode436, TreeNode437, TreeNode438, TreeNode439})
        Dim TreeNode441 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Date Wise")
        Dim TreeNode442 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Jobber Wise")
        Dim TreeNode443 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Process Wise")
        Dim TreeNode444 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sub-Group Wise")
        Dim TreeNode445 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Product Wise")
        Dim TreeNode446 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Brand Wise")
        Dim TreeNode447 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Process Issue Register", New System.Windows.Forms.TreeNode() {TreeNode441, TreeNode442, TreeNode443, TreeNode444, TreeNode445, TreeNode446})
        Dim TreeNode448 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Date Wise")
        Dim TreeNode449 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Jobber Wise")
        Dim TreeNode450 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Process Wise")
        Dim TreeNode451 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sub-Group Wise")
        Dim TreeNode452 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Product Wise")
        Dim TreeNode453 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Brand Wise")
        Dim TreeNode454 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Process Receipt Register", New System.Windows.Forms.TreeNode() {TreeNode448, TreeNode449, TreeNode450, TreeNode451, TreeNode452, TreeNode453})
        Dim TreeNode455 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Date Wise")
        Dim TreeNode456 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Jobber Wise")
        Dim TreeNode457 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Process Wise")
        Dim TreeNode458 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sub-Group Wise")
        Dim TreeNode459 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Product Wise")
        Dim TreeNode460 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Brand Wise")
        Dim TreeNode461 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Process/Production Delay", New System.Windows.Forms.TreeNode() {TreeNode455, TreeNode456, TreeNode457, TreeNode458, TreeNode459, TreeNode460})
        Dim TreeNode462 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Date Wise")
        Dim TreeNode463 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Jobber Wise")
        Dim TreeNode464 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Process Wise")
        Dim TreeNode465 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sub-Group Wise")
        Dim TreeNode466 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Product Wise")
        Dim TreeNode467 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Brand Wise")
        Dim TreeNode468 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Process Stock With Party", New System.Windows.Forms.TreeNode() {TreeNode462, TreeNode463, TreeNode464, TreeNode465, TreeNode466, TreeNode467})
        Dim TreeNode469 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Date Wise")
        Dim TreeNode470 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Jobber Wise")
        Dim TreeNode471 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Process Wise")
        Dim TreeNode472 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sub-Group Wise")
        Dim TreeNode473 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Product Wise")
        Dim TreeNode474 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Brand Wise")
        Dim TreeNode475 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Semi Process Stock At WH", New System.Windows.Forms.TreeNode() {TreeNode469, TreeNode470, TreeNode471, TreeNode472, TreeNode473, TreeNode474})
        Dim TreeNode476 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Date Wise")
        Dim TreeNode477 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Jobber Wise")
        Dim TreeNode478 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Process Wise")
        Dim TreeNode479 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sub-Group Wise")
        Dim TreeNode480 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Product Wise")
        Dim TreeNode481 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Brand Wise")
        Dim TreeNode482 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Process Ledger", New System.Windows.Forms.TreeNode() {TreeNode476, TreeNode477, TreeNode478, TreeNode479, TreeNode480, TreeNode481})
        Dim TreeNode483 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Date Wise")
        Dim TreeNode484 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Jobber Wise")
        Dim TreeNode485 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Process Wise")
        Dim TreeNode486 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sub-Group Wise")
        Dim TreeNode487 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Product Wise")
        Dim TreeNode488 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Brand Wise")
        Dim TreeNode489 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Process Shortage", New System.Windows.Forms.TreeNode() {TreeNode483, TreeNode484, TreeNode485, TreeNode486, TreeNode487, TreeNode488})
        Dim TreeNode490 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Karigar Salary")
        Dim TreeNode491 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Date Wise")
        Dim TreeNode492 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Doc Wise")
        Dim TreeNode493 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Summery")
        Dim TreeNode494 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Process Reports", New System.Windows.Forms.TreeNode() {TreeNode491, TreeNode492, TreeNode493})
        Dim TreeNode495 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Style Shade Wise")
        Dim TreeNode496 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Style Shade Wise Summery")
        Dim TreeNode497 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Style Reports", New System.Windows.Forms.TreeNode() {TreeNode495, TreeNode496})
        Dim TreeNode498 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Fabric Ledger at Jobber")
        Dim TreeNode499 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Process/Production Reports", New System.Windows.Forms.TreeNode() {TreeNode397, TreeNode403, TreeNode407, TreeNode412, TreeNode417, TreeNode421, TreeNode425, TreeNode429, TreeNode432, TreeNode440, TreeNode447, TreeNode454, TreeNode461, TreeNode468, TreeNode475, TreeNode482, TreeNode489, TreeNode490, TreeNode494, TreeNode497, TreeNode498})
        Dim TreeNode500 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Bill Wise Register")
        Dim TreeNode501 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Date Wise Register")
        Dim TreeNode502 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Party Wise Register")
        Dim TreeNode503 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Party-Product Wise Register")
        Dim TreeNode504 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Consignee Wise Register")
        Dim TreeNode505 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Consignee-Product Wise Register")
        Dim TreeNode506 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Product Wise Register")
        Dim TreeNode507 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Brand Wise Register")
        Dim TreeNode508 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Broker Wise Register")
        Dim TreeNode509 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Order Status Bill Wise")
        Dim TreeNode510 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Order Status Date Wise")
        Dim TreeNode511 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Order Status Party Wise")
        Dim TreeNode512 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Order Status Party-Product")
        Dim TreeNode513 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Order Status Consignee Wise")
        Dim TreeNode514 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Order Status Consignee-Product Wise")
        Dim TreeNode515 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Order Status Product Wise")
        Dim TreeNode516 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Order Status Brand Wise")
        Dim TreeNode517 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Order Status Broker Wise")
        Dim TreeNode518 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sales Order Status")
        Dim TreeNode519 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stock Ready To Dispatch")
        Dim TreeNode520 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Buyer Wise Grid")
        Dim TreeNode521 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Transactions", New System.Windows.Forms.TreeNode() {TreeNode500, TreeNode501, TreeNode502, TreeNode503, TreeNode504, TreeNode505, TreeNode506, TreeNode507, TreeNode508, TreeNode509, TreeNode510, TreeNode511, TreeNode512, TreeNode513, TreeNode514, TreeNode515, TreeNode516, TreeNode517, TreeNode518, TreeNode519, TreeNode520})
        Dim TreeNode522 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("O/S Sales Order (Style Wise)")
        Dim TreeNode523 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("OS Sales Order (Style Wise)- Stock")
        Dim TreeNode524 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("O/S Sales Order (Style/Party)")
        Dim TreeNode525 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("O/S Sales Order (Party/Style)")
        Dim TreeNode526 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("O/S Sales Order (Party/Size)")
        Dim TreeNode527 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("O/S Sales Order (Party/Consignee)")
        Dim TreeNode528 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("O/S Sales Order (Style/Party/Consignee)")
        Dim TreeNode529 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("O/S Sales Order (Party/Consignee/Style)")
        Dim TreeNode530 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sales Order Summary (Style Wise)")
        Dim TreeNode531 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sales Order Summary (Style/Party)")
        Dim TreeNode532 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sales Order Summary (Party/Style)")
        Dim TreeNode533 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sales Order Summary (Party/Size)")
        Dim TreeNode534 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sales Order Summary (Style/Party/Consignee)")
        Dim TreeNode535 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sales Order Summary (Party/Consignee/Style)")
        Dim TreeNode536 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sales Order/ Desp Detail")
        Dim TreeNode537 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("RetailerWise SaleOrder")
        Dim TreeNode538 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("DesignWise Retailer")
        Dim TreeNode539 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("CrossTab Format", New System.Windows.Forms.TreeNode() {TreeNode522, TreeNode523, TreeNode524, TreeNode525, TreeNode526, TreeNode527, TreeNode528, TreeNode529, TreeNode530, TreeNode531, TreeNode532, TreeNode533, TreeNode534, TreeNode535, TreeNode536, TreeNode537, TreeNode538})
        Dim TreeNode540 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sales Order", New System.Windows.Forms.TreeNode() {TreeNode521, TreeNode539})
        Dim TreeNode541 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Bill Wise Register")
        Dim TreeNode542 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Date Wise Register")
        Dim TreeNode543 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Party Wise Register")
        Dim TreeNode544 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Party-Product Wise Register")
        Dim TreeNode545 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Consignee Wise Register")
        Dim TreeNode546 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Consignee-Product Wise Register")
        Dim TreeNode547 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Product Wise Register")
        Dim TreeNode548 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Brand Wise Register")
        Dim TreeNode549 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Broker Wise Register")
        Dim TreeNode550 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Transactions", New System.Windows.Forms.TreeNode() {TreeNode541, TreeNode542, TreeNode543, TreeNode544, TreeNode545, TreeNode546, TreeNode547, TreeNode548, TreeNode549})
        Dim TreeNode551 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Packing Summary (Style Wise)")
        Dim TreeNode552 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Packing Summary (Style/Party)")
        Dim TreeNode553 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Packing Summary (Party/Style)")
        Dim TreeNode554 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Packing Summary (Party/Size)")
        Dim TreeNode555 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Packing Summary (Style/Party/Consignee)")
        Dim TreeNode556 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cross Tab Format", New System.Windows.Forms.TreeNode() {TreeNode551, TreeNode552, TreeNode553, TreeNode554, TreeNode555})
        Dim TreeNode557 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Despatch Reports", New System.Windows.Forms.TreeNode() {TreeNode550, TreeNode556})
        Dim TreeNode558 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Bill Wise Register")
        Dim TreeNode559 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Date Wise Register")
        Dim TreeNode560 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Party Wise Register")
        Dim TreeNode561 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Party-Product Wise Register")
        Dim TreeNode562 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Consignee Wise Register")
        Dim TreeNode563 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Consignee-Product Wise Register")
        Dim TreeNode564 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Product Wise Register")
        Dim TreeNode565 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Brand Wise Register")
        Dim TreeNode566 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Broker Wise Register")
        Dim TreeNode567 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sales Person Wise Register")
        Dim TreeNode568 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sales Person Party Wise Register")
        Dim TreeNode569 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Broker Brand Wise Register")
        Dim TreeNode570 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Design Wise Net Sales Register")
        Dim TreeNode571 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Transactions", New System.Windows.Forms.TreeNode() {TreeNode558, TreeNode559, TreeNode560, TreeNode561, TreeNode562, TreeNode563, TreeNode564, TreeNode565, TreeNode566, TreeNode567, TreeNode568, TreeNode569, TreeNode570})
        Dim TreeNode572 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tax Register")
        Dim TreeNode573 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tax Register", New System.Windows.Forms.TreeNode() {TreeNode572})
        Dim TreeNode574 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sales Reports", New System.Windows.Forms.TreeNode() {TreeNode571, TreeNode573})
        Dim TreeNode575 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Bill Wise Register")
        Dim TreeNode576 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Date Wise Register")
        Dim TreeNode577 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Location Wise Register")
        Dim TreeNode578 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Customer Wise Register")
        Dim TreeNode579 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sub-Group Wise Register")
        Dim TreeNode580 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Product Wise Register")
        Dim TreeNode581 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Brand Wise Register")
        Dim TreeNode582 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Broker Party Wise Register")
        Dim TreeNode583 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Transactions", New System.Windows.Forms.TreeNode() {TreeNode575, TreeNode576, TreeNode577, TreeNode578, TreeNode579, TreeNode580, TreeNode581, TreeNode582})
        Dim TreeNode584 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sales Return", New System.Windows.Forms.TreeNode() {TreeNode583})
        Dim TreeNode585 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Opening Stock - Sub-Group Wise")
        Dim TreeNode586 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Opening Stock - Product Wise")
        Dim TreeNode587 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Opening Stock - Brand Wise")
        Dim TreeNode588 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Opening Stock - Location Wise")
        Dim TreeNode589 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stock Ledger Fabric")
        Dim TreeNode590 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Closing Stock - Product Wise")
        Dim TreeNode591 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Closing Stock - Brand Wise")
        Dim TreeNode592 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Closing Stock - Location Wise")
        Dim TreeNode593 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Closing Stock - Supplier Wise")
        Dim TreeNode594 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stock Ledger(All)")
        Dim TreeNode595 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Drill Down Fabric Report")
        Dim TreeNode596 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Regular", New System.Windows.Forms.TreeNode() {TreeNode585, TreeNode586, TreeNode587, TreeNode588, TreeNode589, TreeNode590, TreeNode591, TreeNode592, TreeNode593, TreeNode594, TreeNode595})
        Dim TreeNode597 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Fabric", New System.Windows.Forms.TreeNode() {TreeNode596})
        Dim TreeNode598 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Opening Stock - Sub-Group Wise")
        Dim TreeNode599 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Opening Stock - Product Wise")
        Dim TreeNode600 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Opening Stock - Brand Wise")
        Dim TreeNode601 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Opening Stock - Location Wise")
        Dim TreeNode602 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stock Ledger Finish")
        Dim TreeNode603 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Closing Stock - Product Wise")
        Dim TreeNode604 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Closing Stock - Brand Wise")
        Dim TreeNode605 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Closing Stock - Location Wise")
        Dim TreeNode606 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Closing Stock - Supplier Wise")
        Dim TreeNode607 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Barcode Stock - Sub-Group Wise")
        Dim TreeNode608 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Barcode Stock - Product Wise")
        Dim TreeNode609 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Barcode Stock - Brand Wise")
        Dim TreeNode610 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Barcode Stock - Supplier Wise")
        Dim TreeNode611 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Barcode Stock - Location Wise")
        Dim TreeNode612 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stock At A Glance - Sub-Group Wise")
        Dim TreeNode613 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stock At A Glance - Product Wise")
        Dim TreeNode614 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stock At A Glance - Brand Wise")
        Dim TreeNode615 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stock At A Glance - Supplier Wise")
        Dim TreeNode616 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stock At A Glance - Location Wise")
        Dim TreeNode617 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stock At A Glance - Customer Wise")
        Dim TreeNode618 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stock Ledger")
        Dim TreeNode619 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stock As On (Previous Date)")
        Dim TreeNode620 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stock  Ledger Location")
        Dim TreeNode621 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Drill Down Finish Report")
        Dim TreeNode622 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Regular", New System.Windows.Forms.TreeNode() {TreeNode598, TreeNode599, TreeNode600, TreeNode601, TreeNode602, TreeNode603, TreeNode604, TreeNode605, TreeNode606, TreeNode607, TreeNode608, TreeNode609, TreeNode610, TreeNode611, TreeNode612, TreeNode613, TreeNode614, TreeNode615, TreeNode616, TreeNode617, TreeNode618, TreeNode619, TreeNode620, TreeNode621})
        Dim TreeNode623 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Fast Moving - Supplier Wise")
        Dim TreeNode624 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Fast Moving - Sub-Group Wise")
        Dim TreeNode625 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Fast Moving - Product Wise")
        Dim TreeNode626 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Slow Moving - Supplier Wise")
        Dim TreeNode627 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Slow Moving - Sub-Group Wise")
        Dim TreeNode628 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Slow Moving - Product Wise")
        Dim TreeNode629 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Dead Stock - Product Wise")
        Dim TreeNode630 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stock Movement", New System.Windows.Forms.TreeNode() {TreeNode623, TreeNode624, TreeNode625, TreeNode626, TreeNode627, TreeNode628, TreeNode629})
        Dim TreeNode631 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sub-Group Wise")
        Dim TreeNode632 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Product Wise")
        Dim TreeNode633 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Brand Wise")
        Dim TreeNode634 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Supplier Wise")
        Dim TreeNode635 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Product - Barcode Wise")
        Dim TreeNode636 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stock Aging", New System.Windows.Forms.TreeNode() {TreeNode631, TreeNode632, TreeNode633, TreeNode634, TreeNode635})
        Dim TreeNode637 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("No Stock Report")
        Dim TreeNode638 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("No Sale Report")
        Dim TreeNode639 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Not Yet Sold")
        Dim TreeNode640 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stock Statement")
        Dim TreeNode641 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Doc Wise Stock")
        Dim TreeNode642 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Style Costing")
        Dim TreeNode643 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Analysis", New System.Windows.Forms.TreeNode() {TreeNode637, TreeNode638, TreeNode639, TreeNode640, TreeNode641, TreeNode642})
        Dim TreeNode644 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Finished", New System.Windows.Forms.TreeNode() {TreeNode622, TreeNode630, TreeNode636, TreeNode643})
        Dim TreeNode645 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Opening Stock - Sub-Group Wise")
        Dim TreeNode646 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Opening Stock - Product Wise")
        Dim TreeNode647 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Opening Stock - Brand Wise")
        Dim TreeNode648 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Opening Stock - Location Wise")
        Dim TreeNode649 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stock Ledger Accessories")
        Dim TreeNode650 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Closing Stock - Product Wise")
        Dim TreeNode651 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Closing Stock - Brand Wise")
        Dim TreeNode652 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Closing Stock - Location Wise")
        Dim TreeNode653 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Closing Stock - Supplier Wise")
        Dim TreeNode654 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stock Ledger")
        Dim TreeNode655 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Drill Down Accessories Report")
        Dim TreeNode656 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Regular", New System.Windows.Forms.TreeNode() {TreeNode645, TreeNode646, TreeNode647, TreeNode648, TreeNode649, TreeNode650, TreeNode651, TreeNode652, TreeNode653, TreeNode654, TreeNode655})
        Dim TreeNode657 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Accessories", New System.Windows.Forms.TreeNode() {TreeNode656})
        Dim TreeNode658 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Opening Stock - Sub-Group Wise")
        Dim TreeNode659 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Opening Stock - Product Wise")
        Dim TreeNode660 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Opening Stock - Brand Wise")
        Dim TreeNode661 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Opening Stock - Location Wise")
        Dim TreeNode662 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Closing Stock - Sub-Group Wise")
        Dim TreeNode663 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Closing Stock - Product Wise")
        Dim TreeNode664 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Closing Stock - Brand Wise")
        Dim TreeNode665 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Closing Stock - Location Wise")
        Dim TreeNode666 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Closing Stock - Supplier Wise")
        Dim TreeNode667 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Regular", New System.Windows.Forms.TreeNode() {TreeNode658, TreeNode659, TreeNode660, TreeNode661, TreeNode662, TreeNode663, TreeNode664, TreeNode665, TreeNode666})
        Dim TreeNode668 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Packing", New System.Windows.Forms.TreeNode() {TreeNode667})
        Dim TreeNode669 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stock", New System.Windows.Forms.TreeNode() {TreeNode597, TreeNode644, TreeNode657, TreeNode668})
        Dim TreeNode670 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Physical Stock")
        Dim TreeNode671 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Physical Stock Shortage")
        Dim TreeNode672 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Physical Stock not in Books(Excess)")
        Dim TreeNode673 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Barcode not in Books")
        Dim TreeNode674 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stock Tracking", New System.Windows.Forms.TreeNode() {TreeNode670, TreeNode671, TreeNode672, TreeNode673})
        Dim TreeNode675 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("VAT Computation")
        Dim TreeNode676 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Bill Wise Register")
        Dim TreeNode677 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Party Wise Register")
        Dim TreeNode678 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Pending Bills Against Packing", New System.Windows.Forms.TreeNode() {TreeNode676, TreeNode677})
        Dim TreeNode679 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Bill Wise Register")
        Dim TreeNode680 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Party Wise Register")
        Dim TreeNode681 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Pending DebitNote Against Purchase Rtd", New System.Windows.Forms.TreeNode() {TreeNode679, TreeNode680})
        Dim TreeNode682 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Bill Wise Register")
        Dim TreeNode683 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Party Wise Register")
        Dim TreeNode684 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Pending CreditNote Against Sales Rtd", New System.Windows.Forms.TreeNode() {TreeNode682, TreeNode683})
        Dim TreeNode685 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Daily Reports", New System.Windows.Forms.TreeNode() {TreeNode678, TreeNode681, TreeNode684})
        Dim TreeNode686 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Bill Wise Register")
        Dim TreeNode687 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Date Wise Register")
        Dim TreeNode688 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Party Wise Register")
        Dim TreeNode689 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Party-Product Wise Register")
        Dim TreeNode690 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Product Wise Register")
        Dim TreeNode691 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Order Status Bill Wise")
        Dim TreeNode692 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Order Status Date Wise")
        Dim TreeNode693 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Order Status Party Wise")
        Dim TreeNode694 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Order Status Party-Product")
        Dim TreeNode695 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Order Status Product Wise")
        Dim TreeNode696 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Transactions", New System.Windows.Forms.TreeNode() {TreeNode686, TreeNode687, TreeNode688, TreeNode689, TreeNode690, TreeNode691, TreeNode692, TreeNode693, TreeNode694, TreeNode695})
        Dim TreeNode697 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Service Job Order", New System.Windows.Forms.TreeNode() {TreeNode696})
        Dim TreeNode698 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Bill Wise Register")
        Dim TreeNode699 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Date Wise Register")
        Dim TreeNode700 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Party Wise Register")
        Dim TreeNode701 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Party-Product Wise Register")
        Dim TreeNode702 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Product Wise Register")
        Dim TreeNode703 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Transactions", New System.Windows.Forms.TreeNode() {TreeNode698, TreeNode699, TreeNode700, TreeNode701, TreeNode702})
        Dim TreeNode704 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Service Challan", New System.Windows.Forms.TreeNode() {TreeNode703})
        Dim TreeNode705 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Bill Wise Register")
        Dim TreeNode706 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Date Wise Register")
        Dim TreeNode707 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Party Wise Register")
        Dim TreeNode708 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Party-Product Wise Register")
        Dim TreeNode709 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Product Wise Register")
        Dim TreeNode710 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Transactions", New System.Windows.Forms.TreeNode() {TreeNode705, TreeNode706, TreeNode707, TreeNode708, TreeNode709})
        Dim TreeNode711 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Service Invoice", New System.Windows.Forms.TreeNode() {TreeNode710})
        Dim TreeNode712 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("GSTR-1")
        Dim TreeNode713 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("GSTR-2")
        Dim TreeNode714 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("GSTR-3B")
        Dim TreeNode715 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("GST Returns", New System.Windows.Forms.TreeNode() {TreeNode712, TreeNode713, TreeNode714})
        Dim TreeNode716 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("RCM")
        Dim TreeNode717 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("GST Report", New System.Windows.Forms.TreeNode() {TreeNode715, TreeNode716})
        Dim TreeNode718 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Pending Task Report")
        Dim TreeNode719 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Pending Order Report")
        Dim TreeNode720 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Monthly customer Wise report")
        Dim TreeNode721 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Monthly Factory Wise Delivery Report")
        Dim TreeNode722 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("PP Status")
        Dim TreeNode723 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("PP Status FAB")
        Dim TreeNode724 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("PP Status ACC")
        Dim TreeNode725 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Job Order Status ")
        Dim TreeNode726 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sales Order Report")
        Dim TreeNode727 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sales Invoice Report")
        Dim TreeNode728 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("JobWork Order(PP wise)")
        Dim TreeNode729 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("GRN Pending Against PO")
        Dim TreeNode730 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Item Stock Report")
        Dim TreeNode731 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sales Order Balance Report")
        Dim TreeNode732 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Pending Fabric Issue Agst Job Work Order")
        Dim TreeNode733 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("OC Pending Status")
        Dim TreeNode734 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Buyer Progress Chart")
        Dim TreeNode735 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("CountryWise Buyerwise Order Analysis")
        Dim TreeNode736 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Product CategoryWise BuyerWise Order Analyse")
        Dim TreeNode737 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Top Style")
        Dim TreeNode738 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sales / Order In Hand(Month Wise)")
        Dim TreeNode739 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sales / Order In Hand(Buyer Wise)")
        Dim TreeNode740 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Pre-Shipment Analysis")
        Dim TreeNode741 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("MIS Report", New System.Windows.Forms.TreeNode() {TreeNode718, TreeNode719, TreeNode720, TreeNode721, TreeNode722, TreeNode723, TreeNode724, TreeNode725, TreeNode726, TreeNode727, TreeNode728, TreeNode729, TreeNode730, TreeNode731, TreeNode732, TreeNode733, TreeNode734, TreeNode735, TreeNode736, TreeNode737, TreeNode738, TreeNode739, TreeNode740})
        Dim TreeNode742 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cost Sheet Reports")
        Dim TreeNode743 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Performa Sales Order")
        Dim TreeNode744 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Purchase Sales Order Report")
        Dim TreeNode745 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Fabric Order")
        Dim TreeNode746 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Finish Order")
        Dim TreeNode747 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Accessories And Trims Order")
        Dim TreeNode748 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Buyer Standard Label")
        Dim TreeNode749 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("JobWork PO")
        Dim TreeNode750 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("JobWork Order")
        Dim TreeNode751 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Fabric Purchase Inward")
        Dim TreeNode752 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Finish Purchase Inward")
        Dim TreeNode753 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Accessories Purchase Inward")
        Dim TreeNode754 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Buyer Standard Label Inward")
        Dim TreeNode755 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("JobWork PO Receipt")
        Dim TreeNode756 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("JobWork Order Receipt")
        Dim TreeNode757 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Fabric Purchase Return")
        Dim TreeNode758 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Finish Purchase Return")
        Dim TreeNode759 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Accessories Purchase Return")
        Dim TreeNode760 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Buyer Standard Label Return")
        Dim TreeNode761 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Modules Report", New System.Windows.Forms.TreeNode() {TreeNode742, TreeNode743, TreeNode744, TreeNode745, TreeNode746, TreeNode747, TreeNode748, TreeNode749, TreeNode750, TreeNode751, TreeNode752, TreeNode753, TreeNode754, TreeNode755, TreeNode756, TreeNode757, TreeNode758, TreeNode759, TreeNode760})
        Dim TreeNode762 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("MRN Listing For Department")
        Dim TreeNode763 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("MIN Listing For Department")
        Dim TreeNode764 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("MRT Listing For Department")
        Dim TreeNode765 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("MRN Report", New System.Windows.Forms.TreeNode() {TreeNode762, TreeNode763, TreeNode764})
        Dim TreeNode766 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("System")
        Dim TreeNode767 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("System Caption")
        Dim TreeNode768 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Settings")
        Dim TreeNode769 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Configuration", New System.Windows.Forms.TreeNode() {TreeNode766, TreeNode767, TreeNode768})
        Dim TreeNode770 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Users Type")
        Dim TreeNode771 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("User Rights Type")
        Dim TreeNode772 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Users")
        Dim TreeNode773 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Modules")
        Dim TreeNode774 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("User Rights")
        Dim TreeNode775 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Modules Rights")
        Dim TreeNode776 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Security", New System.Windows.Forms.TreeNode() {TreeNode770, TreeNode771, TreeNode772, TreeNode773, TreeNode774, TreeNode775})
        Dim TreeNode777 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Record History")
        Dim TreeNode778 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Series Master")
        Dim TreeNode779 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stock Adjustment")
        Dim TreeNode780 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stock Adjustment Godown")
        Dim TreeNode781 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stock Tracking")
        Dim TreeNode782 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stock Reconciliation")
        Dim TreeNode783 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Backup Data")
        Dim TreeNode784 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Restore Data")
        Dim TreeNode785 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Detach Database")
        Dim TreeNode786 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Database Options", New System.Windows.Forms.TreeNode() {TreeNode783, TreeNode784, TreeNode785})
        Dim TreeNode787 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Version Update")
        Dim TreeNode788 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Trans For Approval")
        Dim TreeNode789 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Company Wise Master Code")
        Dim TreeNode790 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("TNA Days")
        Dim TreeNode791 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Placement")
        Dim TreeNode792 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Bill Of Material(Product)")
        Dim TreeNode793 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Bill Of Material(Style)")
        Dim TreeNode794 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Bill Of Material(SO Style)")
        Dim TreeNode795 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Bill Of Material(Draft)")
        Dim TreeNode796 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Make To Order", New System.Windows.Forms.TreeNode() {TreeNode791, TreeNode792, TreeNode793, TreeNode794, TreeNode795})
        Dim TreeNode797 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Production Order")
        Dim TreeNode798 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Production Planning")
        Dim TreeNode799 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Job Work Order")
        Dim TreeNode800 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("PP NO Status")
        Dim TreeNode801 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Job WOrk Order Status")
        Dim TreeNode802 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Planning", New System.Windows.Forms.TreeNode() {TreeNode797, TreeNode798, TreeNode799, TreeNode800, TreeNode801})
        Dim TreeNode803 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Program")
        Dim TreeNode804 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Job Card")
        Dim TreeNode805 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Fabric Issue(Cutting)")
        Dim TreeNode806 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Fabric Receipt (Cutting)")
        Dim TreeNode807 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Finish Receipt (Cutting)")
        Dim TreeNode808 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Fabric Issue(Process)")
        Dim TreeNode809 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Running Embroidery Job Order")
        Dim TreeNode810 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Running Embroidery Receipt")
        Dim TreeNode811 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Fabric Process Transfer")
        Dim TreeNode812 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Semi Process Receipt(Production)")
        Dim TreeNode813 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Semi Process Receipt(Process)")
        Dim TreeNode814 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Semi Process Issue (Production)")
        Dim TreeNode815 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Semi Process Issue (Process)")
        Dim TreeNode816 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Fabric Receipt(Production)")
        Dim TreeNode817 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Fabric Receipt(Process)")
        Dim TreeNode818 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Accessories Recipt Against Fabric")
        Dim TreeNode819 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Process Receipt(Finish)")
        Dim TreeNode820 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Fabric Transfer")
        Dim TreeNode821 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Fabric Issue Back")
        Dim TreeNode822 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Accessories & Trims Issue(Production)")
        Dim TreeNode823 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Accessories & Trims Receipt(Process)")
        Dim TreeNode824 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Accessories & Trims Transfer")
        Dim TreeNode825 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Accessories & Trims Issue Back")
        Dim TreeNode826 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Packing Issue")
        Dim TreeNode827 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Packing Transfer")
        Dim TreeNode828 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Packing Issue Back")
        Dim TreeNode829 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Accessories & Trims  Issue(Process)")
        Dim TreeNode830 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Process Entry", New System.Windows.Forms.TreeNode() {TreeNode803, TreeNode804, TreeNode805, TreeNode806, TreeNode807, TreeNode808, TreeNode809, TreeNode810, TreeNode811, TreeNode812, TreeNode813, TreeNode814, TreeNode815, TreeNode816, TreeNode817, TreeNode818, TreeNode819, TreeNode820, TreeNode821, TreeNode822, TreeNode823, TreeNode824, TreeNode825, TreeNode826, TreeNode827, TreeNode828, TreeNode829})
        Dim TreeNode831 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Job Card/Cutting Report")
        Dim TreeNode832 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Divider Embroidery Job Order")
        Dim TreeNode833 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Divider Embroidery Job Receipt")
        Dim TreeNode834 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Job Work PO (Pcs)")
        Dim TreeNode835 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Job Work (Fabrics)")
        Dim TreeNode836 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Job Work PO")
        Dim TreeNode837 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Process Issue For Stiching")
        Dim TreeNode838 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Process Issue (Job Card)")
        Dim TreeNode839 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Process Receipt (Finish)")
        Dim TreeNode840 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Process Receipt (SemiFinish)")
        Dim TreeNode841 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Process Transfer")
        Dim TreeNode842 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Process Re-Issue")
        Dim TreeNode843 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Process Issue (Semi Finish)")
        Dim TreeNode844 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Accessories Consumption")
        Dim TreeNode845 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Fabric Consumption")
        Dim TreeNode846 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sampling")
        Dim TreeNode847 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Process Stock")
        Dim TreeNode848 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Manufacturing", New System.Windows.Forms.TreeNode() {TreeNode831, TreeNode832, TreeNode833, TreeNode834, TreeNode835, TreeNode836, TreeNode837, TreeNode838, TreeNode839, TreeNode840, TreeNode841, TreeNode842, TreeNode843, TreeNode844, TreeNode845, TreeNode846, TreeNode847})
        Dim TreeNode849 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Single Style")
        Dim TreeNode850 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Multi Barcode")
        Dim TreeNode851 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Re-Print Barcode")
        Dim TreeNode852 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Label Print")
        Dim TreeNode853 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Label Print (Size wise)")
        Dim TreeNode854 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Production Sticker")
        Dim TreeNode855 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Barcode Printing", New System.Windows.Forms.TreeNode() {TreeNode849, TreeNode850, TreeNode851, TreeNode852, TreeNode853, TreeNode854})
        Dim TreeNode856 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Settings")
        Dim TreeNode857 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Occassion")
        Dim TreeNode858 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Instant SMS (Masters)")
        Dim TreeNode859 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Instant SMS (Mobile Nos)")
        Dim TreeNode860 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Batch SMS")
        Dim TreeNode861 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("SMS Log")
        Dim TreeNode862 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("SMS Features", New System.Windows.Forms.TreeNode() {TreeNode856, TreeNode857, TreeNode858, TreeNode859, TreeNode860, TreeNode861})
        Dim TreeNode863 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Email")
        Dim TreeNode864 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Email Features", New System.Windows.Forms.TreeNode() {TreeNode863})
        Dim TreeNode865 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Record Unlock")
        Dim TreeNode866 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Reset Doc Number")
        Dim TreeNode867 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Address Label Print")
        Dim TreeNode868 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Envelope Printing")
        Dim TreeNode869 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Import Masters")
        Dim TreeNode870 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Import Masters (Barcode)")
        Dim TreeNode871 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Import Fabric")
        Dim TreeNode872 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tally Export")
        Dim TreeNode873 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Import Accessories Item")
        Dim TreeNode874 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Import Packing Item")
        Dim TreeNode875 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Product Search")
        Dim TreeNode876 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Ledger Search")
        Dim TreeNode877 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sales Order Short Close")
        Dim TreeNode878 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Item-Wise Stock Level")
        Dim TreeNode879 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cutting Program")
        Dim TreeNode880 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Catalogue")
        Dim TreeNode881 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Export Data To Franchisee")
        Dim TreeNode882 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Export Schema For Franchisee")
        Dim TreeNode883 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sync Data from Franchisee")
        Dim TreeNode884 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("TNA(New)")
        Dim TreeNode885 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Category Wise")
        Dim TreeNode886 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Price List", New System.Windows.Forms.TreeNode() {TreeNode885})
        Dim TreeNode887 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Export Masters (Barcode)")
        Dim TreeNode888 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Transfer Bill")
        Dim TreeNode889 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Import Sales Order")
        Dim TreeNode890 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Export Bill")
        Dim TreeNode891 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Data Export To Tally")
        Dim TreeNode892 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Transaction Report")
        Dim TreeNode893 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Import Bills From Frnachisee")
        Dim TreeNode894 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stock Export")
        Dim TreeNode895 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Favourite Buttons")
        Dim TreeNode896 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Ledger")
        Dim TreeNode897 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Main Group")
        Dim TreeNode898 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Group")
        Dim TreeNode899 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sub-Group")
        Dim TreeNode900 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cost Center")
        Dim TreeNode901 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Bank")
        Dim TreeNode902 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Accounts Masters", New System.Windows.Forms.TreeNode() {TreeNode896, TreeNode897, TreeNode898, TreeNode899, TreeNode900, TreeNode901})
        Dim TreeNode903 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("General Ledger")
        Dim TreeNode904 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sundry Debtors")
        Dim TreeNode905 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sundry Creditors")
        Dim TreeNode906 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Bank Reco Opening")
        Dim TreeNode907 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Closing Stock")
        Dim TreeNode908 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Opening Balance", New System.Windows.Forms.TreeNode() {TreeNode903, TreeNode904, TreeNode905, TreeNode906, TreeNode907})
        Dim TreeNode909 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Contra")
        Dim TreeNode910 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Payment")
        Dim TreeNode911 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Receipt")
        Dim TreeNode912 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Journal")
        Dim TreeNode913 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sales")
        Dim TreeNode914 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Credit Note")
        Dim TreeNode915 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Purchase")
        Dim TreeNode916 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Debit Note")
        Dim TreeNode917 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("TDS Entry")
        Dim TreeNode918 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Voucher Entry", New System.Windows.Forms.TreeNode() {TreeNode909, TreeNode910, TreeNode911, TreeNode912, TreeNode913, TreeNode914, TreeNode915, TreeNode916, TreeNode917})
        Dim TreeNode919 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Customer Opening Tax Form")
        Dim TreeNode920 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Customer Tax Form Received")
        Dim TreeNode921 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tax Form", New System.Windows.Forms.TreeNode() {TreeNode919, TreeNode920})
        Dim TreeNode922 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Bank Reconciliation")
        Dim TreeNode923 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cash Book")
        Dim TreeNode924 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Bank Book")
        Dim TreeNode925 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Ledgers")
        Dim TreeNode926 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Group Summary")
        Dim TreeNode927 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Group Voucher")
        Dim TreeNode928 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Journal Register")
        Dim TreeNode929 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Debit Note Register")
        Dim TreeNode930 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Credit Note Register")
        Dim TreeNode931 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Journal Register", New System.Windows.Forms.TreeNode() {TreeNode928, TreeNode929, TreeNode930})
        Dim TreeNode932 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Purchase Register")
        Dim TreeNode933 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sales Register")
        Dim TreeNode934 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Day Book")
        Dim TreeNode935 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Accounts Books", New System.Windows.Forms.TreeNode() {TreeNode923, TreeNode924, TreeNode925, TreeNode926, TreeNode927, TreeNode931, TreeNode932, TreeNode933, TreeNode934})
        Dim TreeNode936 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Receivables")
        Dim TreeNode937 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Payables")
        Dim TreeNode938 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Ledgers")
        Dim TreeNode939 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Groups")
        Dim TreeNode940 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("OS Customer Bills (With Date Filter)")
        Dim TreeNode941 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("OS Customer Bills (With Days Filter)")
        Dim TreeNode942 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Estimated Receivables")
        Dim TreeNode943 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Outstanding Reports", New System.Windows.Forms.TreeNode() {TreeNode936, TreeNode937, TreeNode938, TreeNode939, TreeNode940, TreeNode941, TreeNode942})
        Dim TreeNode944 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Daily Collection - Date Wise")
        Dim TreeNode945 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Daily Collection - Doc Wise")
        Dim TreeNode946 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Daily Collection - Customer Wise")
        Dim TreeNode947 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Daily Collection - Saleperson Wise")
        Dim TreeNode948 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Collection Reports", New System.Windows.Forms.TreeNode() {TreeNode944, TreeNode945, TreeNode946, TreeNode947})
        Dim TreeNode949 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Unbilled GRN")
        Dim TreeNode950 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tax Form Status of Customers ( Datewise)")
        Dim TreeNode951 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Pending Tax Form From Customers")
        Dim TreeNode952 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tax Form Received From Customers (Party Wise)")
        Dim TreeNode953 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tax Form Reports", New System.Windows.Forms.TreeNode() {TreeNode950, TreeNode951, TreeNode952})
        Dim TreeNode954 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Broker Commission Report")
        Dim TreeNode955 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Broker Commission Reciept (BillWise)")
        Dim TreeNode956 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("PartyWise Commission Report")
        Dim TreeNode957 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Brokerwise Collection Report")
        Dim TreeNode958 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Misc Reports", New System.Windows.Forms.TreeNode() {TreeNode948, TreeNode949, TreeNode953, TreeNode954, TreeNode955, TreeNode956, TreeNode957})
        Dim TreeNode959 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Group Trial Balance")
        Dim TreeNode960 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Trial Balance")
        Dim TreeNode961 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Profit And Loss A/c")
        Dim TreeNode962 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Profit And Loss A/c (Screen)")
        Dim TreeNode963 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Balance Sheet")
        Dim TreeNode964 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Balance Sheet (Screen)")
        Dim TreeNode965 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cash Flow")
        Dim TreeNode966 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Fund Flow")
        Dim TreeNode967 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Final Accounts", New System.Windows.Forms.TreeNode() {TreeNode961, TreeNode962, TreeNode963, TreeNode964, TreeNode965, TreeNode966})
        Dim TreeNode968 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sales Register")
        Dim TreeNode969 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sales Register GST")
        Dim TreeNode970 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sales Register (With TIN No)")
        Dim TreeNode971 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sales Register (Party With TIN No)")
        Dim TreeNode972 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sales Register (Broker Wise)")
        Dim TreeNode973 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Monthly Sales (Product-Type Wise)")
        Dim TreeNode974 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tax Summary")
        Dim TreeNode975 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("GST Summery")
        Dim TreeNode976 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Discount Summary")
        Dim TreeNode977 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sales Summary (Party Wise)")
        Dim TreeNode978 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sales Summary (Party/Tax)")
        Dim TreeNode979 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("RG1 Register")
        Dim TreeNode980 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Credit Note Register")
        Dim TreeNode981 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Credit Note Register GST")
        Dim TreeNode982 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Credit Note Register (Broker Wise)")
        Dim TreeNode983 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Party Wise Sales Summary (With CN & Qty)")
        Dim TreeNode984 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Day Book (Sales)", New System.Windows.Forms.TreeNode() {TreeNode968, TreeNode969, TreeNode970, TreeNode971, TreeNode972, TreeNode973, TreeNode974, TreeNode975, TreeNode976, TreeNode977, TreeNode978, TreeNode979, TreeNode980, TreeNode981, TreeNode982, TreeNode983})
        Dim TreeNode985 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Customer Ledger")
        Dim TreeNode986 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Customer A/c (BillWise)")
        Dim TreeNode987 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Customer A/c  Confirmation")
        Dim TreeNode988 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Ledger On Screen")
        Dim TreeNode989 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Manual Matching (F6)")
        Dim TreeNode990 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Customer Outstanding")
        Dim TreeNode991 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Broker Wise Outstanding")
        Dim TreeNode992 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Ledger", New System.Windows.Forms.TreeNode() {TreeNode985, TreeNode986, TreeNode987, TreeNode988, TreeNode989, TreeNode990, TreeNode991})
        Dim TreeNode993 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tax Form Reminder")
        Dim TreeNode994 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Outstanding Reminder")
        Dim TreeNode995 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Outstanding Reminder (On Sreen)")
        Dim TreeNode996 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Reminders", New System.Windows.Forms.TreeNode() {TreeNode993, TreeNode994, TreeNode995})
        Dim TreeNode997 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Purchase Register")
        Dim TreeNode998 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Purchase Register GST")
        Dim TreeNode999 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Purchase Summary (Party Wise)")
        Dim TreeNode1000 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Purchase Summary (Party/Tax)")
        Dim TreeNode1001 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Purchase Bill Register(Date Wise)")
        Dim TreeNode1002 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Day Book (Purchase)", New System.Windows.Forms.TreeNode() {TreeNode997, TreeNode998, TreeNode999, TreeNode1000, TreeNode1001})
        Me.MenuStrip = New System.Windows.Forms.MenuStrip
        Me.WindowsMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuChangeUser = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuChangeCompany = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuCalculator = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuTeamviewer = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.CascadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TileVerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TileHorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CloseAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SyncFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuContact = New System.Windows.Forms.ToolStripMenuItem
        Me.mnurptProfitLossAc = New System.Windows.Forms.ToolStripMenuItem
        Me.mnurptBalanceSheet = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuRegister = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuActivate = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.sbrMain = New System.Windows.Forms.StatusStrip
        Me.ApplnName = New System.Windows.Forms.ToolStripStatusLabel
        Me.Version = New System.Windows.Forms.ToolStripStatusLabel
        Me.UserName = New System.Windows.Forms.ToolStripStatusLabel
        Me.Counter = New System.Windows.Forms.ToolStripStatusLabel
        Me.Server = New System.Windows.Forms.ToolStripStatusLabel
        Me.LoginTime = New System.Windows.Forms.ToolStripStatusLabel
        Me.CurrentDate = New System.Windows.Forms.ToolStripStatusLabel
        Me.CurrentTime = New System.Windows.Forms.ToolStripStatusLabel
        Me.MDINaviBar = New Guifreaks.NavigationBar.NaviBar(Me.components)
        Me.BandTransactions = New Guifreaks.NavigationBar.NaviBand(Me.components)
        Me.tvwPurchase = New System.Windows.Forms.TreeView
        Me.MainImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.BandMasters = New Guifreaks.NavigationBar.NaviBand(Me.components)
        Me.tvwMasters = New System.Windows.Forms.TreeView
        Me.BandInvReports = New Guifreaks.NavigationBar.NaviBand(Me.components)
        Me.tvwInventoryReports = New System.Windows.Forms.TreeView
        Me.BandAdmin = New Guifreaks.NavigationBar.NaviBand(Me.components)
        Me.tvwAdmin = New System.Windows.Forms.TreeView
        Me.BandProduction = New Guifreaks.NavigationBar.NaviBand(Me.components)
        Me.tvwProduction = New System.Windows.Forms.TreeView
        Me.BandUtilities = New Guifreaks.NavigationBar.NaviBand(Me.components)
        Me.tvwUtilities = New System.Windows.Forms.TreeView
        Me.BandAccounts = New Guifreaks.NavigationBar.NaviBand(Me.components)
        Me.tvwAccounts = New System.Windows.Forms.TreeView
        Me.BandAccReports = New Guifreaks.NavigationBar.NaviBand(Me.components)
        Me.tvwAccountReports = New System.Windows.Forms.TreeView
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrBackup = New System.Windows.Forms.Timer(Me.components)
        Me.grpAlert = New DevExpress.XtraEditors.GroupControl
        Me.lnkTNA = New System.Windows.Forms.LinkLabel
        Me.LnkPOAgaintsDelivery = New System.Windows.Forms.LinkLabel
        Me.lnkOutPay = New System.Windows.Forms.LinkLabel
        Me.lnkOutRec = New System.Windows.Forms.LinkLabel
        Me.Label1 = New System.Windows.Forms.Label
        Me.lnkMiniStk = New System.Windows.Forms.LinkLabel
        Me.lblCloseAlert = New System.Windows.Forms.Label
        Me.grpAppAlert = New DevExpress.XtraEditors.GroupControl
        Me.lnkPTR = New System.Windows.Forms.LinkLabel
        Me.lnkCorrection = New System.Windows.Forms.LinkLabel
        Me.Label2 = New System.Windows.Forms.Label
        Me.lnkApproval = New System.Windows.Forms.LinkLabel
        Me.Label3 = New System.Windows.Forms.Label
        Me.grpEnable = New DevExpress.XtraEditors.GroupControl
        Me.lblMinimise = New System.Windows.Forms.Label
        Me.lblClose = New System.Windows.Forms.Label
        Me.grpShortcut = New DevExpress.XtraEditors.GroupControl
        Me.btnShortcut = New DevExpress.XtraEditors.SimpleButton
        Me.MenuStrip.SuspendLayout()
        Me.sbrMain.SuspendLayout()
        CType(Me.MDINaviBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MDINaviBar.SuspendLayout()
        Me.BandTransactions.ClientArea.SuspendLayout()
        Me.BandTransactions.SuspendLayout()
        Me.BandMasters.ClientArea.SuspendLayout()
        Me.BandMasters.SuspendLayout()
        Me.BandInvReports.ClientArea.SuspendLayout()
        Me.BandInvReports.SuspendLayout()
        Me.BandAdmin.ClientArea.SuspendLayout()
        Me.BandAdmin.SuspendLayout()
        Me.BandProduction.ClientArea.SuspendLayout()
        Me.BandProduction.SuspendLayout()
        Me.BandUtilities.ClientArea.SuspendLayout()
        Me.BandUtilities.SuspendLayout()
        Me.BandAccounts.ClientArea.SuspendLayout()
        Me.BandAccounts.SuspendLayout()
        Me.BandAccReports.ClientArea.SuspendLayout()
        Me.BandAccReports.SuspendLayout()
        CType(Me.grpAlert, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpAlert.SuspendLayout()
        CType(Me.grpAppAlert, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpAppAlert.SuspendLayout()
        CType(Me.grpEnable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpEnable.SuspendLayout()
        CType(Me.grpShortcut, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpShortcut.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WindowsMenu, Me.HelpMenu, Me.mnuExit, Me.mnuRegister})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.MdiWindowListItem = Me.WindowsMenu
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1024, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'WindowsMenu
        '
        Me.WindowsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuChangeUser, Me.mnuChangeCompany, Me.ToolStripSeparator1, Me.mnuCalculator, Me.mnuTeamviewer, Me.ToolStripSeparator2, Me.CascadeToolStripMenuItem, Me.TileVerticalToolStripMenuItem, Me.TileHorizontalToolStripMenuItem, Me.CloseAllToolStripMenuItem, Me.SyncFileToolStripMenuItem})
        Me.WindowsMenu.Name = "WindowsMenu"
        Me.WindowsMenu.Size = New System.Drawing.Size(68, 20)
        Me.WindowsMenu.Text = "&Windows"
        '
        'mnuChangeUser
        '
        Me.mnuChangeUser.Name = "mnuChangeUser"
        Me.mnuChangeUser.Size = New System.Drawing.Size(164, 22)
        Me.mnuChangeUser.Text = "Switch User"
        '
        'mnuChangeCompany
        '
        Me.mnuChangeCompany.Name = "mnuChangeCompany"
        Me.mnuChangeCompany.Size = New System.Drawing.Size(164, 22)
        Me.mnuChangeCompany.Text = "Switch Company"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(161, 6)
        '
        'mnuCalculator
        '
        Me.mnuCalculator.Name = "mnuCalculator"
        Me.mnuCalculator.Size = New System.Drawing.Size(164, 22)
        Me.mnuCalculator.Text = "Calculator"
        '
        'mnuTeamviewer
        '
        Me.mnuTeamviewer.Name = "mnuTeamviewer"
        Me.mnuTeamviewer.Size = New System.Drawing.Size(164, 22)
        Me.mnuTeamviewer.Text = "Teamviewer"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(161, 6)
        '
        'CascadeToolStripMenuItem
        '
        Me.CascadeToolStripMenuItem.Name = "CascadeToolStripMenuItem"
        Me.CascadeToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.CascadeToolStripMenuItem.Text = "&Cascade"
        '
        'TileVerticalToolStripMenuItem
        '
        Me.TileVerticalToolStripMenuItem.Name = "TileVerticalToolStripMenuItem"
        Me.TileVerticalToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.TileVerticalToolStripMenuItem.Text = "Tile &Vertical"
        '
        'TileHorizontalToolStripMenuItem
        '
        Me.TileHorizontalToolStripMenuItem.Name = "TileHorizontalToolStripMenuItem"
        Me.TileHorizontalToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.TileHorizontalToolStripMenuItem.Text = "Tile &Horizontal"
        '
        'CloseAllToolStripMenuItem
        '
        Me.CloseAllToolStripMenuItem.Name = "CloseAllToolStripMenuItem"
        Me.CloseAllToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.CloseAllToolStripMenuItem.Text = "C&lose All"
        '
        'SyncFileToolStripMenuItem
        '
        Me.SyncFileToolStripMenuItem.Name = "SyncFileToolStripMenuItem"
        Me.SyncFileToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.SyncFileToolStripMenuItem.Text = "Sync File"
        '
        'HelpMenu
        '
        Me.HelpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAbout, Me.mnuContact, Me.mnurptProfitLossAc, Me.mnurptBalanceSheet})
        Me.HelpMenu.Name = "HelpMenu"
        Me.HelpMenu.Size = New System.Drawing.Size(44, 20)
        Me.HelpMenu.Text = "&Help"
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(164, 22)
        Me.mnuAbout.Text = "&About ..."
        '
        'mnuContact
        '
        Me.mnuContact.Name = "mnuContact"
        Me.mnuContact.Size = New System.Drawing.Size(164, 22)
        Me.mnuContact.Text = "Contact Us"
        Me.mnuContact.Visible = False
        '
        'mnurptProfitLossAc
        '
        Me.mnurptProfitLossAc.Name = "mnurptProfitLossAc"
        Me.mnurptProfitLossAc.Size = New System.Drawing.Size(164, 22)
        Me.mnurptProfitLossAc.Text = "Profit && Loss A/c"
        Me.mnurptProfitLossAc.Visible = False
        '
        'mnurptBalanceSheet
        '
        Me.mnurptBalanceSheet.Name = "mnurptBalanceSheet"
        Me.mnurptBalanceSheet.Size = New System.Drawing.Size(164, 22)
        Me.mnurptBalanceSheet.Text = "Balance Sheet"
        Me.mnurptBalanceSheet.Visible = False
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(37, 20)
        Me.mnuExit.Text = "E&xit"
        '
        'mnuRegister
        '
        Me.mnuRegister.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuActivate})
        Me.mnuRegister.Name = "mnuRegister"
        Me.mnuRegister.Size = New System.Drawing.Size(82, 20)
        Me.mnuRegister.Text = "&Registration"
        '
        'mnuActivate
        '
        Me.mnuActivate.Name = "mnuActivate"
        Me.mnuActivate.Size = New System.Drawing.Size(117, 22)
        Me.mnuActivate.Text = "Activate"
        '
        'sbrMain
        '
        Me.sbrMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ApplnName, Me.Version, Me.UserName, Me.Counter, Me.Server, Me.LoginTime, Me.CurrentDate, Me.CurrentTime})
        Me.sbrMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.sbrMain.Location = New System.Drawing.Point(0, 678)
        Me.sbrMain.Name = "sbrMain"
        Me.sbrMain.Size = New System.Drawing.Size(1024, 24)
        Me.sbrMain.TabIndex = 32
        Me.sbrMain.Text = "Status Bar"
        '
        'ApplnName
        '
        Me.ApplnName.AutoSize = False
        Me.ApplnName.AutoToolTip = True
        Me.ApplnName.BackColor = System.Drawing.SystemColors.Control
        Me.ApplnName.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.ApplnName.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter
        Me.ApplnName.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApplnName.ForeColor = System.Drawing.Color.Maroon
        Me.ApplnName.Name = "ApplnName"
        Me.ApplnName.Size = New System.Drawing.Size(115, 19)
        Me.ApplnName.Text = "ApplnName"
        '
        'Version
        '
        Me.Version.AutoSize = False
        Me.Version.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.Version.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter
        Me.Version.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Version.ForeColor = System.Drawing.Color.Maroon
        Me.Version.Name = "Version"
        Me.Version.Size = New System.Drawing.Size(60, 19)
        Me.Version.Text = "Version"
        '
        'UserName
        '
        Me.UserName.AutoSize = False
        Me.UserName.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.UserName.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter
        Me.UserName.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserName.ForeColor = System.Drawing.Color.Maroon
        Me.UserName.IsLink = True
        Me.UserName.Name = "UserName"
        Me.UserName.Size = New System.Drawing.Size(150, 19)
        Me.UserName.Spring = True
        Me.UserName.Text = "UserName"
        '
        'Counter
        '
        Me.Counter.AutoSize = False
        Me.Counter.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.Counter.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter
        Me.Counter.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Counter.ForeColor = System.Drawing.Color.Maroon
        Me.Counter.Name = "Counter"
        Me.Counter.Size = New System.Drawing.Size(90, 19)
        Me.Counter.Text = "Counter"
        '
        'Server
        '
        Me.Server.AutoSize = False
        Me.Server.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.Server.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter
        Me.Server.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Server.ForeColor = System.Drawing.Color.Maroon
        Me.Server.Name = "Server"
        Me.Server.Size = New System.Drawing.Size(150, 19)
        Me.Server.Text = "Server"
        '
        'LoginTime
        '
        Me.LoginTime.AutoSize = False
        Me.LoginTime.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.LoginTime.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter
        Me.LoginTime.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginTime.ForeColor = System.Drawing.Color.Maroon
        Me.LoginTime.Name = "LoginTime"
        Me.LoginTime.Size = New System.Drawing.Size(170, 19)
        Me.LoginTime.Text = "Login Time"
        '
        'CurrentDate
        '
        Me.CurrentDate.AutoSize = False
        Me.CurrentDate.AutoToolTip = True
        Me.CurrentDate.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.CurrentDate.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter
        Me.CurrentDate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.CurrentDate.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentDate.ForeColor = System.Drawing.Color.Maroon
        Me.CurrentDate.Name = "CurrentDate"
        Me.CurrentDate.Size = New System.Drawing.Size(140, 19)
        Me.CurrentDate.Text = "Current Date"
        '
        'CurrentTime
        '
        Me.CurrentTime.AutoSize = False
        Me.CurrentTime.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.CurrentTime.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner
        Me.CurrentTime.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentTime.ForeColor = System.Drawing.Color.Maroon
        Me.CurrentTime.Name = "CurrentTime"
        Me.CurrentTime.Size = New System.Drawing.Size(100, 19)
        Me.CurrentTime.Text = "Current Time"
        '
        'MDINaviBar
        '
        Me.MDINaviBar.ActiveBand = Me.BandTransactions
        Me.MDINaviBar.ButtonHeight = 26
        Me.MDINaviBar.Controls.Add(Me.BandTransactions)
        Me.MDINaviBar.Controls.Add(Me.BandMasters)
        Me.MDINaviBar.Controls.Add(Me.BandInvReports)
        Me.MDINaviBar.Controls.Add(Me.BandAdmin)
        Me.MDINaviBar.Controls.Add(Me.BandProduction)
        Me.MDINaviBar.Controls.Add(Me.BandUtilities)
        Me.MDINaviBar.Controls.Add(Me.BandAccounts)
        Me.MDINaviBar.Controls.Add(Me.BandAccReports)
        Me.MDINaviBar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MDINaviBar.Dock = System.Windows.Forms.DockStyle.Left
        Me.MDINaviBar.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MDINaviBar.LayoutStyle = Guifreaks.NavigationBar.NaviLayoutStyle.Office2003Blue
        Me.MDINaviBar.Location = New System.Drawing.Point(0, 24)
        Me.MDINaviBar.Name = "MDINaviBar"
        Me.MDINaviBar.Size = New System.Drawing.Size(262, 654)
        Me.MDINaviBar.TabIndex = 34
        Me.MDINaviBar.VisibleLargeButtons = 8
        '
        'BandTransactions
        '
        '
        'BandTransactions.ClientArea
        '
        Me.BandTransactions.ClientArea.Controls.Add(Me.tvwPurchase)
        Me.BandTransactions.ClientArea.Location = New System.Drawing.Point(0, 0)
        Me.BandTransactions.ClientArea.Name = "ClientArea"
        Me.BandTransactions.ClientArea.Size = New System.Drawing.Size(260, 379)
        Me.BandTransactions.ClientArea.TabIndex = 0
        Me.BandTransactions.LargeImage = CType(resources.GetObject("BandTransactions.LargeImage"), System.Drawing.Image)
        Me.BandTransactions.LayoutStyle = Guifreaks.NavigationBar.NaviLayoutStyle.Office2003Blue
        Me.BandTransactions.Location = New System.Drawing.Point(1, 27)
        Me.BandTransactions.Name = "BandTransactions"
        Me.BandTransactions.Size = New System.Drawing.Size(260, 379)
        Me.BandTransactions.TabIndex = 0
        Me.BandTransactions.Text = "&Transactions"
        '
        'tvwPurchase
        '
        Me.tvwPurchase.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tvwPurchase.Dock = System.Windows.Forms.DockStyle.Top
        Me.tvwPurchase.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tvwPurchase.ImageIndex = 3
        Me.tvwPurchase.ImageList = Me.MainImageList
        Me.tvwPurchase.Location = New System.Drawing.Point(0, 0)
        Me.tvwPurchase.Name = "tvwPurchase"
        TreeNode1.Name = "ndFabricPO"
        TreeNode1.Text = "Fabric Order"
        TreeNode2.Name = "ndFinishPO"
        TreeNode2.Text = "Finished Order"
        TreeNode3.Name = "ndAccessoriesPO"
        TreeNode3.Text = "Accessories & Trims Order"
        TreeNode4.Name = "ndMiscPO"
        TreeNode4.Text = "Other Order"
        TreeNode5.Name = "ndPurOrder"
        TreeNode5.Text = "Purchase Order"
        TreeNode6.Name = "ndFabPurchaseWithoutPO"
        TreeNode6.Text = "Purchase Inward"
        TreeNode6.ToolTipText = "Purchase Inward"
        TreeNode7.Name = "ndFabPurchaseWithPO"
        TreeNode7.Text = "Purchase Inward (Against PO)"
        TreeNode8.Name = "ndJobWorkInward"
        TreeNode8.Text = "Job Work Inward"
        TreeNode9.Name = "ndbeleopen"
        TreeNode9.Text = "Bale Open"
        TreeNode10.Name = "ndFabPurchase"
        TreeNode10.Text = "Fabric"
        TreeNode11.Name = "ndFinPurchaseWithoutPO"
        TreeNode11.Text = "Purchase Inward"
        TreeNode12.Name = "ndFinPurchaseWithPO"
        TreeNode12.Text = "Purchase Inward (Against PO)"
        TreeNode13.Name = "ndFinPurchaseBarcodeWithoutPO"
        TreeNode13.Text = "Purchase Inward from Barcode"
        TreeNode14.Name = "ndFinPurchaseBarcodeWithPO"
        TreeNode14.Text = "Purchase Inward from Barcode (PO)"
        TreeNode15.Name = "ndFinPurchase"
        TreeNode15.Text = "Finished"
        TreeNode16.Name = "ndAccessoriesPurchase"
        TreeNode16.Text = "Acc & Trims Purchase Inward"
        TreeNode17.Name = "ndStoresPurchase"
        TreeNode17.Text = "Accesssories  & Trims"
        TreeNode18.Name = "ndMiscPurchase"
        TreeNode18.Text = "Other Purchase"
        TreeNode19.Name = "ndPurInward"
        TreeNode19.Text = "Purchase Inward"
        TreeNode20.Name = "ndPurchaseBill"
        TreeNode20.Text = "Purchase Invoice"
        TreeNode21.Name = "ndFabricRtn"
        TreeNode21.Text = "Purchase Return"
        TreeNode22.Name = "ndFabPurRtn"
        TreeNode22.Text = "Fabric"
        TreeNode23.Name = "ndFinishRtn"
        TreeNode23.Text = "Purchase Return"
        TreeNode24.Name = "ndFinishRtnWithBarcode"
        TreeNode24.Text = "Purchase Return from Barcode"
        TreeNode25.Name = "ndFinPurRtn"
        TreeNode25.Text = "Finished"
        TreeNode26.Name = "ndAccessoriesRtn"
        TreeNode26.Text = "Purchase Return"
        TreeNode27.Name = "ndStoresRtn"
        TreeNode27.Text = "Accesssories  & Trims"
        TreeNode28.Name = "ndMiscRtn"
        TreeNode28.Text = "Other Return"
        TreeNode29.Name = "ndPurReturn"
        TreeNode29.Text = "Purchase Return"
        TreeNode30.Name = "ndQuotation"
        TreeNode30.Text = "Quotation"
        TreeNode31.Name = "NDRQUOTATION"
        TreeNode31.Text = "Revised Quotation"
        TreeNode32.Name = "ndSODRAFT"
        TreeNode32.Text = "Sales Order Draft"
        TreeNode33.Name = "ndSalesOrder"
        TreeNode33.Text = "Sales Order"
        TreeNode34.Name = "ndsalesorderwithbarcode"
        TreeNode34.Text = "Sales Order From Barcode"
        TreeNode35.Name = "NdDispatchList"
        TreeNode35.Text = "Dispatch List"
        TreeNode36.Name = "NDPACKINGSLIP"
        TreeNode36.Text = "Packing Slip (Carton Wise)"
        TreeNode37.Name = "NDPACKINGLISTSLIP"
        TreeNode37.Text = "Packing List (Against Packing Slip)"
        TreeNode38.Name = "ndDeliveryNote"
        TreeNode38.Text = "Packing List"
        TreeNode39.Name = "ndDeliveryNoteOnline"
        TreeNode39.Text = "Packing List Online"
        TreeNode40.Name = "ndDeliveryNoteAgainstSO"
        TreeNode40.Text = "Packing List (Against SO)"
        TreeNode41.Name = "ndDeliveryNoteWithBarcode"
        TreeNode41.Text = "Packing List From Barcode"
        TreeNode42.Name = "ndDeliveryNoteWithBarcodeSO"
        TreeNode42.Text = "Packing List From Barcode (SO)"
        TreeNode43.Name = "ndPackingReturn"
        TreeNode43.Text = "Packing Return"
        TreeNode44.Name = "ndestimate"
        TreeNode44.Text = "Packing List(Estimate)"
        TreeNode45.Name = "ndbarestimate"
        TreeNode45.Text = "Packing List From Barcode(Estimate)"
        TreeNode46.Name = "ndSalesInvoice"
        TreeNode46.Text = "Sales Invoice"
        TreeNode47.Name = "ndSalesInvoiceOnline"
        TreeNode47.Text = "Sales Invoice(Online)"
        TreeNode48.Name = "ndestimateBill"
        TreeNode48.Text = "Sales Invoice(Estimate)"
        TreeNode49.Name = "ndSalesInvoiceOutlets"
        TreeNode49.Text = "Sales Invoice(Showroom)"
        TreeNode50.Name = "ndExchangeOutlets"
        TreeNode50.Text = "Exchange(Showroom)"
        TreeNode51.Name = "ndSalesRtn"
        TreeNode51.Text = "Sales Return"
        TreeNode52.Name = "ndSalesREstimate"
        TreeNode52.Text = "Sales Return(Estimate)"
        TreeNode53.Name = "ndSalesRtnBarCode"
        TreeNode53.Text = "Sales Return From Barcode"
        TreeNode54.Name = "ndGatePassEntry"
        TreeNode54.Text = "GatePass Entry"
        TreeNode55.Name = "ndpackingweightentry"
        TreeNode55.Text = "Packing Weight Entry"
        TreeNode56.Name = "ndLREntry"
        TreeNode56.Text = "Lr Entry"
        TreeNode57.Name = "ndCreditNoteOth"
        TreeNode57.Text = "Credit Note (Other)"
        TreeNode58.Name = "ndSamplePacking"
        TreeNode58.Text = "Sample Packing"
        TreeNode59.Name = "ndSamplePackingReturn"
        TreeNode59.Text = "Sample Packing Return"
        TreeNode60.Name = "ndCustomInvoice"
        TreeNode60.Text = "Custom Invoice"
        TreeNode61.Name = "NDRETAILINVOICE"
        TreeNode61.Text = "Retail Invoice"
        TreeNode62.ImageIndex = 4
        TreeNode62.Name = "ndSalesAndDispatch"
        TreeNode62.SelectedImageIndex = 4
        TreeNode62.Text = "Sales And Despatch"
        TreeNode63.Name = "ndOpeningStockFinishPurchase"
        TreeNode63.Text = "Opening Stock (Purchase)"
        TreeNode64.Name = "ndOpeningStockFinish"
        TreeNode64.Text = "Opening Stock(Finish)"
        TreeNode65.Name = "ndOpeningAccStk"
        TreeNode65.Text = "Opening Stock (Accessories)"
        TreeNode66.Name = "ndOpeningPackStk"
        TreeNode66.Text = "Opening Stock (Packing Item)"
        TreeNode67.Name = "ndOpeningFabricStk"
        TreeNode67.Text = "Opening Stock (Fabric)"
        TreeNode68.Name = "ndOpeningFabricStkPro"
        TreeNode68.Text = "Opening Stock With Jobber(Fabric)"
        TreeNode69.Name = "ndOpeningAccStkPro"
        TreeNode69.Text = "Opening Stock With Jobber(Accessories)"
        TreeNode70.Name = "ndOpeningPackStkPro"
        TreeNode70.Text = "Opening Stock With Jobber(Packing)"
        TreeNode71.Name = "ndProcessStockWithParty"
        TreeNode71.Text = "Process Stock With Party"
        TreeNode72.Name = "ndProcessStockWithgodown"
        TreeNode72.Text = "Process Stock With Godown"
        TreeNode73.ImageIndex = 13
        TreeNode73.Name = "ndOpeningStock"
        TreeNode73.SelectedImageIndex = 13
        TreeNode73.Text = "Opening Stock"
        TreeNode74.Name = "ndStyleTransfer"
        TreeNode74.Text = "Style Transfer"
        TreeNode75.Name = "ndProductSetMaking"
        TreeNode75.Text = "Product Set Making"
        TreeNode75.ToolTipText = "Product Set Making"
        TreeNode76.ImageIndex = 3
        TreeNode76.Name = "ndDamageStock"
        TreeNode76.Text = "Damage Stock"
        TreeNode77.Name = "ndStockTransfer1"
        TreeNode77.Text = "Stock Transfer"
        TreeNode78.Name = "ndSetMakingNew"
        TreeNode78.Text = "Set Making New"
        TreeNode79.Name = "ndFabTfrFromBToF"
        TreeNode79.Text = "Fabric Transfer From Booked To Free"
        TreeNode80.Name = "ndFabTfrFromFToB"
        TreeNode80.Text = "Fabric Transfer From Free To Booked"
        TreeNode81.Name = "ndAccTfrFromBToF"
        TreeNode81.Text = "Accessories Transfer From Booked To Free"
        TreeNode82.Name = "ndAccTfrFromFToB"
        TreeNode82.Text = "Accessories Transfer From Free To Booked "
        TreeNode83.Name = "ndOthers"
        TreeNode83.Text = "Other Transactions"
        TreeNode84.Name = "ndJobOrder"
        TreeNode84.Text = "Job Order"
        TreeNode85.Name = "ndJobChallan"
        TreeNode85.Text = "Delivery Challan"
        TreeNode86.Name = "ndJobInvoice"
        TreeNode86.Text = "Invoice"
        TreeNode87.Name = "ndSalesAndServices"
        TreeNode87.Text = "Sales & Services"
        TreeNode88.Name = "NDFAB"
        TreeNode88.Text = "Fabric"
        TreeNode89.Name = "NDACC"
        TreeNode89.Text = "Accessories"
        TreeNode90.Name = "NDSTKTRANSFER"
        TreeNode90.Text = "Stock Transfer"
        TreeNode91.Name = "NDMATERIALREQUISITIONNOTE"
        TreeNode91.Text = "Material Requisition Note"
        TreeNode92.Name = "NDMATERIALISSUENOTE"
        TreeNode92.Text = "Material Issue Note"
        TreeNode93.Name = "NDMATERIALCONSMNOTE"
        TreeNode93.Text = "Material Consumption Note"
        TreeNode94.Name = "NDMATERIALRETURNNOTE"
        TreeNode94.Text = "Material Return Note"
        TreeNode95.Name = "NDMRN"
        TreeNode95.Text = "MRN"
        TreeNode96.Name = "ndStockIssuePacking"
        TreeNode96.Text = "Stock Issue(Packing)"
        TreeNode97.Name = "ndStockReceiptPacking"
        TreeNode97.Text = "Stock Receipt(Packing)"
        TreeNode98.Name = "ndStockIssueBackPacking"
        TreeNode98.Text = "Stock Issue Back(Packing)"
        TreeNode99.Name = "ndStockPacking "
        TreeNode99.Text = "Stock Packing"
        Me.tvwPurchase.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode5, TreeNode19, TreeNode20, TreeNode29, TreeNode62, TreeNode73, TreeNode83, TreeNode87, TreeNode90, TreeNode95, TreeNode99})
        Me.tvwPurchase.SelectedImageIndex = 3
        Me.tvwPurchase.ShowLines = False
        Me.tvwPurchase.Size = New System.Drawing.Size(260, 416)
        Me.tvwPurchase.TabIndex = 2
        Me.tvwPurchase.TabStop = False
        '
        'MainImageList
        '
        Me.MainImageList.ImageStream = CType(resources.GetObject("MainImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.MainImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.MainImageList.Images.SetKeyName(0, "Closed")
        Me.MainImageList.Images.SetKeyName(1, "ShopCart")
        Me.MainImageList.Images.SetKeyName(2, "UserRights")
        Me.MainImageList.Images.SetKeyName(3, "buy.png")
        Me.MainImageList.Images.SetKeyName(4, "invoice.png")
        Me.MainImageList.Images.SetKeyName(5, "report.png")
        Me.MainImageList.Images.SetKeyName(6, "configuration.png")
        Me.MainImageList.Images.SetKeyName(7, "settings.png")
        Me.MainImageList.Images.SetKeyName(8, "gnome_preferences_other.png")
        Me.MainImageList.Images.SetKeyName(9, "address_book_blue.png")
        Me.MainImageList.Images.SetKeyName(10, "EMail_32x32.png")
        Me.MainImageList.Images.SetKeyName(11, "iphone_sms.png")
        Me.MainImageList.Images.SetKeyName(12, "stock_id.png")
        Me.MainImageList.Images.SetKeyName(13, "Inventory.png")
        '
        'BandMasters
        '
        '
        'BandMasters.ClientArea
        '
        Me.BandMasters.ClientArea.Controls.Add(Me.tvwMasters)
        Me.BandMasters.ClientArea.Location = New System.Drawing.Point(0, 0)
        Me.BandMasters.ClientArea.Name = "ClientArea"
        Me.BandMasters.ClientArea.Size = New System.Drawing.Size(260, 379)
        Me.BandMasters.ClientArea.TabIndex = 0
        Me.BandMasters.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BandMasters.LargeImage = CType(resources.GetObject("BandMasters.LargeImage"), System.Drawing.Image)
        Me.BandMasters.LayoutStyle = Guifreaks.NavigationBar.NaviLayoutStyle.Office2003Blue
        Me.BandMasters.Location = New System.Drawing.Point(1, 27)
        Me.BandMasters.Name = "BandMasters"
        Me.BandMasters.Size = New System.Drawing.Size(260, 379)
        Me.BandMasters.TabIndex = 2
        Me.BandMasters.Text = "&Masters"
        '
        'tvwMasters
        '
        Me.tvwMasters.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvwMasters.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tvwMasters.ImageIndex = 0
        Me.tvwMasters.ImageList = Me.MainImageList
        Me.tvwMasters.LabelEdit = True
        Me.tvwMasters.Location = New System.Drawing.Point(0, 0)
        Me.tvwMasters.Name = "tvwMasters"
        TreeNode100.Name = "ndCompany"
        TreeNode100.Text = "Company"
        TreeNode101.Name = "ndRegion"
        TreeNode101.Text = "Region"
        TreeNode102.Name = "ndCountry"
        TreeNode102.Text = "Country"
        TreeNode103.Name = "ndZone"
        TreeNode103.Text = "Zone"
        TreeNode104.Name = "ndState"
        TreeNode104.Text = "State"
        TreeNode105.Name = "ndDistrict"
        TreeNode105.Text = "District"
        TreeNode106.Name = "ndCity"
        TreeNode106.Text = "City"
        TreeNode107.Name = "ndStation"
        TreeNode107.Text = "Station"
        TreeNode108.Name = "ndPortOfDischg"
        TreeNode108.Text = "Port Of Discharge"
        TreeNode109.Name = "NDPORTOFLOADING"
        TreeNode109.Text = "Port Of Loading"
        TreeNode110.Name = "ndLocation"
        TreeNode110.Text = "Location"
        TreeNode111.Name = "ndStkLocation"
        TreeNode111.Text = "Location"
        TreeNode112.Name = "ndRack"
        TreeNode112.Text = "Rack"
        TreeNode113.Name = "ndStockLocation"
        TreeNode113.Text = "Stock Location"
        TreeNode114.Name = "ndDepartment"
        TreeNode114.Text = "Department"
        TreeNode115.Name = "ndDesignation"
        TreeNode115.Text = "Designation"
        TreeNode116.Name = "ndEmployee"
        TreeNode116.Text = "Employee"
        TreeNode117.Name = "ndEmployee1"
        TreeNode117.Text = "Employee1"
        TreeNode118.Name = "ndPersonalContacts"
        TreeNode118.Text = "Personal Contacts"
        TreeNode119.Name = "ndRelationType"
        TreeNode119.Text = "Relation Type"
        TreeNode120.Name = "ndSalesperson"
        TreeNode120.Text = "Salesperson"
        TreeNode121.Name = "ndPersonal"
        TreeNode121.Text = "Personal"
        TreeNode122.Name = "ndCustomerWholeSale"
        TreeNode122.Text = "Customer"
        TreeNode123.Name = "ndCustomerGroup"
        TreeNode123.Text = "Customer Group"
        TreeNode124.Name = "ndCustomer"
        TreeNode124.Text = "Customer"
        TreeNode125.Name = "ndCreditorsSuppliers"
        TreeNode125.Text = "Creditors/Suppliers"
        TreeNode126.Name = "ndTransporter"
        TreeNode126.Text = "Transporter"
        TreeNode127.Name = "ndBroker"
        TreeNode127.Text = "Broker"
        TreeNode128.Name = "ndCreditorsSuppliersGroup"
        TreeNode128.Text = "Creditors/Suppliers Group"
        TreeNode129.Name = "ndManufacturer"
        TreeNode129.Text = "Manufacturer"
        TreeNode130.Name = "ndMarketedBy"
        TreeNode130.Text = "Marketed By"
        TreeNode131.Name = "ndVendors"
        TreeNode131.Text = "Vendors"
        TreeNode132.Name = "ndFinGroup"
        TreeNode132.Text = "Group"
        TreeNode133.Name = "ndFinSubGroup"
        TreeNode133.Text = "Sub-Group"
        TreeNode134.Name = "ndFinish"
        TreeNode134.Text = "Product"
        TreeNode135.Name = "ndDesign"
        TreeNode135.Text = "Style"
        TreeNode136.Name = "ndType"
        TreeNode136.Text = "Type"
        TreeNode137.Name = "nditembrandwise_discount"
        TreeNode137.Text = "Item/BrandWise Discount"
        TreeNode138.Name = "ndFinishType"
        TreeNode138.Text = "Finish"
        TreeNode139.Name = "ndFabGroup"
        TreeNode139.Text = "Group"
        TreeNode140.Name = "ndFabSubGroup"
        TreeNode140.Text = "Sub-Group"
        TreeNode141.Name = "ndFabric"
        TreeNode141.Text = "Fabric Master"
        TreeNode142.Name = "ndComponent"
        TreeNode142.Text = "Component"
        TreeNode143.Name = "ndFabricType"
        TreeNode143.Text = "Fabric"
        TreeNode144.Name = "ndAccessGroup"
        TreeNode144.Text = "Group"
        TreeNode145.Name = "ndAccessSubGroup"
        TreeNode145.Text = "Sub-Group"
        TreeNode146.Name = "ndAccessories"
        TreeNode146.Text = "Accessories Master"
        TreeNode147.Name = "ndAccType"
        TreeNode147.Text = "Accessories"
        TreeNode148.Name = "ndPackGroup"
        TreeNode148.Text = "Group"
        TreeNode149.Name = "ndPackSubGroup"
        TreeNode149.Text = "Sub-Group"
        TreeNode150.Name = "ndPacking"
        TreeNode150.Text = "Packing Master"
        TreeNode151.Name = "ndPack"
        TreeNode151.Text = "Packing"
        TreeNode152.Name = "ndPrintSubGroup"
        TreeNode152.Text = "Sub Group"
        TreeNode153.Name = "ndPrintType"
        TreeNode153.Text = "Type"
        TreeNode154.Name = "ndPrintDesignMasters"
        TreeNode154.Text = "Design Masters"
        TreeNode155.Name = "ndPrintDesignMst"
        TreeNode155.Text = "Print Design"
        TreeNode156.Name = "ndOtherItem"
        TreeNode156.Text = "Other Item"
        TreeNode157.Name = "ndMiscGroup"
        TreeNode157.Text = "Group"
        TreeNode158.Name = "ndMiscSubGroup"
        TreeNode158.Text = "Sub-Group"
        TreeNode159.Name = "ndMiscMaster"
        TreeNode159.Text = "Misc Master"
        TreeNode160.Name = "ndMisc1"
        TreeNode160.Text = "Miscellaneous"
        TreeNode161.Name = "ndProductType"
        TreeNode161.Text = "Product"
        TreeNode162.Name = "ndShade"
        TreeNode162.Text = "Shade"
        TreeNode163.Name = "ndBrand"
        TreeNode163.Text = "Brand"
        TreeNode164.Name = "ndUnit"
        TreeNode164.Text = "Unit"
        TreeNode165.Name = "ndQuality"
        TreeNode165.Text = "Quality"
        TreeNode166.Name = "ndSeason"
        TreeNode166.Text = "Season"
        TreeNode167.Name = "ndOccassion"
        TreeNode167.Text = "Occassion"
        TreeNode168.Name = "ndPackType"
        TreeNode168.Text = "Packing Type"
        TreeNode169.Name = "ndRateCategory"
        TreeNode169.Text = "Rate Category"
        TreeNode170.Name = "ndRateCode"
        TreeNode170.Text = "Rate Code"
        TreeNode171.Name = "ndImageType"
        TreeNode171.Text = "Image Type"
        TreeNode172.Name = "ndSection"
        TreeNode172.Text = "Section"
        TreeNode173.Name = "ndPDesign"
        TreeNode173.Text = "Category"
        TreeNode174.Name = "NDPEXP"
        TreeNode174.Text = "Product Expenses"
        TreeNode175.Name = "ndMisc"
        TreeNode175.Text = "Miscellaneous"
        TreeNode176.Name = "NDEAN"
        TreeNode176.Text = "EAN Desc"
        TreeNode177.Name = "NDREASON"
        TreeNode177.Text = "Reason"
        TreeNode178.Name = "ndProductRef"
        TreeNode178.Text = "Product References"
        TreeNode179.Name = "ndPaymentType"
        TreeNode179.Text = "Payment Type"
        TreeNode180.Name = "ndDeducteeType"
        TreeNode180.Text = "Deductee Type"
        TreeNode181.Name = "ndTDS"
        TreeNode181.Text = "TDS Details"
        TreeNode182.Name = "ndTDSRef"
        TreeNode182.Text = "TDS"
        TreeNode183.Name = "ndTaxDetails"
        TreeNode183.Text = "Tax"
        TreeNode184.Name = "ndTermDetails"
        TreeNode184.Text = "Terms"
        TreeNode185.Name = "ndTermDiscount"
        TreeNode185.Text = "Term Discount"
        TreeNode186.Name = "ndGSTSlab"
        TreeNode186.Text = "GST Slab"
        TreeNode187.Name = "ndTaxTerms"
        TreeNode187.Text = "Tax/Terms"
        TreeNode188.Name = "ndCurrency"
        TreeNode188.Text = "Currency"
        TreeNode189.Name = "ndRemoteRptPath"
        TreeNode189.Text = "Remote Report Path"
        TreeNode190.Name = "NDTALLYEXPORTDATA"
        TreeNode190.Text = "Tally Export Data"
        TreeNode191.Name = "NDATTACHMENTTYPE"
        TreeNode191.Text = "Attachment Type"
        TreeNode192.Name = "NDMACHINEMSTR"
        TreeNode192.Text = "Machine Master"
        TreeNode193.Name = "NDLINEMSTR"
        TreeNode193.Text = "Line Master"
        TreeNode194.Name = "NDCOMBINATIONITEMMSTR"
        TreeNode194.Text = "Combination Item"
        TreeNode195.Name = "ndMiscellaneous"
        TreeNode195.Text = "Miscellaneous"
        TreeNode196.Name = "ndProStgGrp"
        TreeNode196.Text = "Process Group"
        TreeNode197.Name = "ndProStg"
        TreeNode197.Text = "Process Name"
        TreeNode198.Name = "ndPart"
        TreeNode198.Text = "Operation Name"
        TreeNode199.Name = "NDSUBPROCESS"
        TreeNode199.Text = "Sub Process"
        TreeNode200.Name = "ndProcess"
        TreeNode200.Text = "Process"
        TreeNode201.Name = "ndExciseTrf"
        TreeNode201.Text = "Excise Tariff Master"
        TreeNode202.Name = "ndExciseTrfGrp"
        TreeNode202.Text = "Excise Trariff Group"
        TreeNode203.Name = "ndExcise"
        TreeNode203.Text = "Excise"
        TreeNode204.Name = "ndSchDef"
        TreeNode204.Text = "Scheme Definition"
        TreeNode205.Name = "ndScheme"
        TreeNode205.Text = "Scheme"
        TreeNode206.Name = "ndSchemeType"
        TreeNode206.Text = "Scheme"
        TreeNode207.Name = "ndProductWiseTax"
        TreeNode207.Text = "Product Wise Tax"
        TreeNode208.Name = "ndEboSystem"
        TreeNode208.Text = "EBO System"
        Me.tvwMasters.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode100, TreeNode110, TreeNode113, TreeNode121, TreeNode124, TreeNode131, TreeNode161, TreeNode178, TreeNode182, TreeNode187, TreeNode195, TreeNode200, TreeNode203, TreeNode206, TreeNode208})
        Me.tvwMasters.SelectedImageIndex = 0
        Me.tvwMasters.Size = New System.Drawing.Size(260, 379)
        Me.tvwMasters.TabIndex = 0
        Me.tvwMasters.TabStop = False
        '
        'BandInvReports
        '
        '
        'BandInvReports.ClientArea
        '
        Me.BandInvReports.ClientArea.Controls.Add(Me.tvwInventoryReports)
        Me.BandInvReports.ClientArea.Location = New System.Drawing.Point(0, 0)
        Me.BandInvReports.ClientArea.Name = "ClientArea"
        Me.BandInvReports.ClientArea.Size = New System.Drawing.Size(260, 379)
        Me.BandInvReports.ClientArea.TabIndex = 0
        Me.BandInvReports.LargeImage = CType(resources.GetObject("BandInvReports.LargeImage"), System.Drawing.Image)
        Me.BandInvReports.LayoutStyle = Guifreaks.NavigationBar.NaviLayoutStyle.Office2003Blue
        Me.BandInvReports.Location = New System.Drawing.Point(1, 27)
        Me.BandInvReports.Name = "BandInvReports"
        Me.BandInvReports.Size = New System.Drawing.Size(260, 379)
        Me.BandInvReports.TabIndex = 3
        Me.BandInvReports.Text = "&Inventory Reports"
        '
        'tvwInventoryReports
        '
        Me.tvwInventoryReports.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tvwInventoryReports.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvwInventoryReports.ImageIndex = 5
        Me.tvwInventoryReports.ImageList = Me.MainImageList
        Me.tvwInventoryReports.LabelEdit = True
        Me.tvwInventoryReports.Location = New System.Drawing.Point(0, 0)
        Me.tvwInventoryReports.Name = "tvwInventoryReports"
        TreeNode209.Name = "ndrptFabPOBill"
        TreeNode209.Text = "Bill Wise Register"
        TreeNode210.Name = "ndrptFabPODate"
        TreeNode210.Text = "Date Wise Register"
        TreeNode211.Name = "ndrptFabPOSupplier"
        TreeNode211.Text = "Supplier Wise Register"
        TreeNode212.Name = "ndrptFabPOSubGrp"
        TreeNode212.Text = "Sub-Group Wise Register"
        TreeNode213.Name = "ndrptFabPOProduct"
        TreeNode213.Text = "Product Wise Register"
        TreeNode214.Name = "ndrptFabPOBrand"
        TreeNode214.Text = "Brand Wise Register"
        TreeNode215.Name = "ndrptFabPOStatusBill"
        TreeNode215.Text = "Order Status Bill Wise"
        TreeNode216.Name = "ndrptFabPOStatusDate"
        TreeNode216.Text = "Order Status Date Wise"
        TreeNode217.Name = "ndrptFabPOStatusSupplier"
        TreeNode217.Text = "Order Status Supplier Wise"
        TreeNode218.Name = "ndrptFabPOStatusSubGrp"
        TreeNode218.Text = "Order Status Sub-Group Wise"
        TreeNode219.Name = "ndrptFabPOStatusProduct"
        TreeNode219.Text = "Order Status Product Wise"
        TreeNode220.Name = "ndrptFabPOStatusBrand"
        TreeNode220.Text = "Order Status Brand Wise"
        TreeNode221.Name = "ndOrderStatusAsPerPurchase"
        TreeNode221.Text = "Order Status As Per Purchase(Date Wise)"
        TreeNode222.Name = "ndrptFabPOAllInOne"
        TreeNode222.Text = "Purchase Order Report"
        TreeNode223.Name = "ndrptFabPOTrn"
        TreeNode223.Text = "Transaction"
        TreeNode224.Name = "ndrptFabPOAnalysisCancel"
        TreeNode224.Text = "Cancelled Purchase Order"
        TreeNode225.Name = "ndrptFabPOAnalysisShortClose"
        TreeNode225.Text = "Short Close Register"
        TreeNode226.Name = "ndrptFabPOAnalysisAllInOne"
        TreeNode226.Text = "All In One Purchase Order"
        TreeNode227.Name = "ndrptFabPOAnalysis"
        TreeNode227.Text = "Analysis"
        TreeNode228.Name = "ndrptFabPO"
        TreeNode228.Text = "Fabric"
        TreeNode229.Name = "ndPurOrderRegBill"
        TreeNode229.Text = "Bill Wise Register"
        TreeNode230.Name = "ndPurOrderRegDate"
        TreeNode230.Text = "Date Wise Register"
        TreeNode231.Name = "ndPurOrderRegParty"
        TreeNode231.Text = "Supplier Wise Register"
        TreeNode232.Name = "ndPurOrderRegSubGroup"
        TreeNode232.Text = "Sub-Group Wise Register"
        TreeNode233.Name = "ndPurOrderRegProduct"
        TreeNode233.Text = "Product Wise Register"
        TreeNode234.Name = "ndPurOrderRegBrand"
        TreeNode234.Text = "Brand Wise Register"
        TreeNode235.Name = "ndPendPurOrderRegBill"
        TreeNode235.Text = "Order Status Bill Wise"
        TreeNode236.Name = "ndPendPurOrderRegDate"
        TreeNode236.Text = "Order Status Date Wise"
        TreeNode237.Name = "ndPendPurOrderRegParty"
        TreeNode237.Text = "Order Status Supplier Wise"
        TreeNode238.Name = "ndPendPurOrderRegSubGroup"
        TreeNode238.Text = "Order Status Sub-Group Wise"
        TreeNode239.Name = "ndPendPurOrderRegProduct"
        TreeNode239.Text = "Order Status Product Wise"
        TreeNode240.Name = "ndPendPurOrderRegBrand"
        TreeNode240.Text = "Order Status Brand Wise"
        TreeNode241.Name = "ndPurOrderTrans"
        TreeNode241.Text = "Transactions"
        TreeNode242.Name = "ndPurOrderCancelled"
        TreeNode242.Text = "Cancelled Purchase Order"
        TreeNode243.Name = "ndPurOrderShortClose"
        TreeNode243.Text = "Short Close Register"
        TreeNode244.Name = "ndAllInPurOrder"
        TreeNode244.Text = "All In One Purchase Order"
        TreeNode245.Name = "ndPurOrderAnalysis"
        TreeNode245.Text = "Analysis"
        TreeNode246.Name = "ndrptFinishedPO"
        TreeNode246.Text = "Finished"
        TreeNode247.Name = "ndrptStorePOBill"
        TreeNode247.Text = "Bill Wise Register"
        TreeNode248.Name = "ndrptStorePODate"
        TreeNode248.Text = "Date Wise Register"
        TreeNode249.Name = "ndrptStorePOSupplier"
        TreeNode249.Text = "Supplier Wise Register"
        TreeNode250.Name = "ndrptStorePOSubGrp"
        TreeNode250.Text = "Sub-Group Wise Register"
        TreeNode251.Name = "ndrptStorePOProduct"
        TreeNode251.Text = "Product Wise Register"
        TreeNode252.Name = "ndrptStorePOBrand"
        TreeNode252.Text = "Brand Wise Register"
        TreeNode253.Name = "ndrptStorePOStatusBill"
        TreeNode253.Text = "Order Status Bill Wise"
        TreeNode254.Name = "ndrptStorePOStatusDate"
        TreeNode254.Text = "Order Status Date Wise"
        TreeNode255.Name = "ndrptStorePOStatusSupplier"
        TreeNode255.Text = "Order Status Supplier Wise"
        TreeNode256.Name = "ndrptStorePOStatusSubGrp"
        TreeNode256.Text = "Order Status Sub-Group Wise"
        TreeNode257.Name = "ndrptStorePOStatusProduct"
        TreeNode257.Text = "Order Status Product Wise"
        TreeNode258.Name = "ndrptStorePOStatusBrand"
        TreeNode258.Text = "Order Status Brand Wise"
        TreeNode259.Name = "ndrptStorePOTrans"
        TreeNode259.Text = "Transaction"
        TreeNode260.Name = "ndrptStorePOAnalysisCancel"
        TreeNode260.Text = "Cancelled Purchase Order"
        TreeNode261.Name = "ndrptStorePOAnalysisShortClose"
        TreeNode261.Text = "Short Close Register"
        TreeNode262.Name = "ndrptStorePOAnalysisAllInOne"
        TreeNode262.Text = "All In One Purchase Order"
        TreeNode263.Name = "ndrptStorePOAnalysis"
        TreeNode263.Text = "Analysis"
        TreeNode264.Name = "ndrptTrimsStoresPO"
        TreeNode264.Text = "Trims/Stores"
        TreeNode265.Name = "ndrptPurchaseOrder"
        TreeNode265.Text = "Purchase Order"
        TreeNode266.Name = "ndrptFabPurTransBill"
        TreeNode266.Text = "Bill Wise Register"
        TreeNode267.Name = "ndrptFabPurTransDate"
        TreeNode267.Text = "Date Wise Register"
        TreeNode268.Name = "ndrptFabPurTransLocation"
        TreeNode268.Text = "Location Wise Register"
        TreeNode269.Name = "ndrptFabPurTransSupplier"
        TreeNode269.Text = "Supplier Wise Register"
        TreeNode270.Name = "ndrptFabPurTransSubGrp"
        TreeNode270.Text = "Sub-Group Wise Register"
        TreeNode271.Name = "ndrptFabPurTransProduct"
        TreeNode271.Text = "Product Wise Register"
        TreeNode272.Name = "ndrptFabPurTransBrand"
        TreeNode272.Text = "Brand Wise Register"
        TreeNode273.Name = "ndrptFabPurTransPrdBarCd"
        TreeNode273.Text = "Product Wise Barcode Purchase"
        TreeNode274.Name = "ndrptFabPurTrans"
        TreeNode274.Text = "Transactions"
        TreeNode275.Name = "ndrptFabPurAnalysisDoc"
        TreeNode275.Text = "Purchase Doc Wise Stock"
        TreeNode276.Name = "ndrptFabPurAnalysisPeriodPur"
        TreeNode276.Text = "Periodical Purchase"
        TreeNode277.Name = "ndrptFabPurAnalysisExcessLessQtyRecd"
        TreeNode277.Text = "Excess/Less Qty Recd Against Order"
        TreeNode278.Name = "ndrptFabPurAnalysisMthly"
        TreeNode278.Text = "Monthly"
        TreeNode279.Name = "ndrptFabPurAnalysisMthlyDate"
        TreeNode279.Text = "Monthly - Date Wise"
        TreeNode280.Name = "ndrptFabPurAnalysisDateProduct"
        TreeNode280.Text = "Date Wise - Product Wise Consolidated"
        TreeNode281.Name = "ndrptFabPurAnalysisAllInOne"
        TreeNode281.Text = "All In One Purchase"
        TreeNode282.Name = "ndrptFabPurAnalysisMarginSumm"
        TreeNode282.Text = "Margin Summary On Purchase"
        TreeNode283.Name = "ndrptFabPurAnalysisTopNSupplier"
        TreeNode283.Text = "Top N Suppliers"
        TreeNode284.Name = "ndrptFabPurAnalysisTopNPur"
        TreeNode284.Text = "Top N Purchase"
        TreeNode285.Name = "ndrptFabPurAnalysis"
        TreeNode285.Text = "Analysis"
        TreeNode286.Name = "ndrptFabPurTaxDoc"
        TreeNode286.Text = "Doc Wise"
        TreeNode287.Name = "ndrptFabPurTaxDate"
        TreeNode287.Text = "Date Wise"
        TreeNode288.Name = "ndrptFabPurTaxSummary"
        TreeNode288.Text = "Tax Summary"
        TreeNode289.Name = "ndrptFabPurTaxProduct"
        TreeNode289.Text = "Product Wise"
        TreeNode290.Name = "ndrptFabPurTaxSupplier"
        TreeNode290.Text = "Supplier Wise"
        TreeNode291.Name = "ndrptFabPurTax"
        TreeNode291.Text = "Tax Register"
        TreeNode292.Name = "ndrptFabPur"
        TreeNode292.Text = "Fabric"
        TreeNode293.Name = "ndPurRegBill"
        TreeNode293.Text = "Bill Wise Register"
        TreeNode294.Name = "ndPurRegDate"
        TreeNode294.Text = "Date Wise Register"
        TreeNode295.Name = "ndPurRegLocation"
        TreeNode295.Text = "Location Wise Register"
        TreeNode296.Name = "ndPurRegSupplier"
        TreeNode296.Text = "Supplier Wise Register"
        TreeNode297.Name = "ndPurRegSubGroup"
        TreeNode297.Text = "Sub-Group Wise Register"
        TreeNode298.Name = "ndPurRegProduct"
        TreeNode298.Text = "Product Wise Register"
        TreeNode299.Name = "ndPurRegBrand"
        TreeNode299.Text = "Brand Wise Register"
        TreeNode300.Name = "ndProdWiseBarcdPurch"
        TreeNode300.Text = "Product Wise Barcode Purchase"
        TreeNode301.Name = "ndPurchaseTrans"
        TreeNode301.Text = "Transactions"
        TreeNode302.Name = "ndPurchaseDocWiseStock"
        TreeNode302.Text = "Purchase Doc Wise Stock"
        TreeNode303.Name = "ndPeriodicalPurchase"
        TreeNode303.Text = "Periodical Purchase"
        TreeNode304.Name = "ndExcessLessQtyRecdAgainstOrder"
        TreeNode304.Text = "Excess/Less Qty Recd Against Order"
        TreeNode305.Name = "ndMonthlyPur"
        TreeNode305.Text = "Monthly"
        TreeNode306.Name = "ndMonthlyPurDate"
        TreeNode306.Text = "Monthly - Date Wise"
        TreeNode307.Name = "ndConsoPurDateProd"
        TreeNode307.Text = "Date Wise - Product Wise Consolidated"
        TreeNode308.Name = "ndAllInOnePurchase"
        TreeNode308.Text = "All In One Purchase"
        TreeNode309.Name = "ndMarginSumOnPur"
        TreeNode309.Text = "Margin Summary On Purchase"
        TreeNode310.Name = "ndTopNSuppliers"
        TreeNode310.Text = "Top N Suppliers"
        TreeNode311.Name = "ndTopNPurchase"
        TreeNode311.Text = "Top N Purchase"
        TreeNode312.Name = "ndPurchaseAnalysis"
        TreeNode312.Text = "Analysis"
        TreeNode313.Name = "ndPurTaxRegDoc"
        TreeNode313.Text = "Doc Wise"
        TreeNode314.Name = "ndPurTaxRegDate"
        TreeNode314.Text = "Date Wise"
        TreeNode315.Name = "ndPurTaxRegSummary"
        TreeNode315.Text = "Tax Summary"
        TreeNode316.Name = "ndTaxRegProduct"
        TreeNode316.Text = "Product Wise"
        TreeNode317.Name = "ndTaxRegSupplier"
        TreeNode317.Text = "Supplier Wise"
        TreeNode318.Name = "ndPurchaseTax"
        TreeNode318.Text = "Tax Register"
        TreeNode319.Name = "ndrptFinPurchase"
        TreeNode319.Text = "Finished"
        TreeNode320.Name = "ndrptStoresPurTranBill"
        TreeNode320.Text = "Bill Wise Register"
        TreeNode321.Name = "ndrptStoresPurTranDate"
        TreeNode321.Text = "Date Wise Register"
        TreeNode322.Name = "ndrptStoresPurTranLocation"
        TreeNode322.Text = "Location Wise Register"
        TreeNode323.Name = "ndrptStoresPurTranSupplier"
        TreeNode323.Text = "Supplier Wise Register"
        TreeNode324.Name = "ndrptStoresPurTranSubGrp"
        TreeNode324.Text = "Sub-Group Wise Register"
        TreeNode325.Name = "ndrptStoresPurTranProduct"
        TreeNode325.Text = "Product Wise Register"
        TreeNode326.Name = "ndrptStoresPurTranBrand"
        TreeNode326.Text = "Brand Wise Register"
        TreeNode327.Name = "ndrptStoresPurTranPrdBarCd"
        TreeNode327.Text = "Product Wise Barcode Purchase"
        TreeNode328.Name = "ndrptStoresPurTran"
        TreeNode328.Text = "Transactions"
        TreeNode329.Name = "ndrptStoresPurAnalysisDoc"
        TreeNode329.Text = "Purchase Doc Wise Stock"
        TreeNode330.Name = "ndrptStoresPurAnalysisPeriod"
        TreeNode330.Text = "Periodical Purchase"
        TreeNode331.Name = "ndrptStoresPurAnalysisExcessLessQtyRecd"
        TreeNode331.Text = "Excess/Less Qty Recd Against Order"
        TreeNode332.Name = "ndrptStoresPurAnalysisMthly"
        TreeNode332.Text = "Monthly"
        TreeNode333.Name = "ndrptStoresPurAnalysisMthlyDate"
        TreeNode333.Text = "Monthly - Date Wise"
        TreeNode334.Name = "ndrptStoresPurAnalysisDateProduct"
        TreeNode334.Text = "Date Wise - Product Wise Consolidated"
        TreeNode335.Name = "ndrptStoresPurAnalysisAllInOne"
        TreeNode335.Text = "All In One Purchase"
        TreeNode336.Name = "ndrptStoresPurAnalysisMarginSumm"
        TreeNode336.Text = "Margin Summary On Purchase"
        TreeNode337.Name = "ndrptStoresPurAnalysisTopNSupplier"
        TreeNode337.Text = "Top N Suppliers"
        TreeNode338.Name = "ndrptStoresPurAnalysisTopNPur"
        TreeNode338.Text = "Top N Purchase"
        TreeNode339.Name = "ndrptStoresPurAnalysis"
        TreeNode339.Text = "Analysis"
        TreeNode340.Name = "ndrptStoresTaxDoc"
        TreeNode340.Text = "Doc Wise"
        TreeNode341.Name = "ndrptStoresTaxDate"
        TreeNode341.Text = "Date Wise"
        TreeNode342.Name = "ndrptStoresTaxSumm"
        TreeNode342.Text = "Tax Summary"
        TreeNode343.Name = "ndrptStoresTaxProduct"
        TreeNode343.Text = "Product Wise"
        TreeNode344.Name = "ndrptStoresTaxSupplier"
        TreeNode344.Text = "Supplier Wise"
        TreeNode345.Name = "ndrptStoresTax"
        TreeNode345.Text = "Tax Register"
        TreeNode346.Name = "ndrptStoresPur"
        TreeNode346.Text = "Trims/Stores"
        TreeNode347.Name = "ndPurRegDateWise"
        TreeNode347.Text = "Purchase Register (Date Wise)"
        TreeNode348.Name = "ndrptPurchase"
        TreeNode348.Text = "Purchase"
        TreeNode349.Name = "ndrptFabPurRtnTranBill"
        TreeNode349.Text = "Bill Wise Register"
        TreeNode350.Name = "ndrptFabPurRtnTranDate"
        TreeNode350.Text = "Date Wise Register"
        TreeNode351.Name = "ndrptFabPurRtnTranLoc"
        TreeNode351.Text = "Location Wise Register"
        TreeNode352.Name = "ndrptFabPurRtnTranSupplier"
        TreeNode352.Text = "Supplier Wise Register"
        TreeNode353.Name = "ndrptFabPurRtnTranSubGrp"
        TreeNode353.Text = "Sub-Group Wise Register"
        TreeNode354.Name = "ndrptFabPurRtnTranProduct"
        TreeNode354.Text = "Product Wise Register"
        TreeNode355.Name = "ndrptFabPurRtnTranBrand"
        TreeNode355.Text = "Brand Wise Register"
        TreeNode356.Name = "ndrptFabPurRtnTran"
        TreeNode356.Text = "Transaction"
        TreeNode357.Name = "ndrptFabPurRtnAnalysisMthly"
        TreeNode357.Text = "Monthly"
        TreeNode358.Name = "ndrptFabPurRtnAnalysisMthlyDate"
        TreeNode358.Text = "Monthly - Date Wise"
        TreeNode359.Name = "ndrptFabPurRtnAnalysisPeriod"
        TreeNode359.Text = "Periodical Purchase Rtn"
        TreeNode360.Name = "ndrptFabPurRtnAnalysisAllInOne"
        TreeNode360.Text = "All-In-One Purchase Rtn"
        TreeNode361.Name = "ndrptFabPurRtnAnalysis"
        TreeNode361.Text = "Analysis"
        TreeNode362.Name = "ndrptFabPurRtn"
        TreeNode362.Text = "Fabric"
        TreeNode363.Name = "ndPurRtnRegBill"
        TreeNode363.Text = "Bill Wise Register"
        TreeNode364.Name = "ndPurRtnRegDate"
        TreeNode364.Text = "Date Wise Register"
        TreeNode365.Name = "ndPurRtnRegLocation"
        TreeNode365.Text = "Location Wise Register"
        TreeNode366.Name = "ndPurRtnRegParty"
        TreeNode366.Text = "Supplier Wise Register"
        TreeNode367.Name = "ndPurRtnRegSubGroup"
        TreeNode367.Text = "Sub-Group Wise Register"
        TreeNode368.Name = "ndPurRtnRegProduct"
        TreeNode368.Text = "Product Wise Register"
        TreeNode369.Name = "ndPurRtnRegBrand"
        TreeNode369.Text = "Brand Wise Register"
        TreeNode370.Name = "ndPurchaseRtnTrans"
        TreeNode370.Text = "Transactions"
        TreeNode371.Name = "ndMonthlyPurRtn"
        TreeNode371.Text = "Monthly"
        TreeNode372.Name = "ndMonthlyPurRtnDate"
        TreeNode372.Text = "Monthly - Date Wise"
        TreeNode373.Name = "ndPeriodicalPurchaseRtn"
        TreeNode373.Text = "Periodical Purchase Rtn"
        TreeNode374.Name = "ndAllInOnePurchaseRtn"
        TreeNode374.Text = "All-In-One Purchase Rtn"
        TreeNode375.Name = "ndPurchaseRtnAnalysis"
        TreeNode375.Text = "Analysis"
        TreeNode376.Name = "ndrptFinPurRtn"
        TreeNode376.Text = "Finished"
        TreeNode377.Name = "ndrptStoresTranBill"
        TreeNode377.Text = "Bill Wise Register"
        TreeNode378.Name = "ndrptStoresTranDate"
        TreeNode378.Text = "Date Wise Register"
        TreeNode379.Name = "ndrptStoresTranLocation"
        TreeNode379.Text = "Location Wise Register"
        TreeNode380.Name = "ndrptStoresTranSuplier"
        TreeNode380.Text = "Supplier Wise Register"
        TreeNode381.Name = "ndrptStoresTranSubGrp"
        TreeNode381.Text = "Sub-Group Wise Register"
        TreeNode382.Name = "ndrptStoresTranProduct"
        TreeNode382.Text = "Product Wise Register"
        TreeNode383.Name = "ndrptStoresTranBrand"
        TreeNode383.Text = "Brand Wise Register"
        TreeNode384.Name = "ndrptStoresTran"
        TreeNode384.Text = "Transaction"
        TreeNode385.Name = "ndrptStoresPurRtnAnalysisMthly"
        TreeNode385.Text = "Monthly"
        TreeNode386.Name = "ndrptStoresPurRtnAnalysisMthlyDate"
        TreeNode386.Text = "Monthly - Date Wise"
        TreeNode387.Name = "ndrptStoresPurRtnAnalysisPeriod"
        TreeNode387.Text = "Periodical Purchase Rtn"
        TreeNode388.Name = "ndrptStoresPurRtnAnalysisAllInOne"
        TreeNode388.Text = "All-In-One Purchase Rtn"
        TreeNode389.Name = "ndrptStoresPurRtnAnalysis"
        TreeNode389.Text = "Analysis"
        TreeNode390.Name = "ndrptStores"
        TreeNode390.Text = "Trims/Stores"
        TreeNode391.Name = "ndrptPurchaseRtn"
        TreeNode391.Text = "Purchase Return"
        TreeNode392.Name = "ndrptFabIsuDate"
        TreeNode392.Text = "Date Wise"
        TreeNode393.Name = "ndrptFabIsuJobber"
        TreeNode393.Text = "Jobber Wise"
        TreeNode394.Name = "ndrptFabIsuSubGrp"
        TreeNode394.Text = "Sub-Group Wise"
        TreeNode395.Name = "ndrptFabIsuProduct"
        TreeNode395.Text = "Product Wise"
        TreeNode396.Name = "ndrptFabIsuBrand"
        TreeNode396.Text = "Brand Wise"
        TreeNode397.Name = "ndrptFabricIssue"
        TreeNode397.Text = "Fabric Issue"
        TreeNode398.Name = "ndrptFabIsuBkDate"
        TreeNode398.Text = "Date Wise"
        TreeNode399.Name = "ndrptFabIsuBkJobber"
        TreeNode399.Text = "Jobber Wise"
        TreeNode400.Name = "ndrptFabIsuBkSubGrp"
        TreeNode400.Text = "Sub-Group Wise"
        TreeNode401.Name = "ndrptFabIsuBkProduct"
        TreeNode401.Text = "Product Wise"
        TreeNode402.Name = "ndrptFabIsuBkBrand"
        TreeNode402.Text = "Brand Wise"
        TreeNode403.Name = "ndrptFabricIssueBack"
        TreeNode403.Text = "Fabric Issue Back"
        TreeNode404.Name = "ndrptFabricStkJobber"
        TreeNode404.Text = "Jobber Wise"
        TreeNode405.Name = "ndrptFabricStkProduct"
        TreeNode405.Text = "Product Wise"
        TreeNode406.Name = "ndrptStkLedgerAtJobber"
        TreeNode406.Text = "Stock Ledger"
        TreeNode407.Name = "ndrptFabricStkParty"
        TreeNode407.Text = "Fabric Stock With Party"
        TreeNode408.Name = "ndrptStoresIsuDate"
        TreeNode408.Text = "Date Wise"
        TreeNode409.Name = "ndrptStoresIsuJobber"
        TreeNode409.Text = "Jobber Wise"
        TreeNode410.Name = "ndrptStoresIsuSubGrp"
        TreeNode410.Text = "Sub-Group Wise"
        TreeNode411.Name = "ndrptStoresIsuProduct"
        TreeNode411.Text = "Product Wise"
        TreeNode412.Name = "ndrptStoresIssue"
        TreeNode412.Text = "Stores Issue"
        TreeNode413.Name = "ndrptStoresIsuBkDate"
        TreeNode413.Text = "Date Wise"
        TreeNode414.Name = "ndrptStoresIsuBkJobber"
        TreeNode414.Text = "Jobber Wise"
        TreeNode415.Name = "ndrptStoresIsuBkSubGrp"
        TreeNode415.Text = "Sub-Group Wise"
        TreeNode416.Name = "ndrptStoresIsuBkProduct"
        TreeNode416.Text = "Product Wise"
        TreeNode417.Name = "ndrptStoresIssueBack"
        TreeNode417.Text = "Stores Issue Back"
        TreeNode418.Name = "ndrptStoresStkJobber"
        TreeNode418.Text = "Jobber Wise"
        TreeNode419.Name = "ndrptStoresStkProduct"
        TreeNode419.Text = "Product Wise"
        TreeNode420.Name = "NDRPTACCSTKLEDGERATJOBBER"
        TreeNode420.Text = "Stock Ledger"
        TreeNode421.Name = "ndrptStoresStkParty"
        TreeNode421.Text = "Stores Stock With Party"
        TreeNode422.Name = "ndrptJobWorkPOStatusBillWise"
        TreeNode422.Text = "JobWork PO Status BillWise"
        TreeNode423.Name = "NDRPTGOODSRECVAGSTJOBWORKPO"
        TreeNode423.Text = "Goods Recv Agst JobWork PO"
        TreeNode424.Name = "NDJOBWORKPOSTATUS"
        TreeNode424.Text = "JobWork PO Status"
        TreeNode425.Name = "ndrptJobWorkPO"
        TreeNode425.Text = "JobWork PO Register"
        TreeNode426.Name = "ndrptJobWorkOrderStatusBillWise"
        TreeNode426.Text = "JobWork Order Status BillWise"
        TreeNode427.Name = "NDRPTGOODSRECVAGSTJOBWORKORDER"
        TreeNode427.Text = "Goods Recv Agst JobWork Order"
        TreeNode428.Name = "NDJOBWORKORDERSTATUS"
        TreeNode428.Text = "JobWork Order Status"
        TreeNode429.Name = "ndrptJobWorkOrder"
        TreeNode429.Text = "JobWork Order Register"
        TreeNode430.Name = "NDRPTJOBORDERDATE"
        TreeNode430.Text = "Date Wise"
        TreeNode431.Name = "NDRPTJOBORDERSTATUS"
        TreeNode431.Text = "Job Order Status"
        TreeNode432.Name = "NDRPTJOBORDER"
        TreeNode432.Text = "Job Order Register"
        TreeNode433.Name = "ndrptJobCardDate"
        TreeNode433.Text = "Date Wise"
        TreeNode434.Name = "ndrptJobCardJobber"
        TreeNode434.Text = "Jobber Wise"
        TreeNode435.Name = "ndrptJobCardProcess"
        TreeNode435.Text = "Process Wise"
        TreeNode436.Name = "ndrptJobCardSubGrp"
        TreeNode436.Text = "Sub-Group Wise"
        TreeNode437.Name = "ndrptJobCardProduct"
        TreeNode437.Text = "Product Wise"
        TreeNode438.Name = "ndrptJobCardBrand"
        TreeNode438.Text = "Brand Wise"
        TreeNode439.Name = "NDJOBCARDSTATUSDATEWISE"
        TreeNode439.Text = "Job Card Status (Datewise)"
        TreeNode440.Name = "ndrptJobCard"
        TreeNode440.Text = "Job Card Register"
        TreeNode441.Name = "ndrptProcIsuDate"
        TreeNode441.Text = "Date Wise"
        TreeNode442.Name = "ndrptProcIsuJobber"
        TreeNode442.Text = "Jobber Wise"
        TreeNode443.Name = "ndrptProcIsuProcess"
        TreeNode443.Text = "Process Wise"
        TreeNode444.Name = "ndrptProcIsuSubGrp"
        TreeNode444.Text = "Sub-Group Wise"
        TreeNode445.Name = "ndrptProcIsuProduct"
        TreeNode445.Text = "Product Wise"
        TreeNode446.Name = "ndrptProcIsuBrand"
        TreeNode446.Text = "Brand Wise"
        TreeNode447.Name = "ndrptProcessIsu"
        TreeNode447.Text = "Process Issue Register"
        TreeNode448.Name = "ndrptProcRcptDate"
        TreeNode448.Text = "Date Wise"
        TreeNode449.Name = "ndrptProcRcptJobber"
        TreeNode449.Text = "Jobber Wise"
        TreeNode450.Name = "ndrptProcRcptProcess"
        TreeNode450.Text = "Process Wise"
        TreeNode451.Name = "ndrptProcRcptSubGrp"
        TreeNode451.Text = "Sub-Group Wise"
        TreeNode452.Name = "ndrptProcRcptProduct"
        TreeNode452.Text = "Product Wise"
        TreeNode453.Name = "ndrptProcRcptBrand"
        TreeNode453.Text = "Brand Wise"
        TreeNode454.Name = "ndrptProcessRcpt"
        TreeNode454.Text = "Process Receipt Register"
        TreeNode455.Name = "ndrptProcDelayDate"
        TreeNode455.Text = "Date Wise"
        TreeNode456.Name = "ndrptProcDelayJobber"
        TreeNode456.Text = "Jobber Wise"
        TreeNode457.Name = "ndrptProcDelayProcess"
        TreeNode457.Text = "Process Wise"
        TreeNode458.Name = "ndrptProcDelaySubGrp"
        TreeNode458.Text = "Sub-Group Wise"
        TreeNode459.Name = "ndrptProcDelayProduct"
        TreeNode459.Text = "Product Wise"
        TreeNode460.Name = "ndrptProcDelayBrand"
        TreeNode460.Text = "Brand Wise"
        TreeNode461.Name = "ndrptProcDelay"
        TreeNode461.Text = "Process/Production Delay"
        TreeNode462.Name = "ndrptProcStkPartyDate"
        TreeNode462.Text = "Date Wise"
        TreeNode463.Name = "ndrptProcStkPartyJobber"
        TreeNode463.Text = "Jobber Wise"
        TreeNode464.Name = "ndrptProcStkPartyProcess"
        TreeNode464.Text = "Process Wise"
        TreeNode465.Name = "ndrptProcStkPartySubGrp"
        TreeNode465.Text = "Sub-Group Wise"
        TreeNode466.Name = "ndrptProcStkPartyProduct"
        TreeNode466.Text = "Product Wise"
        TreeNode467.Name = "ndrptProcStkPartyBrand"
        TreeNode467.Text = "Brand Wise"
        TreeNode468.Name = "ndrptProcStkParty"
        TreeNode468.Text = "Process Stock With Party"
        TreeNode469.Name = "ndrptSemiProcStkWHDate"
        TreeNode469.Text = "Date Wise"
        TreeNode470.Name = "ndrptSemiProcStkWHJobber"
        TreeNode470.Text = "Jobber Wise"
        TreeNode471.Name = "ndrptSemiProcStkWHProcess"
        TreeNode471.Text = "Process Wise"
        TreeNode472.Name = "ndrptSemiProcStkWHSubGrp"
        TreeNode472.Text = "Sub-Group Wise"
        TreeNode473.Name = "ndrptSemiProcStkWHProduct"
        TreeNode473.Text = "Product Wise"
        TreeNode474.Name = "ndrptSemiProcStkWHBrand"
        TreeNode474.Text = "Brand Wise"
        TreeNode475.Name = "ndrptSemiProcStkWH"
        TreeNode475.Text = "Semi Process Stock At WH"
        TreeNode476.Name = "ndrptProcLedDate"
        TreeNode476.Text = "Date Wise"
        TreeNode477.Name = "ndrptProcLedJobber"
        TreeNode477.Text = "Jobber Wise"
        TreeNode478.Name = "ndrptProcLedProcess"
        TreeNode478.Text = "Process Wise"
        TreeNode479.Name = "ndrptProcLedSubGrp"
        TreeNode479.Text = "Sub-Group Wise"
        TreeNode480.Name = "ndrptProcLedProduct"
        TreeNode480.Text = "Product Wise"
        TreeNode481.Name = "ndrptProcLedBrand"
        TreeNode481.Text = "Brand Wise"
        TreeNode482.Name = "ndrptProcessLedger"
        TreeNode482.Text = "Process Ledger"
        TreeNode483.Name = "ndrptProcShtgDate"
        TreeNode483.Text = "Date Wise"
        TreeNode484.Name = "ndrptProcShtgJobber"
        TreeNode484.Text = "Jobber Wise"
        TreeNode485.Name = "ndrptProcShtgProcess"
        TreeNode485.Text = "Process Wise"
        TreeNode486.Name = "ndrptProcShtgSubGrp"
        TreeNode486.Text = "Sub-Group Wise"
        TreeNode487.Name = "ndrptProcShtgProduct"
        TreeNode487.Text = "Product Wise"
        TreeNode488.Name = "ndrptProcShtgBrand"
        TreeNode488.Text = "Brand Wise"
        TreeNode489.Name = "ndrptProcShtg"
        TreeNode489.Text = "Process Shortage"
        TreeNode490.Name = "ndKarigarSalary"
        TreeNode490.Text = "Karigar Salary"
        TreeNode491.Name = "ndProcessReportsDate"
        TreeNode491.Text = "Date Wise"
        TreeNode492.Name = "ndProcessReportsDoc"
        TreeNode492.Text = "Doc Wise"
        TreeNode493.Name = "ndProcessReportsSum"
        TreeNode493.Text = "Summery"
        TreeNode494.Name = "ndProcessReports"
        TreeNode494.Text = "Process Reports"
        TreeNode495.Name = "ndStyleCol"
        TreeNode495.Text = "Style Shade Wise"
        TreeNode496.Name = "ndStyleColSum"
        TreeNode496.Text = "Style Shade Wise Summery"
        TreeNode497.Name = "ndStyleReports"
        TreeNode497.Text = "Style Reports"
        TreeNode498.Name = "ndFabricLedgerReports"
        TreeNode498.Text = "Fabric Ledger at Jobber"
        TreeNode499.Name = "ndrptProcProdn"
        TreeNode499.Text = "Process/Production Reports"
        TreeNode500.Name = "ndSalesOrderRegBill"
        TreeNode500.Text = "Bill Wise Register"
        TreeNode501.Name = "ndSalesOrderRegDate"
        TreeNode501.Text = "Date Wise Register"
        TreeNode502.Name = "ndSalesOrderRegParty"
        TreeNode502.Text = "Party Wise Register"
        TreeNode503.Name = "ndSalesOrderRegPartyProd"
        TreeNode503.Text = "Party-Product Wise Register"
        TreeNode504.Name = "ndSalesOrderRegConsignee"
        TreeNode504.Text = "Consignee Wise Register"
        TreeNode505.Name = "ndSalesOrderRegConsigneeProd"
        TreeNode505.Text = "Consignee-Product Wise Register"
        TreeNode506.Name = "ndSalesOrderRegProduct"
        TreeNode506.Text = "Product Wise Register"
        TreeNode507.Name = "ndSalesOrderRegBrand"
        TreeNode507.Text = "Brand Wise Register"
        TreeNode508.Name = "ndSalesOrderRegBroker"
        TreeNode508.Text = "Broker Wise Register"
        TreeNode509.Name = "ndPendSalesOrderRegBill"
        TreeNode509.Text = "Order Status Bill Wise"
        TreeNode510.Name = "ndPendSalesOrderRegDate"
        TreeNode510.Text = "Order Status Date Wise"
        TreeNode511.Name = "ndPendSalesOrderRegParty"
        TreeNode511.Text = "Order Status Party Wise"
        TreeNode512.Name = "ndPendSalesOrderRegPartyProd"
        TreeNode512.Text = "Order Status Party-Product"
        TreeNode513.Name = "ndPendSalesOrderRegConsignee"
        TreeNode513.Text = "Order Status Consignee Wise"
        TreeNode514.Name = "ndPendSalesOrderRegConsigneeProd"
        TreeNode514.Text = "Order Status Consignee-Product Wise"
        TreeNode515.Name = "ndPendSalesOrderRegProduct"
        TreeNode515.Text = "Order Status Product Wise"
        TreeNode516.Name = "ndPendSalesOrderRegBrand"
        TreeNode516.Text = "Order Status Brand Wise"
        TreeNode517.Name = "ndPendSalesOrderRegBroker"
        TreeNode517.Text = "Order Status Broker Wise"
        TreeNode518.Name = "NDSOSTATUS"
        TreeNode518.Text = "Sales Order Status"
        TreeNode519.Name = "NDSTOCKREADYTODISP"
        TreeNode519.Text = "Stock Ready To Dispatch"
        TreeNode520.Name = "ndSalesOrderRegAllinOne"
        TreeNode520.Text = "Buyer Wise Grid"
        TreeNode521.Name = "ndSalesOrderTrans"
        TreeNode521.Text = "Transactions"
        TreeNode522.Name = "ndSOCrossTabStyle"
        TreeNode522.Text = "O/S Sales Order (Style Wise)"
        TreeNode523.Name = "ndSOCrossTabStock"
        TreeNode523.Text = "OS Sales Order (Style Wise)- Stock"
        TreeNode524.Name = "ndSOCrossTabStyleParty"
        TreeNode524.Text = "O/S Sales Order (Style/Party)"
        TreeNode525.Name = "ndSOCrossTabPartyStyle"
        TreeNode525.Text = "O/S Sales Order (Party/Style)"
        TreeNode526.Name = "ndSOCrossTabPartySize"
        TreeNode526.Text = "O/S Sales Order (Party/Size)"
        TreeNode527.Name = "ndSOCrossTabPartyConsg"
        TreeNode527.Text = "O/S Sales Order (Party/Consignee)"
        TreeNode528.Name = "ndSOCrossTabStylePartyConsg"
        TreeNode528.Text = "O/S Sales Order (Style/Party/Consignee)"
        TreeNode529.Name = "NDSOCROSSTABPARTYCONSGSTYLE"
        TreeNode529.Text = "O/S Sales Order (Party/Consignee/Style)"
        TreeNode530.Name = "ndSOSumStyle"
        TreeNode530.Text = "Sales Order Summary (Style Wise)"
        TreeNode531.Name = "ndSOSumStyleParty"
        TreeNode531.Text = "Sales Order Summary (Style/Party)"
        TreeNode532.Name = "ndSOSumPartyStyle"
        TreeNode532.Text = "Sales Order Summary (Party/Style)"
        TreeNode533.Name = "ndSOSumPartySize"
        TreeNode533.Text = "Sales Order Summary (Party/Size)"
        TreeNode534.Name = "ndSOSumStylePartyConsg"
        TreeNode534.Text = "Sales Order Summary (Style/Party/Consignee)"
        TreeNode535.Name = "NDSOSUMPARTYCONSGSTYLE"
        TreeNode535.Text = "Sales Order Summary (Party/Consignee/Style)"
        TreeNode536.Name = "ndSOpackSumStylePartyConsg"
        TreeNode536.Text = "Sales Order/ Desp Detail"
        TreeNode537.Name = "ndRetailerWiseSaleOrder"
        TreeNode537.Text = "RetailerWise SaleOrder"
        TreeNode538.Name = "ndRetailerWiseSaleOrderDesign"
        TreeNode538.Text = "DesignWise Retailer"
        TreeNode539.Name = "ndSalesOrderCrossTab"
        TreeNode539.Text = "CrossTab Format"
        TreeNode540.Name = "ndrptSalesOrder"
        TreeNode540.Text = "Sales Order"
        TreeNode541.Name = "ndPackingRegBill"
        TreeNode541.Text = "Bill Wise Register"
        TreeNode542.Name = "ndPackingRegDate"
        TreeNode542.Text = "Date Wise Register"
        TreeNode543.Name = "ndPackingRegParty"
        TreeNode543.Text = "Party Wise Register"
        TreeNode544.Name = "ndPackingRegPartyProd"
        TreeNode544.Text = "Party-Product Wise Register"
        TreeNode545.Name = "ndPackingRegConsignee"
        TreeNode545.Text = "Consignee Wise Register"
        TreeNode546.Name = "ndPackingRegConsigneeProd"
        TreeNode546.Text = "Consignee-Product Wise Register"
        TreeNode547.Name = "ndPackingRegProduct"
        TreeNode547.Text = "Product Wise Register"
        TreeNode548.Name = "ndPackingRegBrand"
        TreeNode548.Text = "Brand Wise Register"
        TreeNode549.Name = "ndPackingRegBroker"
        TreeNode549.Text = "Broker Wise Register"
        TreeNode550.Name = "ndPackingTrans"
        TreeNode550.Text = "Transactions"
        TreeNode551.Name = "ndPackingSumStyle"
        TreeNode551.Text = "Packing Summary (Style Wise)"
        TreeNode552.Name = "ndPackingSumStyleParty"
        TreeNode552.Text = "Packing Summary (Style/Party)"
        TreeNode553.Name = "ndPackingSumPartyStyle"
        TreeNode553.Text = "Packing Summary (Party/Style)"
        TreeNode554.Name = "ndPackingSumPartySize"
        TreeNode554.Text = "Packing Summary (Party/Size)"
        TreeNode555.Name = "ndPackingSumStylePartyConsg"
        TreeNode555.Text = "Packing Summary (Style/Party/Consignee)"
        TreeNode556.Name = "ndPackingCrossTab"
        TreeNode556.Text = "Cross Tab Format"
        TreeNode557.Name = "ndrptPacking"
        TreeNode557.Text = "Despatch Reports"
        TreeNode558.Name = "ndSalesBillRegBill"
        TreeNode558.Text = "Bill Wise Register"
        TreeNode559.Name = "ndSalesBillRegDate"
        TreeNode559.Text = "Date Wise Register"
        TreeNode560.Name = "ndSalesBillRegParty"
        TreeNode560.Text = "Party Wise Register"
        TreeNode561.Name = "ndSalesBillRegPartyProd"
        TreeNode561.Text = "Party-Product Wise Register"
        TreeNode562.Name = "ndSalesBillRegConsignee"
        TreeNode562.Text = "Consignee Wise Register"
        TreeNode563.Name = "ndSalesBillRegConsigneeProd"
        TreeNode563.Text = "Consignee-Product Wise Register"
        TreeNode564.Name = "ndSalesBillRegProduct"
        TreeNode564.Text = "Product Wise Register"
        TreeNode565.Name = "ndSalesBillRegBrand"
        TreeNode565.Text = "Brand Wise Register"
        TreeNode566.Name = "ndSalesBillRegBroker"
        TreeNode566.Text = "Broker Wise Register"
        TreeNode567.Name = "ndSalesBillRegSalesPerson"
        TreeNode567.Text = "Sales Person Wise Register"
        TreeNode568.Name = "ndSalesPersonPartyWise"
        TreeNode568.Text = "Sales Person Party Wise Register"
        TreeNode569.Name = "ndBrokerBrandWise"
        TreeNode569.Text = "Broker Brand Wise Register"
        TreeNode570.Name = "NDDegnWiseNetSalesReg"
        TreeNode570.Text = "Design Wise Net Sales Register"
        TreeNode571.Name = "ndSalesBillTrans"
        TreeNode571.Text = "Transactions"
        TreeNode572.Name = "ndSalesTaxRegister"
        TreeNode572.Text = "Tax Register"
        TreeNode573.Name = "ndSalesTaxRegister1"
        TreeNode573.Text = "Tax Register"
        TreeNode574.Name = "ndrptSalesBill"
        TreeNode574.Text = "Sales Reports"
        TreeNode575.Name = "ndSalesRtnRegBill"
        TreeNode575.Text = "Bill Wise Register"
        TreeNode576.Name = "ndSalesRtnRegDate"
        TreeNode576.Text = "Date Wise Register"
        TreeNode577.Name = "ndSalesRtnRegLocation"
        TreeNode577.Text = "Location Wise Register"
        TreeNode578.Name = "ndSalesRtnRegCustomer"
        TreeNode578.Text = "Customer Wise Register"
        TreeNode579.Name = "ndSalesRtnRegSubGroup"
        TreeNode579.Text = "Sub-Group Wise Register"
        TreeNode580.Name = "ndSalesRtnRegProduct"
        TreeNode580.Text = "Product Wise Register"
        TreeNode581.Name = "ndSalesRtnRegBrand"
        TreeNode581.Text = "Brand Wise Register"
        TreeNode582.Name = "ndrptSalesRtnRegBrokerParty"
        TreeNode582.Text = "Broker Party Wise Register"
        TreeNode583.Name = "ndrptSalesRtnTrans"
        TreeNode583.Text = "Transactions"
        TreeNode584.Name = "ndrptSalesRtn"
        TreeNode584.Text = "Sales Return"
        TreeNode585.Name = "ndrptFabOpStkSubGrp"
        TreeNode585.Text = "Opening Stock - Sub-Group Wise"
        TreeNode586.Name = "ndrptFabOpStkProduct"
        TreeNode586.Text = "Opening Stock - Product Wise"
        TreeNode587.Name = "ndrptFabOpStkBrand"
        TreeNode587.Text = "Opening Stock - Brand Wise"
        TreeNode588.Name = "ndrptFabOpStkLocation"
        TreeNode588.Text = "Opening Stock - Location Wise"
        TreeNode589.Name = "ndrptClStkFabSubGrp"
        TreeNode589.Text = "Stock Ledger Fabric"
        TreeNode590.Name = "ndrptClStkFabProduct"
        TreeNode590.Text = "Closing Stock - Product Wise"
        TreeNode591.Name = "ndrptClStkFabBrand"
        TreeNode591.Text = "Closing Stock - Brand Wise"
        TreeNode592.Name = "ndrptClStkFabLocation"
        TreeNode592.Text = "Closing Stock - Location Wise"
        TreeNode593.Name = "ndrptClStkFabSupplier"
        TreeNode593.Text = "Closing Stock - Supplier Wise"
        TreeNode594.Name = "ndrptStockLedgerFab"
        TreeNode594.Text = "Stock Ledger(All)"
        TreeNode595.Name = "NDDRILLDOWNFABRICRPT"
        TreeNode595.Text = "Drill Down Fabric Report"
        TreeNode596.Name = "ndRegular"
        TreeNode596.Text = "Regular"
        TreeNode597.Name = "ndrptFabricStock"
        TreeNode597.Text = "Fabric"
        TreeNode598.Name = "ndOpeningStkSubGroup"
        TreeNode598.Text = "Opening Stock - Sub-Group Wise"
        TreeNode599.Name = "ndOpeningStkProduct"
        TreeNode599.Text = "Opening Stock - Product Wise"
        TreeNode600.Name = "ndOpeningStkBrand"
        TreeNode600.Text = "Opening Stock - Brand Wise"
        TreeNode601.Name = "ndOpeningStkLocation"
        TreeNode601.Text = "Opening Stock - Location Wise"
        TreeNode602.Name = "ndClosingStkSubGroup"
        TreeNode602.Text = "Stock Ledger Finish"
        TreeNode603.Name = "ndClosingStkProduct"
        TreeNode603.Text = "Closing Stock - Product Wise"
        TreeNode604.Name = "ndClosingStkSubBrand"
        TreeNode604.Text = "Closing Stock - Brand Wise"
        TreeNode605.Name = "ndClosingStkLocation"
        TreeNode605.Text = "Closing Stock - Location Wise"
        TreeNode606.Name = "ndClosingStkSupplier"
        TreeNode606.Text = "Closing Stock - Supplier Wise"
        TreeNode607.Name = "ndBarcodeStkSubGroup"
        TreeNode607.Text = "Barcode Stock - Sub-Group Wise"
        TreeNode608.Name = "ndBarcodeStkProduct"
        TreeNode608.Text = "Barcode Stock - Product Wise"
        TreeNode609.Name = "ndBarcodeStkBrand"
        TreeNode609.Text = "Barcode Stock - Brand Wise"
        TreeNode610.Name = "ndBarcodeStkSupplier"
        TreeNode610.Text = "Barcode Stock - Supplier Wise"
        TreeNode611.Name = "ndBarcodeStkLocation"
        TreeNode611.Text = "Barcode Stock - Location Wise"
        TreeNode612.Name = "ndStockAtGlanceSubGroup"
        TreeNode612.Text = "Stock At A Glance - Sub-Group Wise"
        TreeNode613.Name = "ndStockAtGlanceProduct"
        TreeNode613.Text = "Stock At A Glance - Product Wise"
        TreeNode614.Name = "ndStockAtGlanceBrand"
        TreeNode614.Text = "Stock At A Glance - Brand Wise"
        TreeNode615.Name = "ndStockAtGlanceSupplier"
        TreeNode615.Text = "Stock At A Glance - Supplier Wise"
        TreeNode616.Name = "ndStockAtGlanceLocation"
        TreeNode616.Text = "Stock At A Glance - Location Wise"
        TreeNode617.Name = "ndStockAtGlanceCust"
        TreeNode617.Text = "Stock At A Glance - Customer Wise"
        TreeNode618.Name = "ndrptStockLedger"
        TreeNode618.Text = "Stock Ledger"
        TreeNode619.Name = "ndStockAsOnPrevDate"
        TreeNode619.Text = "Stock As On (Previous Date)"
        TreeNode620.Name = "NDSTOCKLEDGERLOC"
        TreeNode620.Text = "Stock  Ledger Location"
        TreeNode621.Name = "NDDRILLDOWNFINISHRPT"
        TreeNode621.Text = "Drill Down Finish Report"
        TreeNode622.Name = "ndStockRegular"
        TreeNode622.Text = "Regular"
        TreeNode623.Name = "ndFastMovingSupplier"
        TreeNode623.Text = "Fast Moving - Supplier Wise"
        TreeNode624.Name = "ndFastMovingSubGroup"
        TreeNode624.Text = "Fast Moving - Sub-Group Wise"
        TreeNode625.Name = "ndFastMovingProduct"
        TreeNode625.Text = "Fast Moving - Product Wise"
        TreeNode626.Name = "ndSlowMovingSupplier"
        TreeNode626.Text = "Slow Moving - Supplier Wise"
        TreeNode627.Name = "ndSlowMovingSubGroup"
        TreeNode627.Text = "Slow Moving - Sub-Group Wise"
        TreeNode628.Name = "ndSlowMovingProduct"
        TreeNode628.Text = "Slow Moving - Product Wise"
        TreeNode629.Name = "ndDeadStock"
        TreeNode629.Text = "Dead Stock - Product Wise"
        TreeNode630.Name = "ndStockMovement"
        TreeNode630.Text = "Stock Movement"
        TreeNode631.Name = "ndStkAgingSubGroup"
        TreeNode631.Text = "Sub-Group Wise"
        TreeNode632.Name = "ndStkAgingProduct"
        TreeNode632.Text = "Product Wise"
        TreeNode633.Name = "ndStkAgingBrand"
        TreeNode633.Text = "Brand Wise"
        TreeNode634.Name = "ndStkAgingSupplier"
        TreeNode634.Text = "Supplier Wise"
        TreeNode635.Name = "ndStkAgingProductBarcode"
        TreeNode635.Text = "Product - Barcode Wise"
        TreeNode636.Name = "ndStockAging"
        TreeNode636.Text = "Stock Aging"
        TreeNode637.Name = "ndNoStockReport"
        TreeNode637.Text = "No Stock Report"
        TreeNode638.Name = "ndStockUnsold"
        TreeNode638.Text = "No Sale Report"
        TreeNode639.Name = "ndNotYetSold"
        TreeNode639.Text = "Not Yet Sold"
        TreeNode640.Name = "ndStockStmt"
        TreeNode640.Text = "Stock Statement"
        TreeNode641.Name = "ndStockDoc"
        TreeNode641.Text = "Doc Wise Stock"
        TreeNode642.Name = "ndStyleCosting"
        TreeNode642.Text = "Style Costing"
        TreeNode643.Name = "ndrptStkAnalysis"
        TreeNode643.Text = "Analysis"
        TreeNode644.Name = "ndrptFinishStock"
        TreeNode644.Text = "Finished"
        TreeNode645.Name = "ndrptStoresOpStkSubGrp"
        TreeNode645.Text = "Opening Stock - Sub-Group Wise"
        TreeNode646.Name = "ndrptStoresOpStkProduct"
        TreeNode646.Text = "Opening Stock - Product Wise"
        TreeNode647.Name = "ndrptStoresOpStkBrand"
        TreeNode647.Text = "Opening Stock - Brand Wise"
        TreeNode648.Name = "ndrptStoresOpStkLocation"
        TreeNode648.Text = "Opening Stock - Location Wise"
        TreeNode649.Name = "ndrptClStkAccSubGrp"
        TreeNode649.Text = "Stock Ledger Accessories"
        TreeNode650.Name = "ndrptClStkAccProduct"
        TreeNode650.Text = "Closing Stock - Product Wise"
        TreeNode651.Name = "ndrptClStkAccBrand"
        TreeNode651.Text = "Closing Stock - Brand Wise"
        TreeNode652.Name = "ndrptClStkAccLocation"
        TreeNode652.Text = "Closing Stock - Location Wise"
        TreeNode653.Name = "ndrptClStkAccSupplier"
        TreeNode653.Text = "Closing Stock - Supplier Wise"
        TreeNode654.Name = "NDRPTSTOCKLEDGERACC"
        TreeNode654.Text = "Stock Ledger"
        TreeNode655.Name = "NDDRILLDOWNACCRPT"
        TreeNode655.Text = "Drill Down Accessories Report"
        TreeNode656.Name = "ndAccRegular"
        TreeNode656.Text = "Regular"
        TreeNode657.Name = "ndrptAccStock"
        TreeNode657.Text = "Accessories"
        TreeNode658.Name = "ndrptPackOpStkSubGrp"
        TreeNode658.Text = "Opening Stock - Sub-Group Wise"
        TreeNode659.Name = "ndrptPackOpStkProduct"
        TreeNode659.Text = "Opening Stock - Product Wise"
        TreeNode660.Name = "ndrptPackOpStkBrand"
        TreeNode660.Text = "Opening Stock - Brand Wise"
        TreeNode661.Name = "ndrptPackOpStkLocation"
        TreeNode661.Text = "Opening Stock - Location Wise"
        TreeNode662.Name = "ndrptClStkPackSubGrp"
        TreeNode662.Text = "Closing Stock - Sub-Group Wise"
        TreeNode663.Name = "ndrptClStkPackProduct"
        TreeNode663.Text = "Closing Stock - Product Wise"
        TreeNode664.Name = "ndrptClStkPackBrand"
        TreeNode664.Text = "Closing Stock - Brand Wise"
        TreeNode665.Name = "ndrptClStkPackLocation"
        TreeNode665.Text = "Closing Stock - Location Wise"
        TreeNode666.Name = "ndrptClStkPackSupplier"
        TreeNode666.Text = "Closing Stock - Supplier Wise"
        TreeNode667.Name = "ndPackRegular"
        TreeNode667.Text = "Regular"
        TreeNode668.Name = "ndrptPackStock"
        TreeNode668.Text = "Packing"
        TreeNode669.Name = "ndrptStockType"
        TreeNode669.Text = "Stock"
        TreeNode670.Name = "ndPhysicalStk"
        TreeNode670.Text = "Physical Stock"
        TreeNode671.Name = "ndPhysicalStkShort"
        TreeNode671.Text = "Physical Stock Shortage"
        TreeNode672.Name = "ndPhysicalStkExcess"
        TreeNode672.Text = "Physical Stock not in Books(Excess)"
        TreeNode673.Name = "ndBarcodeNotInBook"
        TreeNode673.Text = "Barcode not in Books"
        TreeNode674.Name = "ndStockTrack"
        TreeNode674.Text = "Stock Tracking"
        TreeNode675.Name = "ndTaxComputation"
        TreeNode675.Text = "VAT Computation"
        TreeNode676.Name = "ndPendBillsPackBill"
        TreeNode676.Text = "Bill Wise Register"
        TreeNode677.Name = "ndPendBillsPackParty"
        TreeNode677.Text = "Party Wise Register"
        TreeNode678.Name = "ndPendBillsPack"
        TreeNode678.Text = "Pending Bills Against Packing"
        TreeNode679.Name = "ndPendDrNtAgstPurchRtdBill"
        TreeNode679.Text = "Bill Wise Register"
        TreeNode680.Name = "ndPendDrNtAgstPurchRtdParty"
        TreeNode680.Text = "Party Wise Register"
        TreeNode681.Name = "ndPendDrNtAgstPurchRtd"
        TreeNode681.Text = "Pending DebitNote Against Purchase Rtd"
        TreeNode682.Name = "ndPendCrNtAgstSalesRtdBill"
        TreeNode682.Text = "Bill Wise Register"
        TreeNode683.Name = "ndPendCrNtAgstSalesRtdParty"
        TreeNode683.Text = "Party Wise Register"
        TreeNode684.Name = "ndPendCrNtAgstSalesRtd"
        TreeNode684.Text = "Pending CreditNote Against Sales Rtd"
        TreeNode685.Name = "ndrptDailyReports"
        TreeNode685.Text = "Daily Reports"
        TreeNode686.Name = "ndServiceJobOrderRegBill"
        TreeNode686.Text = "Bill Wise Register"
        TreeNode687.Name = "ndServiceJobOrderRegDate"
        TreeNode687.Text = "Date Wise Register"
        TreeNode688.Name = "ndServiceJobOrderRegParty"
        TreeNode688.Text = "Party Wise Register"
        TreeNode689.Name = "ndServiceJobOrderRegPartyProd"
        TreeNode689.Text = "Party-Product Wise Register"
        TreeNode690.Name = "ndServiceJobOrderRegProduct"
        TreeNode690.Text = "Product Wise Register"
        TreeNode691.Name = "ndPendServiceJobOrderRegBill"
        TreeNode691.Text = "Order Status Bill Wise"
        TreeNode692.Name = "ndPendServiceJobOrderRegDate"
        TreeNode692.Text = "Order Status Date Wise"
        TreeNode693.Name = "ndPendServiceJobOrderRegParty"
        TreeNode693.Text = "Order Status Party Wise"
        TreeNode694.Name = "ndPendServiceJobOrderRegPartyProd"
        TreeNode694.Text = "Order Status Party-Product"
        TreeNode695.Name = "ndPendServiceJobOrderRegProduct"
        TreeNode695.Text = "Order Status Product Wise"
        TreeNode696.Name = "ndServiceJobOrderTrans"
        TreeNode696.Text = "Transactions"
        TreeNode697.Name = "ndServiceJobOrder"
        TreeNode697.Text = "Service Job Order"
        TreeNode698.Name = "ndServiceChallanRegBill"
        TreeNode698.Text = "Bill Wise Register"
        TreeNode699.Name = "ndServiceChallanRegDate"
        TreeNode699.Text = "Date Wise Register"
        TreeNode700.Name = "ndServiceChallanRegParty"
        TreeNode700.Text = "Party Wise Register"
        TreeNode701.Name = "ndServiceChallanRegPartyProd"
        TreeNode701.Text = "Party-Product Wise Register"
        TreeNode702.Name = "ndServiceChallanRegProduct"
        TreeNode702.Text = "Product Wise Register"
        TreeNode703.Name = "ndServiceChallanTrans"
        TreeNode703.Text = "Transactions"
        TreeNode704.Name = "ndServiceChallan"
        TreeNode704.Text = "Service Challan"
        TreeNode705.Name = "ndServiceInvoiceRegBill"
        TreeNode705.Text = "Bill Wise Register"
        TreeNode706.Name = "ndServiceInvoiceRegDate"
        TreeNode706.Text = "Date Wise Register"
        TreeNode707.Name = "ndServiceInvoiceRegParty"
        TreeNode707.Text = "Party Wise Register"
        TreeNode708.Name = "ndServiceInvoiceRegPartyProd"
        TreeNode708.Text = "Party-Product Wise Register"
        TreeNode709.Name = "ndServiceInvoiceRegProduct"
        TreeNode709.Text = "Product Wise Register"
        TreeNode710.Name = "ndServiceInvoiceTrans"
        TreeNode710.Text = "Transactions"
        TreeNode711.Name = "ndServiceInvoice"
        TreeNode711.Text = "Service Invoice"
        TreeNode712.Name = "ndGSTR1"
        TreeNode712.Text = "GSTR-1"
        TreeNode713.Name = "ndGSTR2"
        TreeNode713.Text = "GSTR-2"
        TreeNode714.Name = "ndGSTR3B"
        TreeNode714.Text = "GSTR-3B"
        TreeNode715.Name = "ndGSTReturns"
        TreeNode715.Text = "GST Returns"
        TreeNode716.Name = "NDREVERSE"
        TreeNode716.Text = "RCM"
        TreeNode717.Name = "ndGSTReport"
        TreeNode717.Text = "GST Report"
        TreeNode718.Name = "ndPTR"
        TreeNode718.Text = "Pending Task Report"
        TreeNode719.Name = "NDPENDINGORDERREPORT"
        TreeNode719.Text = "Pending Order Report"
        TreeNode720.Name = "NDMONTHLYCUSTOMERWISE"
        TreeNode720.Text = "Monthly customer Wise report"
        TreeNode721.Name = "NDMONTHLYFACTORYWISE"
        TreeNode721.Text = "Monthly Factory Wise Delivery Report"
        TreeNode722.Name = "NDPPSTATUS"
        TreeNode722.Text = "PP Status"
        TreeNode723.Name = "NDPPFABSTATUS"
        TreeNode723.Text = "PP Status FAB"
        TreeNode724.Name = "NDPPACCSTATUS"
        TreeNode724.Text = "PP Status ACC"
        TreeNode725.Name = "NDJOBORDERSTATUS"
        TreeNode725.Text = "Job Order Status "
        TreeNode726.Name = "ndSalesOrderRpt"
        TreeNode726.Text = "Sales Order Report"
        TreeNode727.Name = "ndSalesInvoiceRpt"
        TreeNode727.Text = "Sales Invoice Report"
        TreeNode728.Name = "ndJobWorkOrderPP"
        TreeNode728.Text = "JobWork Order(PP wise)"
        TreeNode729.Name = "ndGRNPendingPO"
        TreeNode729.Text = "GRN Pending Against PO"
        TreeNode730.Name = "ndItemStockRpt"
        TreeNode730.Text = "Item Stock Report"
        TreeNode731.Name = "ndSOBalanceRpt"
        TreeNode731.Text = "Sales Order Balance Report"
        TreeNode732.Name = "NDSOPendingFabricIssueAgtJobWorkOrderRPT"
        TreeNode732.Text = "Pending Fabric Issue Agst Job Work Order"
        TreeNode733.Name = "NDOCPENDINGSTATUSREPORT"
        TreeNode733.Text = "OC Pending Status"
        TreeNode734.Name = "NDBUYERPROGRESSCHART"
        TreeNode734.Text = "Buyer Progress Chart"
        TreeNode735.Name = "NDCOUNTRYWISEBUYERWISEORDERANAL"
        TreeNode735.Text = "CountryWise Buyerwise Order Analysis"
        TreeNode736.Name = "NDPRODUCTCATEGORYWISEBUYERWISEORDERANALYSIS"
        TreeNode736.Text = "Product CategoryWise BuyerWise Order Analyse"
        TreeNode737.Name = "NDTOPSTYLE"
        TreeNode737.Text = "Top Style"
        TreeNode738.Name = "ndSOInHandMonthWise"
        TreeNode738.Text = "Sales / Order In Hand(Month Wise)"
        TreeNode739.Name = "ndSOInHandBuyerWise"
        TreeNode739.Text = "Sales / Order In Hand(Buyer Wise)"
        TreeNode740.Name = "ndPreShipmentAnalysis"
        TreeNode740.Text = "Pre-Shipment Analysis"
        TreeNode741.Name = "ndrptMISReport"
        TreeNode741.Text = "MIS Report"
        TreeNode742.Name = "NDCOSTSHEETREPORT"
        TreeNode742.Text = "Cost Sheet Reports"
        TreeNode743.Name = "NDPERFORMASALESORDER"
        TreeNode743.Text = "Performa Sales Order"
        TreeNode744.Name = "NDPURCHASESALESORDERREPORT"
        TreeNode744.Text = "Purchase Sales Order Report"
        TreeNode745.Name = "NDFABRICORDERREPORT"
        TreeNode745.Text = "Fabric Order"
        TreeNode746.Name = "NDFINISHORDERREPORT"
        TreeNode746.Text = "Finish Order"
        TreeNode747.Name = "NDACCORDERREPORT"
        TreeNode747.Text = "Accessories And Trims Order"
        TreeNode748.Name = "NDBUYERSTANDARDLABELREPORT"
        TreeNode748.Text = "Buyer Standard Label"
        TreeNode749.Name = "NDJOBWORKPOREPORT"
        TreeNode749.Text = "JobWork PO"
        TreeNode750.Name = "NDJOBORDERREPORT"
        TreeNode750.Text = "JobWork Order"
        TreeNode751.Name = "NDFABRICGRNREPORT"
        TreeNode751.Text = "Fabric Purchase Inward"
        TreeNode752.Name = "NDFINISHGRNREPORT"
        TreeNode752.Text = "Finish Purchase Inward"
        TreeNode753.Name = "NDACCGRNREPORT"
        TreeNode753.Text = "Accessories Purchase Inward"
        TreeNode754.Name = "NDBUYERSTANDARDLBLGRNREPORT"
        TreeNode754.Text = "Buyer Standard Label Inward"
        TreeNode755.Name = "NDJOBWORKPORECVREPORT"
        TreeNode755.Text = "JobWork PO Receipt"
        TreeNode756.Name = "NDJOBWORKORDERRECVREPORT"
        TreeNode756.Text = "JobWork Order Receipt"
        TreeNode757.Name = "NDFABRTNREPORT"
        TreeNode757.Text = "Fabric Purchase Return"
        TreeNode758.Name = "NDFINRTNREPORT"
        TreeNode758.Text = "Finish Purchase Return"
        TreeNode759.Name = "NDACCRTNREPORT"
        TreeNode759.Text = "Accessories Purchase Return"
        TreeNode760.Name = "NDBUYERSTANDARDLBLRTNREPORT"
        TreeNode760.Text = "Buyer Standard Label Return"
        TreeNode761.Name = "NDMODULEREPORTS"
        TreeNode761.Text = "Modules Report"
        TreeNode762.Name = "NDMATERIALREQNOTERPT"
        TreeNode762.Text = "MRN Listing For Department"
        TreeNode763.Name = "NDMATERIALISUNOTERPT"
        TreeNode763.Text = "MIN Listing For Department"
        TreeNode764.Name = "NDMATERIALRETURNNOTERPT"
        TreeNode764.Text = "MRT Listing For Department"
        TreeNode765.Name = "NDMRNREPORTS"
        TreeNode765.Text = "MRN Report"
        Me.tvwInventoryReports.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode265, TreeNode348, TreeNode391, TreeNode499, TreeNode540, TreeNode557, TreeNode574, TreeNode584, TreeNode669, TreeNode674, TreeNode675, TreeNode685, TreeNode697, TreeNode704, TreeNode711, TreeNode717, TreeNode741, TreeNode761, TreeNode765})
        Me.tvwInventoryReports.SelectedImageIndex = 5
        Me.tvwInventoryReports.ShowNodeToolTips = True
        Me.tvwInventoryReports.Size = New System.Drawing.Size(260, 379)
        Me.tvwInventoryReports.TabIndex = 35
        '
        'BandAdmin
        '
        '
        'BandAdmin.ClientArea
        '
        Me.BandAdmin.ClientArea.Controls.Add(Me.tvwAdmin)
        Me.BandAdmin.ClientArea.Location = New System.Drawing.Point(0, 0)
        Me.BandAdmin.ClientArea.Name = "ClientArea"
        Me.BandAdmin.ClientArea.Size = New System.Drawing.Size(260, 379)
        Me.BandAdmin.ClientArea.TabIndex = 0
        Me.BandAdmin.LargeImage = CType(resources.GetObject("BandAdmin.LargeImage"), System.Drawing.Image)
        Me.BandAdmin.LayoutStyle = Guifreaks.NavigationBar.NaviLayoutStyle.Office2003Blue
        Me.BandAdmin.Location = New System.Drawing.Point(1, 27)
        Me.BandAdmin.Name = "BandAdmin"
        Me.BandAdmin.Size = New System.Drawing.Size(260, 379)
        Me.BandAdmin.TabIndex = 7
        Me.BandAdmin.Text = "A&dministrator"
        '
        'tvwAdmin
        '
        Me.tvwAdmin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvwAdmin.ImageIndex = 7
        Me.tvwAdmin.ImageList = Me.MainImageList
        Me.tvwAdmin.LabelEdit = True
        Me.tvwAdmin.Location = New System.Drawing.Point(0, 0)
        Me.tvwAdmin.Name = "tvwAdmin"
        TreeNode766.Name = "ndApplnSettings"
        TreeNode766.Text = "System"
        TreeNode767.Name = "ndSysCaption"
        TreeNode767.Text = "System Caption"
        TreeNode768.Name = "ndSetting"
        TreeNode768.Text = "Settings"
        TreeNode769.Name = "ndSettings"
        TreeNode769.Text = "Configuration"
        TreeNode770.Name = "ndUsersType"
        TreeNode770.Text = "Users Type"
        TreeNode770.ToolTipText = "Users Type"
        TreeNode771.Name = "ndUserRightsType"
        TreeNode771.Text = "User Rights Type"
        TreeNode771.ToolTipText = "User Rights Type"
        TreeNode772.Name = "ndUsers"
        TreeNode772.Text = "Users"
        TreeNode773.Name = "ndModules"
        TreeNode773.Text = "Modules"
        TreeNode774.Name = "ndUserRights"
        TreeNode774.Text = "User Rights"
        TreeNode775.Name = "ndModRights"
        TreeNode775.Text = "Modules Rights"
        TreeNode776.Name = "ndSecurity"
        TreeNode776.Text = "Security"
        TreeNode777.Name = "ndRecordHistory"
        TreeNode777.Text = "Record History"
        TreeNode778.Name = "ndSeries"
        TreeNode778.Text = "Series Master"
        TreeNode779.Name = "ndStockAdjust"
        TreeNode779.Text = "Stock Adjustment"
        TreeNode780.Name = "ndStockAdjustmentGodown"
        TreeNode780.Text = "Stock Adjustment Godown"
        TreeNode781.Name = "ndStockTracking"
        TreeNode781.Text = "Stock Tracking"
        TreeNode782.Name = "ndStockReco"
        TreeNode782.Text = "Stock Reconciliation"
        TreeNode783.Name = "ndBackup"
        TreeNode783.Text = "Backup Data"
        TreeNode784.Name = "ndRestore"
        TreeNode784.Text = "Restore Data"
        TreeNode785.Name = "ndDetach"
        TreeNode785.Text = "Detach Database"
        TreeNode786.Name = "ndDatabaseOptions"
        TreeNode786.Text = "Database Options"
        TreeNode787.Name = "ndVersionUpdate"
        TreeNode787.Text = "Version Update"
        TreeNode788.Name = "NDTRANSFORAPPROVAL"
        TreeNode788.Text = "Trans For Approval"
        TreeNode789.Name = "ndCompanyWiseMasterCode"
        TreeNode789.Text = "Company Wise Master Code"
        TreeNode790.Name = "NDTNADAYS"
        TreeNode790.Text = "TNA Days"
        Me.tvwAdmin.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode769, TreeNode776, TreeNode777, TreeNode778, TreeNode779, TreeNode780, TreeNode781, TreeNode782, TreeNode786, TreeNode787, TreeNode788, TreeNode789, TreeNode790})
        Me.tvwAdmin.SelectedImageIndex = 7
        Me.tvwAdmin.Size = New System.Drawing.Size(260, 379)
        Me.tvwAdmin.TabIndex = 0
        '
        'BandProduction
        '
        '
        'BandProduction.ClientArea
        '
        Me.BandProduction.ClientArea.Controls.Add(Me.tvwProduction)
        Me.BandProduction.ClientArea.Location = New System.Drawing.Point(0, 0)
        Me.BandProduction.ClientArea.Name = "ClientArea"
        Me.BandProduction.ClientArea.Size = New System.Drawing.Size(260, 379)
        Me.BandProduction.ClientArea.TabIndex = 0
        Me.BandProduction.LargeImage = CType(resources.GetObject("BandProduction.LargeImage"), System.Drawing.Image)
        Me.BandProduction.LayoutStyle = Guifreaks.NavigationBar.NaviLayoutStyle.Office2003Blue
        Me.BandProduction.Location = New System.Drawing.Point(1, 27)
        Me.BandProduction.Name = "BandProduction"
        Me.BandProduction.Size = New System.Drawing.Size(260, 379)
        Me.BandProduction.TabIndex = 1
        Me.BandProduction.Text = "&Production"
        '
        'tvwProduction
        '
        Me.tvwProduction.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvwProduction.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tvwProduction.ImageIndex = 0
        Me.tvwProduction.ImageList = Me.MainImageList
        Me.tvwProduction.LabelEdit = True
        Me.tvwProduction.Location = New System.Drawing.Point(0, 0)
        Me.tvwProduction.Name = "tvwProduction"
        TreeNode791.Name = "NDPLACEMENT"
        TreeNode791.Text = "Placement"
        TreeNode792.Name = "ndBOMProduct"
        TreeNode792.Text = "Bill Of Material(Product)"
        TreeNode793.Name = "ndBOMStyle"
        TreeNode793.Text = "Bill Of Material(Style)"
        TreeNode794.Name = "ndBOMSOStyle"
        TreeNode794.Text = "Bill Of Material(SO Style)"
        TreeNode795.Name = "ndBOMStyleDraft"
        TreeNode795.Text = "Bill Of Material(Draft)"
        TreeNode796.Name = "ndMakeToOrder"
        TreeNode796.Text = "Make To Order"
        TreeNode797.Name = "ndProductionOrder"
        TreeNode797.Text = "Production Order"
        TreeNode798.Name = "ndProductionPlanning"
        TreeNode798.Text = "Production Planning"
        TreeNode799.Name = "ndJobWorkOrder"
        TreeNode799.Text = "Job Work Order"
        TreeNode800.Name = "ndPPNOStatus"
        TreeNode800.Text = "PP NO Status"
        TreeNode801.Name = "ndJWNOStatus"
        TreeNode801.Text = "Job WOrk Order Status"
        TreeNode802.Name = "ndPlanning"
        TreeNode802.Text = "Planning"
        TreeNode803.Name = "ndProgram"
        TreeNode803.Text = "Program"
        TreeNode804.Name = "ndjobcardProg"
        TreeNode804.Text = "Job Card"
        TreeNode805.Name = "ndFabricIssue"
        TreeNode805.Text = "Fabric Issue(Cutting)"
        TreeNode806.Name = "ndFabricRcptCutting"
        TreeNode806.Text = "Fabric Receipt (Cutting)"
        TreeNode807.Name = "ndFinishRcptCutting"
        TreeNode807.Text = "Finish Receipt (Cutting)"
        TreeNode808.Name = "ndFabricIssueProcess"
        TreeNode808.Text = "Fabric Issue(Process)"
        TreeNode809.Name = "ndRunningEmbroideryJOrder"
        TreeNode809.Text = "Running Embroidery Job Order"
        TreeNode810.Name = "ndRunningEmbroideryReceipt"
        TreeNode810.Text = "Running Embroidery Receipt"
        TreeNode811.Name = "ndFabProcessTransfer"
        TreeNode811.Text = "Fabric Process Transfer"
        TreeNode812.Name = "ndSemiProcessReceiptProd"
        TreeNode812.Text = "Semi Process Receipt(Production)"
        TreeNode813.Name = "ndSemiProcessReceiptProc"
        TreeNode813.Text = "Semi Process Receipt(Process)"
        TreeNode814.Name = "ndSemiFinishIssueProd"
        TreeNode814.Text = "Semi Process Issue (Production)"
        TreeNode815.Name = "ndSemiFinishIssueProc"
        TreeNode815.Text = "Semi Process Issue (Process)"
        TreeNode816.Name = "ndFabricReceiptProd"
        TreeNode816.Text = "Fabric Receipt(Production)"
        TreeNode817.Name = "ndFabricReceiptProc"
        TreeNode817.Text = "Fabric Receipt(Process)"
        TreeNode818.Name = "ndAccReceiptProc"
        TreeNode818.Text = "Accessories Recipt Against Fabric"
        TreeNode819.Name = "ndFinishReceipt"
        TreeNode819.Text = "Process Receipt(Finish)"
        TreeNode820.Name = "ndFabricTransfer"
        TreeNode820.Text = "Fabric Transfer"
        TreeNode821.Name = "ndFabricIssueBack"
        TreeNode821.Text = "Fabric Issue Back"
        TreeNode822.Name = "ndAccIssue"
        TreeNode822.Text = "Accessories & Trims Issue(Production)"
        TreeNode823.Name = "ndAccRecP"
        TreeNode823.Text = "Accessories & Trims Receipt(Process)"
        TreeNode824.Name = "ndAccTransfer"
        TreeNode824.Text = "Accessories & Trims Transfer"
        TreeNode825.Name = "ndAccIssueBack"
        TreeNode825.Text = "Accessories & Trims Issue Back"
        TreeNode826.Name = "ndPackIssue"
        TreeNode826.Text = "Packing Issue"
        TreeNode827.Name = "ndPackTransfer"
        TreeNode827.Text = "Packing Transfer"
        TreeNode828.Name = "ndPackIssueBack"
        TreeNode828.Text = "Packing Issue Back"
        TreeNode829.Name = "ndAccIssueP"
        TreeNode829.Text = "Accessories & Trims  Issue(Process)"
        TreeNode830.Name = "ndProcessEntry"
        TreeNode830.Text = "Process Entry"
        TreeNode831.Name = "ndJobCard"
        TreeNode831.Text = "Job Card/Cutting Report"
        TreeNode832.Name = "ndEmbrroderyJobOrder"
        TreeNode832.Text = "Divider Embroidery Job Order"
        TreeNode833.Name = "ndEmbrroderyJobReceipt"
        TreeNode833.Text = "Divider Embroidery Job Receipt"
        TreeNode834.Name = "ndJobWorkPO"
        TreeNode834.Text = "Job Work PO (Pcs)"
        TreeNode835.Name = "ndJobWorkFabrics"
        TreeNode835.Text = "Job Work (Fabrics)"
        TreeNode836.Name = "ndJobWorkProcess"
        TreeNode836.Text = "Job Work PO"
        TreeNode837.Name = "ndProcIsuForStiching"
        TreeNode837.Text = "Process Issue For Stiching"
        TreeNode838.Name = "ndProcessIsujobcard"
        TreeNode838.Text = "Process Issue (Job Card)"
        TreeNode839.Name = "ndProcessRcpt"
        TreeNode839.Text = "Process Receipt (Finish)"
        TreeNode840.Name = "ndProcessRcptSemi"
        TreeNode840.Text = "Process Receipt (SemiFinish)"
        TreeNode841.Name = "ndProcessTfr"
        TreeNode841.Text = "Process Transfer"
        TreeNode842.Name = "ndProcessIsu"
        TreeNode842.Text = "Process Re-Issue"
        TreeNode843.Name = "ndProcessIsuSemiFinish"
        TreeNode843.Text = "Process Issue (Semi Finish)"
        TreeNode844.Name = "ndTrimsStoresConsumption"
        TreeNode844.Text = "Accessories Consumption"
        TreeNode845.Name = "ndfabricConsumption"
        TreeNode845.Text = "Fabric Consumption"
        TreeNode846.Name = "ndSampling"
        TreeNode846.Text = "Sampling"
        TreeNode847.Name = "NDPROCESSSTOCK"
        TreeNode847.Text = "Process Stock"
        TreeNode848.Name = "ndManufacturing"
        TreeNode848.Text = "Manufacturing"
        Me.tvwProduction.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode796, TreeNode802, TreeNode830, TreeNode848})
        Me.tvwProduction.SelectedImageIndex = 0
        Me.tvwProduction.Size = New System.Drawing.Size(260, 379)
        Me.tvwProduction.TabIndex = 1
        Me.tvwProduction.TabStop = False
        '
        'BandUtilities
        '
        '
        'BandUtilities.ClientArea
        '
        Me.BandUtilities.ClientArea.Controls.Add(Me.tvwUtilities)
        Me.BandUtilities.ClientArea.Location = New System.Drawing.Point(0, 0)
        Me.BandUtilities.ClientArea.Name = "ClientArea"
        Me.BandUtilities.ClientArea.Size = New System.Drawing.Size(260, 379)
        Me.BandUtilities.ClientArea.TabIndex = 0
        Me.BandUtilities.LargeImage = CType(resources.GetObject("BandUtilities.LargeImage"), System.Drawing.Image)
        Me.BandUtilities.LayoutStyle = Guifreaks.NavigationBar.NaviLayoutStyle.Office2003Blue
        Me.BandUtilities.Location = New System.Drawing.Point(1, 27)
        Me.BandUtilities.Name = "BandUtilities"
        Me.BandUtilities.Size = New System.Drawing.Size(260, 379)
        Me.BandUtilities.TabIndex = 6
        Me.BandUtilities.Text = "&Utilities"
        '
        'tvwUtilities
        '
        Me.tvwUtilities.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvwUtilities.ImageIndex = 8
        Me.tvwUtilities.ImageList = Me.MainImageList
        Me.tvwUtilities.LabelEdit = True
        Me.tvwUtilities.Location = New System.Drawing.Point(0, 0)
        Me.tvwUtilities.Name = "tvwUtilities"
        TreeNode849.Name = "ndSingleStyleBarcode"
        TreeNode849.Text = "Single Style"
        TreeNode850.Name = "ndMultiBarcode"
        TreeNode850.Text = "Multi Barcode"
        TreeNode851.Name = "ndSingleBarcode"
        TreeNode851.Text = "Re-Print Barcode"
        TreeNode852.Name = "ndLabel"
        TreeNode852.Text = "Label Print"
        TreeNode853.Name = "NDPRINT"
        TreeNode853.Text = "Label Print (Size wise)"
        TreeNode854.Name = "NDPRODNSTICKER"
        TreeNode854.Text = "Production Sticker"
        TreeNode855.Name = "ndBarcodePrinting"
        TreeNode855.Text = "Barcode Printing"
        TreeNode856.Name = "ndSMSSettings"
        TreeNode856.Text = "Settings"
        TreeNode857.Name = "ndSMSOccassion"
        TreeNode857.Text = "Occassion"
        TreeNode858.Name = "ndSMSMasters"
        TreeNode858.Text = "Instant SMS (Masters)"
        TreeNode859.Name = "ndSMSMobileNos"
        TreeNode859.Text = "Instant SMS (Mobile Nos)"
        TreeNode860.Name = "ndBatchSMS"
        TreeNode860.Text = "Batch SMS"
        TreeNode861.Name = "ndSMSLog"
        TreeNode861.Text = "SMS Log"
        TreeNode862.Name = "ndSMSMain"
        TreeNode862.Text = "SMS Features"
        TreeNode863.Name = "ndEmail"
        TreeNode863.Text = "Email"
        TreeNode864.Name = "ndEmailFeatures"
        TreeNode864.Text = "Email Features"
        TreeNode865.Name = "ndReleaseLocks"
        TreeNode865.Text = "Record Unlock"
        TreeNode866.Name = "ndDocRenumbering"
        TreeNode866.Text = "Reset Doc Number"
        TreeNode867.Name = "ndAddressLabelPrint"
        TreeNode867.Text = "Address Label Print"
        TreeNode868.Name = "ndEnvelopePrint"
        TreeNode868.Text = "Envelope Printing"
        TreeNode869.Name = "ndImportMasters"
        TreeNode869.Text = "Import Masters"
        TreeNode870.Name = "ndImportMastersBarcode"
        TreeNode870.Text = "Import Masters (Barcode)"
        TreeNode871.Name = "ndImportFabric"
        TreeNode871.Text = "Import Fabric"
        TreeNode872.Name = "ndTallyExport"
        TreeNode872.Text = "Tally Export"
        TreeNode873.Name = "ndImportAccessories"
        TreeNode873.Text = "Import Accessories Item"
        TreeNode874.Name = "ndImportPackingItem"
        TreeNode874.Text = "Import Packing Item"
        TreeNode875.Name = "ndProductSearch"
        TreeNode875.Text = "Product Search"
        TreeNode876.Name = "ndLedgerSearch"
        TreeNode876.Text = "Ledger Search"
        TreeNode877.Name = "ndSalesOrdShortClose"
        TreeNode877.Text = "Sales Order Short Close"
        TreeNode878.Name = "ndItemWiseStockLevel"
        TreeNode878.Text = "Item-Wise Stock Level"
        TreeNode879.Name = "ndCuttingProgram"
        TreeNode879.Text = "Cutting Program"
        TreeNode880.Name = "ndCatalogue"
        TreeNode880.Text = "Catalogue"
        TreeNode881.Name = "ndExpDataToFranchisee"
        TreeNode881.Text = "Export Data To Franchisee"
        TreeNode882.Name = "ndExpSchemaForFranchisee"
        TreeNode882.Text = "Export Schema For Franchisee"
        TreeNode883.Name = "ndSyncDatafromfranchisee"
        TreeNode883.Text = "Sync Data from Franchisee"
        TreeNode884.Name = "ndTNANew"
        TreeNode884.Text = "TNA(New)"
        TreeNode885.Name = "ndPriceListCategoryWise"
        TreeNode885.Text = "Category Wise"
        TreeNode886.Name = "ndrptPriceList"
        TreeNode886.Text = "Price List"
        TreeNode887.Name = "ndExportMastersBarcode"
        TreeNode887.Text = "Export Masters (Barcode)"
        TreeNode888.Name = "ndTransferBill"
        TreeNode888.Text = "Transfer Bill"
        TreeNode889.Name = "ndImpSO"
        TreeNode889.Text = "Import Sales Order"
        TreeNode890.Name = "ndrptExportBill"
        TreeNode890.Text = "Export Bill"
        TreeNode891.Name = "ndDataExportToTally"
        TreeNode891.Text = "Data Export To Tally"
        TreeNode892.Name = "ndTransactionReport"
        TreeNode892.Text = "Transaction Report"
        TreeNode893.Name = "ndImportBill"
        TreeNode893.Text = "Import Bills From Frnachisee"
        TreeNode894.Name = "NDSTOCKEXPORT"
        TreeNode894.Text = "Stock Export"
        TreeNode895.Name = "NDFAVOURITEBTN"
        TreeNode895.Text = "Favourite Buttons"
        Me.tvwUtilities.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode855, TreeNode862, TreeNode864, TreeNode865, TreeNode866, TreeNode867, TreeNode868, TreeNode869, TreeNode870, TreeNode871, TreeNode872, TreeNode873, TreeNode874, TreeNode875, TreeNode876, TreeNode877, TreeNode878, TreeNode879, TreeNode880, TreeNode881, TreeNode882, TreeNode883, TreeNode884, TreeNode886, TreeNode887, TreeNode888, TreeNode889, TreeNode890, TreeNode891, TreeNode892, TreeNode893, TreeNode894, TreeNode895})
        Me.tvwUtilities.SelectedImageIndex = 8
        Me.tvwUtilities.Size = New System.Drawing.Size(260, 379)
        Me.tvwUtilities.TabIndex = 0
        '
        'BandAccounts
        '
        '
        'BandAccounts.ClientArea
        '
        Me.BandAccounts.ClientArea.Controls.Add(Me.tvwAccounts)
        Me.BandAccounts.ClientArea.Location = New System.Drawing.Point(0, 0)
        Me.BandAccounts.ClientArea.Name = "ClientArea"
        Me.BandAccounts.ClientArea.Size = New System.Drawing.Size(260, 379)
        Me.BandAccounts.ClientArea.TabIndex = 0
        Me.BandAccounts.LargeImage = CType(resources.GetObject("BandAccounts.LargeImage"), System.Drawing.Image)
        Me.BandAccounts.LayoutStyle = Guifreaks.NavigationBar.NaviLayoutStyle.Office2003Blue
        Me.BandAccounts.Location = New System.Drawing.Point(1, 27)
        Me.BandAccounts.Name = "BandAccounts"
        Me.BandAccounts.Size = New System.Drawing.Size(260, 379)
        Me.BandAccounts.TabIndex = 5
        Me.BandAccounts.Text = "&Accounts"
        '
        'tvwAccounts
        '
        Me.tvwAccounts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvwAccounts.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tvwAccounts.ImageIndex = 9
        Me.tvwAccounts.ImageList = Me.MainImageList
        Me.tvwAccounts.LabelEdit = True
        Me.tvwAccounts.Location = New System.Drawing.Point(0, 0)
        Me.tvwAccounts.Name = "tvwAccounts"
        TreeNode896.Name = "ndLedger"
        TreeNode896.Text = "Ledger"
        TreeNode897.Name = "ndAccMainGroup"
        TreeNode897.Text = "Main Group"
        TreeNode898.Name = "ndAccGroup"
        TreeNode898.Text = "Group"
        TreeNode899.Name = "ndAccSubGroup"
        TreeNode899.Text = "Sub-Group"
        TreeNode900.Name = "ndCostCenter"
        TreeNode900.Text = "Cost Center"
        TreeNode901.Name = "ndBank"
        TreeNode901.Text = "Bank"
        TreeNode902.Name = "ndAccounts"
        TreeNode902.Text = "Accounts Masters"
        TreeNode903.Name = "ndGenLedOpBalance"
        TreeNode903.Text = "General Ledger"
        TreeNode904.Name = "ndSDOpBalance"
        TreeNode904.Text = "Sundry Debtors"
        TreeNode905.Name = "ndSCOpBalance"
        TreeNode905.Text = "Sundry Creditors"
        TreeNode906.Name = "ndBankRecoOpen"
        TreeNode906.Text = "Bank Reco Opening"
        TreeNode907.Name = "ndClosing_stock"
        TreeNode907.Text = "Closing Stock"
        TreeNode908.Name = "ndAccOpening"
        TreeNode908.Text = "Opening Balance"
        TreeNode909.Name = "ndContra"
        TreeNode909.Text = "Contra"
        TreeNode910.Name = "ndPayment"
        TreeNode910.Text = "Payment"
        TreeNode911.Name = "ndReceipt"
        TreeNode911.Text = "Receipt"
        TreeNode912.Name = "ndJournal"
        TreeNode912.Text = "Journal"
        TreeNode913.Name = "ndSalesVchr"
        TreeNode913.Text = "Sales"
        TreeNode914.Name = "ndCreditNote"
        TreeNode914.Text = "Credit Note"
        TreeNode915.Name = "ndPurchaseVchr"
        TreeNode915.Text = "Purchase"
        TreeNode916.Name = "ndDebitNote"
        TreeNode916.Text = "Debit Note"
        TreeNode917.Name = "ndTDSEntry"
        TreeNode917.Text = "TDS Entry"
        TreeNode918.Name = "ndVchrEntry"
        TreeNode918.Text = "Voucher Entry"
        TreeNode919.Name = "ndCustOpenTax"
        TreeNode919.Text = "Customer Opening Tax Form"
        TreeNode920.Name = "ndcustTaxRece"
        TreeNode920.Text = "Customer Tax Form Received"
        TreeNode921.Name = "ndTaxForm"
        TreeNode921.Text = "Tax Form"
        TreeNode922.Name = "ndBankReco"
        TreeNode922.Text = "Bank Reconciliation"
        Me.tvwAccounts.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode902, TreeNode908, TreeNode918, TreeNode921, TreeNode922})
        Me.tvwAccounts.SelectedImageIndex = 9
        Me.tvwAccounts.Size = New System.Drawing.Size(260, 379)
        Me.tvwAccounts.TabIndex = 0
        '
        'BandAccReports
        '
        '
        'BandAccReports.ClientArea
        '
        Me.BandAccReports.ClientArea.Controls.Add(Me.tvwAccountReports)
        Me.BandAccReports.ClientArea.Location = New System.Drawing.Point(0, 0)
        Me.BandAccReports.ClientArea.Name = "ClientArea"
        Me.BandAccReports.ClientArea.Size = New System.Drawing.Size(260, 379)
        Me.BandAccReports.ClientArea.TabIndex = 0
        Me.BandAccReports.LargeImage = CType(resources.GetObject("BandAccReports.LargeImage"), System.Drawing.Image)
        Me.BandAccReports.LayoutStyle = Guifreaks.NavigationBar.NaviLayoutStyle.Office2003Blue
        Me.BandAccReports.Location = New System.Drawing.Point(1, 27)
        Me.BandAccReports.Name = "BandAccReports"
        Me.BandAccReports.Size = New System.Drawing.Size(260, 379)
        Me.BandAccReports.TabIndex = 4
        Me.BandAccReports.Text = "A&ccounts Reports"
        '
        'tvwAccountReports
        '
        Me.tvwAccountReports.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvwAccountReports.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tvwAccountReports.ImageIndex = 5
        Me.tvwAccountReports.ImageList = Me.MainImageList
        Me.tvwAccountReports.LabelEdit = True
        Me.tvwAccountReports.Location = New System.Drawing.Point(0, 0)
        Me.tvwAccountReports.Name = "tvwAccountReports"
        TreeNode923.Name = "ndCashBook"
        TreeNode923.Text = "Cash Book"
        TreeNode924.Name = "ndBankBook"
        TreeNode924.Text = "Bank Book"
        TreeNode925.Name = "ndGenLedgers"
        TreeNode925.Text = "Ledgers"
        TreeNode926.Name = "ndGroupSummary"
        TreeNode926.Text = "Group Summary"
        TreeNode927.Name = "ndGroupVoucher"
        TreeNode927.Text = "Group Voucher"
        TreeNode928.Name = "ndJournalRegister"
        TreeNode928.Text = "Journal Register"
        TreeNode929.Name = "ndDebitNoteRegister"
        TreeNode929.Text = "Debit Note Register"
        TreeNode930.Name = "ndCreditNoteRegister"
        TreeNode930.Text = "Credit Note Register"
        TreeNode931.Name = "ndJournalReg"
        TreeNode931.Text = "Journal Register"
        TreeNode932.Name = "ndrptPurchaseReg"
        TreeNode932.Text = "Purchase Register"
        TreeNode933.Name = "ndrptSalesReg"
        TreeNode933.Text = "Sales Register"
        TreeNode934.Name = "ndrptDayBook"
        TreeNode934.Text = "Day Book"
        TreeNode935.Name = "ndrptAccountBooks"
        TreeNode935.Text = "Accounts Books"
        TreeNode936.Name = "ndReceivables"
        TreeNode936.Text = "Receivables"
        TreeNode937.Name = "ndPayables"
        TreeNode937.Text = "Payables"
        TreeNode938.Name = "ndOsLedgers"
        TreeNode938.Text = "Ledgers"
        TreeNode939.Name = "ndOsGroups"
        TreeNode939.Text = "Groups"
        TreeNode940.Name = "ndrptOSCustDtwise"
        TreeNode940.Text = "OS Customer Bills (With Date Filter)"
        TreeNode941.Name = "ndrptOSCustBillDayWise"
        TreeNode941.Text = "OS Customer Bills (With Days Filter)"
        TreeNode942.Name = "ndReceivablesB"
        TreeNode942.Text = "Estimated Receivables"
        TreeNode943.Name = "ndOutstandingReport"
        TreeNode943.Text = "Outstanding Reports"
        TreeNode944.Name = "ndDlyCollDate"
        TreeNode944.Text = "Daily Collection - Date Wise"
        TreeNode945.Name = "ndDlyCollDoc"
        TreeNode945.Text = "Daily Collection - Doc Wise"
        TreeNode946.Name = "ndDlyCollCust"
        TreeNode946.Text = "Daily Collection - Customer Wise"
        TreeNode947.Name = "ndDlyCollSalePerson"
        TreeNode947.Text = "Daily Collection - Saleperson Wise"
        TreeNode948.Name = "ndCollectionReports"
        TreeNode948.Text = "Collection Reports"
        TreeNode949.Name = "ndUnBilledGRN"
        TreeNode949.Text = "Unbilled GRN"
        TreeNode950.Name = "ndrptTaxFormStatus"
        TreeNode950.Text = "Tax Form Status of Customers ( Datewise)"
        TreeNode951.Name = "ndrptPendingTaxForm"
        TreeNode951.Text = "Pending Tax Form From Customers"
        TreeNode952.Name = "NDRPTTAXFORMRECD"
        TreeNode952.Text = "Tax Form Received From Customers (Party Wise)"
        TreeNode953.Name = "ndrptTaxFormReports"
        TreeNode953.Text = "Tax Form Reports"
        TreeNode954.Name = "ndrptBrokerComm"
        TreeNode954.Text = "Broker Commission Report"
        TreeNode955.Name = "ndrptBrokerCommRcptBill"
        TreeNode955.Text = "Broker Commission Reciept (BillWise)"
        TreeNode956.Name = "ndrptPartyComm"
        TreeNode956.Text = "PartyWise Commission Report"
        TreeNode957.Name = "ndBrockerwiseCollectionReport"
        TreeNode957.Text = "Brokerwise Collection Report"
        TreeNode958.Name = "ndMiscReports"
        TreeNode958.Text = "Misc Reports"
        TreeNode959.Name = "ndCrsBalance"
        TreeNode959.Text = "Group Trial Balance"
        TreeNode960.Name = "ndTrialBalance"
        TreeNode960.Text = "Trial Balance"
        TreeNode961.Name = "ndProfitAndLoss"
        TreeNode961.Text = "Profit And Loss A/c"
        TreeNode962.Name = "ndProfitAndLossScreen"
        TreeNode962.Text = "Profit And Loss A/c (Screen)"
        TreeNode963.Name = "ndBalanceSheet"
        TreeNode963.Text = "Balance Sheet"
        TreeNode964.Name = "ndBalanceSheetScreen"
        TreeNode964.Text = "Balance Sheet (Screen)"
        TreeNode965.Name = "ndCashFlow"
        TreeNode965.Text = "Cash Flow"
        TreeNode966.Name = "ndFundFlow"
        TreeNode966.Text = "Fund Flow"
        TreeNode967.Name = "ndFinalAccounts"
        TreeNode967.Text = "Final Accounts"
        TreeNode968.Name = "ndrptDayBookSalesReg"
        TreeNode968.Text = "Sales Register"
        TreeNode969.Name = "ndrptDayBookSalesRegGST"
        TreeNode969.Text = "Sales Register GST"
        TreeNode970.Name = "ndrptDaySalesWithTinNo"
        TreeNode970.Text = "Sales Register (With TIN No)"
        TreeNode971.Name = "ndrptDaySalesPartyWithTinNo"
        TreeNode971.Text = "Sales Register (Party With TIN No)"
        TreeNode972.Name = "ndrptDaySalesBroker"
        TreeNode972.Text = "Sales Register (Broker Wise)"
        TreeNode973.Name = "ndrptMonthlySalesPTwise"
        TreeNode973.Text = "Monthly Sales (Product-Type Wise)"
        TreeNode974.Name = "ndrptTaxSummary"
        TreeNode974.Text = "Tax Summary"
        TreeNode975.Name = "NDRPTTAXSUMMARYGST"
        TreeNode975.Text = "GST Summery"
        TreeNode976.Name = "ndrptDiscountSum"
        TreeNode976.Text = "Discount Summary"
        TreeNode977.Name = "ndrptSalesTaxSumPartyWise"
        TreeNode977.Text = "Sales Summary (Party Wise)"
        TreeNode978.Name = "ndrptSalesTaxSumPartyTax"
        TreeNode978.Text = "Sales Summary (Party/Tax)"
        TreeNode979.Name = "ndrptRG1Reg"
        TreeNode979.Text = "RG1 Register"
        TreeNode980.Name = "ndrptCNReg"
        TreeNode980.Text = "Credit Note Register"
        TreeNode981.Name = "ndrptCNRegGST"
        TreeNode981.Text = "Credit Note Register GST"
        TreeNode982.Name = "ndrptCNBroker"
        TreeNode982.Text = "Credit Note Register (Broker Wise)"
        TreeNode983.Name = "ndrptPartySalesAnalysisQty"
        TreeNode983.Text = "Party Wise Sales Summary (With CN & Qty)"
        TreeNode984.Name = "ndrptDayBookSales"
        TreeNode984.Text = "Day Book (Sales)"
        TreeNode985.Name = "ndrptCustLedger"
        TreeNode985.Text = "Customer Ledger"
        TreeNode986.Name = "ndrptCustBillwise"
        TreeNode986.Text = "Customer A/c (BillWise)"
        TreeNode987.Name = "ndrptCustConfirm"
        TreeNode987.Text = "Customer A/c  Confirmation"
        TreeNode988.Name = "ndrptLedgerOnScreen"
        TreeNode988.Text = "Ledger On Screen"
        TreeNode989.Name = "ndrptManualMatching"
        TreeNode989.Text = "Manual Matching (F6)"
        TreeNode990.Name = "ndrptCustOutstanding"
        TreeNode990.Text = "Customer Outstanding"
        TreeNode991.Name = "ndrptBrokerOutstanding"
        TreeNode991.Text = "Broker Wise Outstanding"
        TreeNode992.Name = "ndrptLedger"
        TreeNode992.Text = "Ledger"
        TreeNode993.Name = "ndrptTaxFormRem"
        TreeNode993.Text = "Tax Form Reminder"
        TreeNode994.Name = "ndrptOSReminder"
        TreeNode994.Text = "Outstanding Reminder"
        TreeNode995.Name = "NDRPTOSReminderPartyWise"
        TreeNode995.Text = "Outstanding Reminder (On Sreen)"
        TreeNode996.Name = "ndrptReminders"
        TreeNode996.Text = "Reminders"
        TreeNode997.Name = "ndrptPurchaseRegister"
        TreeNode997.Text = "Purchase Register"
        TreeNode998.Name = "NDRPTPURCHASEREGISTERGST"
        TreeNode998.Text = "Purchase Register GST"
        TreeNode999.Name = "ndrptPurchTaxSumPartyWise"
        TreeNode999.Text = "Purchase Summary (Party Wise)"
        TreeNode1000.Name = "ndrptPurchTaxSumPartyTax"
        TreeNode1000.Text = "Purchase Summary (Party/Tax)"
        TreeNode1001.Name = "ndPurBillRegisterDateWise"
        TreeNode1001.Text = "Purchase Bill Register(Date Wise)"
        TreeNode1002.Name = "ndrptDayBookPurchase"
        TreeNode1002.Text = "Day Book (Purchase)"
        Me.tvwAccountReports.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode935, TreeNode943, TreeNode958, TreeNode959, TreeNode960, TreeNode967, TreeNode984, TreeNode992, TreeNode996, TreeNode1002})
        Me.tvwAccountReports.SelectedImageIndex = 5
        Me.tvwAccountReports.Size = New System.Drawing.Size(260, 379)
        Me.tvwAccountReports.TabIndex = 1
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'tmrBackup
        '
        Me.tmrBackup.Enabled = True
        Me.tmrBackup.Interval = 60000
        '
        'grpAlert
        '
        Me.grpAlert.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpAlert.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.grpAlert.AppearanceCaption.Options.UseFont = True
        Me.grpAlert.AppearanceCaption.Options.UseTextOptions = True
        Me.grpAlert.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grpAlert.Controls.Add(Me.lnkTNA)
        Me.grpAlert.Controls.Add(Me.LnkPOAgaintsDelivery)
        Me.grpAlert.Controls.Add(Me.lnkOutPay)
        Me.grpAlert.Controls.Add(Me.lnkOutRec)
        Me.grpAlert.Controls.Add(Me.Label1)
        Me.grpAlert.Controls.Add(Me.lnkMiniStk)
        Me.grpAlert.Controls.Add(Me.lblCloseAlert)
        Me.grpAlert.Location = New System.Drawing.Point(857, 544)
        Me.grpAlert.LookAndFeel.SkinName = "Money Twins"
        Me.grpAlert.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grpAlert.Name = "grpAlert"
        Me.grpAlert.ShowCaption = False
        Me.grpAlert.Size = New System.Drawing.Size(170, 133)
        Me.grpAlert.TabIndex = 39
        Me.grpAlert.Text = "Today's Events"
        Me.grpAlert.Visible = False
        '
        'lnkTNA
        '
        Me.lnkTNA.BackColor = System.Drawing.Color.Transparent
        Me.lnkTNA.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkTNA.LinkColor = System.Drawing.Color.Blue
        Me.lnkTNA.Location = New System.Drawing.Point(6, 110)
        Me.lnkTNA.Name = "lnkTNA"
        Me.lnkTNA.Size = New System.Drawing.Size(157, 20)
        Me.lnkTNA.TabIndex = 22
        Me.lnkTNA.TabStop = True
        Me.lnkTNA.Text = "TNA Status for Order"
        Me.lnkTNA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lnkTNA.Visible = False
        '
        'LnkPOAgaintsDelivery
        '
        Me.LnkPOAgaintsDelivery.BackColor = System.Drawing.Color.Transparent
        Me.LnkPOAgaintsDelivery.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LnkPOAgaintsDelivery.LinkColor = System.Drawing.Color.Blue
        Me.LnkPOAgaintsDelivery.Location = New System.Drawing.Point(6, 90)
        Me.LnkPOAgaintsDelivery.Name = "LnkPOAgaintsDelivery"
        Me.LnkPOAgaintsDelivery.Size = New System.Drawing.Size(157, 20)
        Me.LnkPOAgaintsDelivery.TabIndex = 21
        Me.LnkPOAgaintsDelivery.TabStop = True
        Me.LnkPOAgaintsDelivery.Text = "PO Againts Delivery Note"
        Me.LnkPOAgaintsDelivery.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LnkPOAgaintsDelivery.Visible = False
        '
        'lnkOutPay
        '
        Me.lnkOutPay.BackColor = System.Drawing.Color.Transparent
        Me.lnkOutPay.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkOutPay.LinkColor = System.Drawing.Color.Blue
        Me.lnkOutPay.Location = New System.Drawing.Point(3, 70)
        Me.lnkOutPay.Name = "lnkOutPay"
        Me.lnkOutPay.Size = New System.Drawing.Size(141, 20)
        Me.lnkOutPay.TabIndex = 20
        Me.lnkOutPay.TabStop = True
        Me.lnkOutPay.Text = "Outstanding (Payable)"
        Me.lnkOutPay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lnkOutPay.Visible = False
        '
        'lnkOutRec
        '
        Me.lnkOutRec.BackColor = System.Drawing.Color.Transparent
        Me.lnkOutRec.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkOutRec.LinkColor = System.Drawing.Color.Blue
        Me.lnkOutRec.Location = New System.Drawing.Point(3, 51)
        Me.lnkOutRec.Name = "lnkOutRec"
        Me.lnkOutRec.Size = New System.Drawing.Size(160, 18)
        Me.lnkOutRec.TabIndex = 19
        Me.lnkOutRec.TabStop = True
        Me.lnkOutRec.Text = "Outstanding (Receivable)"
        Me.lnkOutRec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lnkOutRec.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(62, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 15)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Alert"
        '
        'lnkMiniStk
        '
        Me.lnkMiniStk.BackColor = System.Drawing.Color.Transparent
        Me.lnkMiniStk.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkMiniStk.LinkColor = System.Drawing.Color.Blue
        Me.lnkMiniStk.Location = New System.Drawing.Point(3, 33)
        Me.lnkMiniStk.Name = "lnkMiniStk"
        Me.lnkMiniStk.Size = New System.Drawing.Size(108, 18)
        Me.lnkMiniStk.TabIndex = 17
        Me.lnkMiniStk.TabStop = True
        Me.lnkMiniStk.Text = "Minimum Stock"
        Me.lnkMiniStk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lnkMiniStk.Visible = False
        '
        'lblCloseAlert
        '
        Me.lblCloseAlert.AutoSize = True
        Me.lblCloseAlert.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCloseAlert.ForeColor = System.Drawing.Color.Red
        Me.lblCloseAlert.Location = New System.Drawing.Point(146, 3)
        Me.lblCloseAlert.Name = "lblCloseAlert"
        Me.lblCloseAlert.Size = New System.Drawing.Size(18, 17)
        Me.lblCloseAlert.TabIndex = 16
        Me.lblCloseAlert.Text = "X"
        '
        'grpAppAlert
        '
        Me.grpAppAlert.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpAppAlert.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.grpAppAlert.AppearanceCaption.Options.UseFont = True
        Me.grpAppAlert.AppearanceCaption.Options.UseTextOptions = True
        Me.grpAppAlert.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grpAppAlert.Controls.Add(Me.lnkPTR)
        Me.grpAppAlert.Controls.Add(Me.lnkCorrection)
        Me.grpAppAlert.Controls.Add(Me.Label2)
        Me.grpAppAlert.Controls.Add(Me.lnkApproval)
        Me.grpAppAlert.Controls.Add(Me.Label3)
        Me.grpAppAlert.Location = New System.Drawing.Point(855, 454)
        Me.grpAppAlert.LookAndFeel.SkinName = "Money Twins"
        Me.grpAppAlert.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grpAppAlert.Name = "grpAppAlert"
        Me.grpAppAlert.ShowCaption = False
        Me.grpAppAlert.Size = New System.Drawing.Size(170, 90)
        Me.grpAppAlert.TabIndex = 41
        Me.grpAppAlert.Text = "1"
        Me.grpAppAlert.Visible = False
        '
        'lnkPTR
        '
        Me.lnkPTR.BackColor = System.Drawing.Color.Transparent
        Me.lnkPTR.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkPTR.LinkColor = System.Drawing.Color.Blue
        Me.lnkPTR.Location = New System.Drawing.Point(57, 63)
        Me.lnkPTR.Name = "lnkPTR"
        Me.lnkPTR.Size = New System.Drawing.Size(43, 19)
        Me.lnkPTR.TabIndex = 20
        Me.lnkPTR.TabStop = True
        Me.lnkPTR.Text = "PTR"
        Me.lnkPTR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lnkCorrection
        '
        Me.lnkCorrection.BackColor = System.Drawing.Color.Transparent
        Me.lnkCorrection.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkCorrection.LinkColor = System.Drawing.Color.Blue
        Me.lnkCorrection.Location = New System.Drawing.Point(2, 43)
        Me.lnkCorrection.Name = "lnkCorrection"
        Me.lnkCorrection.Size = New System.Drawing.Size(150, 19)
        Me.lnkCorrection.TabIndex = 19
        Me.lnkCorrection.TabStop = True
        Me.lnkCorrection.Text = "Pending For Correction"
        Me.lnkCorrection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lnkCorrection.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(62, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 15)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Alert"
        '
        'lnkApproval
        '
        Me.lnkApproval.BackColor = System.Drawing.Color.Transparent
        Me.lnkApproval.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkApproval.LinkColor = System.Drawing.Color.Blue
        Me.lnkApproval.Location = New System.Drawing.Point(2, 26)
        Me.lnkApproval.Name = "lnkApproval"
        Me.lnkApproval.Size = New System.Drawing.Size(142, 18)
        Me.lnkApproval.TabIndex = 17
        Me.lnkApproval.TabStop = True
        Me.lnkApproval.Text = "Pending For Approval"
        Me.lnkApproval.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lnkApproval.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(144, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 17)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "."
        Me.Label3.Visible = False
        '
        'grpEnable
        '
        Me.grpEnable.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpEnable.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.grpEnable.AppearanceCaption.Options.UseFont = True
        Me.grpEnable.AppearanceCaption.Options.UseTextOptions = True
        Me.grpEnable.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grpEnable.Controls.Add(Me.lblMinimise)
        Me.grpEnable.Controls.Add(Me.lblClose)
        Me.grpEnable.Location = New System.Drawing.Point(1004, 457)
        Me.grpEnable.LookAndFeel.SkinName = "Money Twins"
        Me.grpEnable.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grpEnable.Name = "grpEnable"
        Me.grpEnable.ShowCaption = False
        Me.grpEnable.Size = New System.Drawing.Size(18, 36)
        Me.grpEnable.TabIndex = 43
        Me.grpEnable.Text = "Today's Events"
        Me.grpEnable.Visible = False
        '
        'lblMinimise
        '
        Me.lblMinimise.AutoSize = True
        Me.lblMinimise.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinimise.ForeColor = System.Drawing.Color.Blue
        Me.lblMinimise.Location = New System.Drawing.Point(2, 19)
        Me.lblMinimise.Name = "lblMinimise"
        Me.lblMinimise.Size = New System.Drawing.Size(14, 13)
        Me.lblMinimise.TabIndex = 20
        Me.lblMinimise.Text = "0"
        '
        'lblClose
        '
        Me.lblClose.AutoSize = True
        Me.lblClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClose.ForeColor = System.Drawing.Color.Red
        Me.lblClose.Location = New System.Drawing.Point(2, 3)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(15, 13)
        Me.lblClose.TabIndex = 16
        Me.lblClose.Text = "X"
        '
        'grpShortcut
        '
        Me.grpShortcut.Controls.Add(Me.btnShortcut)
        Me.grpShortcut.Dock = System.Windows.Forms.DockStyle.Right
        Me.grpShortcut.Location = New System.Drawing.Point(887, 24)
        Me.grpShortcut.Name = "grpShortcut"
        Me.grpShortcut.Size = New System.Drawing.Size(137, 654)
        Me.grpShortcut.TabIndex = 45
        Me.grpShortcut.Text = "Favourites"
        '
        'btnShortcut
        '
        Me.btnShortcut.Location = New System.Drawing.Point(5, 27)
        Me.btnShortcut.LookAndFeel.SkinName = "Money Twins"
        Me.btnShortcut.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnShortcut.Name = "btnShortcut"
        Me.btnShortcut.Size = New System.Drawing.Size(127, 30)
        Me.btnShortcut.TabIndex = 0
        Me.btnShortcut.Text = "View Rights"
        '
        'MDIMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1024, 702)
        Me.Controls.Add(Me.grpShortcut)
        Me.Controls.Add(Me.grpEnable)
        Me.Controls.Add(Me.grpAppAlert)
        Me.Controls.Add(Me.grpAlert)
        Me.Controls.Add(Me.MDINaviBar)
        Me.Controls.Add(Me.sbrMain)
        Me.Controls.Add(Me.MenuStrip)
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "MDIMain"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MDIMain"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.sbrMain.ResumeLayout(False)
        Me.sbrMain.PerformLayout()
        CType(Me.MDINaviBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MDINaviBar.ResumeLayout(False)
        Me.BandTransactions.ClientArea.ResumeLayout(False)
        Me.BandTransactions.ResumeLayout(False)
        Me.BandMasters.ClientArea.ResumeLayout(False)
        Me.BandMasters.ResumeLayout(False)
        Me.BandInvReports.ClientArea.ResumeLayout(False)
        Me.BandInvReports.ResumeLayout(False)
        Me.BandAdmin.ClientArea.ResumeLayout(False)
        Me.BandAdmin.ResumeLayout(False)
        Me.BandProduction.ClientArea.ResumeLayout(False)
        Me.BandProduction.ResumeLayout(False)
        Me.BandUtilities.ClientArea.ResumeLayout(False)
        Me.BandUtilities.ResumeLayout(False)
        Me.BandAccounts.ClientArea.ResumeLayout(False)
        Me.BandAccounts.ResumeLayout(False)
        Me.BandAccReports.ClientArea.ResumeLayout(False)
        Me.BandAccReports.ResumeLayout(False)
        CType(Me.grpAlert, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpAlert.ResumeLayout(False)
        Me.grpAlert.PerformLayout()
        CType(Me.grpAppAlert, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpAppAlert.ResumeLayout(False)
        Me.grpAppAlert.PerformLayout()
        CType(Me.grpEnable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpEnable.ResumeLayout(False)
        Me.grpEnable.PerformLayout()
        CType(Me.grpShortcut, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpShortcut.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HelpMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WindowsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CascadeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileVerticalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileHorizontalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents sbrMain As System.Windows.Forms.StatusStrip
    Friend WithEvents ApplnName As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents CurrentDate As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents CurrentTime As System.Windows.Forms.ToolStripStatusLabel
    Private WithEvents BandMasters As Guifreaks.NavigationBar.NaviBand
    Friend WithEvents tvwMasters As System.Windows.Forms.TreeView
    Friend WithEvents BandTransactions As Guifreaks.NavigationBar.NaviBand
    Friend WithEvents BandAdmin As Guifreaks.NavigationBar.NaviBand
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents LoginTime As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MDINaviBar As Guifreaks.NavigationBar.NaviBar
    Friend WithEvents BandInvReports As Guifreaks.NavigationBar.NaviBand
    Friend WithEvents BandUtilities As Guifreaks.NavigationBar.NaviBand
    Friend WithEvents tvwUtilities As System.Windows.Forms.TreeView
    Friend WithEvents BandAccounts As Guifreaks.NavigationBar.NaviBand
    Friend WithEvents tvwAccounts As System.Windows.Forms.TreeView
    Friend WithEvents BandAccReports As Guifreaks.NavigationBar.NaviBand
    Friend WithEvents mnuChangeUser As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuChangeCompany As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuCalculator As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTeamviewer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tmrBackup As System.Windows.Forms.Timer
    Friend WithEvents Version As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents UserName As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Counter As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Server As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tvwInventoryReports As System.Windows.Forms.TreeView
    Friend WithEvents tvwAccountReports As System.Windows.Forms.TreeView
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MainImageList As System.Windows.Forms.ImageList
    Friend WithEvents mnuRegister As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuActivate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuContact As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BandProduction As Guifreaks.NavigationBar.NaviBand
    Friend WithEvents tvwProduction As System.Windows.Forms.TreeView
    Friend WithEvents tvwPurchase As System.Windows.Forms.TreeView
    Private WithEvents tvwAdmin As System.Windows.Forms.TreeView
    Friend WithEvents grpAlert As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lnkOutPay As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkOutRec As System.Windows.Forms.LinkLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lnkMiniStk As System.Windows.Forms.LinkLabel
    Friend WithEvents lblCloseAlert As System.Windows.Forms.Label
    Friend WithEvents LnkPOAgaintsDelivery As System.Windows.Forms.LinkLabel
    Friend WithEvents SyncFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnurptProfitLossAc As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnurptBalanceSheet As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grpAppAlert As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lnkCorrection As System.Windows.Forms.LinkLabel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lnkApproval As System.Windows.Forms.LinkLabel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents grpEnable As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblMinimise As System.Windows.Forms.Label
    Friend WithEvents lblClose As System.Windows.Forms.Label
    Friend WithEvents lnkPTR As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkTNA As System.Windows.Forms.LinkLabel
    Friend WithEvents grpShortcut As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnShortcut As DevExpress.XtraEditors.SimpleButton
End Class
