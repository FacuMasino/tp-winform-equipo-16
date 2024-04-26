namespace WindowsForms
{
    partial class CatalogForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.roundPanel3 = new WindowsForms.RoundPanel();
            this.idLabel = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.brandLabel = new System.Windows.Forms.Label();
            this.roundPanel2 = new WindowsForms.RoundPanel();
            this.newButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.filterTextBox = new System.Windows.Forms.TextBox();
            this.filterLabel = new System.Windows.Forms.Label();
            this.roundPanel1 = new WindowsForms.RoundPanel();
            this.dataGridViewTitle = new System.Windows.Forms.Label();
            this.ArticlesdataGridView = new System.Windows.Forms.DataGridView();
            this.roundPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.roundPanel2.SuspendLayout();
            this.roundPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ArticlesdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // roundPanel3
            // 
            this.roundPanel3.BackColor = System.Drawing.Color.Transparent;
            this.roundPanel3.BackgroundColor = System.Drawing.Color.White;
            this.roundPanel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.roundPanel3.BorderWidth = 3F;
            this.roundPanel3.Controls.Add(this.idLabel);
            this.roundPanel3.Controls.Add(this.pictureBox);
            this.roundPanel3.Controls.Add(this.priceLabel);
            this.roundPanel3.Controls.Add(this.nameLabel);
            this.roundPanel3.Controls.Add(this.categoryLabel);
            this.roundPanel3.Controls.Add(this.descriptionLabel);
            this.roundPanel3.Controls.Add(this.brandLabel);
            this.roundPanel3.Location = new System.Drawing.Point(12, 10);
            this.roundPanel3.Name = "roundPanel3";
            this.roundPanel3.Radius = 10;
            this.roundPanel3.Size = new System.Drawing.Size(418, 201);
            this.roundPanel3.TabIndex = 11;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.idLabel.Location = new System.Drawing.Point(184, 19);
            this.idLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(22, 18);
            this.idLabel.TabIndex = 16;
            this.idLabel.Text = "ID";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(19, 17);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(150, 164);
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.priceLabel.Location = new System.Drawing.Point(184, 164);
            this.priceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(51, 18);
            this.priceLabel.TabIndex = 15;
            this.priceLabel.Text = "Precio";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.nameLabel.Location = new System.Drawing.Point(184, 48);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(62, 18);
            this.nameLabel.TabIndex = 11;
            this.nameLabel.Text = "Nombre";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.categoryLabel.Location = new System.Drawing.Point(184, 135);
            this.categoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(72, 18);
            this.categoryLabel.TabIndex = 14;
            this.categoryLabel.Text = "Categoría";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.descriptionLabel.Location = new System.Drawing.Point(184, 77);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(87, 18);
            this.descriptionLabel.TabIndex = 12;
            this.descriptionLabel.Text = "Descripción";
            // 
            // brandLabel
            // 
            this.brandLabel.AutoSize = true;
            this.brandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.brandLabel.Location = new System.Drawing.Point(184, 106);
            this.brandLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(50, 18);
            this.brandLabel.TabIndex = 13;
            this.brandLabel.Text = "Marca";
            // 
            // roundPanel2
            // 
            this.roundPanel2.BackColor = System.Drawing.Color.Transparent;
            this.roundPanel2.BackgroundColor = System.Drawing.Color.White;
            this.roundPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.roundPanel2.BorderWidth = 3F;
            this.roundPanel2.Controls.Add(this.newButton);
            this.roundPanel2.Controls.Add(this.editButton);
            this.roundPanel2.Controls.Add(this.deleteButton);
            this.roundPanel2.Controls.Add(this.clearButton);
            this.roundPanel2.Controls.Add(this.filterTextBox);
            this.roundPanel2.Controls.Add(this.filterLabel);
            this.roundPanel2.Location = new System.Drawing.Point(436, 10);
            this.roundPanel2.Name = "roundPanel2";
            this.roundPanel2.Radius = 10;
            this.roundPanel2.Size = new System.Drawing.Size(348, 201);
            this.roundPanel2.TabIndex = 10;
            // 
            // newButton
            // 
            this.newButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(105)))), ((int)(((byte)(245)))));
            this.newButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.newButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newButton.ForeColor = System.Drawing.Color.White;
            this.newButton.Image = global::WindowsForms.Properties.Resources.fi_plus;
            this.newButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newButton.Location = new System.Drawing.Point(26, 20);
            this.newButton.Margin = new System.Windows.Forms.Padding(2);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(96, 42);
            this.newButton.TabIndex = 2;
            this.newButton.Text = "Nuevo";
            this.newButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.newButton.UseVisualStyleBackColor = false;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.Transparent;
            this.editButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(105)))), ((int)(((byte)(245)))));
            this.editButton.FlatAppearance.BorderSize = 2;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(105)))), ((int)(((byte)(245)))));
            this.editButton.Image = global::WindowsForms.Properties.Resources.fi_edit_3_primary;
            this.editButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editButton.Location = new System.Drawing.Point(137, 20);
            this.editButton.Margin = new System.Windows.Forms.Padding(2);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(94, 42);
            this.editButton.TabIndex = 3;
            this.editButton.Text = "Editar";
            this.editButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(105)))), ((int)(((byte)(245)))));
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Image = global::WindowsForms.Properties.Resources.fi_x;
            this.deleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteButton.Location = new System.Drawing.Point(250, 20);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(96, 42);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Eliminar";
            this.deleteButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Transparent;
            this.clearButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(105)))), ((int)(((byte)(245)))));
            this.clearButton.FlatAppearance.BorderSize = 2;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(105)))), ((int)(((byte)(245)))));
            this.clearButton.Image = global::WindowsForms.Properties.Resources.fluent__broom_20_regular;
            this.clearButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clearButton.Location = new System.Drawing.Point(252, 82);
            this.clearButton.Margin = new System.Windows.Forms.Padding(2);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(94, 42);
            this.clearButton.TabIndex = 14;
            this.clearButton.Text = "Limpiar";
            this.clearButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // filterTextBox
            // 
            this.filterTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.filterTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filterTextBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterTextBox.Location = new System.Drawing.Point(85, 89);
            this.filterTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(146, 23);
            this.filterTextBox.TabIndex = 12;
            this.filterTextBox.TextChanged += new System.EventHandler(this.filterTextBox_TextChanged);
            // 
            // filterLabel
            // 
            this.filterLabel.AutoSize = true;
            this.filterLabel.BackColor = System.Drawing.Color.Transparent;
            this.filterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.filterLabel.Location = new System.Drawing.Point(23, 94);
            this.filterLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.filterLabel.Name = "filterLabel";
            this.filterLabel.Size = new System.Drawing.Size(45, 18);
            this.filterLabel.TabIndex = 13;
            this.filterLabel.Text = "Filtrar";
            // 
            // roundPanel1
            // 
            this.roundPanel1.BackColor = System.Drawing.Color.Transparent;
            this.roundPanel1.BackgroundColor = System.Drawing.Color.White;
            this.roundPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.roundPanel1.BorderWidth = 3F;
            this.roundPanel1.Controls.Add(this.dataGridViewTitle);
            this.roundPanel1.Controls.Add(this.ArticlesdataGridView);
            this.roundPanel1.Location = new System.Drawing.Point(12, 218);
            this.roundPanel1.Name = "roundPanel1";
            this.roundPanel1.Radius = 10;
            this.roundPanel1.Size = new System.Drawing.Size(772, 346);
            this.roundPanel1.TabIndex = 9;
            // 
            // dataGridViewTitle
            // 
            this.dataGridViewTitle.AutoSize = true;
            this.dataGridViewTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.dataGridViewTitle.Location = new System.Drawing.Point(15, 15);
            this.dataGridViewTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dataGridViewTitle.Name = "dataGridViewTitle";
            this.dataGridViewTitle.Size = new System.Drawing.Size(147, 18);
            this.dataGridViewTitle.TabIndex = 15;
            this.dataGridViewTitle.Text = "Listado de productos";
            // 
            // ArticlesdataGridView
            // 
            this.ArticlesdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ArticlesdataGridView.BackgroundColor = System.Drawing.Color.White;
            this.ArticlesdataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ArticlesdataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ArticlesdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(112)))), ((int)(((byte)(121)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ArticlesdataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.ArticlesdataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ArticlesdataGridView.GridColor = System.Drawing.Color.Silver;
            this.ArticlesdataGridView.Location = new System.Drawing.Point(19, 47);
            this.ArticlesdataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.ArticlesdataGridView.MultiSelect = false;
            this.ArticlesdataGridView.Name = "ArticlesdataGridView";
            this.ArticlesdataGridView.RowHeadersWidth = 51;
            this.ArticlesdataGridView.RowTemplate.Height = 24;
            this.ArticlesdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ArticlesdataGridView.Size = new System.Drawing.Size(731, 285);
            this.ArticlesdataGridView.TabIndex = 6;
            this.ArticlesdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(797, 576);
            this.Controls.Add(this.roundPanel3);
            this.Controls.Add(this.roundPanel2);
            this.Controls.Add(this.roundPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CatalogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catálogo";
            this.Load += new System.EventHandler(this.CatalogForm_Load);
            this.roundPanel3.ResumeLayout(false);
            this.roundPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.roundPanel2.ResumeLayout(false);
            this.roundPanel2.PerformLayout();
            this.roundPanel1.ResumeLayout(false);
            this.roundPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ArticlesdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.DataGridView ArticlesdataGridView;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label brandLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox filterTextBox;
        private System.Windows.Forms.Label filterLabel;
        private System.Windows.Forms.Button clearButton;
        private RoundPanel roundPanel1;
        private System.Windows.Forms.Label dataGridViewTitle;
        private RoundPanel roundPanel2;
        private RoundPanel roundPanel3;
    }
}