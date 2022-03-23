namespace VRDR
{
    /// <summary> ValueSet Helpers </summary>
    public static class ValueSets
    {
        /////////// FLAGGED FOR DELETION
        /// <summary> CertificationRole </summary>
        public static class CertificationRole {
            /// <summary> Codes </summary>
            public static string[,] Codes = {
                { "455381000124109", "Medical Examiner/Coroner", VRDR.CodeSystems.SCT },
                { "434641000124105", "Physician certified and pronounced death certificate", VRDR.CodeSystems.SCT },
                { "434651000124107", "Physician certified death certificate", VRDR.CodeSystems.SCT },
                { "OTH", "Other", VRDR.CodeSystems.PH_NullFlavor_HL7_V3 }
            };
            /// <summary> Medical Examiner/Coroner </summary>
            public static string  Medical_Examiner_Coroner = "455381000124109";
            /// <summary> Physician certified and pronounced death certificate </summary>
            public static string  Physician_Certified_And_Pronounced_Death_Certificate = "434641000124105";
            /// <summary> Physician certified death certificate </summary>
            public static string  Physician_Certified_Death_Certificate = "434651000124107";
            /// <summary> Other </summary>
            public static string  Other = "OTH";
        };
        /// <summary> MethodsOfDisposition </summary>
        public static class MethodsOfDisposition {
            /// <summary> Codes </summary>
            public static string[,] Codes = {
                { "449971000124106", "Burial", VRDR.CodeSystems.SCT },
                { "449961000124104", "Cremation", VRDR.CodeSystems.SCT },
                { "449951000124101", "Donation", VRDR.CodeSystems.SCT },
                { "449931000124108", "Entombment", VRDR.CodeSystems.SCT },
                { "449941000124103", "Removal from State", VRDR.CodeSystems.SCT },
                { "OTH", "other", VRDR.CodeSystems.PH_NullFlavor_HL7_V3 },
                { "UNK", "unknown", VRDR.CodeSystems.PH_NullFlavor_HL7_V3 }
            };
            /// <summary> Burial </summary>
            public static string  Burial = "449971000124106";
            /// <summary> Cremation </summary>
            public static string  Cremation = "449961000124104";
            /// <summary> Donation </summary>
            public static string  Donation = "449951000124101";
            /// <summary> Entombment </summary>
            public static string  Entombment = "449931000124108";
            /// <summary> Removal_From_State </summary>
            public static string  Removal_From_State = "449941000124103";
            /// <summary> Other </summary>
            public static string  Other = "OTH";
            /// <summary> Unknown </summary>
            public static string  Unknown = "UNK";
        };
        /// <summary> PlaceOfInjury </summary>
        public static class PlaceOfInjury {
            /// <summary> Codes </summary>
            public static string[,] Codes = {
                { "0", "Home", VRDR.CodeSystems.PH_PlaceOfOccurrence_ICD_10_WHO },
                { "1", "Residential Institution", VRDR.CodeSystems.PH_PlaceOfOccurrence_ICD_10_WHO },
                { "2", "School, Other Institutions, Public Administrative Area", VRDR.CodeSystems.PH_PlaceOfOccurrence_ICD_10_WHO },
                { "3", "Sports and Athletics Area", VRDR.CodeSystems.PH_PlaceOfOccurrence_ICD_10_WHO },
                { "4", "Street/Highway", VRDR.CodeSystems.PH_PlaceOfOccurrence_ICD_10_WHO },
                { "5", "Trade and Service Area", VRDR.CodeSystems.PH_PlaceOfOccurrence_ICD_10_WHO },
                { "6", "Industrial and Construction Area", VRDR.CodeSystems.PH_PlaceOfOccurrence_ICD_10_WHO },
                { "7", "Farm", VRDR.CodeSystems.PH_PlaceOfOccurrence_ICD_10_WHO },
                { "8", "Other Specified Place", VRDR.CodeSystems.PH_PlaceOfOccurrence_ICD_10_WHO },
                { "9", "Unspecified Place", VRDR.CodeSystems.PH_PlaceOfOccurrence_ICD_10_WHO },
                { "NI", "No Information", VRDR.CodeSystems.PH_NullFlavor_HL7_V3 }
            };
            /// <summary> Home </summary>
            public static string  Home = "0";
            /// <summary> Residential_Institution </summary>
            public static string  Residential_Institution = "1";
            /// <summary> School_Other_Institutions_Public_Administrative_Area </summary>
            public static string  School_Other_Institutions_Public_Administrative_Area = "2";
            /// <summary> Sports_And_Athletics_Area </summary>
            public static string  Sports_And_Athletics_Area = "3";
            /// <summary> Street_Highway </summary>
            public static string  Street_Highway = "4";
            /// <summary> Trade_And_Service_Area </summary>
            public static string  Trade_And_Service_Area = "5";
            /// <summary> Industrial_And_Construction_Area </summary>
            public static string  Industrial_And_Construction_Area = "6";
            /// <summary> Farm </summary>
            public static string  Farm = "7";
            /// <summary> Other_Specified_Place </summary>
            public static string  Other_Specified_Place = "8";
            /// <summary> Unspecified_Place </summary>
            public static string  Unspecified_Place = "9";
            /// <summary> No_Information </summary>
            public static string  No_Information = "NI";
        };
        /// <summary> TransportationRoles </summary>
        public static class TransportationRoles {
            /// <summary> Codes </summary>
            public static string[,] Codes = {
                { "236320001", "Driver/Operator", VRDR.CodeSystems.SCT },
                { "257500003", "Passenger", VRDR.CodeSystems.SCT },
                { "257518000", "Pedestrian", VRDR.CodeSystems.SCT },
                { "OTH", "Other", VRDR.CodeSystems.PH_NullFlavor_HL7_V3 }
            };
            /// <summary> Driver_Operator </summary>
            public static string  Driver_Operator = "236320001";
            /// <summary> Passenger </summary>
            public static string  Passenger = "257500003";
            /// <summary> Pedestrian </summary>
            public static string  Pedestrian = "257518000";
            /// <summary> Other </summary>
            public static string  Other = "OTH";
        };
        /////////// FLAGGED FOR DELETION

        /// <summary> AdministrativeGender </summary>
        public static class AdministrativeGender {
            /// <summary> Codes </summary>
            public static string[,] Codes = {
                { "male", "Male", VRDR.CodeSystems.AdministrativeGender },
                { "female", "Female", VRDR.CodeSystems.AdministrativeGender },
                { "unknown", "unknown", VRDR.CodeSystems.AdministrativeGender }
            };
            /// <summary> Male </summary>
            public static string  Male = "male";
            /// <summary> Female </summary>
            public static string  Female = "female";
            /// <summary> Unknown </summary>
            public static string  Unknown = "unknown";
        };
        /// <summary> CertifierTypes </summary>
        public static class CertifierTypes {
            /// <summary> Codes </summary>
            public static string[,] Codes = {
                { "455381000124109", "Medical Examiner/Coroner-On the basis of examination, and/or investigation, in my opinion, death occurred at the time, date, and place, and due to the cause(s) and manner stated.", VRDR.CodeSystems.SCT },
                { "434641000124105", "Pronouncing & Certifying physician-To the best of my knowledge, death occurred at the time, date, and place, and due to the cause(s) and manner stated.", VRDR.CodeSystems.SCT },
                { "434651000124107", "Certifying physician-To the best of my knowledge, death occurred due to the cause(s) and manner stated.", VRDR.CodeSystems.SCT },
                { "OTH", "Other (Specify)", VRDR.CodeSystems.PH_NullFlavor_HL7_V3 }
            };
            /// <summary> Medical_Examiner_Coroner </summary>
            public static string  Medical_Examiner_Coroner = "455381000124109";
            /// <summary> Pronouncing_Certifying_Physician </summary>
            public static string  Pronouncing_Certifying_Physician = "434641000124105";
            /// <summary> Certifying_Physician </summary>
            public static string  Certifying_Physician = "434651000124107";
            /// <summary> Other_Specify </summary>
            public static string  Other_Specify = "OTH";
        };
        /// <summary> ContributoryTobaccoUse </summary>
        public static class ContributoryTobaccoUse {
            /// <summary> Codes </summary>
            public static string[,] Codes = {
                { "373066001", "Yes", VRDR.CodeSystems.SCT },
                { "373067005", "No", VRDR.CodeSystems.SCT },
                { "2931005", "Probably", VRDR.CodeSystems.SCT },
                { "UNK", "Unknown", VRDR.CodeSystems.PH_NullFlavor_HL7_V3 },
                { "NI", "no information", VRDR.CodeSystems.PH_NullFlavor_HL7_V3 }
            };
            /// <summary> Yes </summary>
            public static string  Yes = "373066001";
            /// <summary> No </summary>
            public static string  No = "373067005";
            /// <summary> Probably </summary>
            public static string  Probably = "2931005";
            /// <summary> Unknown </summary>
            public static string  Unknown = "UNK";
            /// <summary> No_Information </summary>
            public static string  No_Information = "NI";
        };
        /// <summary> EditBypass01 </summary>
        public static class EditBypass01 {
            /// <summary> Codes </summary>
            public static string[,] Codes = {
                { "0", "Edit Passed", VRDR.CodeSystems.BypassEditFlag },
                { "1", "Edit Failed, Data Queried, and Verified", VRDR.CodeSystems.BypassEditFlag }
            };
            /// <summary> Edit_Passed </summary>
            public static string  Edit_Passed = "0";
            /// <summary> Edit_Failed_Data_Queried_And_Verified </summary>
            public static string  Edit_Failed_Data_Queried_And_Verified = "1";
        };
        /// <summary> EditBypass012 </summary>
        public static class EditBypass012 {
            /// <summary> Codes </summary>
            public static string[,] Codes = {
                { "0", "Edit Passed", VRDR.CodeSystems.BypassEditFlag },
                { "1", "Edit Failed, Data Queried, and Verified", VRDR.CodeSystems.BypassEditFlag },
                { "2", "Edit Failed, Data Queried, but not Verified", VRDR.CodeSystems.BypassEditFlag }
            };
            /// <summary> Edit_Passed </summary>
            public static string  Edit_Passed = "0";
            /// <summary> Edit_Failed_Data_Queried_And_Verified </summary>
            public static string  Edit_Failed_Data_Queried_And_Verified = "1";
            /// <summary> Edit_Failed_Data_Queried_But_Not_Verified </summary>
            public static string  Edit_Failed_Data_Queried_But_Not_Verified = "2";
        };
        /// <summary> EditBypass01234 </summary>
        public static class EditBypass01234 {
            /// <summary> Codes </summary>
            public static string[,] Codes = {
                { "0", "Edit Passed", VRDR.CodeSystems.BypassEditFlag },
                { "1", "Edit Failed, Data Queried, and Verified", VRDR.CodeSystems.BypassEditFlag },
                { "2", "Edit Failed, Data Queried, but not Verified", VRDR.CodeSystems.BypassEditFlag },
                { "3", "Edit Failed, Review Needed", VRDR.CodeSystems.BypassEditFlag },
                { "4", "Edit Failed, Query Needed", VRDR.CodeSystems.BypassEditFlag }
            };
            /// <summary> Edit_Passed </summary>
            public static string  Edit_Passed = "0";
            /// <summary> Edit_Failed_Data_Queried_And_Verified </summary>
            public static string  Edit_Failed_Data_Queried_And_Verified = "1";
            /// <summary> Edit_Failed_Data_Queried_But_Not_Verified </summary>
            public static string  Edit_Failed_Data_Queried_But_Not_Verified = "2";
            /// <summary> Edit_Failed_Review_Needed </summary>
            public static string  Edit_Failed_Review_Needed = "3";
            /// <summary> Edit_Failed_Query_Needed </summary>
            public static string  Edit_Failed_Query_Needed = "4";
        };
        /// <summary> EditBypass0124 </summary>
        public static class EditBypass0124 {
            /// <summary> Codes </summary>
            public static string[,] Codes = {
                { "0", "Edit Passed", VRDR.CodeSystems.BypassEditFlag },
                { "1", "Edit Failed, Data Queried, and Verified", VRDR.CodeSystems.BypassEditFlag },
                { "2", "Edit Failed, Data Queried, but not Verified", VRDR.CodeSystems.BypassEditFlag },
                { "4", "Edit Failed, Query Needed", VRDR.CodeSystems.BypassEditFlag }
            };
            /// <summary> Edit_Passed </summary>
            public static string  Edit_Passed = "0";
            /// <summary> Edit_Failed_Data_Queried_And_Verified </summary>
            public static string  Edit_Failed_Data_Queried_And_Verified = "1";
            /// <summary> Edit_Failed_Data_Queried_But_Not_Verified </summary>
            public static string  Edit_Failed_Data_Queried_But_Not_Verified = "2";
            /// <summary> Edit_Failed_Query_Needed </summary>
            public static string  Edit_Failed_Query_Needed = "4";
        };
        /// <summary> EducationLevel </summary>
        public static class EducationLevel {
            /// <summary> Codes </summary>
            public static string[,] Codes = {
                { "ELEM", "Elementary School", VRDR.CodeSystems.EducationLevel },
                { "SEC", "Some secondary or high school education", VRDR.CodeSystems.EducationLevel },
                { "HS", "High School or secondary school degree complete", VRDR.CodeSystems.EducationLevel },
                { "SCOL", "Some College education", VRDR.CodeSystems.EducationLevel },
                { "POSTG", "Doctoral or post graduate education", VRDR.CodeSystems.EducationLevel },
                { "AA", "Associate's or technical degree complete", VRDR.CodeSystems.DegreeLicenceAndCertificate },
                { "BA", "Bachelor's degree", VRDR.CodeSystems.DegreeLicenceAndCertificate },
                { "MA", "Master's degree", VRDR.CodeSystems.DegreeLicenceAndCertificate },
                { "UNK", "unknown", VRDR.CodeSystems.PH_NullFlavor_HL7_V3 }
            };
            /// <summary> Elementary_School </summary>
            public static string  Elementary_School = "ELEM";
            /// <summary> Some_Secondary_Or_High_School_Education </summary>
            public static string  Some_Secondary_Or_High_School_Education = "SEC";
            /// <summary> High_School_Or_Secondary_School_Degree_Complete </summary>
            public static string  High_School_Or_Secondary_School_Degree_Complete = "HS";
            /// <summary> Some_College_Education </summary>
            public static string  Some_College_Education = "SCOL";
            /// <summary> Doctoral_Or_Post_Graduate_Education </summary>
            public static string  Doctoral_Or_Post_Graduate_Education = "POSTG";
            /// <summary> Associate_S_Or_Technical_Degree_Complete </summary>
            public static string  Associate_S_Or_Technical_Degree_Complete = "AA";
            /// <summary> Bachelor_S_Degree </summary>
            public static string  Bachelor_S_Degree = "BA";
            /// <summary> Master_S_Degree </summary>
            public static string  Master_S_Degree = "MA";
            /// <summary> Unknown </summary>
            public static string  Unknown = "UNK";
        };
        /// <summary> MannerOfDeath </summary>
        public static class MannerOfDeath {
            /// <summary> Codes </summary>
            public static string[,] Codes = {
                { "38605008", "Natural death", VRDR.CodeSystems.SCT },
                { "7878000", "Accidental death", VRDR.CodeSystems.SCT },
                { "44301001", "Suicide", VRDR.CodeSystems.SCT },
                { "27935005", "Homicide", VRDR.CodeSystems.SCT },
                { "185973002", "Patient awaiting investigation", VRDR.CodeSystems.SCT },
                { "65037004", "Death, manner undetermined", VRDR.CodeSystems.SCT }
            };
            /// <summary> Natural_Death </summary>
            public static string  Natural_Death = "38605008";
            /// <summary> Accidental_Death </summary>
            public static string  Accidental_Death = "7878000";
            /// <summary> Suicide </summary>
            public static string  Suicide = "44301001";
            /// <summary> Homicide </summary>
            public static string  Homicide = "27935005";
            /// <summary> Patient_Awaiting_Investigation </summary>
            public static string  Patient_Awaiting_Investigation = "185973002";
            /// <summary> Death_Manner_Undetermined </summary>
            public static string  Death_Manner_Undetermined = "65037004";
        };
        /// <summary> MaritalStatus </summary>
        public static class MaritalStatus {
            /// <summary> Codes </summary>
            public static string[,] Codes = {
                { "D", "Divorced", VRDR.CodeSystems.PH_MaritalStatus_HL7_2x },
                { "L", "Legally Separated", VRDR.CodeSystems.PH_MaritalStatus_HL7_2x },
                { "M", "Married", VRDR.CodeSystems.PH_MaritalStatus_HL7_2x },
                { "S", "Never Married", VRDR.CodeSystems.PH_MaritalStatus_HL7_2x },
                { "W", "Widowed", VRDR.CodeSystems.PH_MaritalStatus_HL7_2x },
                { "UNK", "unknown", VRDR.CodeSystems.PH_NullFlavor_HL7_V3 }
            };
            /// <summary> Divorced </summary>
            public static string  Divorced = "D";
            /// <summary> Legally_Separated </summary>
            public static string  Legally_Separated = "L";
            /// <summary> Married </summary>
            public static string  Married = "M";
            /// <summary> Never_Married </summary>
            public static string  Never_Married = "S";
            /// <summary> Widowed </summary>
            public static string  Widowed = "W";
            /// <summary> Unknown </summary>
            public static string  Unknown = "UNK";
        };
        /// <summary> MethodOfDisposition </summary>
        public static class MethodOfDisposition {
            /// <summary> Codes </summary>
            public static string[,] Codes = {
                { "449931000124108", "Entombment", VRDR.CodeSystems.SCT },
                { "449941000124103", "Removal from state", VRDR.CodeSystems.SCT },
                { "449951000124101", "Donation", VRDR.CodeSystems.SCT },
                { "449961000124104", "Cremation", VRDR.CodeSystems.SCT },
                { "449971000124106", "Burial", VRDR.CodeSystems.SCT },
                { "OTH", "Other", VRDR.CodeSystems.PH_NullFlavor_HL7_V3 },
                { "UNK", "Unknown", VRDR.CodeSystems.PH_NullFlavor_HL7_V3 }
            };
            /// <summary> Entombment </summary>
            public static string  Entombment = "449931000124108";
            /// <summary> Removal_From_State </summary>
            public static string  Removal_From_State = "449941000124103";
            /// <summary> Donation </summary>
            public static string  Donation = "449951000124101";
            /// <summary> Cremation </summary>
            public static string  Cremation = "449961000124104";
            /// <summary> Burial </summary>
            public static string  Burial = "449971000124106";
            /// <summary> Other </summary>
            public static string  Other = "OTH";
            /// <summary> Unknown </summary>
            public static string  Unknown = "UNK";
        };
        /// <summary> NotApplicable </summary>
        public static class NotApplicable {
            /// <summary> Codes </summary>
            public static string[,] Codes = {
                { "NA", "not applicable", VRDR.CodeSystems.PH_NullFlavor_HL7_V3 }
            };
            /// <summary> Not_Applicable </summary>
            public static string  Not_Applicable = "NA";
        };
        /// <summary> PlaceOfDeath </summary>
        public static class PlaceOfDeath {
            /// <summary> Codes </summary>
            public static string[,] Codes = {
                { "63238001", "Dead on arrival at hospital", VRDR.CodeSystems.SCT },
                { "440081000124100", "Death in home", VRDR.CodeSystems.SCT },
                { "440071000124103", "Death in hospice", VRDR.CodeSystems.SCT },
                { "16983000", "Death in hospital", VRDR.CodeSystems.SCT },
                { "450391000124102", "Death in hospital-based emergency department or outpatient department", VRDR.CodeSystems.SCT },
                { "450381000124100", "Death in nursing home or long term care facility", VRDR.CodeSystems.SCT },
                { "OTH", "Other", VRDR.CodeSystems.PH_NullFlavor_HL7_V3 },
                { "UNK", "UNK", VRDR.CodeSystems.PH_NullFlavor_HL7_V3 }
            };
            /// <summary> Dead_On_Arrival_At_Hospital </summary>
            public static string  Dead_On_Arrival_At_Hospital = "63238001";
            /// <summary> Death_In_Home </summary>
            public static string  Death_In_Home = "440081000124100";
            /// <summary> Death_In_Hospice </summary>
            public static string  Death_In_Hospice = "440071000124103";
            /// <summary> Death_In_Hospital </summary>
            public static string  Death_In_Hospital = "16983000";
            /// <summary> Death_In_Hospital_Based_Emergency_Department_Or_Outpatient_Department </summary>
            public static string  Death_In_Hospital_Based_Emergency_Department_Or_Outpatient_Department = "450391000124102";
            /// <summary> Death_In_Nursing_Home_Or_Long_Term_Care_Facility </summary>
            public static string  Death_In_Nursing_Home_Or_Long_Term_Care_Facility = "450381000124100";
            /// <summary> Other </summary>
            public static string  Other = "OTH";
            /// <summary> Unk </summary>
            public static string  Unk = "UNK";
        };
        /// <summary> PregnancyStatus </summary>
        public static class PregnancyStatus {
            /// <summary> Codes </summary>
            public static string[,] Codes = {
                { "1", "Not pregnant within past year", VRDR.CodeSystems.PregnancyStatus },
                { "2", "Pregnant at time of death", VRDR.CodeSystems.PregnancyStatus },
                { "3", "Not pregnant, but pregnant within 42 days of death", VRDR.CodeSystems.PregnancyStatus },
                { "4", "Not pregnant, but pregnant 43 days to 1 year before death", VRDR.CodeSystems.PregnancyStatus },
                { "9", "Unknown if pregnant within the past year", VRDR.CodeSystems.PregnancyStatus },
                { "NA", "Not applicable", VRDR.CodeSystems.PH_NullFlavor_HL7_V3 }
            };
            /// <summary> Not_Pregnant_Within_Past_Year </summary>
            public static string  Not_Pregnant_Within_Past_Year = "1";
            /// <summary> Pregnant_At_Time_Of_Death </summary>
            public static string  Pregnant_At_Time_Of_Death = "2";
            /// <summary> Not_Pregnant_But_Pregnant_Within_Days_Of_Death </summary>
            public static string  Not_Pregnant_But_Pregnant_Within_Days_Of_Death = "3";
            /// <summary> Not_Pregnant_But_Pregnant_Days_To_Year_Before_Death </summary>
            public static string  Not_Pregnant_But_Pregnant_Days_To_Year_Before_Death = "4";
            /// <summary> Unknown_If_Pregnant_Within_The_Past_Year </summary>
            public static string  Unknown_If_Pregnant_Within_The_Past_Year = "9";
            /// <summary> Not_Applicable </summary>
            public static string  Not_Applicable = "NA";
        };
        /// <summary> RaceMissingValueReason </summary>
        public static class RaceMissingValueReason {
            /// <summary> Codes </summary>
            public static string[,] Codes = {
                { "R", "Refused", VRDR.CodeSystems.MissingValueReason },
                { "S", "Sought, but unknown", VRDR.CodeSystems.MissingValueReason },
                { "C", "Not obtainable", VRDR.CodeSystems.MissingValueReason }
            };
            /// <summary> Refused </summary>
            public static string  Refused = "R";
            /// <summary> Sought_But_Unknown </summary>
            public static string  Sought_But_Unknown = "S";
            /// <summary> Not_Obtainable </summary>
            public static string  Not_Obtainable = "C";
        };
        /// <summary> TransportationIncidentRole </summary>
        public static class TransportationIncidentRole {
            /// <summary> Codes </summary>
            public static string[,] Codes = {
                { "236320001", "Vehicle driver", VRDR.CodeSystems.SCT },
                { "257500003", "Passenger", VRDR.CodeSystems.SCT },
                { "257518000", "Pedestrian", VRDR.CodeSystems.SCT },
                { "OTH", "Other", VRDR.CodeSystems.PH_NullFlavor_HL7_V3 },
                { "UNK", "unknown", VRDR.CodeSystems.PH_NullFlavor_HL7_V3 },
                { "NA", "not applicable", VRDR.CodeSystems.PH_NullFlavor_HL7_V3 }
            };
            /// <summary> Vehicle_Driver </summary>
            public static string  Vehicle_Driver = "236320001";
            /// <summary> Passenger </summary>
            public static string  Passenger = "257500003";
            /// <summary> Pedestrian </summary>
            public static string  Pedestrian = "257518000";
            /// <summary> Other </summary>
            public static string  Other = "OTH";
            /// <summary> Unknown </summary>
            public static string  Unknown = "UNK";
            /// <summary> Not_Applicable </summary>
            public static string  Not_Applicable = "NA";
        };
        /// <summary> UnitsOfAge </summary>
        public static class UnitsOfAge {
            /// <summary> Codes </summary>
            public static string[,] Codes = {
                { "min", "Minutes", VRDR.CodeSystems.UnitsOfMeasure },
                { "d", "Days", VRDR.CodeSystems.UnitsOfMeasure },
                { "h", "Hours", VRDR.CodeSystems.UnitsOfMeasure },
                { "mo", "Months", VRDR.CodeSystems.UnitsOfMeasure },
                { "a", "Years", VRDR.CodeSystems.UnitsOfMeasure },
                { "UNK", "unknown", VRDR.CodeSystems.PH_NullFlavor_HL7_V3 }
            };
            /// <summary> Minutes </summary>
            public static string  Minutes = "min";
            /// <summary> Days </summary>
            public static string  Days = "d";
            /// <summary> Hours </summary>
            public static string  Hours = "h";
            /// <summary> Months </summary>
            public static string  Months = "mo";
            /// <summary> Years </summary>
            public static string  Years = "a";
            /// <summary> Unknown </summary>
            public static string  Unknown = "UNK";
        };
        /// <summary> YesNoNotApplicable </summary>
        public static class YesNoNotApplicable {
            /// <summary> Codes </summary>
            public static string[,] Codes = {
                { "N", "No", VRDR.CodeSystems.YesNo },
                { "Y", "Yes", VRDR.CodeSystems.YesNo },
                { "NA", "not applicable", VRDR.CodeSystems.PH_NullFlavor_HL7_V3 }
            };
            /// <summary> No </summary>
            public static string  No = "N";
            /// <summary> Yes </summary>
            public static string  Yes = "Y";
            /// <summary> Not_Applicable </summary>
            public static string  Not_Applicable = "NA";
        };
        /// <summary> YesNoUnknownNotApplicable </summary>
        public static class YesNoUnknownNotApplicable {
            /// <summary> Codes </summary>
            public static string[,] Codes = {
                { "Y", "Yes", VRDR.CodeSystems.YesNo },
                { "N", "No", VRDR.CodeSystems.YesNo },
                { "UNK", "unknown", VRDR.CodeSystems.PH_NullFlavor_HL7_V3 },
                { "NA", "not applicable", VRDR.CodeSystems.PH_NullFlavor_HL7_V3 }
            };
            /// <summary> Yes </summary>
            public static string  Yes = "Y";
            /// <summary> No </summary>
            public static string  No = "N";
            /// <summary> Unknown </summary>
            public static string  Unknown = "UNK";
            /// <summary> Not_Applicable </summary>
            public static string  Not_Applicable = "NA";
        };
        /// <summary> YesNoUnknown </summary>
        public static class YesNoUnknown {
            /// <summary> Codes </summary>
            public static string[,] Codes = {
                { "N", "No", VRDR.CodeSystems.YesNo },
                { "Y", "Yes", VRDR.CodeSystems.YesNo },
                { "UNK", "unknown", VRDR.CodeSystems.PH_NullFlavor_HL7_V3 }
            };
            /// <summary> No </summary>
            public static string  No = "N";
            /// <summary> Yes </summary>
            public static string  Yes = "Y";
            /// <summary> Unknown </summary>
            public static string  Unknown = "UNK";
        };
   }
}
