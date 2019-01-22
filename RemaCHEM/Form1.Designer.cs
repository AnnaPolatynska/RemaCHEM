namespace RemaCHEM
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBoxStanowiska = new System.Windows.Forms.GroupBox();
            this.listBoxMeasuringStand = new System.Windows.Forms.ListBox();
            this.groupBoxStandData = new System.Windows.Forms.GroupBox();
            this.labelSystemNumber = new System.Windows.Forms.Label();
            this.textBoxSystemNumber = new System.Windows.Forms.TextBox();
            this.richTextBoxMaker = new System.Windows.Forms.RichTextBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelStandType = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxStandType = new System.Windows.Forms.TextBox();
            this.labelStandKind = new System.Windows.Forms.Label();
            this.textBoxStandKind = new System.Windows.Forms.TextBox();
            this.labelStandName = new System.Windows.Forms.Label();
            this.comboBoxStandKeeper = new System.Windows.Forms.ComboBox();
            this.labelStandFactoryNumber = new System.Windows.Forms.Label();
            this.textBoxStandName = new System.Windows.Forms.TextBox();
            this.textBoxStandFactoryNumber = new System.Windows.Forms.TextBox();
            this.labelMaker = new System.Windows.Forms.Label();
            this.richTextBoxUwagi = new System.Windows.Forms.RichTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.labelStandKeeper = new System.Windows.Forms.Label();
            this.groupBoxSort = new System.Windows.Forms.GroupBox();
            this.radioButtonStandDate = new System.Windows.Forms.RadioButton();
            this.radioButtonStandName = new System.Windows.Forms.RadioButton();
            this.radioButtonStandFactoryNumber = new System.Windows.Forms.RadioButton();
            this.radioButtonStandType = new System.Windows.Forms.RadioButton();
            this.groupBoxFind = new System.Windows.Forms.GroupBox();
            this.buttonSzukaj = new System.Windows.Forms.Button();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.groupBoxEdit = new System.Windows.Forms.GroupBox();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAddPicture = new System.Windows.Forms.Button();
            this.buttonDeletePicture = new System.Windows.Forms.Button();
            this.pictureBoxStandPicture = new System.Windows.Forms.PictureBox();
            this.groupBoxPicture = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBoxStanowiska.SuspendLayout();
            this.groupBoxStandData.SuspendLayout();
            this.groupBoxSort.SuspendLayout();
            this.groupBoxFind.SuspendLayout();
            this.groupBoxEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStandPicture)).BeginInit();
            this.groupBoxPicture.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxStanowiska
            // 
            this.groupBoxStanowiska.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxStanowiska.BackColor = System.Drawing.Color.DarkSlateGray;
            this.groupBoxStanowiska.Controls.Add(this.listBoxMeasuringStand);
            this.groupBoxStanowiska.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxStanowiska.ForeColor = System.Drawing.Color.White;
            this.groupBoxStanowiska.Location = new System.Drawing.Point(1, 110);
            this.groupBoxStanowiska.Name = "groupBoxStanowiska";
            this.groupBoxStanowiska.Size = new System.Drawing.Size(321, 492);
            this.groupBoxStanowiska.TabIndex = 2;
            this.groupBoxStanowiska.TabStop = false;
            this.groupBoxStanowiska.Text = "Lista stanowisk";
            // 
            // listBoxMeasuringStand
            // 
            this.listBoxMeasuringStand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxMeasuringStand.BackColor = System.Drawing.Color.Azure;
            this.listBoxMeasuringStand.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.listBoxMeasuringStand.FormattingEnabled = true;
            this.listBoxMeasuringStand.ItemHeight = 20;
            this.listBoxMeasuringStand.Location = new System.Drawing.Point(6, 25);
            this.listBoxMeasuringStand.Name = "listBoxMeasuringStand";
            this.listBoxMeasuringStand.Size = new System.Drawing.Size(309, 444);
            this.listBoxMeasuringStand.TabIndex = 0;
            // 
            // groupBoxStandData
            // 
            this.groupBoxStandData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxStandData.Controls.Add(this.labelSystemNumber);
            this.groupBoxStandData.Controls.Add(this.textBoxSystemNumber);
            this.groupBoxStandData.Controls.Add(this.richTextBoxMaker);
            this.groupBoxStandData.Controls.Add(this.labelDate);
            this.groupBoxStandData.Controls.Add(this.labelStandType);
            this.groupBoxStandData.Controls.Add(this.dateTimePickerDate);
            this.groupBoxStandData.Controls.Add(this.textBoxStandType);
            this.groupBoxStandData.Controls.Add(this.labelStandKind);
            this.groupBoxStandData.Controls.Add(this.textBoxStandKind);
            this.groupBoxStandData.Controls.Add(this.labelStandName);
            this.groupBoxStandData.Controls.Add(this.comboBoxStandKeeper);
            this.groupBoxStandData.Controls.Add(this.labelStandFactoryNumber);
            this.groupBoxStandData.Controls.Add(this.textBoxStandName);
            this.groupBoxStandData.Controls.Add(this.textBoxStandFactoryNumber);
            this.groupBoxStandData.Controls.Add(this.labelMaker);
            this.groupBoxStandData.Controls.Add(this.richTextBoxUwagi);
            this.groupBoxStandData.Controls.Add(this.label14);
            this.groupBoxStandData.Controls.Add(this.labelStandKeeper);
            this.groupBoxStandData.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.groupBoxStandData.ForeColor = System.Drawing.Color.White;
            this.groupBoxStandData.Location = new System.Drawing.Point(328, 28);
            this.groupBoxStandData.Name = "groupBoxStandData";
            this.groupBoxStandData.Size = new System.Drawing.Size(525, 512);
            this.groupBoxStandData.TabIndex = 47;
            this.groupBoxStandData.TabStop = false;
            this.groupBoxStandData.Text = "Dane stanowiska";
            // 
            // labelSystemNumber
            // 
            this.labelSystemNumber.AutoSize = true;
            this.labelSystemNumber.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.labelSystemNumber.Location = new System.Drawing.Point(11, 225);
            this.labelSystemNumber.Name = "labelSystemNumber";
            this.labelSystemNumber.Size = new System.Drawing.Size(84, 20);
            this.labelSystemNumber.TabIndex = 43;
            this.labelSystemNumber.Text = "Nr systemowy";
            // 
            // textBoxSystemNumber
            // 
            this.textBoxSystemNumber.BackColor = System.Drawing.Color.Azure;
            this.textBoxSystemNumber.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.textBoxSystemNumber.Location = new System.Drawing.Point(116, 225);
            this.textBoxSystemNumber.Name = "textBoxSystemNumber";
            this.textBoxSystemNumber.Size = new System.Drawing.Size(380, 24);
            this.textBoxSystemNumber.TabIndex = 44;
            // 
            // richTextBoxMaker
            // 
            this.richTextBoxMaker.BackColor = System.Drawing.Color.Azure;
            this.richTextBoxMaker.Location = new System.Drawing.Point(116, 276);
            this.richTextBoxMaker.Name = "richTextBoxMaker";
            this.richTextBoxMaker.Size = new System.Drawing.Size(380, 46);
            this.richTextBoxMaker.TabIndex = 42;
            this.richTextBoxMaker.Text = "";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.labelDate.Location = new System.Drawing.Point(11, 353);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(152, 20);
            this.labelDate.TabIndex = 25;
            this.labelDate.Text = "Data ostatniego przegladu";
            // 
            // labelStandType
            // 
            this.labelStandType.AutoSize = true;
            this.labelStandType.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.labelStandType.Location = new System.Drawing.Point(11, 74);
            this.labelStandType.Name = "labelStandType";
            this.labelStandType.Size = new System.Drawing.Size(30, 20);
            this.labelStandType.TabIndex = 9;
            this.labelStandType.Text = "Typ";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.CalendarMonthBackground = System.Drawing.Color.Linen;
            this.dateTimePickerDate.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.dateTimePickerDate.Location = new System.Drawing.Point(207, 353);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(289, 24);
            this.dateTimePickerDate.TabIndex = 36;
            // 
            // textBoxStandType
            // 
            this.textBoxStandType.BackColor = System.Drawing.Color.Azure;
            this.textBoxStandType.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.textBoxStandType.Location = new System.Drawing.Point(116, 70);
            this.textBoxStandType.Name = "textBoxStandType";
            this.textBoxStandType.Size = new System.Drawing.Size(380, 24);
            this.textBoxStandType.TabIndex = 8;
            // 
            // labelStandKind
            // 
            this.labelStandKind.AutoSize = true;
            this.labelStandKind.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.labelStandKind.Location = new System.Drawing.Point(11, 121);
            this.labelStandKind.Name = "labelStandKind";
            this.labelStandKind.Size = new System.Drawing.Size(47, 20);
            this.labelStandKind.TabIndex = 10;
            this.labelStandKind.Text = "Rodzaj";
            // 
            // textBoxStandKind
            // 
            this.textBoxStandKind.BackColor = System.Drawing.Color.Azure;
            this.textBoxStandKind.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.textBoxStandKind.Location = new System.Drawing.Point(116, 121);
            this.textBoxStandKind.Name = "textBoxStandKind";
            this.textBoxStandKind.Size = new System.Drawing.Size(380, 24);
            this.textBoxStandKind.TabIndex = 11;
            // 
            // labelStandName
            // 
            this.labelStandName.AutoSize = true;
            this.labelStandName.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.labelStandName.Location = new System.Drawing.Point(11, 25);
            this.labelStandName.Name = "labelStandName";
            this.labelStandName.Size = new System.Drawing.Size(46, 20);
            this.labelStandName.TabIndex = 7;
            this.labelStandName.Text = "Nazwa";
            // 
            // comboBoxStandKeeper
            // 
            this.comboBoxStandKeeper.BackColor = System.Drawing.Color.Azure;
            this.comboBoxStandKeeper.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.comboBoxStandKeeper.FormattingEnabled = true;
            this.comboBoxStandKeeper.Location = new System.Drawing.Point(207, 394);
            this.comboBoxStandKeeper.Name = "comboBoxStandKeeper";
            this.comboBoxStandKeeper.Size = new System.Drawing.Size(289, 28);
            this.comboBoxStandKeeper.TabIndex = 33;
            // 
            // labelStandFactoryNumber
            // 
            this.labelStandFactoryNumber.AutoSize = true;
            this.labelStandFactoryNumber.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.labelStandFactoryNumber.Location = new System.Drawing.Point(11, 179);
            this.labelStandFactoryNumber.Name = "labelStandFactoryNumber";
            this.labelStandFactoryNumber.Size = new System.Drawing.Size(75, 20);
            this.labelStandFactoryNumber.TabIndex = 13;
            this.labelStandFactoryNumber.Text = "Nr fabryczny";
            this.labelStandFactoryNumber.Click += new System.EventHandler(this.labelNrFabrycznyMaszyny_Click);
            // 
            // textBoxStandName
            // 
            this.textBoxStandName.BackColor = System.Drawing.Color.Azure;
            this.textBoxStandName.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.textBoxStandName.Location = new System.Drawing.Point(116, 25);
            this.textBoxStandName.Name = "textBoxStandName";
            this.textBoxStandName.Size = new System.Drawing.Size(380, 24);
            this.textBoxStandName.TabIndex = 6;
            // 
            // textBoxStandFactoryNumber
            // 
            this.textBoxStandFactoryNumber.BackColor = System.Drawing.Color.Azure;
            this.textBoxStandFactoryNumber.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.textBoxStandFactoryNumber.Location = new System.Drawing.Point(116, 179);
            this.textBoxStandFactoryNumber.Name = "textBoxStandFactoryNumber";
            this.textBoxStandFactoryNumber.Size = new System.Drawing.Size(380, 24);
            this.textBoxStandFactoryNumber.TabIndex = 14;
            this.textBoxStandFactoryNumber.TextChanged += new System.EventHandler(this.textBoxNr_fabryczny_TextChanged);
            // 
            // labelMaker
            // 
            this.labelMaker.AutoSize = true;
            this.labelMaker.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.labelMaker.Location = new System.Drawing.Point(11, 276);
            this.labelMaker.Name = "labelMaker";
            this.labelMaker.Size = new System.Drawing.Size(105, 20);
            this.labelMaker.TabIndex = 15;
            this.labelMaker.Text = "Dane producenta";
            // 
            // richTextBoxUwagi
            // 
            this.richTextBoxUwagi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.richTextBoxUwagi.BackColor = System.Drawing.Color.Linen;
            this.richTextBoxUwagi.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.richTextBoxUwagi.Location = new System.Drawing.Point(6, 779);
            this.richTextBoxUwagi.Name = "richTextBoxUwagi";
            this.richTextBoxUwagi.Size = new System.Drawing.Size(502, 0);
            this.richTextBoxUwagi.TabIndex = 30;
            this.richTextBoxUwagi.Text = "";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.label14.Location = new System.Drawing.Point(6, 762);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 20);
            this.label14.TabIndex = 29;
            this.label14.Text = "Uwagi";
            // 
            // labelStandKeeper
            // 
            this.labelStandKeeper.AutoSize = true;
            this.labelStandKeeper.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.labelStandKeeper.Location = new System.Drawing.Point(11, 397);
            this.labelStandKeeper.Name = "labelStandKeeper";
            this.labelStandKeeper.Size = new System.Drawing.Size(105, 20);
            this.labelStandKeeper.TabIndex = 21;
            this.labelStandKeeper.Text = "Opiekun maszyny";
            // 
            // groupBoxSort
            // 
            this.groupBoxSort.BackColor = System.Drawing.Color.DarkSlateGray;
            this.groupBoxSort.Controls.Add(this.radioButtonStandDate);
            this.groupBoxSort.Controls.Add(this.radioButtonStandName);
            this.groupBoxSort.Controls.Add(this.radioButtonStandFactoryNumber);
            this.groupBoxSort.Controls.Add(this.radioButtonStandType);
            this.groupBoxSort.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.groupBoxSort.ForeColor = System.Drawing.Color.White;
            this.groupBoxSort.Location = new System.Drawing.Point(7, 28);
            this.groupBoxSort.Name = "groupBoxSort";
            this.groupBoxSort.Size = new System.Drawing.Size(315, 76);
            this.groupBoxSort.TabIndex = 48;
            this.groupBoxSort.TabStop = false;
            this.groupBoxSort.Text = "Sortowanie";
            // 
            // radioButtonStandDate
            // 
            this.radioButtonStandDate.AutoSize = true;
            this.radioButtonStandDate.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.radioButtonStandDate.ForeColor = System.Drawing.Color.White;
            this.radioButtonStandDate.Location = new System.Drawing.Point(161, 46);
            this.radioButtonStandDate.Name = "radioButtonStandDate";
            this.radioButtonStandDate.Size = new System.Drawing.Size(116, 24);
            this.radioButtonStandDate.TabIndex = 6;
            this.radioButtonStandDate.Text = "Ostatni przegląd";
            this.radioButtonStandDate.UseVisualStyleBackColor = true;
            // 
            // radioButtonStandName
            // 
            this.radioButtonStandName.AutoSize = true;
            this.radioButtonStandName.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.radioButtonStandName.ForeColor = System.Drawing.Color.White;
            this.radioButtonStandName.Location = new System.Drawing.Point(15, 21);
            this.radioButtonStandName.Name = "radioButtonStandName";
            this.radioButtonStandName.Size = new System.Drawing.Size(64, 24);
            this.radioButtonStandName.TabIndex = 4;
            this.radioButtonStandName.Text = "Nazwa";
            this.radioButtonStandName.UseVisualStyleBackColor = true;
            // 
            // radioButtonStandFactoryNumber
            // 
            this.radioButtonStandFactoryNumber.AutoSize = true;
            this.radioButtonStandFactoryNumber.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.radioButtonStandFactoryNumber.ForeColor = System.Drawing.Color.White;
            this.radioButtonStandFactoryNumber.Location = new System.Drawing.Point(161, 21);
            this.radioButtonStandFactoryNumber.Name = "radioButtonStandFactoryNumber";
            this.radioButtonStandFactoryNumber.Size = new System.Drawing.Size(93, 24);
            this.radioButtonStandFactoryNumber.TabIndex = 2;
            this.radioButtonStandFactoryNumber.Text = "Nr fabryczny";
            this.radioButtonStandFactoryNumber.UseVisualStyleBackColor = true;
            // 
            // radioButtonStandType
            // 
            this.radioButtonStandType.AutoSize = true;
            this.radioButtonStandType.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.radioButtonStandType.ForeColor = System.Drawing.Color.White;
            this.radioButtonStandType.Location = new System.Drawing.Point(15, 46);
            this.radioButtonStandType.Name = "radioButtonStandType";
            this.radioButtonStandType.Size = new System.Drawing.Size(48, 24);
            this.radioButtonStandType.TabIndex = 0;
            this.radioButtonStandType.Text = "Typ";
            this.radioButtonStandType.UseVisualStyleBackColor = true;
            // 
            // groupBoxFind
            // 
            this.groupBoxFind.BackColor = System.Drawing.Color.DarkSlateGray;
            this.groupBoxFind.Controls.Add(this.buttonSzukaj);
            this.groupBoxFind.Controls.Add(this.textBoxFind);
            this.groupBoxFind.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBoxFind.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.groupBoxFind.ForeColor = System.Drawing.Color.White;
            this.groupBoxFind.Location = new System.Drawing.Point(859, 542);
            this.groupBoxFind.Name = "groupBoxFind";
            this.groupBoxFind.Size = new System.Drawing.Size(396, 60);
            this.groupBoxFind.TabIndex = 49;
            this.groupBoxFind.TabStop = false;
            this.groupBoxFind.Text = "Wyszukiwanie po nazwie";
            // 
            // buttonSzukaj
            // 
            this.buttonSzukaj.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSzukaj.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSzukaj.BackgroundImage")));
            this.buttonSzukaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSzukaj.Location = new System.Drawing.Point(355, 19);
            this.buttonSzukaj.Name = "buttonSzukaj";
            this.buttonSzukaj.Size = new System.Drawing.Size(35, 34);
            this.buttonSzukaj.TabIndex = 4;
            this.buttonSzukaj.UseVisualStyleBackColor = false;
            // 
            // textBoxFind
            // 
            this.textBoxFind.BackColor = System.Drawing.Color.Linen;
            this.textBoxFind.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.textBoxFind.Location = new System.Drawing.Point(9, 23);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(340, 24);
            this.textBoxFind.TabIndex = 44;
            // 
            // groupBoxEdit
            // 
            this.groupBoxEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxEdit.BackColor = System.Drawing.Color.DarkSlateGray;
            this.groupBoxEdit.Controls.Add(this.buttonNew);
            this.groupBoxEdit.Controls.Add(this.buttonDelete);
            this.groupBoxEdit.Controls.Add(this.buttonSave);
            this.groupBoxEdit.Controls.Add(this.buttonCancel);
            this.groupBoxEdit.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.groupBoxEdit.ForeColor = System.Drawing.Color.White;
            this.groupBoxEdit.Location = new System.Drawing.Point(328, 546);
            this.groupBoxEdit.Name = "groupBoxEdit";
            this.groupBoxEdit.Size = new System.Drawing.Size(525, 56);
            this.groupBoxEdit.TabIndex = 50;
            this.groupBoxEdit.TabStop = false;
            this.groupBoxEdit.Text = "Edycja";
            // 
            // buttonNew
            // 
            this.buttonNew.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonNew.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.buttonNew.Location = new System.Drawing.Point(16, 20);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(100, 30);
            this.buttonNew.TabIndex = 2;
            this.buttonNew.Text = "Nowa";
            this.buttonNew.UseVisualStyleBackColor = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Teal;
            this.buttonDelete.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.buttonDelete.Location = new System.Drawing.Point(396, 20);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(100, 30);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Usuń";
            this.buttonDelete.UseVisualStyleBackColor = false;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.Teal;
            this.buttonSave.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.buttonSave.Location = new System.Drawing.Point(145, 20);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 30);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Zapisz";
            this.buttonSave.UseVisualStyleBackColor = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Teal;
            this.buttonCancel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.buttonCancel.Location = new System.Drawing.Point(265, 20);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 30);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Anuluj";
            this.buttonCancel.UseVisualStyleBackColor = false;
            // 
            // buttonAddPicture
            // 
            this.buttonAddPicture.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonAddPicture.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.buttonAddPicture.Location = new System.Drawing.Point(6, 474);
            this.buttonAddPicture.Name = "buttonAddPicture";
            this.buttonAddPicture.Size = new System.Drawing.Size(170, 27);
            this.buttonAddPicture.TabIndex = 53;
            this.buttonAddPicture.Text = "Wgraj zdjęcie";
            this.buttonAddPicture.UseVisualStyleBackColor = false;
            // 
            // buttonDeletePicture
            // 
            this.buttonDeletePicture.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonDeletePicture.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.buttonDeletePicture.Location = new System.Drawing.Point(220, 474);
            this.buttonDeletePicture.Name = "buttonDeletePicture";
            this.buttonDeletePicture.Size = new System.Drawing.Size(170, 27);
            this.buttonDeletePicture.TabIndex = 52;
            this.buttonDeletePicture.Text = "Usuń zdjęcie";
            this.buttonDeletePicture.UseVisualStyleBackColor = false;
            // 
            // pictureBoxStandPicture
            // 
            this.pictureBoxStandPicture.Location = new System.Drawing.Point(6, 21);
            this.pictureBoxStandPicture.Name = "pictureBoxStandPicture";
            this.pictureBoxStandPicture.Size = new System.Drawing.Size(384, 447);
            this.pictureBoxStandPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxStandPicture.TabIndex = 51;
            this.pictureBoxStandPicture.TabStop = false;
            // 
            // groupBoxPicture
            // 
            this.groupBoxPicture.Controls.Add(this.buttonAddPicture);
            this.groupBoxPicture.Controls.Add(this.pictureBoxStandPicture);
            this.groupBoxPicture.Controls.Add(this.buttonDeletePicture);
            this.groupBoxPicture.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.groupBoxPicture.ForeColor = System.Drawing.Color.White;
            this.groupBoxPicture.Location = new System.Drawing.Point(859, 28);
            this.groupBoxPicture.Name = "groupBoxPicture";
            this.groupBoxPicture.Size = new System.Drawing.Size(396, 512);
            this.groupBoxPicture.TabIndex = 54;
            this.groupBoxPicture.TabStop = false;
            this.groupBoxPicture.Text = "Zdjęcie";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1262, 25);
            this.toolStrip1.TabIndex = 55;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Margin = new System.Windows.Forms.Padding(1, 1, 0, 2);
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButton1.ToolTipText = "Logo";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 614);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1262, 22);
            this.statusStrip1.TabIndex = 56;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(87, 17);
            this.toolStripStatusLabel1.Text = "Stanowisko ID: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1262, 636);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBoxPicture);
            this.Controls.Add(this.groupBoxEdit);
            this.Controls.Add(this.groupBoxFind);
            this.Controls.Add(this.groupBoxSort);
            this.Controls.Add(this.groupBoxStandData);
            this.Controls.Add(this.groupBoxStanowiska);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxStanowiska.ResumeLayout(false);
            this.groupBoxStandData.ResumeLayout(false);
            this.groupBoxStandData.PerformLayout();
            this.groupBoxSort.ResumeLayout(false);
            this.groupBoxSort.PerformLayout();
            this.groupBoxFind.ResumeLayout(false);
            this.groupBoxFind.PerformLayout();
            this.groupBoxEdit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStandPicture)).EndInit();
            this.groupBoxPicture.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxStanowiska;
        private System.Windows.Forms.ListBox listBoxMeasuringStand;
        private System.Windows.Forms.GroupBox groupBoxStandData;
        private System.Windows.Forms.Label labelSystemNumber;
        private System.Windows.Forms.TextBox textBoxSystemNumber;
        private System.Windows.Forms.RichTextBox richTextBoxMaker;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelStandType;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.TextBox textBoxStandType;
        private System.Windows.Forms.Label labelStandKind;
        private System.Windows.Forms.TextBox textBoxStandKind;
        private System.Windows.Forms.Label labelStandName;
        private System.Windows.Forms.ComboBox comboBoxStandKeeper;
        private System.Windows.Forms.Label labelStandFactoryNumber;
        private System.Windows.Forms.TextBox textBoxStandName;
        private System.Windows.Forms.TextBox textBoxStandFactoryNumber;
        private System.Windows.Forms.Label labelMaker;
        private System.Windows.Forms.RichTextBox richTextBoxUwagi;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label labelStandKeeper;
        private System.Windows.Forms.GroupBox groupBoxSort;
        private System.Windows.Forms.RadioButton radioButtonStandDate;
        private System.Windows.Forms.RadioButton radioButtonStandName;
        private System.Windows.Forms.RadioButton radioButtonStandFactoryNumber;
        private System.Windows.Forms.RadioButton radioButtonStandType;
        private System.Windows.Forms.GroupBox groupBoxFind;
        private System.Windows.Forms.Button buttonSzukaj;
        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.GroupBox groupBoxEdit;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAddPicture;
        private System.Windows.Forms.Button buttonDeletePicture;
        private System.Windows.Forms.PictureBox pictureBoxStandPicture;
        private System.Windows.Forms.GroupBox groupBoxPicture;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

