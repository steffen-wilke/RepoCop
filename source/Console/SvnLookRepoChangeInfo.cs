﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Silverseed.de">
//    (c) 2018 Steffen Wilke, Markus Hastreiter @ Silverseed.de
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Silverseed.RepoCop.Subversion
{
  using System;
  using System.Collections.Generic;

  public class SvnLookRepoChangeInfo : IRepoChangeInfo
  {
    public SvnLookRepoChangeInfo(HookType hookType, string author, string logMessage, long revision, DateTime time, ICollection<IRepoAffectedItem> affectedItems)
    {
      this.HookType = hookType;
      this.Author = author;
      this.LogMessage = logMessage;
      this.Revision = revision;
      this.Time = time;
      this.AffectedItems = affectedItems;
    }

    public HookType HookType { get; }

    public string Author { get; }

    public string LogMessage { get; }

    public long Revision { get; }

    public DateTime Time { get; }

    public ICollection<IRepoAffectedItem> AffectedItems { get; }
  }
}