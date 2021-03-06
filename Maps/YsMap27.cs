#pragma warning disable
using System.Collections.Generic;
using XPT.Legacy;
using XPT.Legacy.Entities;

namespace XPT.Legacy.Maps {
    class YserMap27 : AMapScripted {
        protected override int MapIndex => 27;
        protected override int RandomEncounterChance => 5;
        protected override int RandomEncounterExtraCount => 0;

        public YserMap27() {
            MapEvent01 = FnGATEWAYA_01;
            MapEvent02 = FnXOVERA_02;
            MapEvent03 = FnXOVERB_03;
            MapEvent04 = FnAREAA_04;
            MapEvent05 = FnAREAB_05;
            MapEvent06 = FnAREAC_06;
            MapEvent07 = FnAREAD_07;
            MapEvent09 = FnARENTEXT_09;
            MapEvent0A = FnWAITTEXT_0A;
        }
        
        // === Strings ================================================
        private const string String03FC = "A Gateway back to the Labyrinth.";
        private const string String041D = "Gate to the entrance of Arnakkian's Arena.";
        private const string String0448 = "Gate to the Red Arena Staging Area.";
        private const string String046C = "Gate to the Blue Arena Staging Area.";
        private const string String0491 = "Gate to the Green Arena Staging Area.";
        private const string String04B7 = "Gate to the Yellow Arena Staging Area.";
        private const string String04DE = "In the time when Arnakkian bestrode the land of Twinion, a Great Arena was built where the bravest warriors and wisest mages could challenge each other in deadly battle.";
        private const string String0588 = "You stand in the nexus of the Arena.  Doorways lead to the four team staging areas.";
        private const string String05DC = "Carved on a recessed stone, you find a roster from a Arnakkian-era private guild.  None of the names are recognizable. ";
        
        // === Functions ================================================
        private void FnGATEWAYA_01(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String03FC); // A Gateway back to the Labyrinth.
            L0010: TeleportParty(player, 0x36, 0x01, 0x3F, 0x00, type);
            L002A: return; // RETURN;
        }

        private void FnXOVERA_02(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x36, 0x02, 0x57, 0x02, type);
            L001E: return; // RETURN;
        }

        private void FnXOVERB_03(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String041D); // Gate to the entrance of Arnakkian's Arena.
            L0010: TeleportParty(player, 0x36, 0x02, 0x51, 0x00, type);
            L002A: return; // RETURN;
        }

        private void FnAREAA_04(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String0448); // Gate to the Red Arena Staging Area.
            L0010: TeleportParty(player, 0x36, 0x02, 0x33, 0x03, type);
            L002B: return; // RETURN;
        }

        private void FnAREAB_05(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String046C); // Gate to the Blue Arena Staging Area.
            L0010: TeleportParty(player, 0x36, 0x02, 0xC3, 0x03, type);
            L002B: return; // RETURN;
        }

        private void FnAREAC_06(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String0491); // Gate to the Green Arena Staging Area.
            L0010: TeleportParty(player, 0x36, 0x02, 0xCC, 0x03, type);
            L002B: return; // RETURN;
        }

        private void FnAREAD_07(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String04B7); // Gate to the Yellow Arena Staging Area.
            L0010: TeleportParty(player, 0x36, 0x02, 0x3C, 0x03, type);
            L002B: return; // RETURN;
        }

        private void FnARENTEXT_09(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String04DE); // In the time when Arnakkian bestrode the land of Twinion, a Great Arena was built where the bravest warriors and wisest mages could challenge each other in deadly battle.
            L0010: ShowMessage(player, doMsgs, String0588); // You stand in the nexus of the Arena.  Doorways lead to the four team staging areas.
            L001D: return; // RETURN;
        }

        private void FnWAITTEXT_0A(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String05DC); // Carved on a recessed stone, you find a roster from a Arnakkian-era private guild.  None of the names are recognizable. 
            L0010: return; // RETURN;
        }

    }
}
