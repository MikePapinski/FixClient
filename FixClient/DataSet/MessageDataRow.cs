/////////////////////////////////////////////////
//
// FIX Client
//
// Copyright @ 2021 VIRTU Financial Inc.
// All rights reserved.
//
// Filename: MessageDataRow.cs
// Author:   Gary Hughes
//
/////////////////////////////////////////////////

﻿using System.Data;
using Fix;

namespace FixClient
{
    class MessageDataRow : DataRow
    {
        public MessageDataRow(DataRowBuilder builder)
        :   base(builder)
        {
        }

        public Message Message { get; set; }
    }
}
