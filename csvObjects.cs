using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.IO;


namespace FileConverter
{
    public class csvObjects
    {
        public DataTable ImportCsvToDataTable(string FilePath, string Extension, string isHDR)
        {
            DataTable dt = new DataTable();
            dt = ReadCSV_dt(FilePath, isHDR);

            return dt;
        }

        public void  ExportDataTableToXML(DataTable dt, string Path, String ExportedFileName)
        {
            string path = Path.ToString() + ExportedFileName.ToString();
            if (!File.Exists(path))
            {
                // Create a file to write to. 
                using (StreamWriter sw = File.CreateText(path))
                {
                    //Creates Empty File
                }
            }
            else //If path exists
            {
                File.Delete(path);
                // Create a file to write to. 
                using (StreamWriter sw = File.CreateText(path))
                {
                    //Creates Empty File
                }
            }
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            ds.WriteXml(path);
        }

        public DataSet ImportDataTableFromXML(string path)
        {
            //string path = Path.ToString() + ExportedFileName.ToString();
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            ds.ReadXml(path);
            return ds;
        }

        public DataTable ReadCSV_dt(string path, string isHDR)
        {
            if (isHDR == "Yes")
            {
                DataRow row;
                List<string> csvRows = new List<string>();

                int i = 0;
                int count = 0;
                DataTable dt = new DataTable();
                DataSet tableADataSet = new DataSet();
                //string sourceDbConnectionString = @"this_is_your_connection_string_to_the_source_database";
                //string sourceDbConnectionString = ConfigurationManager.ConnectionStrings["VAINTDBConnection"].ConnectionString;
                // SqlConnection sourceDbConnectionString = ExportHelpers.ConnectionManager.GetCanvasConnection();

                List<string> csvLinesCAI = new List<string>();
                //ConsumerAssessmentItemsSheetCSV                                            //(Place Path to CSV file here) //@"c:\temp\WA\ConsumerAssessmentItemsSheetCSV.csv"
                using (System.IO.StreamReader csvStreamReaderCAI = new System.IO.StreamReader(path))
                {
                    while (!csvStreamReaderCAI.EndOfStream)
                    {
                        i = 0;
                        row = dt.NewRow();
                        string currentLine = csvStreamReaderCAI.ReadLine();
                        csvLinesCAI.Add(currentLine);

                        //string[] rows = currentLine.Split("\r".ToCharArray());
                        //int i = rows.Count();

                        string[] rows = currentLine.Split('\n');
                        foreach (string s in rows)
                        {
                            string[] columns = s.Split(',');
                            int cc = columns.Count();
                            foreach (string t in columns)
                            {
                                if (count == 0)
                                {
                                    dt.Columns.Add(t.ToString());
                                    //add header row to the dataTable
                                }
                                if (count > 0)
                                {
                                    //add data to the dataTable
                                    row[i] = t.ToString();
                                }
                                if (count > 0 && i == cc - 1)
                                {
                                    dt.Rows.Add(row);
                                }
                                // each data element
                                i += 1;
                            }

                        }
                        count++;
                    }

                }



                //Add all of the rows from the csv fle to the string array. 

                return dt;
            }
            else
            {
                DataTable rdt = new DataTable();
                DataRow row;
                List<string> csvRows = new List<string>();

                int i = 0;
                int count = 0;
                DataTable dt = new DataTable();
                DataSet tableADataSet = new DataSet();
                //string sourceDbConnectionString = @"this_is_your_connection_string_to_the_source_database";
                //string sourceDbConnectionString = ConfigurationManager.ConnectionStrings["VAINTDBConnection"].ConnectionString;
                // SqlConnection sourceDbConnectionString = ExportHelpers.ConnectionManager.GetCanvasConnection();

                List<string> csvLinesCAI = new List<string>();
                //ConsumerAssessmentItemsSheetCSV                                            //(Place Path to CSV file here) //@"c:\temp\WA\ConsumerAssessmentItemsSheetCSV.csv"
                using (System.IO.StreamReader csvStreamReaderCAI = new System.IO.StreamReader(path))
                {
                    while (!csvStreamReaderCAI.EndOfStream)
                    {
                        i = 0;
                        row = dt.NewRow();
                        string currentLine = csvStreamReaderCAI.ReadLine();
                        csvLinesCAI.Add(currentLine);

                        //string[] rows = currentLine.Split("\r".ToCharArray());
                        //int i = rows.Count();

                        string[] rows = currentLine.Split('\n');
                        foreach (string s in rows)
                        {
                            string[] columns = s.Split(',');
                            int cc = columns.Count();
                            foreach (string t in columns)
                            {
                                //if (count == 0)
                                //{
                                //    dt.Columns.Add(t.ToString());
                                //    //add header row to the dataTable
                                //}
                              
                                    //add data to the dataTable
                                    row[i] = t.ToString();
                               
                                if (i == cc - 1)
                                {
                                    dt.Rows.Add(row);
                                }
                                // each data element
                                i += 1;
                            }

                        }
                        count++;
                    }

                }



                //Add all of the rows from the csv fle to the string array. 

                rdt = dt;
                

                return rdt;
            }
        }

    }
}