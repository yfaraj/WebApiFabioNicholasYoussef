using Newtonsoft.Json;

namespace CommonStructures
{
     public class TC_Data_API_4 : TC_Data_API_3
    {
        [JsonProperty(Order = 11)]
        public string NotificationTypeETXT { get; set; }
        [JsonProperty(Order = 12)]
        public string NotificationTypeFTXT { get; set; }
          
          /*
          API_4_POST(C_InputFile_JSON)
          {
               Input_Data = Read_TC_InputFile(C_InputFile_JSON);
               foreach(Notification Type)
               {
                    Notification_Type = Call_TC_API(Notification Type);
                    Add_To_Input_Data(Notification_Type);
               }
               Save_To_File_1(Input_Data);
          }

          API_4_File_DATA_JSON = API_4_GET_FILE()

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
          */
     }
}