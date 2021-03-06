﻿namespace Rebirth.Common.Types
{
    public enum AllianceOps
    {
        AllianceReq_Create = 0x0,
        AllianceReq_Load = 0x1,
        AllianceReq_Withdraw = 0x2,
        AllianceReq_Invite = 0x3,
        AllianceReq_Join = 0x4,
        AllianceReq_UpdateMemberCountMax = 0x5,
        AllianceReq_Kick = 0x6,
        AllianceReq_ChangeMaster = 0x7,
        AllianceReq_SetGradeName = 0x8,
        AllianceReq_ChangeGrade = 0x9,
        AllianceReq_SetNotice = 0xA,
        AllianceReq_Destroy = 0xB,
        AllianceRes_LoadDone = 0xC,
        AllianceRes_LoadGuildDone = 0xD,
        AllianceRes_NotifyLoginOrLogout = 0xE,
        AllianceRes_CreateDone = 0xF,
        AllianceRes_Withdraw_Done = 0x10,
        AllianceRes_Withdraw_Failed = 0x11,
        AllianceRes_Invite_Done = 0x12,
        AllianceRes_Invite_Failed = 0x13,
        AllianceRes_InviteGuild_BlockedByOpt = 0x14,
        AllianceRes_InviteGuild_AlreadyInvited = 0x15,
        AllianceRes_InviteGuild_Rejected = 0x16,
        AllianceRes_UpdateAllianceInfo = 0x17,
        AllianceRes_ChangeLevelOrJob = 0x18,
        AllianceRes_ChangeMaster_Done = 0x19,
        AllianceRes_SetGradeName_Done = 0x1A,
        AllianceRes_ChangeGrade_Done = 0x1B,
        AllianceRes_SetNotice_Done = 0x1C,
        AllianceRes_Destroy_Done = 0x1D,
        AllianceRes_UpdateGuildInfo = 0x1E,
    }
}
