namespace Taxikosten
{
    partial class Taxikosten
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
            this.textBeginstand = new System.Windows.Forms.TextBox();
            this.textEindstand = new System.Windows.Forms.TextBox();
            this.textRitafstand = new System.Windows.Forms.TextBox();
            this.textBegintijd = new System.Windows.Forms.TextBox();
            this.textEindtijd = new System.Windows.Forms.TextBox();
            this.textDag = new System.Windows.Forms.TextBox();
            this.Begintijd = new System.Windows.Forms.DateTimePicker();
            this.Eindtijd = new System.Windows.Forms.DateTimePicker();
            this.Ritprijs = new System.Windows.Forms.Button();
            this.textboxRitprijs = new System.Windows.Forms.TextBox();
            this.Dag = new System.Windows.Forms.DateTimePicker();
            this.textRitduur = new System.Windows.Forms.TextBox();
            this.Beginstand = new System.Windows.Forms.NumericUpDown();
            this.Eindstand = new System.Windows.Forms.NumericUpDown();
            this.Ritafstand = new System.Windows.Forms.NumericUpDown();
            this.Ritduur = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Beginstand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Eindstand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ritafstand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ritduur)).BeginInit();
            this.SuspendLayout();
            // 
            // textBeginstand
            // 
            this.textBeginstand.Location = new System.Drawing.Point(12, 37);
            this.textBeginstand.Name = "textBeginstand";
            this.textBeginstand.ReadOnly = true;
            this.textBeginstand.Size = new System.Drawing.Size(165, 20);
            this.textBeginstand.TabIndex = 5;
            this.textBeginstand.Text = "Beginstand Kilometerteller (km)";
            this.textBeginstand.TextChanged += new System.EventHandler(this.textBeginstand_TextChanged);
            // 
            // textEindstand
            // 
            this.textEindstand.Location = new System.Drawing.Point(12, 63);
            this.textEindstand.Name = "textEindstand";
            this.textEindstand.ReadOnly = true;
            this.textEindstand.Size = new System.Drawing.Size(165, 20);
            this.textEindstand.TabIndex = 6;
            this.textEindstand.Text = "Eindstand Kilometerteller (km)";
            this.textEindstand.TextChanged += new System.EventHandler(this.textEindstand_TextChanged);
            // 
            // textRitafstand
            // 
            this.textRitafstand.Location = new System.Drawing.Point(12, 89);
            this.textRitafstand.Name = "textRitafstand";
            this.textRitafstand.ReadOnly = true;
            this.textRitafstand.Size = new System.Drawing.Size(165, 20);
            this.textRitafstand.TabIndex = 7;
            this.textRitafstand.Text = "Ritafstand (km)";
            this.textRitafstand.TextChanged += new System.EventHandler(this.textRitafstand_TextChanged);
            // 
            // textBegintijd
            // 
            this.textBegintijd.Location = new System.Drawing.Point(12, 115);
            this.textBegintijd.Name = "textBegintijd";
            this.textBegintijd.ReadOnly = true;
            this.textBegintijd.Size = new System.Drawing.Size(165, 20);
            this.textBegintijd.TabIndex = 8;
            this.textBegintijd.Text = "Begintijd";
            this.textBegintijd.TextChanged += new System.EventHandler(this.textBegintijd_TextChanged);
            // 
            // textEindtijd
            // 
            this.textEindtijd.Location = new System.Drawing.Point(12, 141);
            this.textEindtijd.Name = "textEindtijd";
            this.textEindtijd.ReadOnly = true;
            this.textEindtijd.Size = new System.Drawing.Size(165, 20);
            this.textEindtijd.TabIndex = 9;
            this.textEindtijd.Text = "Eindtijd";
            this.textEindtijd.TextChanged += new System.EventHandler(this.textEindtijd_TextChanged);
            // 
            // textDag
            // 
            this.textDag.Location = new System.Drawing.Point(12, 193);
            this.textDag.Name = "textDag";
            this.textDag.ReadOnly = true;
            this.textDag.Size = new System.Drawing.Size(165, 20);
            this.textDag.TabIndex = 11;
            this.textDag.Text = "Dag";
            this.textDag.TextChanged += new System.EventHandler(this.textDag_TextChanged);
            // 
            // Begintijd
            // 
            this.Begintijd.Checked = false;
            this.Begintijd.CustomFormat = "HH:mm";
            this.Begintijd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Begintijd.Location = new System.Drawing.Point(219, 115);
            this.Begintijd.Name = "Begintijd";
            this.Begintijd.ShowUpDown = true;
            this.Begintijd.Size = new System.Drawing.Size(189, 20);
            this.Begintijd.TabIndex = 12;
            this.Begintijd.ValueChanged += new System.EventHandler(this.Begintijd_ValueChanged);
            // 
            // Eindtijd
            // 
            this.Eindtijd.CustomFormat = "HH:mm";
            this.Eindtijd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Eindtijd.Location = new System.Drawing.Point(219, 141);
            this.Eindtijd.Name = "Eindtijd";
            this.Eindtijd.ShowUpDown = true;
            this.Eindtijd.Size = new System.Drawing.Size(189, 20);
            this.Eindtijd.TabIndex = 13;
            this.Eindtijd.ValueChanged += new System.EventHandler(this.Eindtijd_ValueChanged);
            // 
            // Ritprijs
            // 
            this.Ritprijs.Location = new System.Drawing.Point(118, 219);
            this.Ritprijs.Name = "Ritprijs";
            this.Ritprijs.Size = new System.Drawing.Size(165, 32);
            this.Ritprijs.TabIndex = 14;
            this.Ritprijs.Text = "Ritprijs";
            this.Ritprijs.UseVisualStyleBackColor = true;
            this.Ritprijs.Click += new System.EventHandler(this.Ritprijs_Click);
            // 
            // textboxRitprijs
            // 
            this.textboxRitprijs.BackColor = System.Drawing.SystemColors.Window;
            this.textboxRitprijs.Location = new System.Drawing.Point(118, 257);
            this.textboxRitprijs.Name = "textboxRitprijs";
            this.textboxRitprijs.ReadOnly = true;
            this.textboxRitprijs.Size = new System.Drawing.Size(165, 20);
            this.textboxRitprijs.TabIndex = 15;
            this.textboxRitprijs.TextChanged += new System.EventHandler(this.textboxRitprijs_TextChanged);
            // 
            // Dag
            // 
            this.Dag.CustomFormat = "dddd";
            this.Dag.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dag.Location = new System.Drawing.Point(219, 193);
            this.Dag.Name = "Dag";
            this.Dag.Size = new System.Drawing.Size(189, 20);
            this.Dag.TabIndex = 16;
            this.Dag.ValueChanged += new System.EventHandler(this.Dag_ValueChanged);
            // 
            // textRitduur
            // 
            this.textRitduur.Location = new System.Drawing.Point(12, 167);
            this.textRitduur.Name = "textRitduur";
            this.textRitduur.ReadOnly = true;
            this.textRitduur.Size = new System.Drawing.Size(165, 20);
            this.textRitduur.TabIndex = 18;
            this.textRitduur.Text = "Ritduur (minuten)";
            this.textRitduur.TextChanged += new System.EventHandler(this.textRitduur_TextChanged);
            // 
            // Beginstand
            // 
            this.Beginstand.Location = new System.Drawing.Point(219, 37);
            this.Beginstand.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.Beginstand.Name = "Beginstand";
            this.Beginstand.Size = new System.Drawing.Size(189, 20);
            this.Beginstand.TabIndex = 19;
            this.Beginstand.ValueChanged += new System.EventHandler(this.Beginstand_ValueChanged);
            // 
            // Eindstand
            // 
            this.Eindstand.Location = new System.Drawing.Point(219, 63);
            this.Eindstand.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.Eindstand.Name = "Eindstand";
            this.Eindstand.Size = new System.Drawing.Size(189, 20);
            this.Eindstand.TabIndex = 20;
            this.Eindstand.ValueChanged += new System.EventHandler(this.Eindstand_ValueChanged);
            // 
            // Ritafstand
            // 
            this.Ritafstand.Location = new System.Drawing.Point(219, 89);
            this.Ritafstand.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.Ritafstand.Name = "Ritafstand";
            this.Ritafstand.Size = new System.Drawing.Size(189, 20);
            this.Ritafstand.TabIndex = 21;
            this.Ritafstand.ValueChanged += new System.EventHandler(this.Ritafstand_ValueChanged);
            // 
            // Ritduur
            // 
            this.Ritduur.Location = new System.Drawing.Point(219, 167);
            this.Ritduur.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.Ritduur.Name = "Ritduur";
            this.Ritduur.ReadOnly = true;
            this.Ritduur.Size = new System.Drawing.Size(189, 20);
            this.Ritduur.TabIndex = 22;
            this.Ritduur.ValueChanged += new System.EventHandler(this.Ritduur_ValueChanged);
            // 
            // Taxikosten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 289);
            this.Controls.Add(this.Ritduur);
            this.Controls.Add(this.Ritafstand);
            this.Controls.Add(this.Eindstand);
            this.Controls.Add(this.Beginstand);
            this.Controls.Add(this.textRitduur);
            this.Controls.Add(this.Dag);
            this.Controls.Add(this.textboxRitprijs);
            this.Controls.Add(this.Ritprijs);
            this.Controls.Add(this.Eindtijd);
            this.Controls.Add(this.Begintijd);
            this.Controls.Add(this.textDag);
            this.Controls.Add(this.textEindtijd);
            this.Controls.Add(this.textBegintijd);
            this.Controls.Add(this.textRitafstand);
            this.Controls.Add(this.textEindstand);
            this.Controls.Add(this.textBeginstand);
            this.Name = "Taxikosten";
            this.Text = "Taxikosten";
            ((System.ComponentModel.ISupportInitialize)(this.Beginstand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Eindstand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ritafstand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ritduur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBeginstand;
        private System.Windows.Forms.TextBox textEindstand;
        private System.Windows.Forms.TextBox textRitafstand;
        private System.Windows.Forms.TextBox textBegintijd;
        private System.Windows.Forms.TextBox textEindtijd;
        private System.Windows.Forms.TextBox textDag;
        private System.Windows.Forms.DateTimePicker Begintijd;
        private System.Windows.Forms.Button Ritprijs;
        private System.Windows.Forms.TextBox textboxRitprijs;
        private System.Windows.Forms.DateTimePicker Eindtijd;
        private System.Windows.Forms.DateTimePicker Dag;
        private System.Windows.Forms.TextBox textRitduur;
        private System.Windows.Forms.NumericUpDown Beginstand;
        private System.Windows.Forms.NumericUpDown Eindstand;
        private System.Windows.Forms.NumericUpDown Ritafstand;
        private System.Windows.Forms.NumericUpDown Ritduur;
    }
}

