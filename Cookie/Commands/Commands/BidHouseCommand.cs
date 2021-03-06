﻿using System;
using System.Linq;
using Cookie.API.Commands;
using Cookie.API.Core;
using Cookie.API.Gamedata;
using Cookie.API.Utils;
using Cookie.API.Utils.Enums;
using Cookie.Game.BidHouse;

namespace Cookie.Commands.Commands
{
    public class BidHouseCommand : ICommand
    {
        public string CommandSufix => "[HDV]";
        public string CommandName => "hdv";

        public async void OnCommand(IAccount account, string[] args)
        {
            try
            {
                if (args.Length < 1)
                {
                    Logger.Default.Log("Vous devez spécifier l'id de l'item à chercher", LogMessageType.Error);
                }
                else
                {
                    var itemid = Convert.ToUInt32(args[0]);

                    var hdv = new BidHouse(account);
                    if (!await hdv.StartBidHouseDialog()) return;
                    if (!await hdv.LoadItemData(itemid)) return;

                    var prices = hdv.ItemPricesList.FirstOrDefault();
                    Logger.Default.Log(
                        $" Prix de {D2OParsing.GetItemName(itemid)} => 1:{prices[0]}-  10:{prices[1]} - 100:{prices[2]} - Mean:{hdv.MeanPrice}");

                    hdv.ExitBidHouseDialog();
                }
            }
            catch (Exception ex)
            {
                Logger.Default.Log($"{CommandSufix} Error : {ex.Message}", LogMessageType.Error);
                Logger.Default.Log($"{CommandSufix} StackTrace : {ex.StackTrace}", LogMessageType.Error);
            }
        }
    }
}