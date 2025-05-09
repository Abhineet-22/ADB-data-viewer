namespace AdbDataViewer
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageCpu;
        private System.Windows.Forms.TabPage tabPageContacts;
        private System.Windows.Forms.TabPage tabPageSms;
        private System.Windows.Forms.DataGridView dataGridView1; // CPU Info
        private System.Windows.Forms.DataGridView dataGridView2; // Contacts
        private System.Windows.Forms.DataGridView dataGridView3; // SMS

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageCpu = new System.Windows.Forms.TabPage();
            this.tabPageContacts = new System.Windows.Forms.TabPage();
            this.tabPageSms = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();

            this.tabControl1.SuspendLayout();
            this.tabPageCpu.SuspendLayout();
            this.tabPageContacts.SuspendLayout();
            this.tabPageSms.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();

            this.SuspendLayout();

            // TabControl
            this.tabControl1.Controls.Add(this.tabPageCpu);
            this.tabControl1.Controls.Add(this.tabPageContacts);
            this.tabControl1.Controls.Add(this.tabPageSms);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.TabIndex = 0;

            // tabPageCpu
            this.tabPageCpu.Controls.Add(this.dataGridView1);
            this.tabPageCpu.Location = new System.Drawing.Point(4, 24);
            this.tabPageCpu.Name = "tabPageCpu";
            this.tabPageCpu.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCpu.Size = new System.Drawing.Size(792, 422);
            this.tabPageCpu.TabIndex = 0;
            this.tabPageCpu.Text = "CPU Info";
            this.tabPageCpu.UseVisualStyleBackColor = true;

            // tabPageContacts
            this.tabPageContacts.Controls.Add(this.dataGridView2);
            this.tabPageContacts.Location = new System.Drawing.Point(4, 24);
            this.tabPageContacts.Name = "tabPageContacts";
            this.tabPageContacts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageContacts.Size = new System.Drawing.Size(792, 422);
            this.tabPageContacts.TabIndex = 1;
            this.tabPageContacts.Text = "Contacts";
            this.tabPageContacts.UseVisualStyleBackColor = true;

            // tabPageSms
            this.tabPageSms.Controls.Add(this.dataGridView3);
            this.tabPageSms.Location = new System.Drawing.Point(4, 24);
            this.tabPageSms.Name = "tabPageSms";
            this.tabPageSms.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSms.Size = new System.Drawing.Size(792, 422);
            this.tabPageSms.TabIndex = 2;
            this.tabPageSms.Text = "SMS";
            this.tabPageSms.UseVisualStyleBackColor = true;

            // dataGridView1 (CPU Info)
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.TabIndex = 0;

            // dataGridView2 (Contacts)
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.TabIndex = 1;

            // dataGridView3 (SMS)
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.TabIndex = 2;

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "ADB Data Viewer";
            this.Load += new System.EventHandler(this.Form1_Load);

            this.tabControl1.ResumeLayout(false);
            this.tabPageCpu.ResumeLayout(false);
            this.tabPageContacts.ResumeLayout(false);
            this.tabPageSms.ResumeLayout(false);

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();

            this.ResumeLayout(false);
        }
    }
}
