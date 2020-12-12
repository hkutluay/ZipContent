﻿using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ZipContent.Core
{
    public interface IZipContentLister
    {
         Task<IList<ZipEntry>> GetContents(CancellationToken cancellationToken = default);
    }
}
