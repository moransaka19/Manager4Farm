using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manager4HospitalBackEnd.AzureStorage
{
    public interface IStorage<T>
    {
        public T Download(string blobName);

        public void Upliad(T flie);
    }
}
