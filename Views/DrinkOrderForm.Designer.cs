namespace FileHandler.Views
{
    partial class DrinkOrderForm
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
            label_enterDrinkName = new ReaLTaiizor.Controls.MaterialLabel();
            textBox_drinkName = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            label_sugar = new ReaLTaiizor.Controls.MaterialLabel();
            comboBox_sugar = new ReaLTaiizor.Controls.MaterialComboBox();
            comboBox_coffee = new ReaLTaiizor.Controls.MaterialComboBox();
            label_coffee = new ReaLTaiizor.Controls.MaterialLabel();
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            comboBox_milk = new ReaLTaiizor.Controls.MaterialComboBox();
            label_milk = new ReaLTaiizor.Controls.MaterialLabel();
            textbox_price = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            groupbox_details = new ReaLTaiizor.Controls.ParrotGroupBox();
            label_add = new Label();
            groupbox_portions = new ReaLTaiizor.Controls.ParrotGroupBox();
            dataGridView_drinks = new DataGridView();
            groupbox_details.SuspendLayout();
            groupbox_portions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_drinks).BeginInit();
            SuspendLayout();
            // 
            // label_enterDrinkName
            // 
            label_enterDrinkName.AutoSize = true;
            label_enterDrinkName.Depth = 0;
            label_enterDrinkName.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label_enterDrinkName.Location = new Point(24, 21);
            label_enterDrinkName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            label_enterDrinkName.Name = "label_enterDrinkName";
            label_enterDrinkName.Size = new Size(120, 19);
            label_enterDrinkName.TabIndex = 0;
            label_enterDrinkName.Text = "Enter drink name";
            // 
            // textBox_drinkName
            // 
            textBox_drinkName.AnimateReadOnly = false;
            textBox_drinkName.AutoCompleteMode = AutoCompleteMode.None;
            textBox_drinkName.AutoCompleteSource = AutoCompleteSource.None;
            textBox_drinkName.BackgroundImageLayout = ImageLayout.None;
            textBox_drinkName.CharacterCasing = CharacterCasing.Normal;
            textBox_drinkName.Depth = 0;
            textBox_drinkName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textBox_drinkName.HideSelection = true;
            textBox_drinkName.LeadingIcon = null;
            textBox_drinkName.Location = new Point(24, 41);
            textBox_drinkName.MaxLength = 32767;
            textBox_drinkName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            textBox_drinkName.Name = "textBox_drinkName";
            textBox_drinkName.PasswordChar = '\0';
            textBox_drinkName.PrefixSuffixText = null;
            textBox_drinkName.ReadOnly = false;
            textBox_drinkName.RightToLeft = RightToLeft.No;
            textBox_drinkName.SelectedText = "";
            textBox_drinkName.SelectionLength = 0;
            textBox_drinkName.SelectionStart = 0;
            textBox_drinkName.ShortcutsEnabled = true;
            textBox_drinkName.Size = new Size(165, 48);
            textBox_drinkName.TabIndex = 1;
            textBox_drinkName.TabStop = false;
            textBox_drinkName.TextAlign = HorizontalAlignment.Left;
            textBox_drinkName.TrailingIcon = null;
            textBox_drinkName.UseSystemPasswordChar = false;
            // 
            // label_sugar
            // 
            label_sugar.AutoSize = true;
            label_sugar.Depth = 0;
            label_sugar.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label_sugar.Location = new Point(24, 128);
            label_sugar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            label_sugar.Name = "label_sugar";
            label_sugar.Size = new Size(43, 19);
            label_sugar.TabIndex = 2;
            label_sugar.Text = "Sugar";
            // 
            // comboBox_sugar
            // 
            comboBox_sugar.AutoResize = false;
            comboBox_sugar.BackColor = Color.FromArgb(255, 255, 255);
            comboBox_sugar.Depth = 0;
            comboBox_sugar.DrawMode = DrawMode.OwnerDrawVariable;
            comboBox_sugar.DropDownHeight = 174;
            comboBox_sugar.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_sugar.DropDownWidth = 121;
            comboBox_sugar.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            comboBox_sugar.ForeColor = Color.FromArgb(222, 0, 0, 0);
            comboBox_sugar.FormattingEnabled = true;
            comboBox_sugar.IntegralHeight = false;
            comboBox_sugar.ItemHeight = 43;
            comboBox_sugar.Location = new Point(24, 150);
            comboBox_sugar.MaxDropDownItems = 4;
            comboBox_sugar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            comboBox_sugar.Name = "comboBox_sugar";
            comboBox_sugar.Size = new Size(165, 49);
            comboBox_sugar.StartIndex = 0;
            comboBox_sugar.TabIndex = 3;
            // 
            // comboBox_coffee
            // 
            comboBox_coffee.AutoResize = false;
            comboBox_coffee.BackColor = Color.FromArgb(255, 255, 255);
            comboBox_coffee.Depth = 0;
            comboBox_coffee.DrawMode = DrawMode.OwnerDrawVariable;
            comboBox_coffee.DropDownHeight = 174;
            comboBox_coffee.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_coffee.DropDownWidth = 121;
            comboBox_coffee.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            comboBox_coffee.ForeColor = Color.FromArgb(222, 0, 0, 0);
            comboBox_coffee.FormattingEnabled = true;
            comboBox_coffee.IntegralHeight = false;
            comboBox_coffee.ItemHeight = 43;
            comboBox_coffee.Location = new Point(24, 60);
            comboBox_coffee.MaxDropDownItems = 4;
            comboBox_coffee.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            comboBox_coffee.Name = "comboBox_coffee";
            comboBox_coffee.Size = new Size(165, 49);
            comboBox_coffee.StartIndex = 0;
            comboBox_coffee.TabIndex = 5;
            // 
            // label_coffee
            // 
            label_coffee.AutoSize = true;
            label_coffee.Depth = 0;
            label_coffee.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label_coffee.Location = new Point(24, 38);
            label_coffee.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            label_coffee.Name = "label_coffee";
            label_coffee.Size = new Size(48, 19);
            label_coffee.TabIndex = 4;
            label_coffee.Text = "Coffee";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(246, 19);
            materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(36, 19);
            materialLabel1.TabIndex = 8;
            materialLabel1.Text = "Price";
            // 
            // comboBox_milk
            // 
            comboBox_milk.AutoResize = false;
            comboBox_milk.BackColor = Color.FromArgb(255, 255, 255);
            comboBox_milk.Depth = 0;
            comboBox_milk.DrawMode = DrawMode.OwnerDrawVariable;
            comboBox_milk.DropDownHeight = 174;
            comboBox_milk.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_milk.DropDownWidth = 121;
            comboBox_milk.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            comboBox_milk.ForeColor = Color.FromArgb(222, 0, 0, 0);
            comboBox_milk.FormattingEnabled = true;
            comboBox_milk.IntegralHeight = false;
            comboBox_milk.ItemHeight = 43;
            comboBox_milk.Location = new Point(24, 238);
            comboBox_milk.MaxDropDownItems = 4;
            comboBox_milk.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            comboBox_milk.Name = "comboBox_milk";
            comboBox_milk.Size = new Size(165, 49);
            comboBox_milk.StartIndex = 0;
            comboBox_milk.TabIndex = 7;
            // 
            // label_milk
            // 
            label_milk.AutoSize = true;
            label_milk.Depth = 0;
            label_milk.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label_milk.Location = new Point(24, 216);
            label_milk.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            label_milk.Name = "label_milk";
            label_milk.Size = new Size(31, 19);
            label_milk.TabIndex = 6;
            label_milk.Text = "Milk";
            // 
            // textbox_price
            // 
            textbox_price.AnimateReadOnly = false;
            textbox_price.AutoCompleteMode = AutoCompleteMode.None;
            textbox_price.AutoCompleteSource = AutoCompleteSource.None;
            textbox_price.BackgroundImageLayout = ImageLayout.None;
            textbox_price.CharacterCasing = CharacterCasing.Normal;
            textbox_price.Depth = 0;
            textbox_price.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textbox_price.HideSelection = true;
            textbox_price.LeadingIcon = null;
            textbox_price.Location = new Point(246, 42);
            textbox_price.MaxLength = 32767;
            textbox_price.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            textbox_price.Name = "textbox_price";
            textbox_price.PasswordChar = '\0';
            textbox_price.PrefixSuffixText = null;
            textbox_price.ReadOnly = false;
            textbox_price.RightToLeft = RightToLeft.No;
            textbox_price.SelectedText = "";
            textbox_price.SelectionLength = 0;
            textbox_price.SelectionStart = 0;
            textbox_price.ShortcutsEnabled = true;
            textbox_price.Size = new Size(165, 48);
            textbox_price.TabIndex = 9;
            textbox_price.TabStop = false;
            textbox_price.TextAlign = HorizontalAlignment.Left;
            textbox_price.TrailingIcon = null;
            textbox_price.UseSystemPasswordChar = false;
            textbox_price.KeyPress += textbox_price_KeyPress;
            // 
            // groupbox_details
            // 
            groupbox_details.BorderColor = Color.DodgerBlue;
            groupbox_details.BorderWidth = 1;
            groupbox_details.Controls.Add(label_add);
            groupbox_details.Controls.Add(textbox_price);
            groupbox_details.Controls.Add(textBox_drinkName);
            groupbox_details.Controls.Add(materialLabel1);
            groupbox_details.Controls.Add(label_enterDrinkName);
            groupbox_details.Location = new Point(19, 86);
            groupbox_details.Name = "groupbox_details";
            groupbox_details.ShowText = true;
            groupbox_details.Size = new Size(738, 106);
            groupbox_details.TabIndex = 11;
            groupbox_details.TabStop = false;
            groupbox_details.Text = "Details";
            groupbox_details.TextColor = Color.DodgerBlue;
            // 
            // label_add
            // 
            label_add.AutoSize = true;
            label_add.BackColor = Color.FromArgb(0, 192, 0);
            label_add.BorderStyle = BorderStyle.FixedSingle;
            label_add.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_add.ForeColor = SystemColors.ButtonHighlight;
            label_add.Location = new Point(567, 40);
            label_add.MinimumSize = new Size(165, 49);
            label_add.Name = "label_add";
            label_add.Size = new Size(165, 49);
            label_add.TabIndex = 13;
            label_add.Text = "Add";
            label_add.TextAlign = ContentAlignment.MiddleCenter;
            label_add.Click += label_add_Click;
            // 
            // groupbox_portions
            // 
            groupbox_portions.BorderColor = Color.DodgerBlue;
            groupbox_portions.BorderWidth = 1;
            groupbox_portions.Controls.Add(comboBox_milk);
            groupbox_portions.Controls.Add(label_sugar);
            groupbox_portions.Controls.Add(label_milk);
            groupbox_portions.Controls.Add(comboBox_sugar);
            groupbox_portions.Controls.Add(comboBox_coffee);
            groupbox_portions.Controls.Add(label_coffee);
            groupbox_portions.Location = new Point(19, 218);
            groupbox_portions.Name = "groupbox_portions";
            groupbox_portions.ShowText = true;
            groupbox_portions.Size = new Size(225, 357);
            groupbox_portions.TabIndex = 12;
            groupbox_portions.TabStop = false;
            groupbox_portions.Text = "Portions";
            groupbox_portions.TextColor = Color.DodgerBlue;
            // 
            // dataGridView_drinks
            // 
            dataGridView_drinks.AllowUserToAddRows = false;
            dataGridView_drinks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_drinks.Location = new Point(265, 225);
            dataGridView_drinks.Name = "dataGridView_drinks";
            dataGridView_drinks.ReadOnly = true;
            dataGridView_drinks.Size = new Size(492, 350);
            dataGridView_drinks.TabIndex = 13;
            dataGridView_drinks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // 
            // DrinkOrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 631);
            Controls.Add(dataGridView_drinks);
            Controls.Add(groupbox_portions);
            Controls.Add(groupbox_details);
            Name = "DrinkOrderForm";
            Text = "DrinkOrderForm";
            groupbox_details.ResumeLayout(false);
            groupbox_details.PerformLayout();
            groupbox_portions.ResumeLayout(false);
            groupbox_portions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_drinks).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialLabel label_enterDrinkName;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit textBox_drinkName;
        private ReaLTaiizor.Controls.MaterialLabel label_sugar;
        private ReaLTaiizor.Controls.MaterialComboBox comboBox_sugar;
        private ReaLTaiizor.Controls.MaterialComboBox comboBox_coffee;
        private ReaLTaiizor.Controls.MaterialLabel label_coffee;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private ReaLTaiizor.Controls.MaterialComboBox comboBox_milk;
        private ReaLTaiizor.Controls.MaterialLabel label_milk;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit textbox_price;
        private ReaLTaiizor.Controls.ParrotGroupBox groupbox_details;
        private ReaLTaiizor.Controls.ParrotGroupBox groupbox_portions;
        private Label label_add;
        private DataGridView dataGridView_drinks;
    }
}