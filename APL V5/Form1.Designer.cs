namespace APL_V5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbxVisitor = new System.Windows.Forms.TextBox();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.gbxAdmin = new System.Windows.Forms.GroupBox();
            this.lbxVisitor = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.gbxAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxVisitor
            // 
            this.tbxVisitor.Location = new System.Drawing.Point(401, 241);
            this.tbxVisitor.Name = "tbxVisitor";
            this.tbxVisitor.Size = new System.Drawing.Size(387, 23);
            this.tbxVisitor.TabIndex = 0;
            this.tbxVisitor.TextChanged += new System.EventHandler(this.tbxVisitor_TextChanged);
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Location = new System.Drawing.Point(401, 197);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(75, 23);
            this.btnCheckIn.TabIndex = 2;
            this.btnCheckIn.Text = "Checka In";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(482, 197);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(75, 23);
            this.btnCheckOut.TabIndex = 3;
            this.btnCheckOut.Text = "Checka ut";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(6, 64);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(139, 23);
            this.tbxPassword.TabIndex = 4;
            this.tbxPassword.Text = "Lösenord";
            // 
            // tbxUsername
            // 
            this.tbxUsername.Location = new System.Drawing.Point(6, 22);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(139, 23);
            this.tbxUsername.TabIndex = 5;
            this.tbxUsername.Text = "Användarnamn";
            // 
            // btnLogIn
            // 
            this.btnLogIn.Location = new System.Drawing.Point(6, 104);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(75, 23);
            this.btnLogIn.TabIndex = 6;
            this.btnLogIn.Text = "Logga In";
            this.btnLogIn.UseVisualStyleBackColor = true;
            // 
            // gbxAdmin
            // 
            this.gbxAdmin.Controls.Add(this.btnLogIn);
            this.gbxAdmin.Controls.Add(this.tbxPassword);
            this.gbxAdmin.Controls.Add(this.tbxUsername);
            this.gbxAdmin.Location = new System.Drawing.Point(12, 305);
            this.gbxAdmin.Name = "gbxAdmin";
            this.gbxAdmin.Size = new System.Drawing.Size(200, 133);
            this.gbxAdmin.TabIndex = 7;
            this.gbxAdmin.TabStop = false;
            this.gbxAdmin.Text = "groupBox1";
            // 
            // lbxVisitor
            // 
            this.lbxVisitor.FormattingEnabled = true;
            this.lbxVisitor.ItemHeight = 15;
            this.lbxVisitor.Location = new System.Drawing.Point(401, 299);
            this.lbxVisitor.Name = "lbxVisitor";
            this.lbxVisitor.Size = new System.Drawing.Size(387, 139);
            this.lbxVisitor.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(401, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Skriv namn, företag och ärende nedanför.";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(401, 270);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(234, 23);
            this.dateTimePicker1.TabIndex = 10;
            this.dateTimePicker1.Value = new System.DateTime(2022, 3, 9, 13, 42, 40, 0);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxVisitor);
            this.Controls.Add(this.gbxAdmin);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.tbxVisitor);
            this.Controls.Add(this.btnCheckOut);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨";
            this.gbxAdmin.ResumeLayout(false);
            this.gbxAdmin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbxVisitor;
        private Button btnCheckIn;
        private Button btnCheckOut;
        private TextBox tbxPassword;
        private TextBox tbxUsername;
        private Button btnLogIn;
        private GroupBox gbxAdmin;
        private ListBox lbxVisitor;
        private TextBox tbxDate;
        private Label label1;
        private DateTimePicker dateTimePicker1;
    }
}