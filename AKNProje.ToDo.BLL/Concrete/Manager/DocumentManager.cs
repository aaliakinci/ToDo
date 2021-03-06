﻿using AKNProje.ToDo.BLL.Interface;
using FastMember;
using iTextSharp.text;
using iTextSharp.text.pdf;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;

namespace AKNProje.ToDo.BLL.Concrete.Manager
{
    public class DocumentManager : IDocumentService
    {
        public byte[] ImportExcel<T>(List<T> list) where T : class, new()
        {
            var excelpackage = new ExcelPackage();
            var excelBlank = excelpackage.Workbook.Worksheets.Add("AKN PROJE");
            excelBlank.Cells["A2"].LoadFromCollection(list, true, OfficeOpenXml.Table.TableStyles.Light15);
            return excelpackage.GetAsByteArray();
        }

        public string ImportPdf<T>(List<T> list) where T : class, new()
        {

            DataTable dataTable = new DataTable();
            dataTable.Load(ObjectReader.Create(list));

            var fileName = Guid.NewGuid() + ".pdf";
            var returnPath = "/documents/" + fileName;
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/documents/"+fileName);

            var stream = new FileStream(path, FileMode.Create);

            Document document = new Document(PageSize.A4, 25f, 25f, 25f, 25f);
            PdfWriter.GetInstance(document, stream);

            document.Open();

            PdfPTable pdfpTable = new PdfPTable(dataTable.Columns.Count);

            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                pdfpTable.AddCell(dataTable.Columns[i].ColumnName);
            }
            for (int i = 0 ; i < dataTable.Rows.Count; i++)
            {
                for (int j = 0; j< dataTable.Columns.Count; j++)
                {
                    pdfpTable.AddCell(dataTable.Rows[i][j].ToString());
                }
            }


            document.Close();

            return returnPath;

        }
    }
}
