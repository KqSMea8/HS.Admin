﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Hyt.Model;
using Hyt.ProductImport;
namespace Hyt.DataImporter.Task
{
    public class FnReceiptVoucherItem :BaseTask
    {
        public override void Read()
        {

            using (SqlConnection myConn = new SqlConnection(ConfigurationManager.AppSettings["sqlconnectionstring"].ToString()))
            {
                SqlCommand command = new SqlCommand("ImportData.dbo.proc_FnReceiptVoucherItem",myConn);
                command.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter myAdapter = new SqlDataAdapter(command);

                myAdapter.Fill(Common.RDS, "FnReceiptVoucherItem");

            }
        }

        /* SysNo, ReceiptVoucherSysNo, TransactionSysNo, PaymentTypeSysNo, Amount,
        VoucherNo, CreditCardNumber, ReceivablesSideType, ReceivablesSideSysNo, EasReceiptCode,
        Status, CreatedBy, CreatedDate, LastUpdateBy, LastUpdateDate*/
        public override void SetColumnMapping(OracleBulkCopy bcp)
        {
            bcp.ColumnMappings.Add("SysNo", "SysNo");
            bcp.ColumnMappings.Add("ReceiptVoucherSysNo", "ReceiptVoucherSysNo");
            bcp.ColumnMappings.Add("TransactionSysNo", "TransactionSysNo");
            bcp.ColumnMappings.Add("PaymentTypeSysNo", "PaymentTypeSysNo");
            bcp.ColumnMappings.Add("Amount", "Amount");
            bcp.ColumnMappings.Add("VoucherNo", "VoucherNo");

            bcp.ColumnMappings.Add("CreditCardNumber", "CreditCardNumber");
            bcp.ColumnMappings.Add("ReceivablesSideType", "ReceivablesSideType");
            bcp.ColumnMappings.Add("ReceivablesSideSysNo", "ReceivablesSideSysNo");
            bcp.ColumnMappings.Add("EasReceiptCode", "EasReceiptCode");
            bcp.ColumnMappings.Add("Status", "Status");
            bcp.ColumnMappings.Add("CreatedBy", "CreatedBy");
            bcp.ColumnMappings.Add("CreatedDate", "CreatedDate");
            bcp.ColumnMappings.Add("LastUpdateBy", "LastUpdateBy");
            bcp.ColumnMappings.Add("LastUpdateDate", "LastUpdateDate");
        }
    }
}