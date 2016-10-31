namespace CivGen
{
    partial class Host
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            Entities.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BasePanel = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.EntityList = new System.Windows.Forms.ComboBox();
            this.CivData = new System.Windows.Forms.DataGridView();
            this.BasePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CivData)).BeginInit();
            this.SuspendLayout();
            // 
            // BasePanel
            // 
            this.BasePanel.ColumnCount = 3;
            this.BasePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.11111F));
            this.BasePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.88889F));
            this.BasePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 246F));
            this.BasePanel.Controls.Add(this.label1, 0, 0);
            this.BasePanel.Controls.Add(this.EntityList, 1, 0);
            this.BasePanel.Controls.Add(this.CivData, 0, 1);
            this.BasePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BasePanel.Location = new System.Drawing.Point(0, 0);
            this.BasePanel.Name = "BasePanel";
            this.BasePanel.RowCount = 3;
            this.BasePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.636156F));
            this.BasePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.36385F));
            this.BasePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.BasePanel.Size = new System.Drawing.Size(693, 458);
            this.BasePanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Entity:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EntityList
            // 
            this.EntityList.FormattingEnabled = true;
            this.EntityList.Location = new System.Drawing.Point(97, 3);
            this.EntityList.Name = "EntityList";
            this.EntityList.Size = new System.Drawing.Size(346, 21);
            this.EntityList.TabIndex = 1;
            this.EntityList.SelectedIndexChanged += new System.EventHandler(this.EntityList_SelectedIndexChanged);
            // 
            // CivData
            // 
            this.CivData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BasePanel.SetColumnSpan(this.CivData, 3);
            this.CivData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CivData.Location = new System.Drawing.Point(3, 32);
            this.CivData.Name = "CivData";
            this.CivData.Size = new System.Drawing.Size(687, 402);
            this.CivData.TabIndex = 2;
            // 
            // Host
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 458);
            this.Controls.Add(this.BasePanel);
            this.Name = "Host";
            this.Text = "Civ6 Settings Browser";
            this.BasePanel.ResumeLayout(false);
            this.BasePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CivData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel BasePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox EntityList;
        private System.Windows.Forms.DataGridView CivData;
    }
}