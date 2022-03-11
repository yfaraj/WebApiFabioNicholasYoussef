TC WEB API
https://data.tc.gc.ca/v1.3/api/eng/vehicle-recall-database/recall-summary/recall-number/2016253

    "recallNumber": "2015441",
    "manufactureName": "FORD",
    "makeName": "FORD",
    "modelName": "FUSION",
    "recallYear": "2016"
	
Search by Manufacturer Recall Number
MANUFACTURER_RECALL_NO_TXT

Search by Category
CATEGORY_ETXT
CATEGORY_FTXT

Search by SYSTEM TYPE
SYSTEM_TYPE_ETXT
SYSTEM_TYPE_FTXT

Search by Notification Type
NOTIFICATION_TYPE_ETXT
NOTIFICATION_TYPE_FTXT

public class API_TC_Object_Data
{
    public int recallNumber { get; set; }
    vstring manufactureName { get; set; }
    public string makeName { get; set; }
    public string modelName { get; set; }
    public byte recallYear { get; set; }
}

public class API_1_Object_Data : API_TC_Object_Data
{
    byte ManufacturerRecallNumber { get; set; }
}

API_1_POST(C_InputFile_JSON)
{
	Input_Data = Read_TC_InputFile(C_InputFile_JSON);
	foreach(Recall Number)
	{
		Manufacturer_Recall_Number = Call_TC_API(ecall Number);
		Add_To_Input_Data(Manufacturer_Recall_Number);
	}
	Save_To_File_1(Input_Data);
}

API_1_File_DATA_JSON = API_1_GET_FILE()

API_1_Object_Data = API_1_SearchBy_Manufacturer_Recall_Number(string number)
{
	foreach(API_1_Object_Data in File_1)
	{
		if (API_1_Object_Data.Manufacturer_Recall_Number == number)
		{
			return API_1_Object_Data;
		}
	}
}

