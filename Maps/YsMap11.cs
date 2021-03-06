#pragma warning disable
using System.Collections.Generic;
using XPT.Legacy;
using XPT.Legacy.Entities;

namespace XPT.Legacy.Maps {
    class YserMap11 : AMapScripted {
        protected override int MapIndex => 11;
        protected override int RandomEncounterChance => 10;
        protected override int RandomEncounterExtraCount => 0;

        public YserMap11() {
            MapEvent01 = FnTOCORRA_01;
            MapEvent02 = FnIMPILLAR_02;
            MapEvent03 = FnILPILLAR_03;
            MapEvent04 = FnPASSCOLM_04;
            MapEvent05 = FnTAPESTRY_05;
            MapEvent06 = FnKNGGHST_06;
            MapEvent07 = FnPIT_07;
            MapEvent08 = FnAVRMNSTR_08;
            MapEvent09 = FnSTRMNSTR_09;
            MapEvent0A = FnTUFMNSTR_0A;
            MapEvent0C = FnWEAPBENC_0C;
            MapEvent0D = FnWEAPAENC_0D;
            MapEvent0E = FnWEAPCENC_0E;
            MapEvent0F = FnSHLDENC_0F;
            MapEvent10 = FnJACKTENC_10;
            MapEvent11 = FnARMRBENC_11;
            MapEvent12 = FnRUNES_12;
            MapEvent15 = FnLKPKDOOR_15;
            MapEvent16 = FnSTRDOOR_16;
            MapEvent17 = FnLKPKDOOR_17;
            MapEvent18 = FnTRAPDORA_18;
            MapEvent19 = FnTRAPDORB_19;
            MapEvent1A = FnTRAPDORC_1A;
            MapEvent1B = FnTRAPDORD_1B;
            MapEvent1C = FnTRAPDORE_1C;
            MapEvent1D = FnTRAPDORF_1D;
            MapEvent1E = FnTRAPDORG_1E;
            MapEvent1F = FnTRAPDORH_1F;
            MapEvent20 = FnTRAPDORI_20;
            MapEvent21 = FnTRAPDORJ_21;
            MapEvent22 = FnTRAPDORK_22;
            MapEvent23 = FnTRAPDORL_23;
            MapEvent24 = FnTRAPDORM_24;
            MapEvent25 = FnTRAPDORN_25;
            MapEvent26 = FnTRAPDORO_26;
            MapEvent27 = FnTRAPDORP_27;
            MapEvent28 = FnTRAPDORQ_28;
            MapEvent29 = FnTOCORRB_29;
            MapEvent2A = FnGATEMESS_2A;
            MapEvent2B = FnPASSCOLM_2B;
            MapEvent2C = Fn_2C;
            MapEvent2D = FnNPCCHATA_2D;
            MapEvent2E = FnNPCCHATB_2E;
            MapEvent2F = FnNPCCHATC_2F;
            MapEvent30 = FnKINGMSG_30;
        }
        
        // === Strings ================================================
        private const string String03FC = "As you step forward, the column slides away.";
        private const string String0429 = "As you step forward, the column slides away.";
        private const string String0456 = "Runes appear on the tapestry...";
        private const string String0476 = "Imps have hidden the Crown, Robe and Scepter. Only a master of the runes may find them. Two-faced Y is at the center of the quest. From Y, open O and E and I. When a rune key is used correctly, it will disappear.";
        private const string String054B = "You see an ornate tapestry. The middle of the tapestry is blank.";
        private const string String058C = "King Cleowyn's angry spirit appears.";
        private const string String05B1 = "He tears the Key to the Palace away from you as he and his courtiers attack.";
        private const string String05FE = "King Cleowyn and his dead courtiers appear to challenge you.";
        private const string String063B = "You fall into a deep, deep pit.";
        private const string String065B = "Your body provides a soft landing pad for the rest of your party.";
        private const string String069D = "You feel the tickle of cobwebs on your neck.";
        private const string String06CA = "Spiders are using a spear in the middle of the floor as a support for their webs.";
        private const string String071C = "You see a weapon on the floor and step forward. Banshees sense your presence and gather to attack.";
        private const string String077F = "Nightmares emerge from the shadows.";
        private const string String07A3 = "A group of Nightmares claw at an axe on the floor.";
        private const string String07D6 = "You stumble upon some Zombies, eating the remains of a former adventurer.";
        private const string String0820 = "The shuffle of heavy feet put you on your guard. One of the things kicks a shield out of its way.";
        private const string String0882 = "Ghosts rise from the floor to haunt you.";
        private const string String08AB = "Ghosts are gathered around a jacket on the floor. They seem to be pondering its purpose.";
        private const string String0904 = "Skeletons of King Cleowyn's elite palace guard advance on you.";
        private const string String0943 = "The leader of the dead palace guards that surrounds you wears rusty chainmail.";
        private const string String0992 = "There are runes on the wall...";
        private const string String09B1 = "What you see is not always what is real.";
        private const string String09DA = "You successfully picked the locked door.";
        private const string String0A03 = "The door is locked.";
        private const string String0A17 = "You manage to open the door by brute force.";
        private const string String0A43 = "You are not strong enough to force the door open.";
        private const string String0A75 = "You picked the lock of the door successfully.";
        private const string String0AA3 = "The door is locked.";
        private const string String0AB7 = "You found a trapdoor on the floor.";
        private const string String0ADA = "You fall through a trapdoor.";
        private const string String0AF7 = "You found a trapdoor on the floor.";
        private const string String0B1A = "You fall through a trapdoor.";
        private const string String0B37 = "You found a trapdoor on the floor.";
        private const string String0B5A = "You fall through a trapdoor.";
        private const string String0B77 = "You found a trapdoor on the floor.";
        private const string String0B9A = "You fall through a trapdoor.";
        private const string String0BB7 = "You found a trapdoor on the floor.";
        private const string String0BDA = "You fall through a trapdoor.";
        private const string String0BF7 = "You found a trapdoor on the floor.";
        private const string String0C1A = "You fall through a trapdoor.";
        private const string String0C37 = "You found a trapdoor on the floor.";
        private const string String0C5A = "You fall through a trapdoor.";
        private const string String0C77 = "You found a trapdoor on the floor.";
        private const string String0C9A = "You fall through a trapdoor.";
        private const string String0CB7 = "You found a trapdoor on the floor.";
        private const string String0CDA = "You fall through a trapdoor.";
        private const string String0CF7 = "You found a trapdoor on the floor.";
        private const string String0D1A = "You fall through a trapdoor.";
        private const string String0D37 = "You found a trapdoor on the floor.";
        private const string String0D5A = "You fall through a trapdoor.";
        private const string String0D77 = "You found a trapdoor on the floor.";
        private const string String0D9A = "You fall through a trapdoor.";
        private const string String0DB7 = "You found a trapdoor on the floor.";
        private const string String0DDA = "You fall through a trapdoor.";
        private const string String0DF7 = "You found a trapdoor on the floor.";
        private const string String0E1A = "You fall through a trapdoor.";
        private const string String0E37 = "You found a trapdoor on the floor.";
        private const string String0E5A = "You fall through a trapdoor.";
        private const string String0E77 = "You found a trapdoor on the floor.";
        private const string String0E9A = "You fall through a trapdoor.";
        private const string String0EB7 = "You found a trapdoor on the floor.";
        private const string String0EDA = "You fall through a trapdoor.";
        private const string String0EF7 = "The gateway leads to THE PALACE CORRIDOR.";
        private const string String0F21 = "As you step forward, the column slides away.";
        private const string String0F4E = "You bump into the pillar.";
        private const string String0F68 = "You encounter an Elf Ranger.";
        private const string String0F85 = "The ghost of King Cleowyn appears at his throne on special occasions. Once the king appears, he will not appear again until all mortals have left the Palace.";
        private const string String1023 = "The Elf Ranger ignores you as he wanders the room, rapping on the walls.";
        private const string String106C = "You encounter a Gremlin Thief.";
        private const string String108B = "The pit is pitiless. Do not go near it. The traps are dangerous, but they may aid you.";
        private const string String10E2 = "The Gremlin Thief runs away when you approach him.";
        private const string String1115 = "You encounter a Dwarf Knight.";
        private const string String1133 = "Obey the king. Return his cherished possessions and you will be blessed. Keep them and you will die.";
        private const string String1198 = "The Dwarf Knight snubs you and wanders off in search of adventure.";
        private const string String11DB = "Very good, heroes. You have proven your strength in battle. Know that I am the spirit of King Cleowyn, called the Cruel. I set you a quest.";
        private const string String1267 = "The imps who serve Arnakkian have stolen my Crown, Robe, and Scepter. I want them back. Return them to their proper places in my mausoleum, and I shall reward you.";
        private const string String130B = "If you keep my possessions, I shall curse you! I give you gold to dull your greed.";
        private const string String135E = "I earned Arnakkian's enmity because I tried to wrest his secrets from the buried castle";
        private const string String13B6 = "I almost succeeded, but the spirit of the wizard tracked me down and killed me.";
        private const string String1406 = "I would be grateful if you can find my body and place it in my mausoleum. Then, perhaps, my spirit can rest in peace.";
        private const string String147C = "But first you must return my possessions to me. Then I shall let you continue your journeys.";
        private const string String14D9 = "Take my ring as seal of your promise. Go, heroes! Find the tapestry and read. Start your quest.";
        private const string String1539 = "Echoes of ghostly laughter mock you.";
        
        // === Functions ================================================
        private void FnTOCORRA_01(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x02, 0x02, 0xF0, 0x03, type);
            L001E: return; // RETURN;
        }

        private void FnIMPILLAR_02(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFloorPassable(player, 0x00, GetCurrentTile(player));
            L0017: return; // RETURN;
        }

        private void FnILPILLAR_03(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String03FC); // As you step forward, the column slides away.
            L0010: SetFloorPassable(player, 0x7F, 0x01);
            L0021: return; // RETURN;
        }

        private void FnPASSCOLM_04(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String0429); // As you step forward, the column slides away.
            L0010: SetFloorPassable(player, 0xF5, 0x01);
            L0021: return; // RETURN;
        }

        private void FnTAPESTRY_05(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xF8);
            L0011: if (JumpEqual) goto L002F;
            L0013: ShowMessage(player, doMsgs, String0456); // Runes appear on the tapestry...
            L0020: ShowRunes(player, doMsgs, String0476); // Imps have hidden the Crown, Robe and Scepter. Only a master of the runes may find them. Two-faced Y is at the center of the quest. From Y, open O and E and I. When a rune key is used correctly, it will disappear.
            L002D: goto L003C;
            L002F: ShowMessage(player, doMsgs, String054B); // You see an ornate tapestry. The middle of the tapestry is blank.
            L003C: return; // RETURN;
        }

        private void FnKNGGHST_06(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xF8);
            L0011: if (JumpEqual) goto L005B;
            L0013: ShowMessage(player, doMsgs, String058C); // King Cleowyn's angry spirit appears.
            L0020: ShowMessage(player, doMsgs, String05B1); // He tears the Key to the Palace away from you as he and his courtiers attack.
            L002D: AddTreasure(player, 0x03E8, 0x00, 0x00, 0x00, 0xB7, 0xCF);
            L004D: RemoveItem(player, 0xD9);
            L0059: goto L0089;
            L005B: ShowMessage(player, doMsgs, String05FE); // King Cleowyn and his dead courtiers appear to challenge you.
            L0068: AddTreasure(player, 0x3A98, 0x00, 0x00, 0xF8, 0xB7, 0xCF);
            L0089: AddEncounter(player, 0x05, 0x25);
            L009B: AddEncounter(player, 0x01, 0x01);
            L00AD: AddEncounter(player, 0x02, 0x08);
            L00BF: return; // RETURN;
        }

        private void FnPIT_07(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFloorItem(player, 0x01, GetCurrentTile(player));
            L0018: ShowMessage(player, doMsgs, String063B); // You fall into a deep, deep pit.
            L0025: Compare(PartyCount(player), 0x0001);
            L0030: if (JumpNotEqual) goto L005C;
            L0032: DamagePlayer(player, 0x00FA);
            L003F: TeleportParty(player, 0x04, 0x01, 0xE0, 0x02, type);
            L005A: goto L0091;
            L005C: ShowMessage(player, doMsgs, String065B); // Your body provides a soft landing pad for the rest of your party.
            L0069: DamagePlayer(player, 0x0190);
            L0076: TeleportParty(player, 0x04, 0x01, 0xE0, 0x02, type);
            L0091: return; // RETURN;
        }

        private void FnAVRMNSTR_08(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L0049;
            L0010: AddEncounter(player, 0x01, 0x19);
            L0022: AddEncounter(player, 0x02, 0x1A);
            L0034: AddEncounter(player, 0x03, 0x19);
            L0046: goto L013D;
            L0049: Compare(PartyCount(player), 0x0002);
            L0054: if (JumpEqual) goto L0063;
            L0056: Compare(PartyCount(player), 0x0003);
            L0061: if (JumpNotEqual) goto L00D1;
            L0063: AddEncounter(player, 0x01, 0x1C);
            L0075: AddEncounter(player, 0x02, 0x1C);
            L0087: AddEncounter(player, 0x03, 0x1C);
            L0099: AddEncounter(player, 0x04, 0x1C);
            L00AB: AddEncounter(player, 0x05, 0x1B);
            L00BD: AddEncounter(player, 0x06, 0x1B);
            L00CF: goto L013D;
            L00D1: AddEncounter(player, 0x01, 0x1B);
            L00E3: AddEncounter(player, 0x02, 0x1B);
            L00F5: AddEncounter(player, 0x03, 0x1B);
            L0107: AddEncounter(player, 0x04, 0x1B);
            L0119: AddEncounter(player, 0x05, 0x1B);
            L012B: AddEncounter(player, 0x06, 0x1B);
            L013D: return; // RETURN;
        }

        private void FnSTRMNSTR_09(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpEqual) goto L001D;
            L0010: Compare(PartyCount(player), 0x0002);
            L001B: if (JumpNotEqual) goto L0044;
            L001D: AddEncounter(player, 0x01, 0x1F);
            L002F: AddEncounter(player, 0x02, 0x1F);
            L0041: goto L00F5;
            L0044: Compare(PartyCount(player), 0x0003);
            L004F: if (JumpNotEqual) goto L009B;
            L0051: AddEncounter(player, 0x01, 0x20);
            L0063: AddEncounter(player, 0x02, 0x20);
            L0075: AddEncounter(player, 0x03, 0x1E);
            L0087: AddEncounter(player, 0x04, 0x1E);
            L0099: goto L00F5;
            L009B: AddEncounter(player, 0x01, 0x1F);
            L00AD: AddEncounter(player, 0x02, 0x1F);
            L00BF: AddEncounter(player, 0x03, 0x1F);
            L00D1: AddEncounter(player, 0x04, 0x1F);
            L00E3: AddEncounter(player, 0x05, 0x20);
            L00F5: return; // RETURN;
        }

        private void FnTUFMNSTR_0A(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L0037;
            L0010: AddEncounter(player, 0x01, 0x22);
            L0022: AddEncounter(player, 0x01, 0x22);
            L0034: goto L0152;
            L0037: Compare(PartyCount(player), 0x0002);
            L0042: if (JumpNotEqual) goto L007D;
            L0044: AddEncounter(player, 0x01, 0x23);
            L0056: AddEncounter(player, 0x02, 0x21);
            L0068: AddEncounter(player, 0x03, 0x21);
            L007A: goto L0152;
            L007D: Compare(PartyCount(player), 0x0003);
            L0088: if (JumpNotEqual) goto L00E6;
            L008A: AddEncounter(player, 0x01, 0x21);
            L009C: AddEncounter(player, 0x02, 0x21);
            L00AE: AddEncounter(player, 0x03, 0x24);
            L00C0: AddEncounter(player, 0x04, 0x24);
            L00D2: AddEncounter(player, 0x05, 0x23);
            L00E4: goto L0152;
            L00E6: AddEncounter(player, 0x01, 0x23);
            L00F8: AddEncounter(player, 0x02, 0x23);
            L010A: AddEncounter(player, 0x03, 0x23);
            L011C: AddEncounter(player, 0x04, 0x23);
            L012E: AddEncounter(player, 0x05, 0x22);
            L0140: AddEncounter(player, 0x06, 0x22);
            L0152: return; // RETURN;
        }

        private void FnWEAPBENC_0C(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0x35);
            L0011: if (JumpEqual) goto L0041;
            L0013: ShowMessage(player, doMsgs, String069D); // You feel the tickle of cobwebs on your neck.
            L0020: AddTreasure(player, 0x012C, 0x00, 0x00, 0x00, 0x00, 0xB6);
            L003F: goto L006E;
            L0041: AddTreasure(player, 0x03E8, 0x00, 0x00, 0x00, 0xCF, 0x35);
            L0061: ShowMessage(player, doMsgs, String06CA); // Spiders are using a spear in the middle of the floor as a support for their webs.
            L006E: Compare(PartyCount(player), 0x0001);
            L0079: if (JumpEqual) goto L0088;
            L007B: Compare(PartyCount(player), 0x0002);
            L0086: if (JumpNotEqual) goto L00AF;
            L0088: AddEncounter(player, 0x01, 0x19);
            L009A: AddEncounter(player, 0x02, 0x1A);
            L00AC: goto L013C;
            L00AF: Compare(PartyCount(player), 0x0003);
            L00BA: if (JumpNotEqual) goto L00F4;
            L00BC: AddEncounter(player, 0x01, 0x19);
            L00CE: AddEncounter(player, 0x02, 0x19);
            L00E0: AddEncounter(player, 0x03, 0x1A);
            L00F2: goto L013C;
            L00F4: AddEncounter(player, 0x01, 0x19);
            L0106: AddEncounter(player, 0x02, 0x1A);
            L0118: AddEncounter(player, 0x03, 0x1B);
            L012A: AddEncounter(player, 0x04, 0x1C);
            L013C: return; // RETURN;
        }

        private void FnWEAPAENC_0D(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddTreasure(player, 0x1964, 0x00, 0x00, 0x00, 0x00, 0x3B);
            L0022: ShowMessage(player, doMsgs, String071C); // You see a weapon on the floor and step forward. Banshees sense your presence and gather to attack.
            L002F: Compare(PartyCount(player), 0x0001);
            L003A: if (JumpEqual) goto L0049;
            L003C: Compare(PartyCount(player), 0x0002);
            L0047: if (JumpNotEqual) goto L0082;
            L0049: AddEncounter(player, 0x01, 0x21);
            L005B: AddEncounter(player, 0x02, 0x22);
            L006D: AddEncounter(player, 0x03, 0x21);
            L007F: goto L0157;
            L0082: Compare(PartyCount(player), 0x0003);
            L008D: if (JumpNotEqual) goto L00EB;
            L008F: AddEncounter(player, 0x01, 0x22);
            L00A1: AddEncounter(player, 0x02, 0x22);
            L00B3: AddEncounter(player, 0x03, 0x21);
            L00C5: AddEncounter(player, 0x04, 0x24);
            L00D7: AddEncounter(player, 0x05, 0x23);
            L00E9: goto L0157;
            L00EB: AddEncounter(player, 0x01, 0x23);
            L00FD: AddEncounter(player, 0x02, 0x23);
            L010F: AddEncounter(player, 0x03, 0x21);
            L0121: AddEncounter(player, 0x04, 0x21);
            L0133: AddEncounter(player, 0x05, 0x24);
            L0145: AddEncounter(player, 0x06, 0x24);
            L0157: return; // RETURN;
        }

        private void FnWEAPCENC_0E(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0x16);
            L0011: if (JumpEqual) goto L0041;
            L0013: ShowMessage(player, doMsgs, String077F); // Nightmares emerge from the shadows.
            L0020: AddTreasure(player, 0x00C8, 0x00, 0x00, 0x00, 0x00, 0xCE);
            L003F: goto L006E;
            L0041: AddTreasure(player, 0x0BB8, 0x00, 0x00, 0x00, 0xCF, 0x16);
            L0061: ShowMessage(player, doMsgs, String07A3); // A group of Nightmares claw at an axe on the floor.
            L006E: Compare(PartyCount(player), 0x0001);
            L0079: if (JumpEqual) goto L0088;
            L007B: Compare(PartyCount(player), 0x0002);
            L0086: if (JumpNotEqual) goto L00C1;
            L0088: AddEncounter(player, 0x01, 0x1E);
            L009A: AddEncounter(player, 0x02, 0x1E);
            L00AC: AddEncounter(player, 0x03, 0x1D);
            L00BE: goto L0196;
            L00C1: Compare(PartyCount(player), 0x0003);
            L00CC: if (JumpNotEqual) goto L012A;
            L00CE: AddEncounter(player, 0x01, 0x1F);
            L00E0: AddEncounter(player, 0x02, 0x20);
            L00F2: AddEncounter(player, 0x03, 0x1E);
            L0104: AddEncounter(player, 0x04, 0x1D);
            L0116: AddEncounter(player, 0x05, 0x1F);
            L0128: goto L0196;
            L012A: AddEncounter(player, 0x01, 0x1F);
            L013C: AddEncounter(player, 0x02, 0x1F);
            L014E: AddEncounter(player, 0x03, 0x20);
            L0160: AddEncounter(player, 0x04, 0x20);
            L0172: AddEncounter(player, 0x05, 0x1F);
            L0184: AddEncounter(player, 0x06, 0x1F);
            L0196: return; // RETURN;
        }

        private void FnSHLDENC_0F(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0x4E);
            L0011: if (JumpEqual) goto L0042;
            L0013: ShowMessage(player, doMsgs, String07D6); // You stumble upon some Zombies, eating the remains of a former adventurer.
            L0020: AddTreasure(player, 0x0190, 0x00, 0x00, 0x00, 0xB5, 0xCE);
            L0040: goto L006F;
            L0042: AddTreasure(player, 0x0E74, 0x00, 0x00, 0x00, 0xB5, 0x4E);
            L0062: ShowMessage(player, doMsgs, String0820); // The shuffle of heavy feet put you on your guard. One of the things kicks a shield out of its way.
            L006F: Compare(PartyCount(player), 0x0001);
            L007A: if (JumpEqual) goto L0089;
            L007C: Compare(PartyCount(player), 0x0002);
            L0087: if (JumpNotEqual) goto L00D4;
            L0089: AddEncounter(player, 0x01, 0x11);
            L009B: AddEncounter(player, 0x02, 0x12);
            L00AD: AddEncounter(player, 0x03, 0x12);
            L00BF: AddEncounter(player, 0x04, 0x12);
            L00D1: goto L01BB;
            L00D4: Compare(PartyCount(player), 0x0003);
            L00DF: if (JumpNotEqual) goto L014F;
            L00E1: AddEncounter(player, 0x01, 0x12);
            L00F3: AddEncounter(player, 0x02, 0x12);
            L0105: AddEncounter(player, 0x03, 0x13);
            L0117: AddEncounter(player, 0x04, 0x13);
            L0129: AddEncounter(player, 0x05, 0x11);
            L013B: AddEncounter(player, 0x06, 0x11);
            L014D: goto L01BB;
            L014F: AddEncounter(player, 0x01, 0x14);
            L0161: AddEncounter(player, 0x02, 0x14);
            L0173: AddEncounter(player, 0x03, 0x13);
            L0185: AddEncounter(player, 0x04, 0x13);
            L0197: AddEncounter(player, 0x05, 0x14);
            L01A9: AddEncounter(player, 0x06, 0x14);
            L01BB: return; // RETURN;
        }

        private void FnJACKTENC_10(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0x7A);
            L0011: if (JumpEqual) goto L0042;
            L0013: ShowMessage(player, doMsgs, String0882); // Ghosts rise from the floor to haunt you.
            L0020: AddTreasure(player, 0x0064, 0x00, 0x00, 0x00, 0xB6, 0xCE);
            L0040: goto L006F;
            L0042: AddTreasure(player, 0x0FA0, 0x00, 0x00, 0x00, 0xCE, 0x7A);
            L0062: ShowMessage(player, doMsgs, String08AB); // Ghosts are gathered around a jacket on the floor. They seem to be pondering its purpose.
            L006F: Compare(PartyCount(player), 0x0001);
            L007A: if (JumpEqual) goto L0089;
            L007C: Compare(PartyCount(player), 0x0002);
            L0087: if (JumpNotEqual) goto L00B0;
            L0089: AddEncounter(player, 0x01, 0x03);
            L009B: AddEncounter(player, 0x02, 0x02);
            L00AD: goto L013D;
            L00B0: Compare(PartyCount(player), 0x0003);
            L00BB: if (JumpNotEqual) goto L00F5;
            L00BD: AddEncounter(player, 0x01, 0x03);
            L00CF: AddEncounter(player, 0x02, 0x01);
            L00E1: AddEncounter(player, 0x03, 0x04);
            L00F3: goto L013D;
            L00F5: AddEncounter(player, 0x01, 0x01);
            L0107: AddEncounter(player, 0x02, 0x03);
            L0119: AddEncounter(player, 0x03, 0x02);
            L012B: AddEncounter(player, 0x04, 0x04);
            L013D: return; // RETURN;
        }

        private void FnARMRBENC_11(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0x76);
            L0011: if (JumpEqual) goto L0041;
            L0013: ShowMessage(player, doMsgs, String0904); // Skeletons of King Cleowyn's elite palace guard advance on you.
            L0020: AddTreasure(player, 0x004B, 0x00, 0x00, 0x00, 0x00, 0xCE);
            L003F: goto L006E;
            L0041: AddTreasure(player, 0x07D0, 0x00, 0x00, 0x00, 0xCE, 0x76);
            L0061: ShowMessage(player, doMsgs, String0943); // The leader of the dead palace guards that surrounds you wears rusty chainmail.
            L006E: Compare(PartyCount(player), 0x0001);
            L0079: if (JumpEqual) goto L0088;
            L007B: Compare(PartyCount(player), 0x0002);
            L0086: if (JumpNotEqual) goto L00C1;
            L0088: AddEncounter(player, 0x01, 0x09);
            L009A: AddEncounter(player, 0x02, 0x0A);
            L00AC: AddEncounter(player, 0x03, 0x09);
            L00BE: goto L0196;
            L00C1: Compare(PartyCount(player), 0x0003);
            L00CC: if (JumpNotEqual) goto L012A;
            L00CE: AddEncounter(player, 0x01, 0x0A);
            L00E0: AddEncounter(player, 0x02, 0x0A);
            L00F2: AddEncounter(player, 0x03, 0x0B);
            L0104: AddEncounter(player, 0x04, 0x09);
            L0116: AddEncounter(player, 0x05, 0x09);
            L0128: goto L0196;
            L012A: AddEncounter(player, 0x01, 0x0A);
            L013C: AddEncounter(player, 0x02, 0x0A);
            L014E: AddEncounter(player, 0x03, 0x0B);
            L0160: AddEncounter(player, 0x04, 0x0B);
            L0172: AddEncounter(player, 0x05, 0x0C);
            L0184: AddEncounter(player, 0x06, 0x0C);
            L0196: return; // RETURN;
        }

        private void FnRUNES_12(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String0992); // There are runes on the wall...
            L0010: ShowRunes(player, doMsgs, String09B1); // What you see is not always what is real.
            L001D: return; // RETURN;
        }

        private void FnLKPKDOOR_15(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasUsedItem(player, type, ref doMsgs, 0xC1, 0xC4);
            L0016: if (JumpNotEqual) goto L0029;
            L0018: Compare(HasUsedSkill(player, type, ref doMsgs, 0x0E), 0x0005);
            L0027: if (JumpBelow) goto L0074;
            L0029: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0047: SetWallItem(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L0065: ShowMessage(player, doMsgs, String09DA); // You successfully picked the locked door.
            L0072: goto L009E;
            L0074: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0091: ShowMessage(player, doMsgs, String0A03); // The door is locked.
            L009E: return; // RETURN;
        }

        private void FnSTRDOOR_16(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(CheckStrength(player), 0x000C);
            L0012: if (JumpBelow) goto L005F;
            L0014: ShowMessage(player, doMsgs, String0A17); // You manage to open the door by brute force.
            L0021: SetWallItem(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L003F: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L005D: goto L0089;
            L005F: ShowMessage(player, doMsgs, String0A43); // You are not strong enough to force the door open.
            L006C: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0089: return; // RETURN;
        }

        private void FnLKPKDOOR_17(ServerPlayer player, MapEventType type, bool doMsgs) {
            if ((HasUsedItem(player, type, ref doMsgs, 0xC2, 0xC4) == 1) || (HasUsedSkill(player, type, ref doMsgs, 0x0E) >= 8)) {
                if (GetFacing(player) == 3) {
                    ShowMessage(player, doMsgs, "You picked the lock, but something on the other side of the door bars your progress.");
                }
                else {
                    SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
                    SetWallItem(player, 0x01, GetCurrentTile(player), GetFacing(player));
                    ShowMessage(player, doMsgs, String0A75); // You picked the lock of the door successfully.
                }
                return;
            }
            SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            ShowMessage(player, doMsgs, String0AA3); // The door is locked.
        }

        private void FnTRAPDORA_18(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, type, ref doMsgs, 0x0D), 0x000A);
            L0012: if (JumpNotBelow) goto L004E;
            L0014: RefreshCompareFlags(HasUsedSpell(player, type, ref doMsgs, 0x17));
            L0022: if (JumpNotEqual) goto L004E;
            L0024: ax = HasUsedItem(player, type, ref doMsgs, 0xA2, 0xA2);
            L0037: if (JumpNotEqual) goto L004E;
            L0039: ax = HasUsedItem(player, type, ref doMsgs, 0xBE, 0xBE);
            L004C: if (JumpEqual) goto L0078;
            L004E: ShowMessage(player, doMsgs, String0AB7); // You found a trapdoor on the floor.
            L005B: TeleportParty(player, 0x03, 0x02, 0x82, 0x01, type);
            L0076: goto L00A0;
            L0078: ShowMessage(player, doMsgs, String0ADA); // You fall through a trapdoor.
            L0085: TeleportParty(player, 0x03, 0x02, 0x82, 0x01, type);
            L00A0: return; // RETURN;
        }

        private void FnTRAPDORB_19(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, type, ref doMsgs, 0x0D), 0x000A);
            L0012: if (JumpNotBelow) goto L004E;
            L0014: RefreshCompareFlags(HasUsedSpell(player, type, ref doMsgs, 0x17));
            L0022: if (JumpNotEqual) goto L004E;
            L0024: ax = HasUsedItem(player, type, ref doMsgs, 0xA2, 0xA2);
            L0037: if (JumpNotEqual) goto L004E;
            L0039: ax = HasUsedItem(player, type, ref doMsgs, 0xBE, 0xBE);
            L004C: if (JumpEqual) goto L0078;
            L004E: ShowMessage(player, doMsgs, String0AF7); // You found a trapdoor on the floor.
            L005B: TeleportParty(player, 0x03, 0x02, 0x86, 0x01, type);
            L0076: goto L00A0;
            L0078: ShowMessage(player, doMsgs, String0B1A); // You fall through a trapdoor.
            L0085: TeleportParty(player, 0x03, 0x02, 0x86, 0x01, type);
            L00A0: return; // RETURN;
        }

        private void FnTRAPDORC_1A(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, type, ref doMsgs, 0x0D), 0x000A);
            L0012: if (JumpNotBelow) goto L004E;
            L0014: RefreshCompareFlags(HasUsedSpell(player, type, ref doMsgs, 0x17));
            L0022: if (JumpNotEqual) goto L004E;
            L0024: ax = HasUsedItem(player, type, ref doMsgs, 0xA2, 0xA2);
            L0037: if (JumpNotEqual) goto L004E;
            L0039: ax = HasUsedItem(player, type, ref doMsgs, 0xBE, 0xBE);
            L004C: if (JumpEqual) goto L0078;
            L004E: ShowMessage(player, doMsgs, String0B37); // You found a trapdoor on the floor.
            L005B: TeleportParty(player, 0x03, 0x02, 0xA0, 0x03, type);
            L0076: goto L00A0;
            L0078: ShowMessage(player, doMsgs, String0B5A); // You fall through a trapdoor.
            L0085: TeleportParty(player, 0x03, 0x02, 0xA0, 0x03, type);
            L00A0: return; // RETURN;
        }

        private void FnTRAPDORD_1B(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, type, ref doMsgs, 0x0D), 0x000A);
            L0012: if (JumpNotBelow) goto L004E;
            L0014: RefreshCompareFlags(HasUsedSpell(player, type, ref doMsgs, 0x17));
            L0022: if (JumpNotEqual) goto L004E;
            L0024: ax = HasUsedItem(player, type, ref doMsgs, 0xA2, 0xA2);
            L0037: if (JumpNotEqual) goto L004E;
            L0039: ax = HasUsedItem(player, type, ref doMsgs, 0xBE, 0xBE);
            L004C: if (JumpEqual) goto L0078;
            L004E: ShowMessage(player, doMsgs, String0B77); // You found a trapdoor on the floor.
            L005B: TeleportParty(player, 0x03, 0x02, 0xA8, 0x03, type);
            L0076: goto L00A0;
            L0078: ShowMessage(player, doMsgs, String0B9A); // You fall through a trapdoor.
            L0085: TeleportParty(player, 0x03, 0x02, 0xA8, 0x03, type);
            L00A0: return; // RETURN;
        }

        private void FnTRAPDORE_1C(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, type, ref doMsgs, 0x0D), 0x000A);
            L0012: if (JumpNotBelow) goto L004E;
            L0014: RefreshCompareFlags(HasUsedSpell(player, type, ref doMsgs, 0x17));
            L0022: if (JumpNotEqual) goto L004E;
            L0024: ax = HasUsedItem(player, type, ref doMsgs, 0xA2, 0xA2);
            L0037: if (JumpNotEqual) goto L004E;
            L0039: ax = HasUsedItem(player, type, ref doMsgs, 0xBE, 0xBE);
            L004C: if (JumpEqual) goto L0077;
            L004E: ShowMessage(player, doMsgs, String0BB7); // You found a trapdoor on the floor.
            L005B: TeleportParty(player, 0x03, 0x02, 0xB3, 0x00, type);
            L0075: goto L009E;
            L0077: ShowMessage(player, doMsgs, String0BDA); // You fall through a trapdoor.
            L0084: TeleportParty(player, 0x03, 0x02, 0xB3, 0x00, type);
            L009E: return; // RETURN;
        }

        private void FnTRAPDORF_1D(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, type, ref doMsgs, 0x0D), 0x000A);
            L0012: if (JumpNotBelow) goto L004E;
            L0014: RefreshCompareFlags(HasUsedSpell(player, type, ref doMsgs, 0x17));
            L0022: if (JumpNotEqual) goto L004E;
            L0024: ax = HasUsedItem(player, type, ref doMsgs, 0xA2, 0xA2);
            L0037: if (JumpNotEqual) goto L004E;
            L0039: ax = HasUsedItem(player, type, ref doMsgs, 0xBE, 0xBE);
            L004C: if (JumpEqual) goto L0078;
            L004E: ShowMessage(player, doMsgs, String0BF7); // You found a trapdoor on the floor.
            L005B: TeleportParty(player, 0x03, 0x02, 0xB5, 0x02, type);
            L0076: goto L00A0;
            L0078: ShowMessage(player, doMsgs, String0C1A); // You fall through a trapdoor.
            L0085: TeleportParty(player, 0x03, 0x02, 0xB5, 0x02, type);
            L00A0: return; // RETURN;
        }

        private void FnTRAPDORG_1E(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, type, ref doMsgs, 0x0D), 0x000A);
            L0012: if (JumpNotBelow) goto L004E;
            L0014: RefreshCompareFlags(HasUsedSpell(player, type, ref doMsgs, 0x17));
            L0022: if (JumpNotEqual) goto L004E;
            L0024: ax = HasUsedItem(player, type, ref doMsgs, 0xA2, 0xA2);
            L0037: if (JumpNotEqual) goto L004E;
            L0039: ax = HasUsedItem(player, type, ref doMsgs, 0xBE, 0xBE);
            L004C: if (JumpEqual) goto L0077;
            L004E: ShowMessage(player, doMsgs, String0C37); // You found a trapdoor on the floor.
            L005B: TeleportParty(player, 0x03, 0x02, 0xC2, 0x00, type);
            L0075: goto L009E;
            L0077: ShowMessage(player, doMsgs, String0C5A); // You fall through a trapdoor.
            L0084: TeleportParty(player, 0x03, 0x02, 0xC2, 0x00, type);
            L009E: return; // RETURN;
        }

        private void FnTRAPDORH_1F(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, type, ref doMsgs, 0x0D), 0x000A);
            L0012: if (JumpNotBelow) goto L004E;
            L0014: RefreshCompareFlags(HasUsedSpell(player, type, ref doMsgs, 0x17));
            L0022: if (JumpNotEqual) goto L004E;
            L0024: ax = HasUsedItem(player, type, ref doMsgs, 0xA2, 0xA2);
            L0037: if (JumpNotEqual) goto L004E;
            L0039: ax = HasUsedItem(player, type, ref doMsgs, 0xBE, 0xBE);
            L004C: if (JumpEqual) goto L0078;
            L004E: ShowMessage(player, doMsgs, String0C77); // You found a trapdoor on the floor.
            L005B: TeleportParty(player, 0x03, 0x02, 0xC6, 0x02, type);
            L0076: goto L00A0;
            L0078: ShowMessage(player, doMsgs, String0C9A); // You fall through a trapdoor.
            L0085: TeleportParty(player, 0x03, 0x02, 0xC6, 0x02, type);
            L00A0: return; // RETURN;
        }

        private void FnTRAPDORI_20(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, type, ref doMsgs, 0x0D), 0x000A);
            L0012: if (JumpNotBelow) goto L004E;
            L0014: RefreshCompareFlags(HasUsedSpell(player, type, ref doMsgs, 0x17));
            L0022: if (JumpNotEqual) goto L004E;
            L0024: ax = HasUsedItem(player, type, ref doMsgs, 0xA2, 0xA2);
            L0037: if (JumpNotEqual) goto L004E;
            L0039: ax = HasUsedItem(player, type, ref doMsgs, 0xBE, 0xBE);
            L004C: if (JumpEqual) goto L0077;
            L004E: ShowMessage(player, doMsgs, String0CB7); // You found a trapdoor on the floor.
            L005B: TeleportParty(player, 0x03, 0x02, 0xD3, 0x00, type);
            L0075: goto L009E;
            L0077: ShowMessage(player, doMsgs, String0CDA); // You fall through a trapdoor.
            L0084: TeleportParty(player, 0x03, 0x02, 0xD3, 0x00, type);
            L009E: return; // RETURN;
        }

        private void FnTRAPDORJ_21(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, type, ref doMsgs, 0x0D), 0x000A);
            L0012: if (JumpNotBelow) goto L004E;
            L0014: RefreshCompareFlags(HasUsedSpell(player, type, ref doMsgs, 0x17));
            L0022: if (JumpNotEqual) goto L004E;
            L0024: ax = HasUsedItem(player, type, ref doMsgs, 0xA2, 0xA2);
            L0037: if (JumpNotEqual) goto L004E;
            L0039: ax = HasUsedItem(player, type, ref doMsgs, 0xBE, 0xBE);
            L004C: if (JumpEqual) goto L0078;
            L004E: ShowMessage(player, doMsgs, String0CF7); // You found a trapdoor on the floor.
            L005B: TeleportParty(player, 0x03, 0x02, 0xD4, 0x01, type);
            L0076: goto L00A0;
            L0078: ShowMessage(player, doMsgs, String0D1A); // You fall through a trapdoor.
            L0085: TeleportParty(player, 0x03, 0x02, 0xD4, 0x01, type);
            L00A0: return; // RETURN;
        }

        private void FnTRAPDORK_22(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, type, ref doMsgs, 0x0D), 0x000A);
            L0012: if (JumpNotBelow) goto L004E;
            L0014: RefreshCompareFlags(HasUsedSpell(player, type, ref doMsgs, 0x17));
            L0022: if (JumpNotEqual) goto L004E;
            L0024: ax = HasUsedItem(player, type, ref doMsgs, 0xA2, 0xA2);
            L0037: if (JumpNotEqual) goto L004E;
            L0039: ax = HasUsedItem(player, type, ref doMsgs, 0xBE, 0xBE);
            L004C: if (JumpEqual) goto L0078;
            L004E: ShowMessage(player, doMsgs, String0D37); // You found a trapdoor on the floor.
            L005B: TeleportParty(player, 0x03, 0x02, 0xD5, 0x02, type);
            L0076: goto L00A0;
            L0078: ShowMessage(player, doMsgs, String0D5A); // You fall through a trapdoor.
            L0085: TeleportParty(player, 0x03, 0x02, 0xD5, 0x02, type);
            L00A0: return; // RETURN;
        }

        private void FnTRAPDORL_23(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, type, ref doMsgs, 0x0D), 0x000A);
            L0012: if (JumpNotBelow) goto L004E;
            L0014: RefreshCompareFlags(HasUsedSpell(player, type, ref doMsgs, 0x17));
            L0022: if (JumpNotEqual) goto L004E;
            L0024: ax = HasUsedItem(player, type, ref doMsgs, 0xA2, 0xA2);
            L0037: if (JumpNotEqual) goto L004E;
            L0039: ax = HasUsedItem(player, type, ref doMsgs, 0xBE, 0xBE);
            L004C: if (JumpEqual) goto L0078;
            L004E: ShowMessage(player, doMsgs, String0D77); // You found a trapdoor on the floor.
            L005B: TeleportParty(player, 0x03, 0x02, 0xE0, 0x01, type);
            L0076: goto L00A0;
            L0078: ShowMessage(player, doMsgs, String0D9A); // You fall through a trapdoor.
            L0085: TeleportParty(player, 0x03, 0x02, 0xE0, 0x01, type);
            L00A0: return; // RETURN;
        }

        private void FnTRAPDORM_24(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, type, ref doMsgs, 0x0D), 0x000A);
            L0012: if (JumpNotBelow) goto L004E;
            L0014: RefreshCompareFlags(HasUsedSpell(player, type, ref doMsgs, 0x17));
            L0022: if (JumpNotEqual) goto L004E;
            L0024: ax = HasUsedItem(player, type, ref doMsgs, 0xA2, 0xA2);
            L0037: if (JumpNotEqual) goto L004E;
            L0039: ax = HasUsedItem(player, type, ref doMsgs, 0xBE, 0xBE);
            L004C: if (JumpEqual) goto L0078;
            L004E: ShowMessage(player, doMsgs, String0DB7); // You found a trapdoor on the floor.
            L005B: TeleportParty(player, 0x03, 0x02, 0xE2, 0x01, type);
            L0076: goto L00A0;
            L0078: ShowMessage(player, doMsgs, String0DDA); // You fall through a trapdoor.
            L0085: TeleportParty(player, 0x03, 0x02, 0xE2, 0x01, type);
            L00A0: return; // RETURN;
        }

        private void FnTRAPDORN_25(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, type, ref doMsgs, 0x0D), 0x000A);
            L0012: if (JumpNotBelow) goto L004E;
            L0014: RefreshCompareFlags(HasUsedSpell(player, type, ref doMsgs, 0x17));
            L0022: if (JumpNotEqual) goto L004E;
            L0024: ax = HasUsedItem(player, type, ref doMsgs, 0xA2, 0xA2);
            L0037: if (JumpNotEqual) goto L004E;
            L0039: ax = HasUsedItem(player, type, ref doMsgs, 0xBE, 0xBE);
            L004C: if (JumpEqual) goto L0078;
            L004E: ShowMessage(player, doMsgs, String0DF7); // You found a trapdoor on the floor.
            L005B: TeleportParty(player, 0x03, 0x02, 0xE3, 0x01, type);
            L0076: goto L00A0;
            L0078: ShowMessage(player, doMsgs, String0E1A); // You fall through a trapdoor.
            L0085: TeleportParty(player, 0x03, 0x02, 0xE3, 0x01, type);
            L00A0: return; // RETURN;
        }

        private void FnTRAPDORO_26(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, type, ref doMsgs, 0x0D), 0x000A);
            L0012: if (JumpNotBelow) goto L004E;
            L0014: RefreshCompareFlags(HasUsedSpell(player, type, ref doMsgs, 0x17));
            L0022: if (JumpNotEqual) goto L004E;
            L0024: ax = HasUsedItem(player, type, ref doMsgs, 0xA2, 0xA2);
            L0037: if (JumpNotEqual) goto L004E;
            L0039: ax = HasUsedItem(player, type, ref doMsgs, 0xBE, 0xBE);
            L004C: if (JumpEqual) goto L0078;
            L004E: ShowMessage(player, doMsgs, String0E37); // You found a trapdoor on the floor.
            L005B: TeleportParty(player, 0x03, 0x02, 0xE5, 0x01, type);
            L0076: goto L00A0;
            L0078: ShowMessage(player, doMsgs, String0E5A); // You fall through a trapdoor.
            L0085: TeleportParty(player, 0x03, 0x02, 0xE5, 0x01, type);
            L00A0: return; // RETURN;
        }

        private void FnTRAPDORP_27(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, type, ref doMsgs, 0x0D), 0x000A);
            L0012: if (JumpNotBelow) goto L004E;
            L0014: RefreshCompareFlags(HasUsedSpell(player, type, ref doMsgs, 0x17));
            L0022: if (JumpNotEqual) goto L004E;
            L0024: ax = HasUsedItem(player, type, ref doMsgs, 0xA2, 0xA2);
            L0037: if (JumpNotEqual) goto L004E;
            L0039: ax = HasUsedItem(player, type, ref doMsgs, 0xBE, 0xBE);
            L004C: if (JumpEqual) goto L0078;
            L004E: ShowMessage(player, doMsgs, String0E77); // You found a trapdoor on the floor.
            L005B: TeleportParty(player, 0x03, 0x02, 0xE6, 0x01, type);
            L0076: goto L00A0;
            L0078: ShowMessage(player, doMsgs, String0E9A); // You fall through a trapdoor.
            L0085: TeleportParty(player, 0x03, 0x02, 0xE6, 0x01, type);
            L00A0: return; // RETURN;
        }

        private void FnTRAPDORQ_28(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, type, ref doMsgs, 0x0D), 0x000A);
            L0012: if (JumpNotBelow) goto L004E;
            L0014: RefreshCompareFlags(HasUsedSpell(player, type, ref doMsgs, 0x17));
            L0022: if (JumpNotEqual) goto L004E;
            L0024: ax = HasUsedItem(player, type, ref doMsgs, 0xA2, 0xA2);
            L0037: if (JumpNotEqual) goto L004E;
            L0039: ax = HasUsedItem(player, type, ref doMsgs, 0xBE, 0xBE);
            L004C: if (JumpEqual) goto L0078;
            L004E: ShowMessage(player, doMsgs, String0EB7); // You found a trapdoor on the floor.
            L005B: TeleportParty(player, 0x03, 0x02, 0xE8, 0x01, type);
            L0076: goto L00A0;
            L0078: ShowMessage(player, doMsgs, String0EDA); // You fall through a trapdoor.
            L0085: TeleportParty(player, 0x03, 0x02, 0xE8, 0x01, type);
            L00A0: return; // RETURN;
        }

        private void FnTOCORRB_29(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x02, 0x02, 0xF1, 0x03, type);
            L001E: return; // RETURN;
        }

        private void FnGATEMESS_2A(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String0EF7); // The gateway leads to THE PALACE CORRIDOR.
            L0010: return; // RETURN;
        }

        private void FnPASSCOLM_2B(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String0F21); // As you step forward, the column slides away.
            L0010: SetFloorPassable(player, 0xF7, 0x01);
            L0021: return; // RETURN;
        }

        private void Fn_2C(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String0F4E); // You bump into the pillar.
            L0010: return; // RETURN;
        }

        private void FnNPCCHATA_2D(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String0F68); // You encounter an Elf Ranger.
            L0010: ShowPortrait(player, 0x001F);
            L001D: Compare(GetRandom(0x000F), 0x000D);
            L002D: if (JumpAbove) goto L003E;
            L002F: ShowMessage(player, doMsgs, String0F85); // The ghost of King Cleowyn appears at his throne on special occasions. Once the king appears, he will not appear again until all mortals have left the Palace.
            L003C: goto L004B;
            L003E: ShowMessage(player, doMsgs, String1023); // The Elf Ranger ignores you as he wanders the room, rapping on the walls.
            L004B: return; // RETURN;
        }

        private void FnNPCCHATB_2E(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String106C); // You encounter a Gremlin Thief.
            L0010: ShowPortrait(player, 0x0026);
            L001D: Compare(GetRandom(0x000F), 0x000C);
            L002D: if (JumpAbove) goto L003E;
            L002F: ShowMessage(player, doMsgs, String108B); // The pit is pitiless. Do not go near it. The traps are dangerous, but they may aid you.
            L003C: goto L004B;
            L003E: ShowMessage(player, doMsgs, String10E2); // The Gremlin Thief runs away when you approach him.
            L004B: return; // RETURN;
        }

        private void FnNPCCHATC_2F(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String1115); // You encounter a Dwarf Knight.
            L0010: ShowPortrait(player, 0x001C);
            L001D: Compare(GetRandom(0x000F), 0x000A);
            L002D: if (JumpAbove) goto L003E;
            L002F: ShowMessage(player, doMsgs, String1133); // Obey the king. Return his cherished possessions and you will be blessed. Keep them and you will die.
            L003C: goto L004B;
            L003E: ShowMessage(player, doMsgs, String1198); // The Dwarf Knight snubs you and wanders off in search of adventure.
            L004B: return; // RETURN;
        }

        private void FnKINGMSG_30(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xF8); // kings ring
            L0011: if (JumpNotEqual) goto L0016;
            L0013: goto L00C8;
            L0016: ShowPortrait(player, 0x000A);
            L0023: ShowMessage(player, doMsgs, String11DB); // Very good, heroes. You have proven your strength in battle. Know that I am the spirit of King Cleowyn, called the Cruel. I set you a quest.
            L0030: ShowMessage(player, doMsgs, String1267); // The imps who serve Arnakkian have stolen my Crown, Robe, and Scepter. I want them back. Return them to their proper places in my mausoleum, and I shall reward you.
            L003D: ShowMessage(player, doMsgs, String130B); // If you keep my possessions, I shall curse you! I give you gold to dull your greed.
            L004A: ShowMessage(player, doMsgs, String135E); // I earned Arnakkian's enmity because I tried to wrest his secrets from the buried castle
            L0057: ShowMessage(player, doMsgs, String13B6); // I almost succeeded, but the spirit of the wizard tracked me down and killed me.
            L0064: ShowMessage(player, doMsgs, String1406); // I would be grateful if you can find my body and place it in my mausoleum. Then, perhaps, my spirit can rest in peace.
            L0071: ShowMessage(player, doMsgs, String147C); // But first you must return my possessions to me. Then I shall let you continue your journeys.
            L007E: ShowMessage(player, doMsgs, String14D9); // Take my ring as seal of your promise. Go, heroes! Find the tapestry and read. Start your quest.
            L008B: RefreshCompareFlags(GetFlag(player, FlagTypeDungeon, FlagKingCleown25kExp));
            L009E: if (JumpNotEqual) goto L00C6;
            L00A0: SetFlag(player, FlagTypeDungeon, FlagKingCleown25kExp, 0x01);
            L00B5: AddExperience(player, 0x000061A8);
            L00C6: goto L00D5;
            L00C8: ShowMessage(player, doMsgs, String1539); // Echoes of ghostly laughter mock you.
            L00D5: return; // RETURN;
        }

    }
}
