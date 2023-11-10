using AzureBlobStorage.Models;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureBlobStorage.AzureStorage
{
    public class AzureBlobOptions : AzureBlob
    {
        public AzureBlobOptions(IOptions<AzureOptionsModel> options): base(options.Value.ConnectionKey, options.Value.Container) 
        {

        }
    }
}
