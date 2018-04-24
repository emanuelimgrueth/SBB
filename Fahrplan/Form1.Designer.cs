namespace Fahrplan
{
    partial class Fahrplan
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
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cVon = new System.Windows.Forms.ComboBox();
            this.cNach = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bSuche = new System.Windows.Forms.Button();
            this.dGResultate = new System.Windows.Forms.DataGridView();
            this.Ab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gleis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.An = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gleis2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bAbfahrtsTafel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGResultate)).BeginInit();
            this.SuspendLayout();
            // 
            // cVon
            // 
            this.cVon.FormattingEnabled = true;
            this.cVon.Location = new System.Drawing.Point(41, 34);
            this.cVon.Name = "cVon";
            this.cVon.Size = new System.Drawing.Size(171, 21);
            this.cVon.TabIndex = 0;
            this.cVon.DropDown += new System.EventHandler(this.cVon_DropDown);
            // 
            // cNach
            // 
            this.cNach.FormattingEnabled = true;
            this.cNach.Location = new System.Drawing.Point(41, 71);
            this.cNach.Name = "cNach";
            this.cNach.Size = new System.Drawing.Size(171, 21);
            this.cNach.TabIndex = 1;
            this.cNach.DropDown += new System.EventHandler(this.cNach_DropDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Von:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nach:";
            // 
            // bSuche
            // 
            this.bSuche.Location = new System.Drawing.Point(253, 32);
            this.bSuche.Name = "bSuche";
            this.bSuche.Size = new System.Drawing.Size(75, 23);
            this.bSuche.TabIndex = 2;
            this.bSuche.Text = "Suchen";
            this.bSuche.UseVisualStyleBackColor = true;
            this.bSuche.Click += new System.EventHandler(this.bSuche_Click);
            // 
            // dGResultate
            // 
            this.dGResultate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGResultate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ab,
            this.Gleis,
            this.An,
            this.Gleis2});
            this.dGResultate.Location = new System.Drawing.Point(41, 120);
            this.dGResultate.Name = "dGResultate";
            this.dGResultate.Size = new System.Drawing.Size(443, 206);
            this.dGResultate.TabIndex = 5;
            this.dGResultate.TabStop = false;
            // 
            // Ab
            // 
            this.Ab.HeaderText = "Ab";
            this.Ab.Name = "Ab";
            // 
            // Gleis
            // 
            this.Gleis.HeaderText = "Gleis";
            this.Gleis.Name = "Gleis";
            // 
            // An
            // 
            this.An.HeaderText = "An";
            this.An.Name = "An";
            // 
            // Gleis2
            // 
            this.Gleis2.HeaderText = "Gleis";
            this.Gleis2.Name = "Gleis2";
            // 
            // bAbfahrtsTafel
            // 
            this.bAbfahrtsTafel.Location = new System.Drawing.Point(409, 32);
            this.bAbfahrtsTafel.Name = "bAbfahrtsTafel";
            this.bAbfahrtsTafel.Size = new System.Drawing.Size(75, 23);
            this.bAbfahrtsTafel.TabIndex = 3;
            this.bAbfahrtsTafel.Text = "Abfahrtstafel";
            this.bAbfahrtsTafel.UseVisualStyleBackColor = true;
            this.bAbfahrtsTafel.Click += new System.EventHandler(this.bAbfahrtsTafel_Click);
            // 
            // Fahrplan
            // 
            this.AcceptButton = this.bSuche;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 358);
            this.Controls.Add(this.bAbfahrtsTafel);
            this.Controls.Add(this.dGResultate);
            this.Controls.Add(this.bSuche);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cNach);
            this.Controls.Add(this.cVon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Fahrplan";
            this.Text = "Fahrplan";
            ((System.ComponentModel.ISupportInitialize)(this.dGResultate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cVon;
        private System.Windows.Forms.ComboBox cNach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bSuche;
        private System.Windows.Forms.DataGridView dGResultate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ab;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gleis;
        private System.Windows.Forms.DataGridViewTextBoxColumn An;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gleis2;
        private System.Windows.Forms.Button bAbfahrtsTafel;
    }
}

