namespace WindowsForms
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.tlpValidations = new System.Windows.Forms.ToolTip(this.components);
            this.componentsToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.categoryCheckBox = new System.Windows.Forms.CheckBox();
            this.brandCheckBox = new System.Windows.Forms.CheckBox();
            this.roundPanel2 = new WindowsForms.RoundPanel();
            this.deleteImgButton = new System.Windows.Forms.Button();
            this.nextImgButton = new System.Windows.Forms.Button();
            this.prevImgButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.roundPanel1 = new WindowsForms.RoundPanel();
            this.imageTextBox = new System.Windows.Forms.TextBox();
            this.imageLabel = new System.Windows.Forms.Label();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.codeLabel = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.brandLabel = new System.Windows.Forms.Label();
            this.brandComboBox = new System.Windows.Forms.ComboBox();
            this.roundPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.roundPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(105)))), ((int)(((byte)(245)))));
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Image = global::WindowsForms.Properties.Resources.fi_save;
            this.saveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveButton.Location = new System.Drawing.Point(842, 435);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(160, 65);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Guardar";
            this.saveButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Transparent;
            this.cancelButton.FlatAppearance.BorderSize = 2;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(105)))), ((int)(((byte)(245)))));
            this.cancelButton.Image = global::WindowsForms.Properties.Resources.fi_slash;
            this.cancelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelButton.Location = new System.Drawing.Point(680, 435);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(156, 65);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancelar";
            this.cancelButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // tlpValidations
            // 
            this.tlpValidations.AutomaticDelay = 0;
            this.tlpValidations.IsBalloon = true;
            this.tlpValidations.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.tlpValidations.ToolTipTitle = "Verifique el campo";
            // 
            // categoryCheckBox
            // 
            this.categoryCheckBox.AutoSize = true;
            this.categoryCheckBox.Location = new System.Drawing.Point(443, 234);
            this.categoryCheckBox.Name = "categoryCheckBox";
            this.categoryCheckBox.Size = new System.Drawing.Size(99, 24);
            this.categoryCheckBox.TabIndex = 9;
            this.categoryCheckBox.Text = "En todos";
            this.componentsToolTip.SetToolTip(this.categoryCheckBox, "Editar esta categoría en todos los artículos que la tengan.");
            this.categoryCheckBox.UseVisualStyleBackColor = true;
            // 
            // brandCheckBox
            // 
            this.brandCheckBox.AutoSize = true;
            this.brandCheckBox.Location = new System.Drawing.Point(443, 185);
            this.brandCheckBox.Name = "brandCheckBox";
            this.brandCheckBox.Size = new System.Drawing.Size(99, 24);
            this.brandCheckBox.TabIndex = 8;
            this.brandCheckBox.Text = "En todos";
            this.componentsToolTip.SetToolTip(this.brandCheckBox, "Editar esta marca en todos los artículos que la tengan.");
            this.brandCheckBox.UseVisualStyleBackColor = true;
            // 
            // roundPanel2
            // 
            this.roundPanel2.BackColor = System.Drawing.Color.Transparent;
            this.roundPanel2.BackgroundColor = System.Drawing.Color.White;
            this.roundPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.roundPanel2.BorderWidth = 3F;
            this.roundPanel2.Controls.Add(this.deleteImgButton);
            this.roundPanel2.Controls.Add(this.nextImgButton);
            this.roundPanel2.Controls.Add(this.prevImgButton);
            this.roundPanel2.Controls.Add(this.pictureBox);
            this.roundPanel2.Location = new System.Drawing.Point(18, 18);
            this.roundPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roundPanel2.Name = "roundPanel2";
            this.roundPanel2.Radius = 10;
            this.roundPanel2.Size = new System.Drawing.Size(386, 395);
            this.roundPanel2.TabIndex = 2;
            // 
            // deleteImgButton
            // 
            this.deleteImgButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteImgButton.FlatAppearance.BorderSize = 2;
            this.deleteImgButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteImgButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteImgButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(105)))), ((int)(((byte)(245)))));
            this.deleteImgButton.Image = global::WindowsForms.Properties.Resources.fi_trash_2;
            this.deleteImgButton.Location = new System.Drawing.Point(162, 318);
            this.deleteImgButton.Name = "deleteImgButton";
            this.deleteImgButton.Size = new System.Drawing.Size(57, 58);
            this.deleteImgButton.TabIndex = 5;
            this.deleteImgButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteImgButton.UseVisualStyleBackColor = false;
            this.deleteImgButton.Click += new System.EventHandler(this.deleteImgButton_Click);
            // 
            // nextImgButton
            // 
            this.nextImgButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(105)))), ((int)(((byte)(245)))));
            this.nextImgButton.FlatAppearance.BorderSize = 2;
            this.nextImgButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextImgButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextImgButton.ForeColor = System.Drawing.Color.White;
            this.nextImgButton.Image = global::WindowsForms.Properties.Resources.fi_chevron_right_white;
            this.nextImgButton.Location = new System.Drawing.Point(262, 315);
            this.nextImgButton.Name = "nextImgButton";
            this.nextImgButton.Size = new System.Drawing.Size(60, 62);
            this.nextImgButton.TabIndex = 4;
            this.nextImgButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.nextImgButton.UseVisualStyleBackColor = false;
            this.nextImgButton.Click += new System.EventHandler(this.nextImgButton_Click);
            // 
            // prevImgButton
            // 
            this.prevImgButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(105)))), ((int)(((byte)(245)))));
            this.prevImgButton.FlatAppearance.BorderSize = 2;
            this.prevImgButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prevImgButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevImgButton.ForeColor = System.Drawing.Color.White;
            this.prevImgButton.Image = global::WindowsForms.Properties.Resources.fi_chevron_left_white;
            this.prevImgButton.Location = new System.Drawing.Point(58, 315);
            this.prevImgButton.Name = "prevImgButton";
            this.prevImgButton.Size = new System.Drawing.Size(60, 62);
            this.prevImgButton.TabIndex = 3;
            this.prevImgButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.prevImgButton.UseVisualStyleBackColor = false;
            this.prevImgButton.Click += new System.EventHandler(this.prevImgButton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(58, 37);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(266, 272);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // roundPanel1
            // 
            this.roundPanel1.BackColor = System.Drawing.Color.Transparent;
            this.roundPanel1.BackgroundColor = System.Drawing.Color.White;
            this.roundPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.roundPanel1.BorderWidth = 3F;
            this.roundPanel1.Controls.Add(this.categoryCheckBox);
            this.roundPanel1.Controls.Add(this.brandCheckBox);
            this.roundPanel1.Controls.Add(this.imageTextBox);
            this.roundPanel1.Controls.Add(this.imageLabel);
            this.roundPanel1.Controls.Add(this.codeTextBox);
            this.roundPanel1.Controls.Add(this.codeLabel);
            this.roundPanel1.Controls.Add(this.priceTextBox);
            this.roundPanel1.Controls.Add(this.descriptionLabel);
            this.roundPanel1.Controls.Add(this.priceLabel);
            this.roundPanel1.Controls.Add(this.nameLabel);
            this.roundPanel1.Controls.Add(this.categoryLabel);
            this.roundPanel1.Controls.Add(this.nameTextBox);
            this.roundPanel1.Controls.Add(this.categoryComboBox);
            this.roundPanel1.Controls.Add(this.descriptionTextBox);
            this.roundPanel1.Controls.Add(this.brandLabel);
            this.roundPanel1.Controls.Add(this.brandComboBox);
            this.roundPanel1.Location = new System.Drawing.Point(412, 18);
            this.roundPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roundPanel1.Name = "roundPanel1";
            this.roundPanel1.Radius = 10;
            this.roundPanel1.Size = new System.Drawing.Size(590, 395);
            this.roundPanel1.TabIndex = 0;
            // 
            // imageTextBox
            // 
            this.imageTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.imageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageTextBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageTextBox.Location = new System.Drawing.Point(200, 278);
            this.imageTextBox.Name = "imageTextBox";
            this.imageTextBox.Size = new System.Drawing.Size(340, 31);
            this.imageTextBox.TabIndex = 6;
            this.imageTextBox.TextChanged += new System.EventHandler(this.imageTextBox_TextChanged);
            this.imageTextBox.Leave += new System.EventHandler(this.imageTextBox_Leave);
            // 
            // imageLabel
            // 
            this.imageLabel.AutoSize = true;
            this.imageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.imageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.imageLabel.Location = new System.Drawing.Point(40, 278);
            this.imageLabel.Name = "imageLabel";
            this.imageLabel.Size = new System.Drawing.Size(93, 29);
            this.imageLabel.TabIndex = 7;
            this.imageLabel.Text = "Imágen";
            // 
            // codeTextBox
            // 
            this.codeTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.codeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.codeTextBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeTextBox.Location = new System.Drawing.Point(200, 37);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(340, 31);
            this.codeTextBox.TabIndex = 0;
            this.codeTextBox.TextChanged += new System.EventHandler(this.codeTextBox_TextChanged);
            this.codeTextBox.Leave += new System.EventHandler(this.codeTextBox_Leave);
            // 
            // codeLabel
            // 
            this.codeLabel.AutoSize = true;
            this.codeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.codeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.codeLabel.Location = new System.Drawing.Point(40, 37);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(92, 29);
            this.codeLabel.TabIndex = 5;
            this.codeLabel.Text = "Código";
            // 
            // priceTextBox
            // 
            this.priceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.priceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.priceTextBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTextBox.Location = new System.Drawing.Point(200, 326);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(340, 31);
            this.priceTextBox.TabIndex = 5;
            this.priceTextBox.Leave += new System.EventHandler(this.priceTextBox_Leave);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.descriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.descriptionLabel.Location = new System.Drawing.Point(40, 131);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(141, 29);
            this.descriptionLabel.TabIndex = 1;
            this.descriptionLabel.Text = "Descripción";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.priceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.priceLabel.Location = new System.Drawing.Point(40, 326);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(83, 29);
            this.priceLabel.TabIndex = 4;
            this.priceLabel.Text = "Precio";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.nameLabel.Location = new System.Drawing.Point(40, 82);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(101, 29);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Nombre";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.categoryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.categoryLabel.Location = new System.Drawing.Point(40, 232);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(118, 29);
            this.categoryLabel.TabIndex = 3;
            this.categoryLabel.Text = "Categoría";
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTextBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(200, 85);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(340, 31);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            this.nameTextBox.Leave += new System.EventHandler(this.nameTextBox_Leave);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.categoryComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.categoryComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.categoryComboBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(200, 229);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(224, 31);
            this.categoryComboBox.TabIndex = 4;
            this.categoryComboBox.TextChanged += new System.EventHandler(this.categoryComboBox_TextChanged);
            this.categoryComboBox.Leave += new System.EventHandler(this.categoryComboBox_Leave);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.descriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptionTextBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(200, 132);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(340, 31);
            this.descriptionTextBox.TabIndex = 2;
            this.descriptionTextBox.TextChanged += new System.EventHandler(this.descriptionTextBox_TextChanged);
            this.descriptionTextBox.Leave += new System.EventHandler(this.descriptionTextBox_Leave);
            // 
            // brandLabel
            // 
            this.brandLabel.AutoSize = true;
            this.brandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.brandLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.brandLabel.Location = new System.Drawing.Point(40, 182);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(79, 29);
            this.brandLabel.TabIndex = 2;
            this.brandLabel.Text = "Marca";
            // 
            // brandComboBox
            // 
            this.brandComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.brandComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.brandComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.brandComboBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandComboBox.FormattingEnabled = true;
            this.brandComboBox.Location = new System.Drawing.Point(200, 180);
            this.brandComboBox.Name = "brandComboBox";
            this.brandComboBox.Size = new System.Drawing.Size(224, 31);
            this.brandComboBox.TabIndex = 3;
            this.brandComboBox.TextChanged += new System.EventHandler(this.brandComboBox_TextChanged);
            this.brandComboBox.Leave += new System.EventHandler(this.brandComboBox_Leave);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1015, 512);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.roundPanel2);
            this.Controls.Add(this.roundPanel1);
            this.Controls.Add(this.saveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de artículo";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.roundPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.roundPanel1.ResumeLayout(false);
            this.roundPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.ComboBox brandComboBox;
        private System.Windows.Forms.Label brandLabel;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label priceLabel;
        private RoundPanel roundPanel1;
        private RoundPanel roundPanel2;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.Label codeLabel;
        private System.Windows.Forms.Label imageLabel;
        private System.Windows.Forms.TextBox imageTextBox;
        private System.Windows.Forms.ToolTip tlpValidations;
        private System.Windows.Forms.Button prevImgButton;
        private System.Windows.Forms.Button nextImgButton;
        private System.Windows.Forms.Button deleteImgButton;
        private System.Windows.Forms.CheckBox categoryCheckBox;
        private System.Windows.Forms.CheckBox brandCheckBox;
        private System.Windows.Forms.ToolTip componentsToolTip;
    }
}