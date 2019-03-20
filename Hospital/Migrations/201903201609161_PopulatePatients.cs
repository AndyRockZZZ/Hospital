namespace Hospital.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatePatients : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Patients ON");
            Sql("INSERT INTO Patients(PatientId, PatientName, Address1, Address2, PostCode, SexId, DOB, StatusId) VALUES(1, 'AndrewDevine', '1 Navestock Gardens', 'Essex', 'SS1 3SR', 1, 12/06/1997, 1)");
            Sql("INSERT INTO Patients(PatientId, PatientName, Address1, Address2, PostCode, SexId, DOB, StatusId) VALUES(2, 'William Hilton', '19 Long Street', 'Mile End', 'GL16 0TE', 1, 24/06/1959, 2)");
            Sql("INSERT INTO Patients(PatientId, PatientName, Address1, Address2, PostCode, SexId, DOB, StatusId) VALUES(3, 'Joseph O’Sullivan', '96 Cheriton Rd', 'West Putford', 'EX22 6QS', 1, 8/11/1983, 1)");
            Sql("INSERT INTO Patients(PatientId, PatientName, Address1, Address2, PostCode, SexId, DOB, StatusId) VALUES(4, 'Jessica Spencer', '70 Colorado Way', 'Rhosybol', 'LL68 9BL', 2, 20/05/1936, 3)");
            Sql("INSERT INTO Patients(PatientId, PatientName, Address1, Address2, PostCode, SexId, DOB, StatusId) VALUES(5, 'Elise Alexander', '27 Lincoln Green Lane', 'Chittoe', 'SN15 7YL', 2, 1/12/1947, 2)");
            Sql("INSERT INTO Patients(PatientId, PatientName, Address1, Address2, PostCode, SexId, DOB, StatusId) VALUES(6, 'Ellie Gallagher', '56 Station Rd', 'Queenzieburn', 'G65 0JS', 2, 21/11/1996, 1)");
            Sql("INSERT INTO Patients(PatientId, PatientName, Address1, Address2, PostCode, SexId, DOB, StatusId) VALUES(7, 'Georgia Winter', '25 Prospect Hill', 'Dropmore', 'SL1 8UZ', 2, 19/07/1952, 2)");
            Sql("INSERT INTO Patients(PatientId, PatientName, Address1, Address2, PostCode, SexId, DOB, StatusId) VALUES(8, 'Lydia Cooke', '99 Broomfield Place', 'Stoney Stoke', 'BA9 4WQ', 2, 26/03/1965, 2)");
            Sql("INSERT INTO Patients(PatientId, PatientName, Address1, Address2, PostCode, SexId, DOB, StatusId) VALUES(9, 'Christopher Walker', '60 Sandyhill Rd', 'Fron-Goch', 'LL23 9FG', 1, 16/01/1984, 2)");
            Sql("INSERT INTO Patients(PatientId, PatientName, Address1, Address2, PostCode, SexId, DOB, StatusId) VALUES(10, 'Joel Gibbons', '4 Petworth Rd', 'Durdar', 'CA2 9RY', 1, 21/12/1978, 1)");
            Sql("INSERT INTO Patients(PatientId, PatientName, Address1, Address2, PostCode, SexId, DOB, StatusId) VALUES(11, 'Lauren Johnson', '99 Caradon Hill', 'Udimore', 'TN31 2FE', 2, 06/03/1999, 1)");
            Sql("INSERT INTO Patients(PatientId, PatientName, Address1, Address2, PostCode, SexId, DOB, StatusId) VALUES(12, 'John Fry', '11 Castledore Road', 'Twickenham', 'TW1 6FP', 1, 08/04/1938, 5)");
            Sql("INSERT INTO Patients(PatientId, PatientName, Address1, Address2, PostCode, SexId, DOB, StatusId) VALUES(13, 'Mason Saunders', '9 Abingdon Road', 'Brantwood', 'LA21 4TU', 1, 04/05/1981, 2)");
            Sql("INSERT INTO Patients(PatientId, PatientName, Address1, Address2, PostCode, SexId, DOB, StatusId) VALUES(14, 'Maya Coates', '24 Vicar Lane', 'Sandygate', 'IM7 6NP', 2, 18/07/1997, 1)");
            Sql("INSERT INTO Patients(PatientId, PatientName, Address1, Address2, PostCode, SexId, DOB, StatusId) VALUES(15, 'Maisie Dodd', '47 Gloucester Road', 'Clachaig', 'PA23 4UD', 2, 13/02/1963, 4)");
            Sql("INSERT INTO Patients(PatientId, PatientName, Address1, Address2, PostCode, SexId, DOB, StatusId) VALUES(16, 'Zara Green', '66 Marcham Road', 'Borgue', 'KW7 5UG', 2, 17/12/1961 , 2)"); 
            Sql("INSERT INTO Patients(PatientId, PatientName, Address1, Address2, PostCode, SexId, DOB, StatusId) VALUES(17, 'Spencer Savage', '54 Rhosddu Rd', 'Ferryden', 'DD10 3SS', 1, 17/05/1994 , 1)"); 
            Sql("INSERT INTO Patients(PatientId, PatientName, Address1, Address2, PostCode, SexId, DOB, StatusId) VALUES(18, 'Sam Miller', '3 Warren St', 'West Haddon', 'NN6 6AL', 1, 15/03/1948 , 1)"); 
            Sql("INSERT INTO Patients(PatientId, PatientName, Address1, Address2, PostCode, SexId, DOB, StatusId) VALUES(19, 'Logan White', '13 Fore St', 'Trewalder', 'PL33 9TF', 1, 19/05/1948 , 2)"); 
            Sql("INSERT INTO Patients(PatientId, PatientName, Address1, Address2, PostCode, SexId, DOB, StatusId) VALUES(20, 'Sienna Davis', '81 Thirsk Road', 'Blaenwaun', 'SA34 7PN', 2, 03/01/1995, 1)"); 
        }
        
        public override void Down()
        {
        }
    }
}
