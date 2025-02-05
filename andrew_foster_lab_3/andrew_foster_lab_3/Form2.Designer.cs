namespace andrew_foster_lab_3
{
    partial class stateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stateForm));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label populationLabel;
            System.Windows.Forms.Label flagLabel;
            System.Windows.Forms.Label flowerLabel;
            System.Windows.Forms.Label birdLabel;
            System.Windows.Forms.Label colorsLabel;
            System.Windows.Forms.Label capitolLabel;
            System.Windows.Forms.Label first_CityLabel;
            System.Windows.Forms.Label second_CityLabel;
            System.Windows.Forms.Label third_CityLabel;
            System.Windows.Forms.Label iT_JobsLabel;
            this.statesDataSet = new andrew_foster_lab_3.statesDataSet();
            this.statesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statesTableAdapter = new andrew_foster_lab_3.statesDataSetTableAdapters.StatesTableAdapter();
            this.tableAdapterManager = new andrew_foster_lab_3.statesDataSetTableAdapters.TableAdapterManager();
            this.statesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.statesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.populationTextBox = new System.Windows.Forms.TextBox();
            this.flagTextBox = new System.Windows.Forms.TextBox();
            this.flowerTextBox = new System.Windows.Forms.TextBox();
            this.birdTextBox = new System.Windows.Forms.TextBox();
            this.colorsTextBox = new System.Windows.Forms.TextBox();
            this.capitolTextBox = new System.Windows.Forms.TextBox();
            this.first_CityTextBox = new System.Windows.Forms.TextBox();
            this.second_CityTextBox = new System.Windows.Forms.TextBox();
            this.third_CityTextBox = new System.Windows.Forms.TextBox();
            this.iT_JobsTextBox = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            idLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            populationLabel = new System.Windows.Forms.Label();
            flagLabel = new System.Windows.Forms.Label();
            flowerLabel = new System.Windows.Forms.Label();
            birdLabel = new System.Windows.Forms.Label();
            colorsLabel = new System.Windows.Forms.Label();
            capitolLabel = new System.Windows.Forms.Label();
            first_CityLabel = new System.Windows.Forms.Label();
            second_CityLabel = new System.Windows.Forms.Label();
            third_CityLabel = new System.Windows.Forms.Label();
            iT_JobsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.statesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingNavigator)).BeginInit();
            this.statesBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // statesDataSet
            // 
            this.statesDataSet.DataSetName = "statesDataSet";
            this.statesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statesBindingSource
            // 
            this.statesBindingSource.DataMember = "States";
            this.statesBindingSource.DataSource = this.statesDataSet;
            // 
            // statesTableAdapter
            // 
            this.statesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.StatesTableAdapter = this.statesTableAdapter;
            this.tableAdapterManager.UpdateOrder = andrew_foster_lab_3.statesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // statesBindingNavigator
            // 
            this.statesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.statesBindingNavigator.BindingSource = this.statesBindingSource;
            this.statesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.statesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.statesBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.statesBindingNavigatorSaveItem});
            this.statesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.statesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.statesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.statesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.statesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.statesBindingNavigator.Name = "statesBindingNavigator";
            this.statesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.statesBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.statesBindingNavigator.TabIndex = 0;
            this.statesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // statesBindingNavigatorSaveItem
            // 
            this.statesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.statesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("statesBindingNavigatorSaveItem.Image")));
            this.statesBindingNavigatorSaveItem.Name = "statesBindingNavigatorSaveItem";
            this.statesBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.statesBindingNavigatorSaveItem.Text = "Save Data";
            this.statesBindingNavigatorSaveItem.Click += new System.EventHandler(this.statesBindingNavigatorSaveItem_Click);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(280, 106);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(21, 16);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(368, 103);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(248, 22);
            this.idTextBox.TabIndex = 2;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(280, 134);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(47, 16);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(368, 131);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(248, 22);
            this.nameTextBox.TabIndex = 4;
            // 
            // populationLabel
            // 
            populationLabel.AutoSize = true;
            populationLabel.Location = new System.Drawing.Point(280, 162);
            populationLabel.Name = "populationLabel";
            populationLabel.Size = new System.Drawing.Size(74, 16);
            populationLabel.TabIndex = 5;
            populationLabel.Text = "Population:";
            // 
            // populationTextBox
            // 
            this.populationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesBindingSource, "Population", true));
            this.populationTextBox.Location = new System.Drawing.Point(368, 159);
            this.populationTextBox.Name = "populationTextBox";
            this.populationTextBox.Size = new System.Drawing.Size(248, 22);
            this.populationTextBox.TabIndex = 6;
            // 
            // flagLabel
            // 
            flagLabel.AutoSize = true;
            flagLabel.Location = new System.Drawing.Point(280, 190);
            flagLabel.Name = "flagLabel";
            flagLabel.Size = new System.Drawing.Size(37, 16);
            flagLabel.TabIndex = 7;
            flagLabel.Text = "Flag:";
            // 
            // flagTextBox
            // 
            this.flagTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesBindingSource, "Flag", true));
            this.flagTextBox.Location = new System.Drawing.Point(368, 187);
            this.flagTextBox.Name = "flagTextBox";
            this.flagTextBox.Size = new System.Drawing.Size(248, 22);
            this.flagTextBox.TabIndex = 8;
            // 
            // flowerLabel
            // 
            flowerLabel.AutoSize = true;
            flowerLabel.Location = new System.Drawing.Point(280, 218);
            flowerLabel.Name = "flowerLabel";
            flowerLabel.Size = new System.Drawing.Size(50, 16);
            flowerLabel.TabIndex = 9;
            flowerLabel.Text = "Flower:";
            // 
            // flowerTextBox
            // 
            this.flowerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesBindingSource, "Flower", true));
            this.flowerTextBox.Location = new System.Drawing.Point(368, 215);
            this.flowerTextBox.Name = "flowerTextBox";
            this.flowerTextBox.Size = new System.Drawing.Size(248, 22);
            this.flowerTextBox.TabIndex = 10;
            // 
            // birdLabel
            // 
            birdLabel.AutoSize = true;
            birdLabel.Location = new System.Drawing.Point(280, 246);
            birdLabel.Name = "birdLabel";
            birdLabel.Size = new System.Drawing.Size(34, 16);
            birdLabel.TabIndex = 11;
            birdLabel.Text = "Bird:";
            // 
            // birdTextBox
            // 
            this.birdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesBindingSource, "Bird", true));
            this.birdTextBox.Location = new System.Drawing.Point(368, 243);
            this.birdTextBox.Name = "birdTextBox";
            this.birdTextBox.Size = new System.Drawing.Size(248, 22);
            this.birdTextBox.TabIndex = 12;
            // 
            // colorsLabel
            // 
            colorsLabel.AutoSize = true;
            colorsLabel.Location = new System.Drawing.Point(280, 274);
            colorsLabel.Name = "colorsLabel";
            colorsLabel.Size = new System.Drawing.Size(49, 16);
            colorsLabel.TabIndex = 13;
            colorsLabel.Text = "Colors:";
            // 
            // colorsTextBox
            // 
            this.colorsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesBindingSource, "Colors", true));
            this.colorsTextBox.Location = new System.Drawing.Point(368, 271);
            this.colorsTextBox.Name = "colorsTextBox";
            this.colorsTextBox.Size = new System.Drawing.Size(248, 22);
            this.colorsTextBox.TabIndex = 14;
            // 
            // capitolLabel
            // 
            capitolLabel.AutoSize = true;
            capitolLabel.Location = new System.Drawing.Point(280, 302);
            capitolLabel.Name = "capitolLabel";
            capitolLabel.Size = new System.Drawing.Size(52, 16);
            capitolLabel.TabIndex = 15;
            capitolLabel.Text = "Capitol:";
            // 
            // capitolTextBox
            // 
            this.capitolTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesBindingSource, "Capitol", true));
            this.capitolTextBox.Location = new System.Drawing.Point(368, 299);
            this.capitolTextBox.Name = "capitolTextBox";
            this.capitolTextBox.Size = new System.Drawing.Size(248, 22);
            this.capitolTextBox.TabIndex = 16;
            // 
            // first_CityLabel
            // 
            first_CityLabel.AutoSize = true;
            first_CityLabel.Location = new System.Drawing.Point(280, 330);
            first_CityLabel.Name = "first_CityLabel";
            first_CityLabel.Size = new System.Drawing.Size(60, 16);
            first_CityLabel.TabIndex = 17;
            first_CityLabel.Text = "First City:";
            // 
            // first_CityTextBox
            // 
            this.first_CityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesBindingSource, "First City", true));
            this.first_CityTextBox.Location = new System.Drawing.Point(368, 327);
            this.first_CityTextBox.Name = "first_CityTextBox";
            this.first_CityTextBox.Size = new System.Drawing.Size(248, 22);
            this.first_CityTextBox.TabIndex = 18;
            // 
            // second_CityLabel
            // 
            second_CityLabel.AutoSize = true;
            second_CityLabel.Location = new System.Drawing.Point(280, 358);
            second_CityLabel.Name = "second_CityLabel";
            second_CityLabel.Size = new System.Drawing.Size(82, 16);
            second_CityLabel.TabIndex = 19;
            second_CityLabel.Text = "Second City:";
            // 
            // second_CityTextBox
            // 
            this.second_CityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesBindingSource, "Second City", true));
            this.second_CityTextBox.Location = new System.Drawing.Point(368, 355);
            this.second_CityTextBox.Name = "second_CityTextBox";
            this.second_CityTextBox.Size = new System.Drawing.Size(248, 22);
            this.second_CityTextBox.TabIndex = 20;
            // 
            // third_CityLabel
            // 
            third_CityLabel.AutoSize = true;
            third_CityLabel.Location = new System.Drawing.Point(280, 386);
            third_CityLabel.Name = "third_CityLabel";
            third_CityLabel.Size = new System.Drawing.Size(66, 16);
            third_CityLabel.TabIndex = 21;
            third_CityLabel.Text = "Third City:";
            // 
            // third_CityTextBox
            // 
            this.third_CityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesBindingSource, "Third City", true));
            this.third_CityTextBox.Location = new System.Drawing.Point(368, 383);
            this.third_CityTextBox.Name = "third_CityTextBox";
            this.third_CityTextBox.Size = new System.Drawing.Size(248, 22);
            this.third_CityTextBox.TabIndex = 22;
            // 
            // iT_JobsLabel
            // 
            iT_JobsLabel.AutoSize = true;
            iT_JobsLabel.Location = new System.Drawing.Point(280, 414);
            iT_JobsLabel.Name = "iT_JobsLabel";
            iT_JobsLabel.Size = new System.Drawing.Size(55, 16);
            iT_JobsLabel.TabIndex = 23;
            iT_JobsLabel.Text = "IT Jobs:";
            // 
            // iT_JobsTextBox
            // 
            this.iT_JobsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesBindingSource, "IT Jobs", true));
            this.iT_JobsTextBox.Location = new System.Drawing.Point(368, 411);
            this.iT_JobsTextBox.Name = "iT_JobsTextBox";
            this.iT_JobsTextBox.Size = new System.Drawing.Size(248, 22);
            this.iT_JobsTextBox.TabIndex = 24;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(331, 470);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(105, 33);
            this.exitButton.TabIndex = 25;
            this.exitButton.Text = "Close";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // stateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 533);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(populationLabel);
            this.Controls.Add(this.populationTextBox);
            this.Controls.Add(flagLabel);
            this.Controls.Add(this.flagTextBox);
            this.Controls.Add(flowerLabel);
            this.Controls.Add(this.flowerTextBox);
            this.Controls.Add(birdLabel);
            this.Controls.Add(this.birdTextBox);
            this.Controls.Add(colorsLabel);
            this.Controls.Add(this.colorsTextBox);
            this.Controls.Add(capitolLabel);
            this.Controls.Add(this.capitolTextBox);
            this.Controls.Add(first_CityLabel);
            this.Controls.Add(this.first_CityTextBox);
            this.Controls.Add(second_CityLabel);
            this.Controls.Add(this.second_CityTextBox);
            this.Controls.Add(third_CityLabel);
            this.Controls.Add(this.third_CityTextBox);
            this.Controls.Add(iT_JobsLabel);
            this.Controls.Add(this.iT_JobsTextBox);
            this.Controls.Add(this.statesBindingNavigator);
            this.Name = "stateForm";
            this.Text = "State Information";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingNavigator)).EndInit();
            this.statesBindingNavigator.ResumeLayout(false);
            this.statesBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private statesDataSet statesDataSet;
        private System.Windows.Forms.BindingSource statesBindingSource;
        private statesDataSetTableAdapters.StatesTableAdapter statesTableAdapter;
        private statesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator statesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton statesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox populationTextBox;
        private System.Windows.Forms.TextBox flagTextBox;
        private System.Windows.Forms.TextBox flowerTextBox;
        private System.Windows.Forms.TextBox birdTextBox;
        private System.Windows.Forms.TextBox colorsTextBox;
        private System.Windows.Forms.TextBox capitolTextBox;
        private System.Windows.Forms.TextBox first_CityTextBox;
        private System.Windows.Forms.TextBox second_CityTextBox;
        private System.Windows.Forms.TextBox third_CityTextBox;
        private System.Windows.Forms.TextBox iT_JobsTextBox;
        private System.Windows.Forms.Button exitButton;
    }
}