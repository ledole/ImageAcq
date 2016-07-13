using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageAcq
{
    public partial class ACQUISITION_H
    {

        /// DATASHORT -> 2
        public const int DATASHORT = 2;

        /// DATALONG -> 4
        public const int DATALONG = 4;

        /// DATAFLOAT -> 8
        public const int DATAFLOAT = 8;

        /// DATASIGNED -> 16
        public const int DATASIGNED = 16;

        /// WINRESTSIZE -> 34
        public const int WINRESTSIZE = 34;

        /// WINHARDWAREHEADERSIZE -> 32
        public const int WINHARDWAREHEADERSIZE = 32;

        /// DETEKTOR_DATATYPE_18BIT -> 16
        public const int DETEKTOR_DATATYPE_18BIT = 16;

        /// MAX_GREY_VALUE_18BIT -> 262144
        public const int MAX_GREY_VALUE_18BIT = 262144;

        /// GBIF_IP_MAC_NAME_CHAR_ARRAY_LENGTH -> 16
        public const int GBIF_IP_MAC_NAME_CHAR_ARRAY_LENGTH = 16;

        /// HIS_GbIF_FIRST_CAM -> 0
        public const int HIS_GbIF_FIRST_CAM = 0;

        /// HIS_GbIF_IP -> 1
        public const int HIS_GbIF_IP = 1;

        /// HIS_GbIF_MAC -> 2
        public const int HIS_GbIF_MAC = 2;

        /// HIS_GbIF_NAME -> 3
        public const int HIS_GbIF_NAME = 3;

        /// HIS_GbIF_IP_STATIC -> 1
        public const int HIS_GbIF_IP_STATIC = 1;

        /// HIS_GbIF_IP_DHCP -> 2
        public const int HIS_GbIF_IP_DHCP = 2;

        /// HIS_GbIF_IP_LLA -> 4
        public const int HIS_GbIF_IP_LLA = 4;

        /// HIS_ALL_OK -> 0
        public const int HIS_ALL_OK = 0;

        /// HIS_ERROR_MEMORY -> 1
        public const int HIS_ERROR_MEMORY = 1;

        /// HIS_ERROR_BOARDINIT -> 2
        public const int HIS_ERROR_BOARDINIT = 2;

        /// HIS_ERROR_NOCAMERA -> 3
        public const int HIS_ERROR_NOCAMERA = 3;

        /// HIS_ERROR_CORRBUFFER_INCOMPATIBLE -> 4
        public const int HIS_ERROR_CORRBUFFER_INCOMPATIBLE = 4;

        /// HIS_ERROR_ACQ_ALREADY_RUNNING -> 5
        public const int HIS_ERROR_ACQ_ALREADY_RUNNING = 5;

        /// HIS_ERROR_TIMEOUT -> 6
        public const int HIS_ERROR_TIMEOUT = 6;

        /// HIS_ERROR_INVALIDACQDESC -> 7
        public const int HIS_ERROR_INVALIDACQDESC = 7;

        /// HIS_ERROR_VXDNOTFOUND -> 8
        public const int HIS_ERROR_VXDNOTFOUND = 8;

        /// HIS_ERROR_VXDNOTOPEN -> 9
        public const int HIS_ERROR_VXDNOTOPEN = 9;

        /// HIS_ERROR_VXDUNKNOWNERROR -> 10
        public const int HIS_ERROR_VXDUNKNOWNERROR = 10;

        /// HIS_ERROR_VXDGETDMAADR -> 11
        public const int HIS_ERROR_VXDGETDMAADR = 11;

        /// HIS_ERROR_ACQABORT -> 12
        public const int HIS_ERROR_ACQABORT = 12;

        /// HIS_ERROR_ACQUISITION -> 13
        public const int HIS_ERROR_ACQUISITION = 13;

        /// HIS_ERROR_VXD_REGISTER_IRQ -> 14
        public const int HIS_ERROR_VXD_REGISTER_IRQ = 14;

        /// HIS_ERROR_VXD_REGISTER_STATADR -> 15
        public const int HIS_ERROR_VXD_REGISTER_STATADR = 15;

        /// HIS_ERROR_GETOSVERSION -> 16
        public const int HIS_ERROR_GETOSVERSION = 16;

        /// HIS_ERROR_SETFRMSYNC -> 17
        public const int HIS_ERROR_SETFRMSYNC = 17;

        /// HIS_ERROR_SETFRMSYNCMODE -> 18
        public const int HIS_ERROR_SETFRMSYNCMODE = 18;

        /// HIS_ERROR_SETTIMERSYNC -> 19
        public const int HIS_ERROR_SETTIMERSYNC = 19;

        /// HIS_ERROR_INVALID_FUNC_CALL -> 20
        public const int HIS_ERROR_INVALID_FUNC_CALL = 20;

        /// HIS_ERROR_ABORTCURRFRAME -> 21
        public const int HIS_ERROR_ABORTCURRFRAME = 21;

        /// HIS_ERROR_GETHWHEADERINFO -> 22
        public const int HIS_ERROR_GETHWHEADERINFO = 22;

        /// HIS_ERROR_HWHEADER_INV -> 23
        public const int HIS_ERROR_HWHEADER_INV = 23;

        /// HIS_ERROR_SETLINETRIG_MODE -> 24
        public const int HIS_ERROR_SETLINETRIG_MODE = 24;

        /// HIS_ERROR_WRITE_DATA -> 25
        public const int HIS_ERROR_WRITE_DATA = 25;

        /// HIS_ERROR_READ_DATA -> 26
        public const int HIS_ERROR_READ_DATA = 26;

        /// HIS_ERROR_SETBAUDRATE -> 27
        public const int HIS_ERROR_SETBAUDRATE = 27;

        /// HIS_ERROR_NODESC_AVAILABLE -> 28
        public const int HIS_ERROR_NODESC_AVAILABLE = 28;

        /// HIS_ERROR_BUFFERSPACE_NOT_SUFF -> 29
        public const int HIS_ERROR_BUFFERSPACE_NOT_SUFF = 29;

        /// HIS_ERROR_SETCAMERAMODE -> 30
        public const int HIS_ERROR_SETCAMERAMODE = 30;

        /// HIS_ERROR_FRAME_INV -> 31
        public const int HIS_ERROR_FRAME_INV = 31;

        /// HIS_ERROR_SLOW_SYSTEM -> 32
        public const int HIS_ERROR_SLOW_SYSTEM = 32;

        /// HIS_ERROR_GET_NUM_BOARDS -> 33
        public const int HIS_ERROR_GET_NUM_BOARDS = 33;

        /// HIS_ERROR_HW_ALREADY_OPEN_BY_ANOTHER_PROCESS -> 34
        public const int HIS_ERROR_HW_ALREADY_OPEN_BY_ANOTHER_PROCESS = 34;

        /// HIS_ERROR_CREATE_MEMORYMAPPING -> 35
        public const int HIS_ERROR_CREATE_MEMORYMAPPING = 35;

        /// HIS_ERROR_VXD_REGISTER_DMA_ADDRESS -> 36
        public const int HIS_ERROR_VXD_REGISTER_DMA_ADDRESS = 36;

        /// HIS_ERROR_VXD_REGISTER_STAT_ADDR -> 37
        public const int HIS_ERROR_VXD_REGISTER_STAT_ADDR = 37;

        /// HIS_ERROR_VXD_UNMASK_IRQ -> 38
        public const int HIS_ERROR_VXD_UNMASK_IRQ = 38;

        /// HIS_ERROR_LOADDRIVER -> 39
        public const int HIS_ERROR_LOADDRIVER = 39;

        /// HIS_ERROR_FUNC_NOTIMPL -> 40
        public const int HIS_ERROR_FUNC_NOTIMPL = 40;

        /// HIS_ERROR_MEMORY_MAPPING -> 41
        public const int HIS_ERROR_MEMORY_MAPPING = 41;

        /// HIS_ERROR_CREATE_MUTEX -> 42
        public const int HIS_ERROR_CREATE_MUTEX = 42;

        /// HIS_ERROR_ACQ -> 43
        public const int HIS_ERROR_ACQ = 43;

        /// HIS_ERROR_DESC_NOT_LOCAL -> 44
        public const int HIS_ERROR_DESC_NOT_LOCAL = 44;

        /// HIS_ERROR_INVALID_PARAM -> 45
        public const int HIS_ERROR_INVALID_PARAM = 45;

        /// HIS_ERROR_ABORT -> 46
        public const int HIS_ERROR_ABORT = 46;

        /// HIS_ERROR_WRONGBOARDSELECT -> 47
        public const int HIS_ERROR_WRONGBOARDSELECT = 47;

        /// HIS_ERROR_WRONG_CAMERA_MODE -> 48
        public const int HIS_ERROR_WRONG_CAMERA_MODE = 48;

        /// HIS_ERROR_AVERAGED_LOST -> 49
        public const int HIS_ERROR_AVERAGED_LOST = 49;

        /// HIS_ERROR_BAD_SORTING_PARAM -> 50
        public const int HIS_ERROR_BAD_SORTING_PARAM = 50;

        /// HIS_ERROR_UNKNOWN_IP_MAC_NAME -> 51
        public const int HIS_ERROR_UNKNOWN_IP_MAC_NAME = 51;

        /// HIS_ERROR_NO_BOARD_IN_SUBNET -> 52
        public const int HIS_ERROR_NO_BOARD_IN_SUBNET = 52;

        /// HIS_ERROR_UNABLE_TO_OPEN_BOARD -> 53
        public const int HIS_ERROR_UNABLE_TO_OPEN_BOARD = 53;

        /// HIS_ERROR_UNABLE_TO_CLOSE_BOARD -> 54
        public const int HIS_ERROR_UNABLE_TO_CLOSE_BOARD = 54;

        /// HIS_ERROR_UNABLE_TO_ACCESS_DETECTOR_FLASH -> 55
        public const int HIS_ERROR_UNABLE_TO_ACCESS_DETECTOR_FLASH = 55;

        /// HIS_ERROR_HEADER_TIMEOUT -> 56
        public const int HIS_ERROR_HEADER_TIMEOUT = 56;

        /// HIS_ERROR_NO_PING_ACK -> 57
        public const int HIS_ERROR_NO_PING_ACK = 57;

        /// HIS_ERROR_NR_OF_BOARDS_CHANGED -> 58
        public const int HIS_ERROR_NR_OF_BOARDS_CHANGED = 58;

        /// HIS_SORT_NOSORT -> 0
        public const int HIS_SORT_NOSORT = 0;

        /// HIS_SORT_QUAD -> 1
        public const int HIS_SORT_QUAD = 1;

        /// HIS_SORT_COLUMN -> 2
        public const int HIS_SORT_COLUMN = 2;

        /// HIS_SORT_COLUMNQUAD -> 3
        public const int HIS_SORT_COLUMNQUAD = 3;

        /// HIS_SORT_QUAD_INVERSE -> 4
        public const int HIS_SORT_QUAD_INVERSE = 4;

        /// HIS_SORT_QUAD_TILE -> 5
        public const int HIS_SORT_QUAD_TILE = 5;

        /// HIS_SORT_QUAD_TILE_INVERSE -> 6
        public const int HIS_SORT_QUAD_TILE_INVERSE = 6;

        /// HIS_SORT_QUAD_TILE_INVERSE_SCRAMBLE -> 7
        public const int HIS_SORT_QUAD_TILE_INVERSE_SCRAMBLE = 7;

        /// HIS_SORT_OCT_TILE_INVERSE -> 8
        public const int HIS_SORT_OCT_TILE_INVERSE = 8;

        /// HIS_SORT_OCT_TILE_INVERSE_BINDING -> 9
        public const int HIS_SORT_OCT_TILE_INVERSE_BINDING = 9;

        /// HIS_SORT_OCT_TILE_INVERSE_DOUBLE -> 10
        public const int HIS_SORT_OCT_TILE_INVERSE_DOUBLE = 10;

        /// HIS_SORT_HEX_TILE_INVERSE -> 11
        public const int HIS_SORT_HEX_TILE_INVERSE = 11;

        /// HIS_SORT_HEX_CS -> 12
        public const int HIS_SORT_HEX_CS = 12;

        /// HIS_SORT_12x1 -> 13
        public const int HIS_SORT_12x1 = 13;

        /// HIS_SORT_14 -> 14
        public const int HIS_SORT_14 = 14;

        /// HIS_SEQ_TWO_BUFFERS -> 0x1
        public const int HIS_SEQ_TWO_BUFFERS = 1;

        /// HIS_SEQ_ONE_BUFFER -> 0x2
        public const int HIS_SEQ_ONE_BUFFER = 2;

        /// HIS_SEQ_AVERAGE -> 0x4
        public const int HIS_SEQ_AVERAGE = 4;

        /// HIS_SEQ_DEST_ONE_FRAME -> 0x8
        public const int HIS_SEQ_DEST_ONE_FRAME = 8;

        /// HIS_SEQ_COLLATE -> 0x10
        public const int HIS_SEQ_COLLATE = 16;

        /// HIS_SEQ_CONTINUOUS -> 0x100
        public const int HIS_SEQ_CONTINUOUS = 256;

        /// HIS_SEQ_LEAKAGE -> 0x1000
        public const int HIS_SEQ_LEAKAGE = 4096;

        /// HIS_SEQ_NONLINEAR -> 0x2000
        public const int HIS_SEQ_NONLINEAR = 8192;

        /// HIS_SEQ_AVERAGESEQ -> 0x4000
        public const int HIS_SEQ_AVERAGESEQ = 16384;

        /// HIS_SYNCMODE_SOFT_TRIGGER -> 1
        public const int HIS_SYNCMODE_SOFT_TRIGGER = 1;

        /// HIS_SYNCMODE_INTERNAL_TIMER -> 2
        public const int HIS_SYNCMODE_INTERNAL_TIMER = 2;

        /// HIS_SYNCMODE_EXTERNAL_TRIGGER -> 3
        public const int HIS_SYNCMODE_EXTERNAL_TRIGGER = 3;

        /// HIS_SYNCMODE_FREE_RUNNING -> 4
        public const int HIS_SYNCMODE_FREE_RUNNING = 4;

        /// HIS_CAMMODE_SETSYNC -> 0x8
        public const int HIS_CAMMODE_SETSYNC = 8;

        /// HIS_CAMMODE_TIMEMASK -> 0x7
        public const int HIS_CAMMODE_TIMEMASK = 7;

        /// HIS_CAMMODE_FPGA -> 0x7F
        public const int HIS_CAMMODE_FPGA = 127;

        /// HIS_BOARD_TYPE_NOONE -> 0x0
        public const int HIS_BOARD_TYPE_NOONE = 0;

        /// HIS_BOARD_TYPE_ELTEC -> 0x1
        public const int HIS_BOARD_TYPE_ELTEC = 1;

        /// HIS_BOARD_TYPE_DIPIX -> 0x2
        public const int HIS_BOARD_TYPE_DIPIX = 2;

        /// HIS_BOARD_TYPE_RS232 -> 0x3
        public const int HIS_BOARD_TYPE_RS232 = 3;

        /// HIS_BOARD_TYPE_USB -> 0x4
        public const int HIS_BOARD_TYPE_USB = 4;

        /// HIS_BOARD_TYPE_ELTEC_XRD_FGX -> 0x8
        public const int HIS_BOARD_TYPE_ELTEC_XRD_FGX = 8;

        /// HIS_BOARD_TYPE_ELTEC_XRD_FGE_Opto -> 0x10
        public const int HIS_BOARD_TYPE_ELTEC_XRD_FGE_Opto = 16;

        /// HIS_BOARD_TYPE_ELTEC_GbIF -> 0x20
        public const int HIS_BOARD_TYPE_ELTEC_GbIF = 32;

        /// HIS_MAX_TIMINGS -> 0x8
        public const int HIS_MAX_TIMINGS = 8;

        /// XIS_DETECTOR_SERVICE_MODE_AVAILABLE -> 0x1
        public const int XIS_DETECTOR_SERVICE_MODE_AVAILABLE = 1;

        /// XIS_DETECTOR_TRIGGER_SOURCE_SELECTABLE -> 0x2
        public const int XIS_DETECTOR_TRIGGER_SOURCE_SELECTABLE = 2;

        /// XIS_DETECTOR_SUPPORTS_PING -> 0x3
        public const int XIS_DETECTOR_SUPPORTS_PING = 3;

        /// XIS_DETECTOR_SUPPORTED_ROI_MODES -> 0x4
        public const int XIS_DETECTOR_SUPPORTED_ROI_MODES = 4;

        /// XIS_DETECTOR_SUPPORTED_BINNING_MODES -> 0x5
        public const int XIS_DETECTOR_SUPPORTED_BINNING_MODES = 5;

        /// XIS_DETECTOR_SUPPORTS_GAIN_CHANGE -> 0x6
        public const int XIS_DETECTOR_SUPPORTS_GAIN_CHANGE = 6;

        /// XIS_DETECTOR_SUPPORTS_MULTIPLE_TRIGGER_MODES -> 0x7
        public const int XIS_DETECTOR_SUPPORTS_MULTIPLE_TRIGGER_MODES = 7;

        /// XIS_DETECTOR_SUPPORTS_CONFIGURABLE_TRIGGER_OUT -> 0x8
        public const int XIS_DETECTOR_SUPPORTS_CONFIGURABLE_TRIGGER_OUT = 8;

        /// XIS_DETECTOR_GRPSIZE_ROI_Y -> 0x9
        public const int XIS_DETECTOR_GRPSIZE_ROI_Y = 9;

        /// XIS_DETECTOR_LIVEBUFFERSIZE -> 0xA
        public const int XIS_DETECTOR_LIVEBUFFERSIZE = 10;

        /// XIS_DETECTOR_PROVIDES_ROI_GRP_1 -> 0x1
        public const int XIS_DETECTOR_PROVIDES_ROI_GRP_1 = 1;

        /// XIS_DETECTOR_PROVIDES_ROI_GRP_2 -> 0x2
        public const int XIS_DETECTOR_PROVIDES_ROI_GRP_2 = 2;

        /// XIS_DETECTOR_PROVIDES_ROI_GRP_3 -> 0x4
        public const int XIS_DETECTOR_PROVIDES_ROI_GRP_3 = 4;

        /// XIS_DETECTOR_PROVIDES_ROI_GRP_4 -> 0x8
        public const int XIS_DETECTOR_PROVIDES_ROI_GRP_4 = 8;

        /// XIS_DETECTOR_PROVIDES_ROI_GRP_5 -> 0x10
        public const int XIS_DETECTOR_PROVIDES_ROI_GRP_5 = 16;

        /// XIS_DETECTOR_PROVIDES_ROI_GRP_6 -> 0x20
        public const int XIS_DETECTOR_PROVIDES_ROI_GRP_6 = 32;

        /// XIS_DETECTOR_PROVIDES_ROI_GRP_7 -> 0x40
        public const int XIS_DETECTOR_PROVIDES_ROI_GRP_7 = 64;

        /// XIS_DETECTOR_PROVIDES_ROI_GRP_8 -> 0x80
        public const int XIS_DETECTOR_PROVIDES_ROI_GRP_8 = 128;

        /// XIS_DETECTOR_PROVIDES_ROI_1_GRP -> 0x1
        public const int XIS_DETECTOR_PROVIDES_ROI_1_GRP = 1;

        /// XIS_DETECTOR_PROVIDES_ROI_2_GRPS -> 0x2
        public const int XIS_DETECTOR_PROVIDES_ROI_2_GRPS = 2;

        /// XIS_DETECTOR_PROVIDES_ROI_3_GRPS -> 0x4
        public const int XIS_DETECTOR_PROVIDES_ROI_3_GRPS = 4;

        /// XIS_DETECTOR_PROVIDES_ROI_4_GRPS -> 0x8
        public const int XIS_DETECTOR_PROVIDES_ROI_4_GRPS = 8;

        /// XIS_DETECTOR_PROVIDES_ROI_ALL_GRPS -> 0x1000
        public const int XIS_DETECTOR_PROVIDES_ROI_ALL_GRPS = 4096;

        /// XIS_DETECTOR_PROVIDES_BINNING_1x1 -> 0x1
        public const int XIS_DETECTOR_PROVIDES_BINNING_1x1 = 1;

        /// XIS_DETECTOR_PROVIDES_BINNING_2x2 -> 0x2
        public const int XIS_DETECTOR_PROVIDES_BINNING_2x2 = 2;

        /// XIS_DETECTOR_PROVIDES_BINNING_4x4 -> 0x4
        public const int XIS_DETECTOR_PROVIDES_BINNING_4x4 = 4;

        /// XIS_DETECTOR_PROVIDES_BINNING_1x2 -> 0x8
        public const int XIS_DETECTOR_PROVIDES_BINNING_1x2 = 8;

        /// XIS_DETECTOR_PROVIDES_BINNING_1x4 -> 0x10
        public const int XIS_DETECTOR_PROVIDES_BINNING_1x4 = 16;

        /// XIS_DETECTOR_PROVIDES_BINNING_AVG -> 0x100
        public const int XIS_DETECTOR_PROVIDES_BINNING_AVG = 256;

        /// XIS_DETECTOR_PROVIDES_BINNING_SUM -> 0x200
        public const int XIS_DETECTOR_PROVIDES_BINNING_SUM = 512;

        /// Return Type: UINT->unsigned int
        ///phAcqDesc: HACQDESC*
        ///dwChannelType: DWORD->unsigned int
        ///nChannelNr: int
        ///bEnableIRQ: BOOL->int
        ///Rows: UINT->unsigned int
        ///Columns: UINT->unsigned int
        ///dwSortFlags: UINT->unsigned int
        ///bSelfInit: BOOL->int
        ///bAlwaysOpen: BOOL->int
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_Init")]
        public static extern uint Acquisition_Init(ref System.IntPtr phAcqDesc, uint dwChannelType, int nChannelNr, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.Bool)] bool bEnableIRQ, uint Rows, uint Columns, uint dwSortFlags, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.Bool)] bool bSelfInit, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.Bool)] bool bAlwaysOpen);


        /// Return Type: UINT->unsigned int
        ///pAcqDesc: HACQDESC->HANDLE->void*
        ///hWnd: HWND->HWND__*
        ///dwErrorMsg: UINT->unsigned int
        ///dwLoosingFramesMsg: UINT->unsigned int
        ///lpfnEndFrameCallback: Anonymous_e11ba521_9920_4f57_ab1c_64528eabc09c
        ///lpfnEndAcqCallback: Anonymous_c3be27cb_c2c6_467c_ab9d_b6c9448b3c73
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_SetCallbacksAndMessages")]
        public static extern uint Acquisition_SetCallbacksAndMessages(System.IntPtr pAcqDesc, System.IntPtr hWnd, uint dwErrorMsg, uint dwLoosingFramesMsg, Anonymous_e11ba521_9920_4f57_ab1c_64528eabc09c lpfnEndFrameCallback, Anonymous_c3be27cb_c2c6_467c_ab9d_b6c9448b3c73 lpfnEndAcqCallback);


        /// Return Type: UINT->unsigned int
        ///pdwNumSensors: UINT*
        ///bEnableIRQ: BOOL->int
        ///bAlwaysOpen: BOOL->int
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_EnumSensors")]
        public static extern uint Acquisition_EnumSensors(ref uint pdwNumSensors, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.Bool)] bool bEnableIRQ, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.Bool)] bool bAlwaysOpen);


        /// Return Type: UINT->unsigned int
        ///Pos: ACQDESCPOS*
        ///phAcqDesc: HACQDESC*
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_GetNextSensor")]
        public static extern uint Acquisition_GetNextSensor(ref System.IntPtr Pos, ref System.IntPtr phAcqDesc);


        /// Return Type: UINT->unsigned int
        ///pAcqDesc: HACQDESC->HANDLE->void*
        ///pdwChannelType: UINT*
        ///pnChannelNr: int*
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_GetCommChannel")]
        public static extern uint Acquisition_GetCommChannel(System.IntPtr pAcqDesc, ref uint pdwChannelType, ref int pnChannelNr);


        /// Return Type: UINT->unsigned int
        ///pAcqDesc: HACQDESC->HANDLE->void*
        ///pProcessedData: unsigned short*
        ///nFrames: UINT->unsigned int
        ///nRows: UINT->unsigned int
        ///nColumns: UINT->unsigned int
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_DefineDestBuffers")]
        public static extern uint Acquisition_DefineDestBuffers(System.IntPtr pAcqDesc, ref ushort pProcessedData, uint nFrames, uint nRows, uint nColumns);


        /// Return Type: UINT->unsigned int
        ///pAcqDesc: HACQDESC->HANDLE->void*
        ///dwFrames: UINT->unsigned int
        ///dwSkipFrms: UINT->unsigned int
        ///dwOpt: UINT->unsigned int
        ///pwOffsetData: unsigned short*
        ///pdwGainData: DWORD*
        ///pdwPxlCorrList: DWORD*
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_Acquire_Image")]
        public static extern uint Acquisition_Acquire_Image(System.IntPtr pAcqDesc, uint dwFrames, uint dwSkipFrms, uint dwOpt, ref ushort pwOffsetData, ref uint pdwGainData, ref uint pdwPxlCorrList);


        /// Return Type: UINT->unsigned int
        ///hAcqDesc: HACQDESC->HANDLE->void*
        ///dwFrames: UINT->unsigned int
        ///dwSkipFrms: UINT->unsigned int
        ///dwOpt: UINT->unsigned int
        ///pwOffsetData: unsigned short*
        ///dwGainFrames: UINT->unsigned int
        ///pwGainData: unsigned short*
        ///pwGainAvgData: unsigned short*
        ///pdwGainData: DWORD*
        ///pdwPxlCorrList: DWORD*
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_Acquire_Image_Ex")]
        public static extern uint Acquisition_Acquire_Image_Ex(System.IntPtr hAcqDesc, uint dwFrames, uint dwSkipFrms, uint dwOpt, ref ushort pwOffsetData, uint dwGainFrames, ref ushort pwGainData, ref ushort pwGainAvgData, ref uint pdwGainData, ref uint pdwPxlCorrList);


        /// Return Type: UINT->unsigned int
        ///hAcqDesc: HACQDESC->HANDLE->void*
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_Abort")]
        public static extern uint Acquisition_Abort(System.IntPtr hAcqDesc);


        /// Return Type: UINT->unsigned int
        ///hAcqDesc: HACQDESC->HANDLE->void*
        ///FPGACommand: FPGAType->Anonymous_a87ed962_5279_4475_a9bc_da8777123835
        ///bInverse: BOOL->int
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_SetFPGACameraMode")]
        public static extern uint Acquisition_SetFPGACameraMode(System.IntPtr hAcqDesc, FPGAType FPGACommand, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.Bool)] bool bInverse);


        /// Return Type: UINT->unsigned int
        ///hAcqDesc: HACQDESC->HANDLE->void*
        ///dwMode: UINT->unsigned int
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_SetCameraMode")]
        public static extern uint Acquisition_SetCameraMode(System.IntPtr hAcqDesc, uint dwMode);


        /// Return Type: UINT->unsigned int
        ///hAcqDesc: HACQDESC->HANDLE->void*
        ///pOffsetData: unsigned short*
        ///nRows: UINT->unsigned int
        ///nCols: UINT->unsigned int
        ///nFrames: UINT->unsigned int
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_Acquire_OffsetImage")]
        public static extern uint Acquisition_Acquire_OffsetImage(System.IntPtr hAcqDesc, ref ushort pOffsetData, uint nRows, uint nCols, uint nFrames);


        /// Return Type: UINT->unsigned int
        ///hAcqDesc: HACQDESC->HANDLE->void*
        ///pOffsetData: unsigned short*
        ///nRows: UINT->unsigned int
        ///nCols: UINT->unsigned int
        ///nFrames: UINT->unsigned int
        ///dwOpt: UINT->unsigned int
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_Acquire_OffsetImage_Ex")]
        public static extern uint Acquisition_Acquire_OffsetImage_Ex(System.IntPtr hAcqDesc, ref ushort pOffsetData, uint nRows, uint nCols, uint nFrames, uint dwOpt);


        /// Return Type: UINT->unsigned int
        ///hAcqDesc: HACQDESC->HANDLE->void*
        ///pOffsetData: WORD*
        ///pGainData: DWORD*
        ///nRows: UINT->unsigned int
        ///nCols: UINT->unsigned int
        ///nFrames: UINT->unsigned int
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_Acquire_GainImage")]
        public static extern uint Acquisition_Acquire_GainImage(System.IntPtr hAcqDesc, ref ushort pOffsetData, ref uint pGainData, uint nRows, uint nCols, uint nFrames);


        /// Return Type: UINT->unsigned int
        ///hAcqDesc: HACQDESC->HANDLE->void*
        ///pOffsetData: WORD*
        ///pGainData: DWORD*
        ///nRows: UINT->unsigned int
        ///nCols: UINT->unsigned int
        ///nFrames: UINT->unsigned int
        ///dwOpt: UINT->unsigned int
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_Acquire_GainImage_Ex")]
        public static extern uint Acquisition_Acquire_GainImage_Ex(System.IntPtr hAcqDesc, ref ushort pOffsetData, ref uint pGainData, uint nRows, uint nCols, uint nFrames, uint dwOpt);


        /// Return Type: UINT->unsigned int
        ///pGainData: WORD*
        ///pGainAVG: WORD*
        ///nCount: int
        ///nFrame: int
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_CreateGainMap")]
        public static extern uint Acquisition_CreateGainMap(ref ushort pGainData, ref ushort pGainAVG, int nCount, int nFrame);


        /// Return Type: UINT->unsigned int
        ///pData: WORD*
        ///nDataRows: int
        ///nDataColumns: int
        ///pCorrList: int*
        ///nCorrListSize: int*
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_CreatePixelMap")]
        public static extern uint Acquisition_CreatePixelMap(ref ushort pData, int nDataRows, int nDataColumns, ref int pCorrList, ref int nCorrListSize);


        /// Return Type: UINT->unsigned int
        ///pSource: WORD*
        ///pDest: WORD*
        ///pOffsetData: WORD*
        ///nCount: int
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_DoOffsetCorrection")]
        public static extern uint Acquisition_DoOffsetCorrection(ref ushort pSource, ref ushort pDest, ref ushort pOffsetData, int nCount);


        /// Return Type: UINT->unsigned int
        ///pSource: WORD*
        ///pDest: WORD*
        ///pOffsetData: WORD*
        ///pGainData: DWORD*
        ///nCount: int
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_DoOffsetGainCorrection")]
        public static extern uint Acquisition_DoOffsetGainCorrection(ref ushort pSource, ref ushort pDest, ref ushort pOffsetData, ref uint pGainData, int nCount);


        /// Return Type: UINT->unsigned int
        ///pSource: WORD*
        ///pDest: WORD*
        ///pOffsetData: WORD*
        ///pGainData: WORD*
        ///pGainAVG: WORD*
        ///nCount: int
        ///nFrame: int
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_DoOffsetGainCorrection_Ex")]
        public static extern uint Acquisition_DoOffsetGainCorrection_Ex(ref ushort pSource, ref ushort pDest, ref ushort pOffsetData, ref ushort pGainData, ref ushort pGainAVG, int nCount, int nFrame);


        /// Return Type: UINT->unsigned int
        ///pSource: unsigned int*
        ///pDest: unsigned int*
        ///pOffsetData: unsigned int*
        ///nCount: int
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_DoOffsetCorrection32")]
        public static extern uint Acquisition_DoOffsetCorrection32(ref uint pSource, ref uint pDest, ref uint pOffsetData, int nCount);


        /// Return Type: UINT->unsigned int
        ///pSource: unsigned int*
        ///pDest: unsigned int*
        ///pOffsetData: unsigned int*
        ///pGainData: unsigned int*
        ///nCount: int
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_DoOffsetGainCorrection32")]
        public static extern uint Acquisition_DoOffsetGainCorrection32(ref uint pSource, ref uint pDest, ref uint pOffsetData, ref uint pGainData, int nCount);


        /// Return Type: UINT->unsigned int
        ///pSource: unsigned int*
        ///pDest: unsigned int*
        ///pOffsetData: unsigned int*
        ///pGainData: unsigned int*
        ///pGainAVG: unsigned int*
        ///nCount: int
        ///nFrame: int
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_DoOffsetGainCorrection_Ex32")]
        public static extern uint Acquisition_DoOffsetGainCorrection_Ex32(ref uint pSource, ref uint pDest, ref uint pOffsetData, ref uint pGainData, ref uint pGainAVG, int nCount, int nFrame);


        /// Return Type: UINT->unsigned int
        ///pGainData: unsigned int*
        ///pGainAVG: unsigned int*
        ///nCount: int
        ///nFrame: int
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_CreateGainMap32")]
        public static extern uint Acquisition_CreateGainMap32(ref uint pGainData, ref uint pGainAVG, int nCount, int nFrame);


        /// Return Type: UINT->unsigned int
        ///pData: WORD*
        ///pCorrList: int*
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_DoPixelCorrection")]
        public static extern uint Acquisition_DoPixelCorrection(ref ushort pData, ref int pCorrList);


        /// Return Type: UINT->unsigned int
        ///hAcqDesc: HACQDESC->HANDLE->void*
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_IsAcquiringData")]
        public static extern uint Acquisition_IsAcquiringData(System.IntPtr hAcqDesc);


        /// Return Type: UINT->unsigned int
        ///hAcqDesc: HACQDESC->HANDLE->void*
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_Close")]
        public static extern uint Acquisition_Close(System.IntPtr hAcqDesc);


        /// Return Type: UINT->unsigned int
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_CloseAll")]
        public static extern uint Acquisition_CloseAll();


        /// Return Type: UINT->unsigned int
        ///hAcqDesc: HACQDESC->HANDLE->void*
        ///bFlag: BOOL->int
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_SetReady")]
        public static extern uint Acquisition_SetReady(System.IntPtr hAcqDesc, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.Bool)] bool bFlag);


        /// Return Type: UINT->unsigned int
        ///hAcqDesc: HACQDESC->HANDLE->void*
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_GetReady")]
        public static extern uint Acquisition_GetReady(System.IntPtr hAcqDesc);


        /// Return Type: UINT->unsigned int
        ///hAcqDesc: HACQDESC->HANDLE->void*
        ///dwHISError: DWORD*
        ///dwBoardError: DWORD*
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_GetErrorCode")]
        public static extern uint Acquisition_GetErrorCode(System.IntPtr hAcqDesc, ref uint dwHISError, ref uint dwBoardError);


        /// Return Type: UINT->unsigned int
        ///hAcqDesc: HACQDESC->HANDLE->void*
        ///dwFrames: UINT*
        ///dwRows: UINT*
        ///dwColumns: UINT*
        ///dwDataType: UINT*
        ///dwSortFlags: UINT*
        ///bIRQEnabled: BOOL*
        ///dwAcqType: DWORD*
        ///dwSystemID: DWORD*
        ///dwSyncMode: DWORD*
        ///dwHwAccess: DWORD*
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_GetConfiguration")]
        public static extern uint Acquisition_GetConfiguration(System.IntPtr hAcqDesc, ref uint dwFrames, ref uint dwRows, ref uint dwColumns, ref uint dwDataType, ref uint dwSortFlags, ref int bIRQEnabled, ref uint dwAcqType, ref uint dwSystemID, ref uint dwSyncMode, ref uint dwHwAccess);


        /// Return Type: UINT->unsigned int
        ///hAcqDesc: HACQDESC->HANDLE->void*
        ///dblIntTime: double*
        ///nIntTimes: int*
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_GetIntTimes")]
        public static extern uint Acquisition_GetIntTimes(System.IntPtr hAcqDesc, ref double dblIntTime, ref int nIntTimes);


        /// Return Type: UINT->unsigned int
        ///hAcqDesc: HACQDESC->HANDLE->void*
        ///hWnd: HWND*
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_GetWinHandle")]
        public static extern uint Acquisition_GetWinHandle(System.IntPtr hAcqDesc, ref System.IntPtr hWnd);


        /// Return Type: UINT->unsigned int
        ///hAcqDesc: HACQDESC->HANDLE->void*
        ///dwActAcqFrame: DWORD*
        ///dwActSecBuffFrame: DWORD*
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_GetActFrame")]
        public static extern uint Acquisition_GetActFrame(System.IntPtr hAcqDesc, ref uint dwActAcqFrame, ref uint dwActSecBuffFrame);


        /// Return Type: UINT->unsigned int
        ///hAcqDesc: HACQDESC->HANDLE->void*
        ///AcqData: void*
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_SetAcqData")]
        public static extern uint Acquisition_SetAcqData(System.IntPtr hAcqDesc, System.IntPtr AcqData);


        /// Return Type: UINT->unsigned int
        ///hAcqDesc: HACQDESC->HANDLE->void*
        ///VoidAcqData: void**
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_GetAcqData")]
        public static extern uint Acquisition_GetAcqData(System.IntPtr hAcqDesc, ref System.IntPtr VoidAcqData);


        /// Return Type: UINT->unsigned int
        ///hAcqDesc: HACQDESC->HANDLE->void*
        ///pInfo: CHwHeaderInfo*
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_GetHwHeaderInfo")]
        public static extern uint Acquisition_GetHwHeaderInfo(System.IntPtr hAcqDesc, ref CHwHeaderInfo pInfo);


        /// Return Type: UINT->unsigned int
        ///hAcqDesc: HACQDESC->HANDLE->void*
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_SetFrameSync")]
        public static extern uint Acquisition_SetFrameSync(System.IntPtr hAcqDesc);


        /// Return Type: UINT->unsigned int
        ///hAcqDesc: HACQDESC->HANDLE->void*
        ///dwMode: DWORD->unsigned int
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_SetFrameSyncMode")]
        public static extern uint Acquisition_SetFrameSyncMode(System.IntPtr hAcqDesc, uint dwMode);


        /// Return Type: UINT->unsigned int
        ///hAcqDesc: HACQDESC->HANDLE->void*
        ///dwCycleTime: DWORD*
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_SetTimerSync")]
        public static extern uint Acquisition_SetTimerSync(System.IntPtr hAcqDesc, ref uint dwCycleTime);


        /// Return Type: UINT->unsigned int
        ///hAcqDesc: HACQDESC->HANDLE->void*
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_AbortCurrentFrame")]
        public static extern uint Acquisition_AbortCurrentFrame(System.IntPtr hAcqDesc);


        /// Return Type: UINT->unsigned int
        ///hAcqDesc: HACQDESC->HANDLE->void*
        ///pwOffsetData: unsigned short*
        ///pdwGainData: DWORD*
        ///pdwPxlCorrList: DWORD*
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_SetCorrData")]
        public static extern uint Acquisition_SetCorrData(System.IntPtr hAcqDesc, ref ushort pwOffsetData, ref uint pdwGainData, ref uint pdwPxlCorrList);


        /// Return Type: UINT->unsigned int
        ///hAcqDesc: HACQDESC->HANDLE->void*
        ///pwOffsetData: unsigned short*
        ///pwGainData: unsigned short*
        ///pwGainAvgData: unsigned short*
        ///nGainFrames: UINT->unsigned int
        ///pdwGainData: DWORD*
        ///pdwPxlCorrList: DWORD*
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_SetCorrData_Ex")]
        public static extern uint Acquisition_SetCorrData_Ex(System.IntPtr hAcqDesc, ref ushort pwOffsetData, ref ushort pwGainData, ref ushort pwGainAvgData, uint nGainFrames, ref uint pdwGainData, ref uint pdwPxlCorrList);


        /// Return Type: UINT->unsigned int
        ///hAcqDesc: HACQDESC->HANDLE->void*
        ///ppwOffsetData: unsigned short**
        ///ppdwGainData: DWORD**
        ///ppdwPxlCorrList: DWORD**
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_GetCorrData")]
        public static extern uint Acquisition_GetCorrData(System.IntPtr hAcqDesc, ref System.IntPtr ppwOffsetData, ref System.IntPtr ppdwGainData, ref System.IntPtr ppdwPxlCorrList);


        /// Return Type: UINT->unsigned int
        ///hAcqDesc: HACQDESC->HANDLE->void*
        ///ppwOffsetData: unsigned short**
        ///ppwGainData: unsigned short**
        ///ppwGainAvgData: unsigned short**
        ///nGainFrames: UINT**
        ///pdwGainData: DWORD**
        ///pdwPxlCorrList: DWORD**
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_GetCorrData_Ex")]
        public static extern uint Acquisition_GetCorrData_Ex(System.IntPtr hAcqDesc, ref System.IntPtr ppwOffsetData, ref System.IntPtr ppwGainData, ref System.IntPtr ppwGainAvgData, ref System.IntPtr nGainFrames, ref System.IntPtr pdwGainData, ref System.IntPtr pdwPxlCorrList);


        /// Return Type: UINT->unsigned int
        ///hAcqDesc: HACQDESC->HANDLE->void*
        ///wMode: WORD->unsigned short
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_SetCameraGain")]
        public static extern uint Acquisition_SetCameraGain(System.IntPtr hAcqDesc, ushort wMode);


        /// Return Type: UINT->unsigned int
        ///hAcqDesc: HACQDESC->HANDLE->void*
        ///uiMode: unsigned int
        ///dwDelayTime: unsigned int
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_SetFrameSyncTimeMode")]
        public static extern uint Acquisition_SetFrameSyncTimeMode(System.IntPtr hAcqDesc, uint uiMode, uint dwDelayTime);


        /// Return Type: UINT->unsigned int
        ///hAcqDesc: HACQDESC->HANDLE->void*
        ///pOffsetData: WORD*
        ///pGainData: DWORD*
        ///nRows: UINT->unsigned int
        ///nCols: UINT->unsigned int
        ///nFrames: UINT->unsigned int
        ///dwOpt: UINT->unsigned int
        ///uiULX: UINT->unsigned int
        ///uiULY: UINT->unsigned int
        ///uiBRX: UINT->unsigned int
        ///uiBRY: UINT->unsigned int
        ///uiMode: UINT->unsigned int
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_Acquire_GainImage_Ex_ROI")]
        public static extern uint Acquisition_Acquire_GainImage_Ex_ROI(System.IntPtr hAcqDesc, ref ushort pOffsetData, ref uint pGainData, uint nRows, uint nCols, uint nFrames, uint dwOpt, uint uiULX, uint uiULY, uint uiBRX, uint uiBRY, uint uiMode);


        /// Return Type: UINT->unsigned int
        ///hAcqDesc: HACQDESC->HANDLE->void*
        ///dwFrames: UINT->unsigned int
        ///dwSkipFrms: UINT->unsigned int
        ///dwOpt: UINT->unsigned int
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_Acquire_Image_PreloadCorr")]
        public static extern uint Acquisition_Acquire_Image_PreloadCorr(System.IntPtr hAcqDesc, uint dwFrames, uint dwSkipFrms, uint dwOpt);


        /// Return Type: UINT->unsigned int
        ///hAcqDesc: HACQDESC->HANDLE->void*
        ///pwOffsetData: WORD*
        ///nRows: UINT->unsigned int
        ///nColumns: UINT->unsigned int
        ///nFrames: UINT->unsigned int
        ///dwOpt: UINT->unsigned int
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_Acquire_OffsetImage_PreloadCorr")]
        public static extern uint Acquisition_Acquire_OffsetImage_PreloadCorr(System.IntPtr hAcqDesc, ref ushort pwOffsetData, uint nRows, uint nColumns, uint nFrames, uint dwOpt);


        /// Return Type: UINT->unsigned int
        ///hAcqDesc: HACQDESC->HANDLE->void*
        ///pData: unsigned char*
        ///uiSize: unsigned int
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_GetHwHeader")]
        public static extern uint Acquisition_GetHwHeader(System.IntPtr hAcqDesc, System.IntPtr pData, uint uiSize);


        /// Return Type: UINT->unsigned int
        ///hAcqDesc: HACQDESC->HANDLE->void*
        ///pGainData: DWORD*
        ///nRows: UINT->unsigned int
        ///nCols: UINT->unsigned int
        ///nFrames: UINT->unsigned int
        ///dwOpt: UINT->unsigned int
        ///uiULX: UINT->unsigned int
        ///uiULY: UINT->unsigned int
        ///uiBRX: UINT->unsigned int
        ///uiBRY: UINT->unsigned int
        ///uiMode: UINT->unsigned int
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_Acquire_GainImage_Ex_ROI_PreloadCorr")]
        public static extern uint Acquisition_Acquire_GainImage_Ex_ROI_PreloadCorr(System.IntPtr hAcqDesc, ref uint pGainData, uint nRows, uint nCols, uint nFrames, uint dwOpt, uint uiULX, uint uiULY, uint uiBRX, uint uiBRY, uint uiMode);


        /// Return Type: UINT->unsigned int
        ///hAcqDesc: HACQDESC->HANDLE->void*
        ///pGainData: DWORD*
        ///nRows: UINT->unsigned int
        ///nCols: UINT->unsigned int
        ///nFrames: UINT->unsigned int
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_Acquire_GainImage_PreloadCorr")]
        public static extern uint Acquisition_Acquire_GainImage_PreloadCorr(System.IntPtr hAcqDesc, ref uint pGainData, uint nRows, uint nCols, uint nFrames);


        /// Return Type: UINT->unsigned int
        ///hAcqDesc: HACQDESC->HANDLE->void*
        ///wMode: WORD->unsigned short
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_SetCameraBinningMode")]
        public static extern uint Acquisition_SetCameraBinningMode(System.IntPtr hAcqDesc, ushort wMode);


        /// Return Type: UINT->unsigned int
        ///hAcqDesc: HACQDESC->HANDLE->void*
        ///wMode: WORD*
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_GetCameraBinningMode")]
        public static extern uint Acquisition_GetCameraBinningMode(System.IntPtr hAcqDesc, ref ushort wMode);


        /// Return Type: UINT->unsigned int
        ///hAcqDesc: HACQDESC->HANDLE->void*
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_ResetFrameCnt")]
        public static extern uint Acquisition_ResetFrameCnt(System.IntPtr hAcqDesc);


        /// Return Type: UINT->unsigned int
        ///hAcqDesc: HACQDESC->HANDLE->void*
        ///pInfo: CHwHeaderInfo*
        ///pInfoEx: CHwHeaderInfoEx*
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_GetLatestFrameHeader")]
        public static extern uint Acquisition_GetLatestFrameHeader(System.IntPtr hAcqDesc, ref CHwHeaderInfo pInfo, ref CHwHeaderInfoEx pInfoEx);


        /// Return Type: UINT->unsigned int
        ///hAcqDesc: HACQDESC->HANDLE->void*
        ///pInfo: CHwHeaderInfo*
        ///pInfoEx: CHwHeaderInfoEx*
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_GetHwHeaderInfoEx")]
        public static extern uint Acquisition_GetHwHeaderInfoEx(System.IntPtr hAcqDesc, ref CHwHeaderInfo pInfo, ref CHwHeaderInfoEx pInfoEx);


        /// Return Type: UINT->unsigned int
        ///hAcqDesc: HACQDESC->HANDLE->void*
        ///wMode: WORD->unsigned short
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_SetCameraTriggerMode")]
        public static extern uint Acquisition_SetCameraTriggerMode(System.IntPtr hAcqDesc, ushort wMode);


        /// Return Type: UINT->unsigned int
        ///hAcqDesc: HACQDESC->HANDLE->void*
        ///wMode: WORD*
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_GetCameraTriggerMode")]
        public static extern uint Acquisition_GetCameraTriggerMode(System.IntPtr hAcqDesc, ref ushort wMode);


        /// Return Type: UINT->unsigned int
        ///hAcqDesc: HACQDESC->HANDLE->void*
        ///lRotAngle: int
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_SetRotationAngle")]
        public static extern uint Acquisition_SetRotationAngle(System.IntPtr hAcqDesc, int lRotAngle);


        /// Return Type: UINT->unsigned int
        ///hAcqDesc: HACQDESC->HANDLE->void*
        ///lRotAngle: int*
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_GetRotationAngle")]
        public static extern uint Acquisition_GetRotationAngle(System.IntPtr hAcqDesc, ref int lRotAngle);


        /// Return Type: UINT->unsigned int
        ///phAcqDesc: HACQDESC*
        ///nChannelNr: int
        ///bEnableIRQ: BOOL->int
        ///uiRows: UINT->unsigned int
        ///uiColumns: UINT->unsigned int
        ///bSelfInit: BOOL->int
        ///bAlwaysOpen: BOOL->int
        ///lInitType: int
        ///ucAddress: unsigned char*
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_GbIF_Init")]
        public static extern uint Acquisition_GbIF_Init(ref System.IntPtr phAcqDesc, int nChannelNr, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.Bool)] bool bEnableIRQ, uint uiRows, uint uiColumns, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.Bool)] bool bSelfInit, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.Bool)] bool bAlwaysOpen, int lInitType, System.IntPtr ucAddress);


        /// Return Type: UINT->unsigned int
        ///pGBIF_DEVICE_PARAM: GBIF_DEVICE_PARAM*
        ///nDeviceCnt: int
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_GbIF_GetDeviceList")]
        public static extern uint Acquisition_GbIF_GetDeviceList(ref GBIF_DEVICE_PARAM pGBIF_DEVICE_PARAM, int nDeviceCnt);


        /// Return Type: UINT->unsigned int
        ///ucAddress: unsigned char*
        ///dwAddressType: DWORD->unsigned int
        ///pDevice: GBIF_DEVICE_PARAM*
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_GbIF_GetDevice")]
        public static extern uint Acquisition_GbIF_GetDevice(System.IntPtr ucAddress, uint dwAddressType, ref GBIF_DEVICE_PARAM pDevice);


        /// Return Type: UINT->unsigned int
        ///plNrOfboards: int*
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_GbIF_GetDeviceCnt")]
        public static extern uint Acquisition_GbIF_GetDeviceCnt(ref int plNrOfboards);


        /// Return Type: UINT->unsigned int
        ///cMAC: unsigned char*
        ///ulBootOptions: unsigned int
        ///cDefIP: unsigned char*
        ///cDefSubNetMask: unsigned char*
        ///cStdGateway: unsigned char*
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_GbIF_SetConnectionSettings")]
        public static extern uint Acquisition_GbIF_SetConnectionSettings(System.IntPtr cMAC, uint ulBootOptions, System.IntPtr cDefIP, System.IntPtr cDefSubNetMask, System.IntPtr cStdGateway);


        /// Return Type: UINT->unsigned int
        ///ucMAC: unsigned char*
        ///ulBootOptions: unsigned int*
        ///ucDefIP: unsigned char*
        ///ucDefSubNetMask: unsigned char*
        ///ucStdGateway: unsigned char*
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_GbIF_GetConnectionSettings")]
        public static extern uint Acquisition_GbIF_GetConnectionSettings(System.IntPtr ucMAC, ref uint ulBootOptions, System.IntPtr ucDefIP, System.IntPtr ucDefSubNetMask, System.IntPtr ucStdGateway);


        /// Return Type: UINT->unsigned int
        ///hAcqDesc: HACQDESC->HANDLE->void*
        ///lPacketdelay: int*
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_GbIF_GetPacketDelay")]
        public static extern uint Acquisition_GbIF_GetPacketDelay(System.IntPtr hAcqDesc, ref int lPacketdelay);


        /// Return Type: UINT->unsigned int
        ///hAcqDesc: HACQDESC->HANDLE->void*
        ///lPacketdelay: int
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_GbIF_SetPacketDelay")]
        public static extern uint Acquisition_GbIF_SetPacketDelay(System.IntPtr hAcqDesc, int lPacketdelay);


        /// Return Type: UINT->unsigned int
        ///cMAC: unsigned char*
        ///cDefIP: unsigned char*
        ///cDefSubNetMask: unsigned char*
        ///cStdGateway: unsigned char*
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_GbIF_ForceIP")]
        public static extern uint Acquisition_GbIF_ForceIP(System.IntPtr cMAC, System.IntPtr cDefIP, System.IntPtr cDefSubNetMask, System.IntPtr cStdGateway);


        /// Return Type: UINT->unsigned int
        ///hAcqDesc: HACQDESC->HANDLE->void*
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_GbIF_GetFilterDrvState")]
        public static extern uint Acquisition_GbIF_GetFilterDrvState(System.IntPtr hAcqDesc);


        /// Return Type: UINT->unsigned int
        ///hAcqDesc: HACQDESC->HANDLE->void*
        ///wTiming: WORD*
        ///lPacketDelay: int*
        ///lMaxNetworkLoadPercent: int
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_GbIF_CheckNetworkSpeed")]
        public static extern uint Acquisition_GbIF_CheckNetworkSpeed(System.IntPtr hAcqDesc, ref ushort wTiming, ref int lPacketDelay, int lMaxNetworkLoadPercent);


        /// Return Type: UINT->unsigned int
        ///hAcqDesc: HACQDESC->HANDLE->void*
        ///pDetectorProperties: GBIF_Detector_Properties*
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_GbIF_GetDetectorProperties")]
        public static extern uint Acquisition_GbIF_GetDetectorProperties(System.IntPtr hAcqDesc, ref GBIF_Detector_Properties pDetectorProperties);


        /// Return Type: UINT->unsigned int
        ///hAcqDesc: HACQDESC->HANDLE->void*
        ///pDevice: GBIF_DEVICE_PARAM*
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_GbIF_GetDeviceParams")]
        public static extern uint Acquisition_GbIF_GetDeviceParams(System.IntPtr hAcqDesc, ref GBIF_DEVICE_PARAM pDevice);


        /// Return Type: UINT->unsigned int
        ///hAcqDesc: HACQDESC->HANDLE->void*
        ///bActivate: BOOL->int
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_ActivateServiceMode")]
        public static extern uint Acquisition_ActivateServiceMode(System.IntPtr hAcqDesc, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.Bool)] bool bActivate);


        /// Return Type: UINT->unsigned int
        ///hAcqDesc: HACQDESC->HANDLE->void*
        ///usActivateGrp: unsigned short
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_SetCameraROI")]
        public static extern uint Acquisition_SetCameraROI(System.IntPtr hAcqDesc, ushort usActivateGrp);


        /// Return Type: UINT->unsigned int
        ///hAcqDesc: HACQDESC->HANDLE->void*
        ///usActivateGrp: unsigned short*
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_GetCameraROI")]
        public static extern uint Acquisition_GetCameraROI(System.IntPtr hAcqDesc, ref ushort usActivateGrp);


        /// Return Type: UINT->unsigned int
        ///hAcqDesc: HACQDESC->HANDLE->void*
        ///usTiggerOutSignalMode: unsigned short
        ///usEP_SeqLength: unsigned short
        ///usEP_FirstBrightFrm: unsigned short
        ///usEP_LastBrightFrm: unsigned short
        ///usEP_Delay1: unsigned short
        ///usEP_Delay2: unsigned short
        ///usDDD_Delay: unsigned short
        ///iTriggerOnRisingEdgeEnable: int
        ///iSaveAsDefault: int
        [System.Runtime.InteropServices.DllImportAttribute("C:\\Windows\\System32\\XISL.dll", EntryPoint = "Acquisition_SetTriggerOutSignalOptions")]
        public static extern uint Acquisition_SetTriggerOutSignalOptions(System.IntPtr hAcqDesc, ushort usTiggerOutSignalMode, ushort usEP_SeqLength, ushort usEP_FirstBrightFrm, ushort usEP_LastBrightFrm, ushort usEP_Delay1, ushort usEP_Delay2, ushort usDDD_Delay, int iTriggerOnRisingEdgeEnable, int iSaveAsDefault);

    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct GBIF_DEVICE_PARAM
    {

        /// unsigned char[16]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 16)]
        public string ucMacAddress;

        /// unsigned char[16]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 16)]
        public string ucIP;

        /// unsigned char[16]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 16)]
        public string ucSubnetMask;

        /// unsigned char[16]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 16)]
        public string ucGateway;

        /// unsigned char[16]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 16)]
        public string ucAdapterIP;

        /// unsigned char[16]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 16)]
        public string ucAdapterMask;

        /// DWORD->unsigned int
        public uint dwIPCurrentBootOptions;

        /// CHAR[32]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 32)]
        public string cManufacturerName;

        /// CHAR[32]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 32)]
        public string cModelName;

        /// CHAR[32]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 32)]
        public string cGBIFFirmwareVersion;

        /// CHAR[16]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 16)]
        public string cDeviceName;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct GBIF_Detector_Properties
    {

        /// char[32]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 32)]
        public string cDetectorType;

        /// char[8]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 8)]
        public string cManufacturingDate;

        /// char[8]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 8)]
        public string cPlaceOfManufacture;

        /// char[80]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 80)]
        public string cDummy;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct CHwHeaderInfo
    {

        /// DWORD->unsigned int
        public uint dwPROMID;

        /// DWORD->unsigned int
        public uint dwHeaderID;

        /// BOOL->int
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.Bool)]
        public bool bAddRow;

        /// BOOL->int
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.Bool)]
        public bool bPwrSave;

        /// DWORD->unsigned int
        public uint dwNrRows;

        /// DWORD->unsigned int
        public uint dwNrColumns;

        /// DWORD->unsigned int
        public uint dwZoomULRow;

        /// DWORD->unsigned int
        public uint dwZoomULColumn;

        /// DWORD->unsigned int
        public uint dwZoomBRRow;

        /// DWORD->unsigned int
        public uint dwZoomBRColumn;

        /// DWORD->unsigned int
        public uint dwFrmNrRows;

        /// DWORD->unsigned int
        public uint dwFrmRowType;

        /// DWORD->unsigned int
        public uint dwFrmFillRowIntervalls;

        /// DWORD->unsigned int
        public uint dwNrOfFillingRows;

        /// DWORD->unsigned int
        public uint dwDataType;

        /// DWORD->unsigned int
        public uint dwDataSorting;

        /// DWORD->unsigned int
        public uint dwTiming;

        /// DWORD->unsigned int
        public uint dwAcqMode;

        /// DWORD->unsigned int
        public uint dwGain;

        /// DWORD->unsigned int
        public uint dwOffset;

        /// DWORD->unsigned int
        public uint dwAccess;

        /// BOOL->int
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.Bool)]
        public bool bSyncMode;

        /// DWORD->unsigned int
        public uint dwBias;

        /// DWORD->unsigned int
        public uint dwLeakRows;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct CHwHeaderInfoEx
    {

        /// WORD->unsigned short
        public ushort wHeaderID;

        /// WORD->unsigned short
        public ushort wPROMID;

        /// WORD->unsigned short
        public ushort wResolutionX;

        /// WORD->unsigned short
        public ushort wResolutionY;

        /// WORD->unsigned short
        public ushort wNrRows;

        /// WORD->unsigned short
        public ushort wNrColumns;

        /// WORD->unsigned short
        public ushort wZoomULRow;

        /// WORD->unsigned short
        public ushort wZoomULColumn;

        /// WORD->unsigned short
        public ushort wZoomBRRow;

        /// WORD->unsigned short
        public ushort wZoomBRColumn;

        /// WORD->unsigned short
        public ushort wFrmNrRows;

        /// WORD->unsigned short
        public ushort wFrmRowType;

        /// WORD->unsigned short
        public ushort wRowTime;

        /// WORD->unsigned short
        public ushort wClock;

        /// WORD->unsigned short
        public ushort wDataSorting;

        /// WORD->unsigned short
        public ushort wTiming;

        /// WORD->unsigned short
        public ushort wGain;

        /// WORD->unsigned short
        public ushort wLeakRows;

        /// WORD->unsigned short
        public ushort wAccess;

        /// WORD->unsigned short
        public ushort wBias;

        /// WORD->unsigned short
        public ushort wUgComp;

        /// WORD->unsigned short
        public ushort wCameratype;

        /// WORD->unsigned short
        public ushort wFrameCnt;

        /// WORD->unsigned short
        public ushort wBinningMode;

        /// WORD->unsigned short
        public ushort wRealInttime_milliSec;

        /// WORD->unsigned short
        public ushort wRealInttime_microSec;

        /// WORD->unsigned short
        public ushort wStatus;

        /// WORD->unsigned short
        public ushort wCommand1;

        /// WORD->unsigned short
        public ushort wCommand2;

        /// WORD->unsigned short
        public ushort wCommand3;

        /// WORD->unsigned short
        public ushort wCommand4;

        /// WORD->unsigned short
        public ushort wDummy;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct WinHeaderType
    {

        /// WORD->unsigned short
        public ushort FileType;

        /// WORD->unsigned short
        public ushort HeaderSize;

        /// WORD->unsigned short
        public ushort HeaderVersion;

        /// ULONG->unsigned int
        public uint FileSize;

        /// WORD->unsigned short
        public ushort ImageHeaderSize;

        /// WORD->unsigned short
        public ushort ULX;

        /// WORD->unsigned short
        public ushort ULY;

        /// WORD->unsigned short
        public ushort BRX;

        /// WORD->unsigned short
        public ushort BRY;

        /// WORD->unsigned short
        public ushort NrOfFrames;

        /// WORD->unsigned short
        public ushort Correction;

        /// double
        public double IntegrationTime;

        /// WORD->unsigned short
        public ushort TypeOfNumbers;

        /// BYTE[34]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 34, ArraySubType = System.Runtime.InteropServices.UnmanagedType.I1)]
        public byte[] x;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    public struct WinImageHeaderType
    {

        /// DWORD->unsigned int
        public uint dwPROMID;

        /// char[6]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 6)]
        public string strProject;

        /// char[3]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 3)]
        public string strSystemused;

        /// char[9]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 9)]
        public string strPrefilter;

        /// float
        public float fKVolt;

        /// float
        public float fAmpere;

        /// WORD->unsigned short
        public ushort n_avframes;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct FPGAType
    {

        /// unsigned char
        public byte wTiming;

        /// unsigned char
        public byte wValue0;

        /// unsigned char
        public byte wValue1;

        /// unsigned char
        public byte wValue2;

        /// unsigned char
        public byte wValue3;

        /// unsigned char
        public byte wValue4;

        /// unsigned char
        public byte wValue5;

        /// unsigned char
        public byte wValue6;
    }

    /// Return Type: void
    ///param0: HACQDESC->HANDLE->void*
    [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute(System.Runtime.InteropServices.CallingConvention.StdCall)]
    public delegate void Anonymous_e11ba521_9920_4f57_ab1c_64528eabc09c(System.IntPtr param0);

    /// Return Type: void
    ///param0: HACQDESC->HANDLE->void*
    [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute(System.Runtime.InteropServices.CallingConvention.StdCall)]
    public delegate void Anonymous_c3be27cb_c2c6_467c_ab9d_b6c9448b3c73(System.IntPtr param0);

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct HWND__
    {

        /// int
        public int unused;
    }

}
