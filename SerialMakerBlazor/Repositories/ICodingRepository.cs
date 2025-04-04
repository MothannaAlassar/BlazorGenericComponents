using SerialMakerBlazor.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SerialMakerBlazor.Repositories
{
    public interface ICodingRepository
    {
        List<Coding> GetAllLicenceTypes();
        List<Coding> GetAllInstallationTypes();
    }
}
