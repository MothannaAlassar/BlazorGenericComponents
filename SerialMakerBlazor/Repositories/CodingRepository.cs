using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SerialMakerBlazor.Repositories
{
    public class CodingRepository: ICodingRepository
    {

        List<Data.Coding> ICodingRepository.GetAllLicenceTypes()
        {
            return new List<Data.Coding>
            {
                new Data.Coding{CodingName="Trial",CodingValue="Trial"},
                new Data.Coding{CodingName="Actual",CodingValue="Actual"},
            };
        }
        List<Data.Coding> ICodingRepository.GetAllInstallationTypes()
        {
            return new List<Data.Coding>
            {
                new Data.Coding{CodingName="Main version",CodingValue="Main version"},
                new Data.Coding{CodingName="Subsidiary version",CodingValue="Subsidiary version"},
            };
        }
    }
}
