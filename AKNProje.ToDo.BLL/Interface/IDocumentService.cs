using System;
using System.Collections.Generic;
using System.Text;

namespace AKNProje.ToDo.BLL.Interface
{
    public interface IDocumentService
    {
        /// <summary>
        ///  Geriye üretmiş ve uploName etmiş olduğu pdf dosyasının virtual pathini döner
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        string ImportPdf<T>(List<T> list) where T: class,new();

        /// <summary>
        /// Geriye excel verisini byte dizisi olarak döner
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        byte[] ImportExcel<T>(List<T> list) where T : class, new();
    }
}
