namespace Hospital.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateDrugs : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Drugs ON");
            Sql("INSERT INTO Drugs(DrugId, DrugName, Dosage) VALUES(1, 'Morphine', 10)");
            Sql("INSERT INTO Drugs(DrugId, DrugName, Dosage) VALUES(2, 'Atenolol', 3.5)");
            Sql("INSERT INTO Drugs(DrugId, DrugName, Dosage) VALUES(3, 'Tetracycline', 0.5)");
            Sql("INSERT INTO Drugs(DrugId, DrugName, Dosage) VALUES(4, 'Paracetamol', 2)");
            Sql("INSERT INTO Drugs(DrugId, DrugName, Dosage) VALUES(5, 'Ibuprofen', 5)");
            Sql("INSERT INTO Drugs(DrugId, DrugName, Dosage) VALUES(6, 'Codeine', 3.5)");
            Sql("INSERT INTO Drugs(DrugId, DrugName, Dosage) VALUES(7, 'Tramadol', 4.4)");
            Sql("INSERT INTO Drugs(DrugId, DrugName, Dosage) VALUES(8, 'Co-codamol', 7)");
            Sql("INSERT INTO Drugs(DrugId, DrugName, Dosage) VALUES(9, 'Asprin', 9)");
            Sql("INSERT INTO Drugs(DrugId, DrugName, Dosage) VALUES(10, 'Naproxen', 1.2)");
            Sql("INSERT INTO Drugs(DrugId, DrugName, Dosage) VALUES(11, 'Oxycodone', 8)");
            Sql("INSERT INTO Drugs(DrugId, DrugName, Dosage) VALUES(12, 'Nefopam', 13)");
            Sql("INSERT INTO Drugs(DrugId, DrugName, Dosage) VALUES(13, 'Gabapentin', 6)");
            Sql("INSERT INTO Drugs(DrugId, DrugName, Dosage) VALUES(14, 'Fentanyl', 8.6)");
            Sql("INSERT INTO Drugs(DrugId, DrugName, Dosage) VALUES(15, 'Ketamine', 4)");
            Sql("INSERT INTO Drugs(DrugId, DrugName, Dosage) VALUES(16, 'Bisoprolol', 7)");
            Sql("INSERT INTO Drugs(DrugId, DrugName, Dosage) VALUES(17, 'Digoxin', 3)");
            Sql("INSERT INTO Drugs(DrugId, DrugName, Dosage) VALUES(18, 'Ciprofloxacin', 5.5)");

        }

        public override void Down()
        {
        }
    }
}
