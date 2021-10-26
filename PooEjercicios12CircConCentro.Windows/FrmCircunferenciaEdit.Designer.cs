
namespace PooEjercicios12CircConCentro.Windows
{
    partial class FrmCircunferenciaEdit
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
            this.components = new System.ComponentModel.Container();
            this.ColoresComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RayasRadioButton = new System.Windows.Forms.RadioButton();
            this.PuntosRadioButton = new System.Windows.Forms.RadioButton();
            this.SolidoRadioButton = new System.Windows.Forms.RadioButton();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.RadioTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.XTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.YTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OkBlutton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ColoresComboBox
            // 
            this.ColoresComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColoresComboBox.FormattingEnabled = true;
            this.ColoresComboBox.Location = new System.Drawing.Point(314, 160);
            this.ColoresComboBox.Name = "ColoresComboBox";
            this.ColoresComboBox.Size = new System.Drawing.Size(107, 21);
            this.ColoresComboBox.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RayasRadioButton);
            this.groupBox2.Controls.Add(this.PuntosRadioButton);
            this.groupBox2.Controls.Add(this.SolidoRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(273, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(162, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bordes";
            // 
            // RayasRadioButton
            // 
            this.RayasRadioButton.AutoSize = true;
            this.RayasRadioButton.Location = new System.Drawing.Point(17, 70);
            this.RayasRadioButton.Name = "RayasRadioButton";
            this.RayasRadioButton.Size = new System.Drawing.Size(62, 17);
            this.RayasRadioButton.TabIndex = 0;
            this.RayasRadioButton.Text = "Rayado";
            this.RayasRadioButton.UseVisualStyleBackColor = true;
            // 
            // PuntosRadioButton
            // 
            this.PuntosRadioButton.AutoSize = true;
            this.PuntosRadioButton.Location = new System.Drawing.Point(17, 47);
            this.PuntosRadioButton.Name = "PuntosRadioButton";
            this.PuntosRadioButton.Size = new System.Drawing.Size(71, 17);
            this.PuntosRadioButton.TabIndex = 2;
            this.PuntosRadioButton.Text = "Punteado";
            this.PuntosRadioButton.UseVisualStyleBackColor = true;
            // 
            // SolidoRadioButton
            // 
            this.SolidoRadioButton.AutoSize = true;
            this.SolidoRadioButton.Checked = true;
            this.SolidoRadioButton.Location = new System.Drawing.Point(17, 24);
            this.SolidoRadioButton.Name = "SolidoRadioButton";
            this.SolidoRadioButton.Size = new System.Drawing.Size(54, 17);
            this.SolidoRadioButton.TabIndex = 1;
            this.SolidoRadioButton.TabStop = true;
            this.SolidoRadioButton.Text = "Sólido";
            this.SolidoRadioButton.UseVisualStyleBackColor = true;
            // 
            // CancelarButton
            // 
            this.CancelarButton.Image = global::PooEjercicios12CircConCentro.Windows.Properties.Resources.Cancelar;
            this.CancelarButton.Location = new System.Drawing.Point(350, 204);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(85, 60);
            this.CancelarButton.TabIndex = 7;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CancelarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // RadioTextBox
            // 
            this.RadioTextBox.Location = new System.Drawing.Point(105, 160);
            this.RadioTextBox.Name = "RadioTextBox";
            this.RadioTextBox.Size = new System.Drawing.Size(100, 20);
            this.RadioTextBox.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(256, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Colores:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Radio:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.XTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.YTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(46, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Centro";
            // 
            // XTextBox
            // 
            this.XTextBox.Location = new System.Drawing.Point(69, 32);
            this.XTextBox.Name = "XTextBox";
            this.XTextBox.Size = new System.Drawing.Size(100, 20);
            this.XTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "X:";
            // 
            // YTextBox
            // 
            this.YTextBox.Location = new System.Drawing.Point(69, 69);
            this.YTextBox.Name = "YTextBox";
            this.YTextBox.Size = new System.Drawing.Size(100, 20);
            this.YTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Y:";
            // 
            // OkBlutton
            // 
            this.OkBlutton.Image = global::PooEjercicios12CircConCentro.Windows.Properties.Resources.Guardar;
            this.OkBlutton.Location = new System.Drawing.Point(36, 204);
            this.OkBlutton.Name = "OkBlutton";
            this.OkBlutton.Size = new System.Drawing.Size(86, 60);
            this.OkBlutton.TabIndex = 6;
            this.OkBlutton.Text = "OK";
            this.OkBlutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.OkBlutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.OkBlutton.UseVisualStyleBackColor = true;
            this.OkBlutton.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmCircunferenciaEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 299);
            this.ControlBox = false;
            this.Controls.Add(this.ColoresComboBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.OkBlutton);
            this.Controls.Add(this.RadioTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(488, 338);
            this.MinimumSize = new System.Drawing.Size(488, 338);
            this.Name = "FrmCircunferenciaEdit";
            this.Text = "FrmCircunferenciaEdit";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ColoresComboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RayasRadioButton;
        private System.Windows.Forms.RadioButton PuntosRadioButton;
        private System.Windows.Forms.RadioButton SolidoRadioButton;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button OkBlutton;
        private System.Windows.Forms.TextBox RadioTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox XTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox YTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}