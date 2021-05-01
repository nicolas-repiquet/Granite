using System;
using System.Runtime.InteropServices;

namespace Granite.Core
{
	public static partial class GL
	{

		public const uint ACTIVE_ATTRIBUTE_MAX_LENGTH = 0x00008B8A;
		public const uint ACTIVE_ATTRIBUTES = 0x00008B89;
		public const uint ACTIVE_TEXTURE = 0x000084E0;
		public const uint ACTIVE_UNIFORM_BLOCK_MAX_NAME_LENGTH = 0x00008A35;
		public const uint ACTIVE_UNIFORM_BLOCKS = 0x00008A36;
		public const uint ACTIVE_UNIFORM_MAX_LENGTH = 0x00008B87;
		public const uint ACTIVE_UNIFORMS = 0x00008B86;
		public const uint ALIASED_LINE_WIDTH_RANGE = 0x0000846E;
		public const uint ALPHA = 0x00001906;
		public const uint ALREADY_SIGNALED = 0x0000911A;
		public const uint ALWAYS = 0x00000207;
		public const uint AND = 0x00001501;
		public const uint AND_INVERTED = 0x00001504;
		public const uint AND_REVERSE = 0x00001502;
		public const uint ANY_SAMPLES_PASSED = 0x00008C2F;
		public const uint ARRAY_BUFFER = 0x00008892;
		public const uint ARRAY_BUFFER_BINDING = 0x00008894;
		public const uint ATTACHED_SHADERS = 0x00008B85;
		public const uint BACK = 0x00000405;
		public const uint BACK_LEFT = 0x00000402;
		public const uint BACK_RIGHT = 0x00000403;
		public const uint BGR = 0x000080E0;
		public const uint BGR_INTEGER = 0x00008D9A;
		public const uint BGRA = 0x000080E1;
		public const uint BGRA_INTEGER = 0x00008D9B;
		public const uint BLEND = 0x00000BE2;
		public const uint BLEND_DST = 0x00000BE0;
		public const uint BLEND_DST_ALPHA = 0x000080CA;
		public const uint BLEND_DST_RGB = 0x000080C8;
		public const uint BLEND_EQUATION_ALPHA = 0x0000883D;
		public const uint BLEND_EQUATION_RGB = 0x00008009;
		public const uint BLEND_SRC = 0x00000BE1;
		public const uint BLEND_SRC_ALPHA = 0x000080CB;
		public const uint BLEND_SRC_RGB = 0x000080C9;
		public const uint BLUE = 0x00001905;
		public const uint BLUE_INTEGER = 0x00008D96;
		public const uint BOOL = 0x00008B56;
		public const uint BOOL_VEC2 = 0x00008B57;
		public const uint BOOL_VEC3 = 0x00008B58;
		public const uint BOOL_VEC4 = 0x00008B59;
		public const uint BUFFER_ACCESS = 0x000088BB;
		public const uint BUFFER_ACCESS_FLAGS = 0x0000911F;
		public const uint BUFFER_MAP_LENGTH = 0x00009120;
		public const uint BUFFER_MAP_OFFSET = 0x00009121;
		public const uint BUFFER_MAP_POINTER = 0x000088BD;
		public const uint BUFFER_MAPPED = 0x000088BC;
		public const uint BUFFER_SIZE = 0x00008764;
		public const uint BUFFER_USAGE = 0x00008765;
		public const uint BYTE = 0x00001400;
		public const uint CCW = 0x00000901;
		public const uint CLAMP_READ_COLOR = 0x0000891C;
		public const uint CLAMP_TO_BORDER = 0x0000812D;
		public const uint CLAMP_TO_EDGE = 0x0000812F;
		public const uint CLEAR = 0x00001500;
		public const uint CLIP_DISTANCE0 = 0x00003000;
		public const uint CLIP_DISTANCE1 = 0x00003001;
		public const uint CLIP_DISTANCE2 = 0x00003002;
		public const uint CLIP_DISTANCE3 = 0x00003003;
		public const uint CLIP_DISTANCE4 = 0x00003004;
		public const uint CLIP_DISTANCE5 = 0x00003005;
		public const uint CLIP_DISTANCE6 = 0x00003006;
		public const uint CLIP_DISTANCE7 = 0x00003007;
		public const uint COLOR = 0x00001800;
		public const uint COLOR_ATTACHMENT0 = 0x00008CE0;
		public const uint COLOR_ATTACHMENT1 = 0x00008CE1;
		public const uint COLOR_ATTACHMENT10 = 0x00008CEA;
		public const uint COLOR_ATTACHMENT11 = 0x00008CEB;
		public const uint COLOR_ATTACHMENT12 = 0x00008CEC;
		public const uint COLOR_ATTACHMENT13 = 0x00008CED;
		public const uint COLOR_ATTACHMENT14 = 0x00008CEE;
		public const uint COLOR_ATTACHMENT15 = 0x00008CEF;
		public const uint COLOR_ATTACHMENT2 = 0x00008CE2;
		public const uint COLOR_ATTACHMENT3 = 0x00008CE3;
		public const uint COLOR_ATTACHMENT4 = 0x00008CE4;
		public const uint COLOR_ATTACHMENT5 = 0x00008CE5;
		public const uint COLOR_ATTACHMENT6 = 0x00008CE6;
		public const uint COLOR_ATTACHMENT7 = 0x00008CE7;
		public const uint COLOR_ATTACHMENT8 = 0x00008CE8;
		public const uint COLOR_ATTACHMENT9 = 0x00008CE9;
		public const uint COLOR_BUFFER_BIT = 0x00004000;
		public const uint COLOR_CLEAR_VALUE = 0x00000C22;
		public const uint COLOR_LOGIC_OP = 0x00000BF2;
		public const uint COLOR_WRITEMASK = 0x00000C23;
		public const uint COMPARE_REF_TO_TEXTURE = 0x0000884E;
		public const uint COMPILE_STATUS = 0x00008B81;
		public const uint COMPRESSED_RED = 0x00008225;
		public const uint COMPRESSED_RED_RGTC1 = 0x00008DBB;
		public const uint COMPRESSED_RG = 0x00008226;
		public const uint COMPRESSED_RG_RGTC2 = 0x00008DBD;
		public const uint COMPRESSED_RGB = 0x000084ED;
		public const uint COMPRESSED_RGBA = 0x000084EE;
		public const uint COMPRESSED_SIGNED_RED_RGTC1 = 0x00008DBC;
		public const uint COMPRESSED_SIGNED_RG_RGTC2 = 0x00008DBE;
		public const uint COMPRESSED_SRGB = 0x00008C48;
		public const uint COMPRESSED_SRGB_ALPHA = 0x00008C49;
		public const uint COMPRESSED_TEXTURE_FORMATS = 0x000086A3;
		public const uint CONDITION_SATISFIED = 0x0000911C;
		public const uint CONSTANT_ALPHA = 0x00008003;
		public const uint CONSTANT_COLOR = 0x00008001;
		public const uint CONTEXT_COMPATIBILITY_PROFILE_BIT = 0x00000002;
		public const uint CONTEXT_CORE_PROFILE_BIT = 0x00000001;
		public const uint CONTEXT_FLAG_FORWARD_COMPATIBLE_BIT = 0x00000001;
		public const uint CONTEXT_FLAGS = 0x0000821E;
		public const uint CONTEXT_PROFILE_MASK = 0x00009126;
		public const uint COPY = 0x00001503;
		public const uint COPY_INVERTED = 0x0000150C;
		public const uint COPY_READ_BUFFER = 0x00008F36;
		public const uint COPY_WRITE_BUFFER = 0x00008F37;
		public const uint CULL_FACE = 0x00000B44;
		public const uint CULL_FACE_MODE = 0x00000B45;
		public const uint CURRENT_PROGRAM = 0x00008B8D;
		public const uint CURRENT_QUERY = 0x00008865;
		public const uint CURRENT_VERTEX_ATTRIB = 0x00008626;
		public const uint CW = 0x00000900;
		public const uint DECR = 0x00001E03;
		public const uint DECR_WRAP = 0x00008508;
		public const uint DELETE_STATUS = 0x00008B80;
		public const uint DEPTH = 0x00001801;
		public const uint DEPTH_ATTACHMENT = 0x00008D00;
		public const uint DEPTH_BUFFER_BIT = 0x00000100;
		public const uint DEPTH_CLAMP = 0x0000864F;
		public const uint DEPTH_CLEAR_VALUE = 0x00000B73;
		public const uint DEPTH_COMPONENT = 0x00001902;
		public const uint DEPTH_COMPONENT16 = 0x000081A5;
		public const uint DEPTH_COMPONENT24 = 0x000081A6;
		public const uint DEPTH_COMPONENT32 = 0x000081A7;
		public const uint DEPTH_COMPONENT32F = 0x00008CAC;
		public const uint DEPTH_FUNC = 0x00000B74;
		public const uint DEPTH_RANGE = 0x00000B70;
		public const uint DEPTH_STENCIL = 0x000084F9;
		public const uint DEPTH_STENCIL_ATTACHMENT = 0x0000821A;
		public const uint DEPTH_TEST = 0x00000B71;
		public const uint DEPTH_WRITEMASK = 0x00000B72;
		public const uint DEPTH24_STENCIL8 = 0x000088F0;
		public const uint DEPTH32F_STENCIL8 = 0x00008CAD;
		public const uint DITHER = 0x00000BD0;
		public const uint DONT_CARE = 0x00001100;
		public const uint DOUBLE = 0x0000140A;
		public const uint DOUBLEBUFFER = 0x00000C32;
		public const uint DRAW_BUFFER = 0x00000C01;
		public const uint DRAW_BUFFER0 = 0x00008825;
		public const uint DRAW_BUFFER1 = 0x00008826;
		public const uint DRAW_BUFFER10 = 0x0000882F;
		public const uint DRAW_BUFFER11 = 0x00008830;
		public const uint DRAW_BUFFER12 = 0x00008831;
		public const uint DRAW_BUFFER13 = 0x00008832;
		public const uint DRAW_BUFFER14 = 0x00008833;
		public const uint DRAW_BUFFER15 = 0x00008834;
		public const uint DRAW_BUFFER2 = 0x00008827;
		public const uint DRAW_BUFFER3 = 0x00008828;
		public const uint DRAW_BUFFER4 = 0x00008829;
		public const uint DRAW_BUFFER5 = 0x0000882A;
		public const uint DRAW_BUFFER6 = 0x0000882B;
		public const uint DRAW_BUFFER7 = 0x0000882C;
		public const uint DRAW_BUFFER8 = 0x0000882D;
		public const uint DRAW_BUFFER9 = 0x0000882E;
		public const uint DRAW_FRAMEBUFFER = 0x00008CA9;
		public const uint DRAW_FRAMEBUFFER_BINDING = 0x00008CA6;
		public const uint DST_ALPHA = 0x00000304;
		public const uint DST_COLOR = 0x00000306;
		public const uint DYNAMIC_COPY = 0x000088EA;
		public const uint DYNAMIC_DRAW = 0x000088E8;
		public const uint DYNAMIC_READ = 0x000088E9;
		public const uint ELEMENT_ARRAY_BUFFER = 0x00008893;
		public const uint ELEMENT_ARRAY_BUFFER_BINDING = 0x00008895;
		public const uint EQUAL = 0x00000202;
		public const uint EQUIV = 0x00001509;
		public const uint EXTENSIONS = 0x00001F03;
		public const uint FALSE = 0x00000000;
		public const uint FASTEST = 0x00001101;
		public const uint FILL = 0x00001B02;
		public const uint FIRST_VERTEX_CONVENTION = 0x00008E4D;
		public const uint FIXED_ONLY = 0x0000891D;
		public const uint FLOAT = 0x00001406;
		public const uint FLOAT_32_UNSIGNED_INT_24_8_REV = 0x00008DAD;
		public const uint FLOAT_MAT2 = 0x00008B5A;
		public const uint FLOAT_MAT2x3 = 0x00008B65;
		public const uint FLOAT_MAT2x4 = 0x00008B66;
		public const uint FLOAT_MAT3 = 0x00008B5B;
		public const uint FLOAT_MAT3x2 = 0x00008B67;
		public const uint FLOAT_MAT3x4 = 0x00008B68;
		public const uint FLOAT_MAT4 = 0x00008B5C;
		public const uint FLOAT_MAT4x2 = 0x00008B69;
		public const uint FLOAT_MAT4x3 = 0x00008B6A;
		public const uint FLOAT_VEC2 = 0x00008B50;
		public const uint FLOAT_VEC3 = 0x00008B51;
		public const uint FLOAT_VEC4 = 0x00008B52;
		public const uint FRAGMENT_SHADER = 0x00008B30;
		public const uint FRAGMENT_SHADER_DERIVATIVE_HINT = 0x00008B8B;
		public const uint FRAMEBUFFER = 0x00008D40;
		public const uint FRAMEBUFFER_ATTACHMENT_ALPHA_SIZE = 0x00008215;
		public const uint FRAMEBUFFER_ATTACHMENT_BLUE_SIZE = 0x00008214;
		public const uint FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING = 0x00008210;
		public const uint FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE = 0x00008211;
		public const uint FRAMEBUFFER_ATTACHMENT_DEPTH_SIZE = 0x00008216;
		public const uint FRAMEBUFFER_ATTACHMENT_GREEN_SIZE = 0x00008213;
		public const uint FRAMEBUFFER_ATTACHMENT_LAYERED = 0x00008DA7;
		public const uint FRAMEBUFFER_ATTACHMENT_OBJECT_NAME = 0x00008CD1;
		public const uint FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE = 0x00008CD0;
		public const uint FRAMEBUFFER_ATTACHMENT_RED_SIZE = 0x00008212;
		public const uint FRAMEBUFFER_ATTACHMENT_STENCIL_SIZE = 0x00008217;
		public const uint FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE = 0x00008CD3;
		public const uint FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER = 0x00008CD4;
		public const uint FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL = 0x00008CD2;
		public const uint FRAMEBUFFER_BINDING = 0x00008CA6;
		public const uint FRAMEBUFFER_COMPLETE = 0x00008CD5;
		public const uint FRAMEBUFFER_DEFAULT = 0x00008218;
		public const uint FRAMEBUFFER_INCOMPLETE_ATTACHMENT = 0x00008CD6;
		public const uint FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER = 0x00008CDB;
		public const uint FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS = 0x00008DA8;
		public const uint FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT = 0x00008CD7;
		public const uint FRAMEBUFFER_INCOMPLETE_MULTISAMPLE = 0x00008D56;
		public const uint FRAMEBUFFER_INCOMPLETE_READ_BUFFER = 0x00008CDC;
		public const uint FRAMEBUFFER_SRGB = 0x00008DB9;
		public const uint FRAMEBUFFER_UNDEFINED = 0x00008219;
		public const uint FRAMEBUFFER_UNSUPPORTED = 0x00008CDD;
		public const uint FRONT = 0x00000404;
		public const uint FRONT_AND_BACK = 0x00000408;
		public const uint FRONT_FACE = 0x00000B46;
		public const uint FRONT_LEFT = 0x00000400;
		public const uint FRONT_RIGHT = 0x00000401;
		public const uint FUNC_ADD = 0x00008006;
		public const uint FUNC_REVERSE_SUBTRACT = 0x0000800B;
		public const uint FUNC_SUBTRACT = 0x0000800A;
		public const uint GEOMETRY_INPUT_TYPE = 0x00008917;
		public const uint GEOMETRY_OUTPUT_TYPE = 0x00008918;
		public const uint GEOMETRY_SHADER = 0x00008DD9;
		public const uint GEOMETRY_VERTICES_OUT = 0x00008916;
		public const uint GEQUAL = 0x00000206;
		public const uint GREATER = 0x00000204;
		public const uint GREEN = 0x00001904;
		public const uint GREEN_INTEGER = 0x00008D95;
		public const uint HALF_FLOAT = 0x0000140B;
		public const uint INCR = 0x00001E02;
		public const uint INCR_WRAP = 0x00008507;
		public const uint INDEX = 0x00008222;
		public const uint INFO_LOG_LENGTH = 0x00008B84;
		public const uint INT = 0x00001404;
		public const uint INT_SAMPLER_1D = 0x00008DC9;
		public const uint INT_SAMPLER_1D_ARRAY = 0x00008DCE;
		public const uint INT_SAMPLER_2D = 0x00008DCA;
		public const uint INT_SAMPLER_2D_ARRAY = 0x00008DCF;
		public const uint INT_SAMPLER_2D_MULTISAMPLE = 0x00009109;
		public const uint INT_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x0000910C;
		public const uint INT_SAMPLER_2D_RECT = 0x00008DCD;
		public const uint INT_SAMPLER_3D = 0x00008DCB;
		public const uint INT_SAMPLER_BUFFER = 0x00008DD0;
		public const uint INT_SAMPLER_CUBE = 0x00008DCC;
		public const uint INT_VEC2 = 0x00008B53;
		public const uint INT_VEC3 = 0x00008B54;
		public const uint INT_VEC4 = 0x00008B55;
		public const uint INTERLEAVED_ATTRIBS = 0x00008C8C;
		public const uint INVALID_ENUM = 0x00000500;
		public const uint INVALID_FRAMEBUFFER_OPERATION = 0x00000506;
		public const uint INVALID_INDEX = 0xFFFFFFFF;
		public const uint INVALID_OPERATION = 0x00000502;
		public const uint INVALID_VALUE = 0x00000501;
		public const uint INVERT = 0x0000150A;
		public const uint KEEP = 0x00001E00;
		public const uint LAST_VERTEX_CONVENTION = 0x00008E4E;
		public const uint LEFT = 0x00000406;
		public const uint LEQUAL = 0x00000203;
		public const uint LESS = 0x00000201;
		public const uint LINE = 0x00001B01;
		public const uint LINE_LOOP = 0x00000002;
		public const uint LINE_SMOOTH = 0x00000B20;
		public const uint LINE_SMOOTH_HINT = 0x00000C52;
		public const uint LINE_STRIP = 0x00000003;
		public const uint LINE_STRIP_ADJACENCY = 0x0000000B;
		public const uint LINE_WIDTH = 0x00000B21;
		public const uint LINE_WIDTH_GRANULARITY = 0x00000B23;
		public const uint LINE_WIDTH_RANGE = 0x00000B22;
		public const uint LINEAR = 0x00002601;
		public const uint LINEAR_MIPMAP_LINEAR = 0x00002703;
		public const uint LINEAR_MIPMAP_NEAREST = 0x00002701;
		public const uint LINES = 0x00000001;
		public const uint LINES_ADJACENCY = 0x0000000A;
		public const uint LINK_STATUS = 0x00008B82;
		public const uint LOGIC_OP_MODE = 0x00000BF0;
		public const uint LOWER_LEFT = 0x00008CA1;
		public const uint MAJOR_VERSION = 0x0000821B;
		public const uint MAP_FLUSH_EXPLICIT_BIT = 0x00000010;
		public const uint MAP_INVALIDATE_BUFFER_BIT = 0x00000008;
		public const uint MAP_INVALIDATE_RANGE_BIT = 0x00000004;
		public const uint MAP_READ_BIT = 0x00000001;
		public const uint MAP_UNSYNCHRONIZED_BIT = 0x00000020;
		public const uint MAP_WRITE_BIT = 0x00000002;
		public const uint MAX = 0x00008008;
		public const uint MAX_3D_TEXTURE_SIZE = 0x00008073;
		public const uint MAX_ARRAY_TEXTURE_LAYERS = 0x000088FF;
		public const uint MAX_CLIP_DISTANCES = 0x00000D32;
		public const uint MAX_COLOR_ATTACHMENTS = 0x00008CDF;
		public const uint MAX_COLOR_TEXTURE_SAMPLES = 0x0000910E;
		public const uint MAX_COMBINED_FRAGMENT_UNIFORM_COMPONENTS = 0x00008A33;
		public const uint MAX_COMBINED_TEXTURE_IMAGE_UNITS = 0x00008B4D;
		public const uint MAX_COMBINED_UNIFORM_BLOCKS = 0x00008A2E;
		public const uint MAX_COMBINED_VERTEX_UNIFORM_COMPONENTS = 0x00008A31;
		public const uint MAX_CUBE_MAP_TEXTURE_SIZE = 0x0000851C;
		public const uint MAX_DEPTH_TEXTURE_SAMPLES = 0x0000910F;
		public const uint MAX_DRAW_BUFFERS = 0x00008824;
		public const uint MAX_DUAL_SOURCE_DRAW_BUFFERS = 0x000088FC;
		public const uint MAX_ELEMENTS_INDICES = 0x000080E9;
		public const uint MAX_ELEMENTS_VERTICES = 0x000080E8;
		public const uint MAX_FRAGMENT_INPUT_COMPONENTS = 0x00009125;
		public const uint MAX_FRAGMENT_UNIFORM_BLOCKS = 0x00008A2D;
		public const uint MAX_FRAGMENT_UNIFORM_COMPONENTS = 0x00008B49;
		public const uint MAX_GEOMETRY_INPUT_COMPONENTS = 0x00009123;
		public const uint MAX_GEOMETRY_OUTPUT_COMPONENTS = 0x00009124;
		public const uint MAX_GEOMETRY_OUTPUT_VERTICES = 0x00008DE0;
		public const uint MAX_GEOMETRY_TEXTURE_IMAGE_UNITS = 0x00008C29;
		public const uint MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS = 0x00008DE1;
		public const uint MAX_GEOMETRY_UNIFORM_COMPONENTS = 0x00008DDF;
		public const uint MAX_INTEGER_SAMPLES = 0x00009110;
		public const uint MAX_PROGRAM_TEXEL_OFFSET = 0x00008905;
		public const uint MAX_RECTANGLE_TEXTURE_SIZE = 0x000084F8;
		public const uint MAX_RENDERBUFFER_SIZE = 0x000084E8;
		public const uint MAX_SAMPLE_MASK_WORDS = 0x00008E59;
		public const uint MAX_SAMPLES = 0x00008D57;
		public const uint MAX_SERVER_WAIT_TIMEOUT = 0x00009111;
		public const uint MAX_TEXTURE_BUFFER_SIZE = 0x00008C2B;
		public const uint MAX_TEXTURE_IMAGE_UNITS = 0x00008872;
		public const uint MAX_TEXTURE_LOD_BIAS = 0x000084FD;
		public const uint MAX_TEXTURE_SIZE = 0x00000D33;
		public const uint MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS = 0x00008C8A;
		public const uint MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS = 0x00008C8B;
		public const uint MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS = 0x00008C80;
		public const uint MAX_UNIFORM_BLOCK_SIZE = 0x00008A30;
		public const uint MAX_UNIFORM_BUFFER_BINDINGS = 0x00008A2F;
		public const uint MAX_VARYING_COMPONENTS = 0x00008B4B;
		public const uint MAX_VARYING_FLOATS = 0x00008B4B;
		public const uint MAX_VERTEX_ATTRIBS = 0x00008869;
		public const uint MAX_VERTEX_OUTPUT_COMPONENTS = 0x00009122;
		public const uint MAX_VERTEX_TEXTURE_IMAGE_UNITS = 0x00008B4C;
		public const uint MAX_VERTEX_UNIFORM_BLOCKS = 0x00008A2B;
		public const uint MAX_VERTEX_UNIFORM_COMPONENTS = 0x00008B4A;
		public const uint MAX_VIEWPORT_DIMS = 0x00000D3A;
		public const uint MIN = 0x00008007;
		public const uint MIN_PROGRAM_TEXEL_OFFSET = 0x00008904;
		public const uint MINOR_VERSION = 0x0000821C;
		public const uint MIRRORED_REPEAT = 0x00008370;
		public const uint MULTISAMPLE = 0x0000809D;
		public const uint NAND = 0x0000150E;
		public const uint NEAREST = 0x00002600;
		public const uint NEAREST_MIPMAP_LINEAR = 0x00002702;
		public const uint NEAREST_MIPMAP_NEAREST = 0x00002700;
		public const uint NEVER = 0x00000200;
		public const uint NICEST = 0x00001102;
		public const uint NO_ERROR = 0x00000000;
		public const uint NONE = 0x00000000;
		public const uint NOOP = 0x00001505;
		public const uint NOR = 0x00001508;
		public const uint NOTEQUAL = 0x00000205;
		public const uint NUM_COMPRESSED_TEXTURE_FORMATS = 0x000086A2;
		public const uint NUM_EXTENSIONS = 0x0000821D;
		public const uint OBJECT_TYPE = 0x00009112;
		public const uint ONE = 0x00000001;
		public const uint ONE_MINUS_CONSTANT_ALPHA = 0x00008004;
		public const uint ONE_MINUS_CONSTANT_COLOR = 0x00008002;
		public const uint ONE_MINUS_DST_ALPHA = 0x00000305;
		public const uint ONE_MINUS_DST_COLOR = 0x00000307;
		public const uint ONE_MINUS_SRC_ALPHA = 0x00000303;
		public const uint ONE_MINUS_SRC_COLOR = 0x00000301;
		public const uint ONE_MINUS_SRC1_ALPHA = 0x000088FB;
		public const uint ONE_MINUS_SRC1_COLOR = 0x000088FA;
		public const uint OR = 0x00001507;
		public const uint OR_INVERTED = 0x0000150D;
		public const uint OR_REVERSE = 0x0000150B;
		public const uint OUT_OF_MEMORY = 0x00000505;
		public const uint PACK_ALIGNMENT = 0x00000D05;
		public const uint PACK_IMAGE_HEIGHT = 0x0000806C;
		public const uint PACK_LSB_FIRST = 0x00000D01;
		public const uint PACK_ROW_LENGTH = 0x00000D02;
		public const uint PACK_SKIP_IMAGES = 0x0000806B;
		public const uint PACK_SKIP_PIXELS = 0x00000D04;
		public const uint PACK_SKIP_ROWS = 0x00000D03;
		public const uint PACK_SWAP_BYTES = 0x00000D00;
		public const uint PIXEL_PACK_BUFFER = 0x000088EB;
		public const uint PIXEL_PACK_BUFFER_BINDING = 0x000088ED;
		public const uint PIXEL_UNPACK_BUFFER = 0x000088EC;
		public const uint PIXEL_UNPACK_BUFFER_BINDING = 0x000088EF;
		public const uint POINT = 0x00001B00;
		public const uint POINT_FADE_THRESHOLD_SIZE = 0x00008128;
		public const uint POINT_SIZE = 0x00000B11;
		public const uint POINT_SIZE_GRANULARITY = 0x00000B13;
		public const uint POINT_SIZE_RANGE = 0x00000B12;
		public const uint POINT_SPRITE_COORD_ORIGIN = 0x00008CA0;
		public const uint POINTS = 0x00000000;
		public const uint POLYGON_MODE = 0x00000B40;
		public const uint POLYGON_OFFSET_FACTOR = 0x00008038;
		public const uint POLYGON_OFFSET_FILL = 0x00008037;
		public const uint POLYGON_OFFSET_LINE = 0x00002A02;
		public const uint POLYGON_OFFSET_POINT = 0x00002A01;
		public const uint POLYGON_OFFSET_UNITS = 0x00002A00;
		public const uint POLYGON_SMOOTH = 0x00000B41;
		public const uint POLYGON_SMOOTH_HINT = 0x00000C53;
		public const uint PRIMITIVE_RESTART = 0x00008F9D;
		public const uint PRIMITIVE_RESTART_INDEX = 0x00008F9E;
		public const uint PRIMITIVES_GENERATED = 0x00008C87;
		public const uint PROGRAM_POINT_SIZE = 0x00008642;
		public const uint PROVOKING_VERTEX = 0x00008E4F;
		public const uint PROXY_TEXTURE_1D = 0x00008063;
		public const uint PROXY_TEXTURE_1D_ARRAY = 0x00008C19;
		public const uint PROXY_TEXTURE_2D = 0x00008064;
		public const uint PROXY_TEXTURE_2D_ARRAY = 0x00008C1B;
		public const uint PROXY_TEXTURE_2D_MULTISAMPLE = 0x00009101;
		public const uint PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY = 0x00009103;
		public const uint PROXY_TEXTURE_3D = 0x00008070;
		public const uint PROXY_TEXTURE_CUBE_MAP = 0x0000851B;
		public const uint PROXY_TEXTURE_RECTANGLE = 0x000084F7;
		public const uint QUADS_FOLLOW_PROVOKING_VERTEX_CONVENTION = 0x00008E4C;
		public const uint QUERY_BY_REGION_NO_WAIT = 0x00008E16;
		public const uint QUERY_BY_REGION_WAIT = 0x00008E15;
		public const uint QUERY_COUNTER_BITS = 0x00008864;
		public const uint QUERY_NO_WAIT = 0x00008E14;
		public const uint QUERY_RESULT = 0x00008866;
		public const uint QUERY_RESULT_AVAILABLE = 0x00008867;
		public const uint QUERY_WAIT = 0x00008E13;
		public const uint R11F_G11F_B10F = 0x00008C3A;
		public const uint R16 = 0x0000822A;
		public const uint R16_SNORM = 0x00008F98;
		public const uint R16F = 0x0000822D;
		public const uint R16I = 0x00008233;
		public const uint R16UI = 0x00008234;
		public const uint R3_G3_B2 = 0x00002A10;
		public const uint R32F = 0x0000822E;
		public const uint R32I = 0x00008235;
		public const uint R32UI = 0x00008236;
		public const uint R8 = 0x00008229;
		public const uint R8_SNORM = 0x00008F94;
		public const uint R8I = 0x00008231;
		public const uint R8UI = 0x00008232;
		public const uint RASTERIZER_DISCARD = 0x00008C89;
		public const uint READ_BUFFER = 0x00000C02;
		public const uint READ_FRAMEBUFFER = 0x00008CA8;
		public const uint READ_FRAMEBUFFER_BINDING = 0x00008CAA;
		public const uint READ_ONLY = 0x000088B8;
		public const uint READ_WRITE = 0x000088BA;
		public const uint RED = 0x00001903;
		public const uint RED_INTEGER = 0x00008D94;
		public const uint RENDERBUFFER = 0x00008D41;
		public const uint RENDERBUFFER_ALPHA_SIZE = 0x00008D53;
		public const uint RENDERBUFFER_BINDING = 0x00008CA7;
		public const uint RENDERBUFFER_BLUE_SIZE = 0x00008D52;
		public const uint RENDERBUFFER_DEPTH_SIZE = 0x00008D54;
		public const uint RENDERBUFFER_GREEN_SIZE = 0x00008D51;
		public const uint RENDERBUFFER_HEIGHT = 0x00008D43;
		public const uint RENDERBUFFER_INTERNAL_FORMAT = 0x00008D44;
		public const uint RENDERBUFFER_RED_SIZE = 0x00008D50;
		public const uint RENDERBUFFER_SAMPLES = 0x00008CAB;
		public const uint RENDERBUFFER_STENCIL_SIZE = 0x00008D55;
		public const uint RENDERBUFFER_WIDTH = 0x00008D42;
		public const uint RENDERER = 0x00001F01;
		public const uint REPEAT = 0x00002901;
		public const uint REPLACE = 0x00001E01;
		public const uint RG = 0x00008227;
		public const uint RG_INTEGER = 0x00008228;
		public const uint RG16 = 0x0000822C;
		public const uint RG16_SNORM = 0x00008F99;
		public const uint RG16F = 0x0000822F;
		public const uint RG16I = 0x00008239;
		public const uint RG16UI = 0x0000823A;
		public const uint RG32F = 0x00008230;
		public const uint RG32I = 0x0000823B;
		public const uint RG32UI = 0x0000823C;
		public const uint RG8 = 0x0000822B;
		public const uint RG8_SNORM = 0x00008F95;
		public const uint RG8I = 0x00008237;
		public const uint RG8UI = 0x00008238;
		public const uint RGB = 0x00001907;
		public const uint RGB_INTEGER = 0x00008D98;
		public const uint RGB10 = 0x00008052;
		public const uint RGB10_A2 = 0x00008059;
		public const uint RGB10_A2UI = 0x0000906F;
		public const uint RGB12 = 0x00008053;
		public const uint RGB16 = 0x00008054;
		public const uint RGB16_SNORM = 0x00008F9A;
		public const uint RGB16F = 0x0000881B;
		public const uint RGB16I = 0x00008D89;
		public const uint RGB16UI = 0x00008D77;
		public const uint RGB32F = 0x00008815;
		public const uint RGB32I = 0x00008D83;
		public const uint RGB32UI = 0x00008D71;
		public const uint RGB4 = 0x0000804F;
		public const uint RGB5 = 0x00008050;
		public const uint RGB5_A1 = 0x00008057;
		public const uint RGB8 = 0x00008051;
		public const uint RGB8_SNORM = 0x00008F96;
		public const uint RGB8I = 0x00008D8F;
		public const uint RGB8UI = 0x00008D7D;
		public const uint RGB9_E5 = 0x00008C3D;
		public const uint RGBA = 0x00001908;
		public const uint RGBA_INTEGER = 0x00008D99;
		public const uint RGBA12 = 0x0000805A;
		public const uint RGBA16 = 0x0000805B;
		public const uint RGBA16_SNORM = 0x00008F9B;
		public const uint RGBA16F = 0x0000881A;
		public const uint RGBA16I = 0x00008D88;
		public const uint RGBA16UI = 0x00008D76;
		public const uint RGBA2 = 0x00008055;
		public const uint RGBA32F = 0x00008814;
		public const uint RGBA32I = 0x00008D82;
		public const uint RGBA32UI = 0x00008D70;
		public const uint RGBA4 = 0x00008056;
		public const uint RGBA8 = 0x00008058;
		public const uint RGBA8_SNORM = 0x00008F97;
		public const uint RGBA8I = 0x00008D8E;
		public const uint RGBA8UI = 0x00008D7C;
		public const uint RIGHT = 0x00000407;
		public const uint SAMPLE_ALPHA_TO_COVERAGE = 0x0000809E;
		public const uint SAMPLE_ALPHA_TO_ONE = 0x0000809F;
		public const uint SAMPLE_BUFFERS = 0x000080A8;
		public const uint SAMPLE_COVERAGE = 0x000080A0;
		public const uint SAMPLE_COVERAGE_INVERT = 0x000080AB;
		public const uint SAMPLE_COVERAGE_VALUE = 0x000080AA;
		public const uint SAMPLE_MASK = 0x00008E51;
		public const uint SAMPLE_MASK_VALUE = 0x00008E52;
		public const uint SAMPLE_POSITION = 0x00008E50;
		public const uint SAMPLER_1D = 0x00008B5D;
		public const uint SAMPLER_1D_ARRAY = 0x00008DC0;
		public const uint SAMPLER_1D_ARRAY_SHADOW = 0x00008DC3;
		public const uint SAMPLER_1D_SHADOW = 0x00008B61;
		public const uint SAMPLER_2D = 0x00008B5E;
		public const uint SAMPLER_2D_ARRAY = 0x00008DC1;
		public const uint SAMPLER_2D_ARRAY_SHADOW = 0x00008DC4;
		public const uint SAMPLER_2D_MULTISAMPLE = 0x00009108;
		public const uint SAMPLER_2D_MULTISAMPLE_ARRAY = 0x0000910B;
		public const uint SAMPLER_2D_RECT = 0x00008B63;
		public const uint SAMPLER_2D_RECT_SHADOW = 0x00008B64;
		public const uint SAMPLER_2D_SHADOW = 0x00008B62;
		public const uint SAMPLER_3D = 0x00008B5F;
		public const uint SAMPLER_BINDING = 0x00008919;
		public const uint SAMPLER_BUFFER = 0x00008DC2;
		public const uint SAMPLER_CUBE = 0x00008B60;
		public const uint SAMPLER_CUBE_SHADOW = 0x00008DC5;
		public const uint SAMPLES = 0x000080A9;
		public const uint SAMPLES_PASSED = 0x00008914;
		public const uint SCISSOR_BOX = 0x00000C10;
		public const uint SCISSOR_TEST = 0x00000C11;
		public const uint SEPARATE_ATTRIBS = 0x00008C8D;
		public const uint SET = 0x0000150F;
		public const uint SHADER_SOURCE_LENGTH = 0x00008B88;
		public const uint SHADER_TYPE = 0x00008B4F;
		public const uint SHADING_LANGUAGE_VERSION = 0x00008B8C;
		public const uint SHORT = 0x00001402;
		public const uint SIGNALED = 0x00009119;
		public const uint SIGNED_NORMALIZED = 0x00008F9C;
		public const uint SMOOTH_LINE_WIDTH_GRANULARITY = 0x00000B23;
		public const uint SMOOTH_LINE_WIDTH_RANGE = 0x00000B22;
		public const uint SMOOTH_POINT_SIZE_GRANULARITY = 0x00000B13;
		public const uint SMOOTH_POINT_SIZE_RANGE = 0x00000B12;
		public const uint SRC_ALPHA = 0x00000302;
		public const uint SRC_ALPHA_SATURATE = 0x00000308;
		public const uint SRC_COLOR = 0x00000300;
		public const uint SRC1_ALPHA = 0x00008589;
		public const uint SRC1_COLOR = 0x000088F9;
		public const uint SRGB = 0x00008C40;
		public const uint SRGB_ALPHA = 0x00008C42;
		public const uint SRGB8 = 0x00008C41;
		public const uint SRGB8_ALPHA8 = 0x00008C43;
		public const uint STATIC_COPY = 0x000088E6;
		public const uint STATIC_DRAW = 0x000088E4;
		public const uint STATIC_READ = 0x000088E5;
		public const uint STENCIL = 0x00001802;
		public const uint STENCIL_ATTACHMENT = 0x00008D20;
		public const uint STENCIL_BACK_FAIL = 0x00008801;
		public const uint STENCIL_BACK_FUNC = 0x00008800;
		public const uint STENCIL_BACK_PASS_DEPTH_FAIL = 0x00008802;
		public const uint STENCIL_BACK_PASS_DEPTH_PASS = 0x00008803;
		public const uint STENCIL_BACK_REF = 0x00008CA3;
		public const uint STENCIL_BACK_VALUE_MASK = 0x00008CA4;
		public const uint STENCIL_BACK_WRITEMASK = 0x00008CA5;
		public const uint STENCIL_BUFFER_BIT = 0x00000400;
		public const uint STENCIL_CLEAR_VALUE = 0x00000B91;
		public const uint STENCIL_FAIL = 0x00000B94;
		public const uint STENCIL_FUNC = 0x00000B92;
		public const uint STENCIL_INDEX = 0x00001901;
		public const uint STENCIL_INDEX1 = 0x00008D46;
		public const uint STENCIL_INDEX16 = 0x00008D49;
		public const uint STENCIL_INDEX4 = 0x00008D47;
		public const uint STENCIL_INDEX8 = 0x00008D48;
		public const uint STENCIL_PASS_DEPTH_FAIL = 0x00000B95;
		public const uint STENCIL_PASS_DEPTH_PASS = 0x00000B96;
		public const uint STENCIL_REF = 0x00000B97;
		public const uint STENCIL_TEST = 0x00000B90;
		public const uint STENCIL_VALUE_MASK = 0x00000B93;
		public const uint STENCIL_WRITEMASK = 0x00000B98;
		public const uint STEREO = 0x00000C33;
		public const uint STREAM_COPY = 0x000088E2;
		public const uint STREAM_DRAW = 0x000088E0;
		public const uint STREAM_READ = 0x000088E1;
		public const uint SUBPIXEL_BITS = 0x00000D50;
		public const uint SYNC_CONDITION = 0x00009113;
		public const uint SYNC_FENCE = 0x00009116;
		public const uint SYNC_FLAGS = 0x00009115;
		public const uint SYNC_FLUSH_COMMANDS_BIT = 0x00000001;
		public const uint SYNC_GPU_COMMANDS_COMPLETE = 0x00009117;
		public const uint SYNC_STATUS = 0x00009114;
		public const uint TEXTURE = 0x00001702;
		public const uint TEXTURE_1D = 0x00000DE0;
		public const uint TEXTURE_1D_ARRAY = 0x00008C18;
		public const uint TEXTURE_2D = 0x00000DE1;
		public const uint TEXTURE_2D_ARRAY = 0x00008C1A;
		public const uint TEXTURE_2D_MULTISAMPLE = 0x00009100;
		public const uint TEXTURE_2D_MULTISAMPLE_ARRAY = 0x00009102;
		public const uint TEXTURE_3D = 0x0000806F;
		public const uint TEXTURE_ALPHA_SIZE = 0x0000805F;
		public const uint TEXTURE_ALPHA_TYPE = 0x00008C13;
		public const uint TEXTURE_BASE_LEVEL = 0x0000813C;
		public const uint TEXTURE_BINDING_1D = 0x00008068;
		public const uint TEXTURE_BINDING_1D_ARRAY = 0x00008C1C;
		public const uint TEXTURE_BINDING_2D = 0x00008069;
		public const uint TEXTURE_BINDING_2D_ARRAY = 0x00008C1D;
		public const uint TEXTURE_BINDING_2D_MULTISAMPLE = 0x00009104;
		public const uint TEXTURE_BINDING_2D_MULTISAMPLE_ARRAY = 0x00009105;
		public const uint TEXTURE_BINDING_3D = 0x0000806A;
		public const uint TEXTURE_BINDING_BUFFER = 0x00008C2C;
		public const uint TEXTURE_BINDING_CUBE_MAP = 0x00008514;
		public const uint TEXTURE_BINDING_RECTANGLE = 0x000084F6;
		public const uint TEXTURE_BLUE_SIZE = 0x0000805E;
		public const uint TEXTURE_BLUE_TYPE = 0x00008C12;
		public const uint TEXTURE_BORDER_COLOR = 0x00001004;
		public const uint TEXTURE_BUFFER = 0x00008C2A;
		public const uint TEXTURE_BUFFER_DATA_STORE_BINDING = 0x00008C2D;
		public const uint TEXTURE_COMPARE_FUNC = 0x0000884D;
		public const uint TEXTURE_COMPARE_MODE = 0x0000884C;
		public const uint TEXTURE_COMPRESSED = 0x000086A1;
		public const uint TEXTURE_COMPRESSED_IMAGE_SIZE = 0x000086A0;
		public const uint TEXTURE_COMPRESSION_HINT = 0x000084EF;
		public const uint TEXTURE_CUBE_MAP = 0x00008513;
		public const uint TEXTURE_CUBE_MAP_NEGATIVE_X = 0x00008516;
		public const uint TEXTURE_CUBE_MAP_NEGATIVE_Y = 0x00008518;
		public const uint TEXTURE_CUBE_MAP_NEGATIVE_Z = 0x0000851A;
		public const uint TEXTURE_CUBE_MAP_POSITIVE_X = 0x00008515;
		public const uint TEXTURE_CUBE_MAP_POSITIVE_Y = 0x00008517;
		public const uint TEXTURE_CUBE_MAP_POSITIVE_Z = 0x00008519;
		public const uint TEXTURE_CUBE_MAP_SEAMLESS = 0x0000884F;
		public const uint TEXTURE_DEPTH = 0x00008071;
		public const uint TEXTURE_DEPTH_SIZE = 0x0000884A;
		public const uint TEXTURE_DEPTH_TYPE = 0x00008C16;
		public const uint TEXTURE_FIXED_SAMPLE_LOCATIONS = 0x00009107;
		public const uint TEXTURE_GREEN_SIZE = 0x0000805D;
		public const uint TEXTURE_GREEN_TYPE = 0x00008C11;
		public const uint TEXTURE_HEIGHT = 0x00001001;
		public const uint TEXTURE_INTERNAL_FORMAT = 0x00001003;
		public const uint TEXTURE_LOD_BIAS = 0x00008501;
		public const uint TEXTURE_MAG_FILTER = 0x00002800;
		public const uint TEXTURE_MAX_LEVEL = 0x0000813D;
		public const uint TEXTURE_MAX_LOD = 0x0000813B;
		public const uint TEXTURE_MIN_FILTER = 0x00002801;
		public const uint TEXTURE_MIN_LOD = 0x0000813A;
		public const uint TEXTURE_RECTANGLE = 0x000084F5;
		public const uint TEXTURE_RED_SIZE = 0x0000805C;
		public const uint TEXTURE_RED_TYPE = 0x00008C10;
		public const uint TEXTURE_SAMPLES = 0x00009106;
		public const uint TEXTURE_SHARED_SIZE = 0x00008C3F;
		public const uint TEXTURE_STENCIL_SIZE = 0x000088F1;
		public const uint TEXTURE_SWIZZLE_A = 0x00008E45;
		public const uint TEXTURE_SWIZZLE_B = 0x00008E44;
		public const uint TEXTURE_SWIZZLE_G = 0x00008E43;
		public const uint TEXTURE_SWIZZLE_R = 0x00008E42;
		public const uint TEXTURE_SWIZZLE_RGBA = 0x00008E46;
		public const uint TEXTURE_WIDTH = 0x00001000;
		public const uint TEXTURE_WRAP_R = 0x00008072;
		public const uint TEXTURE_WRAP_S = 0x00002802;
		public const uint TEXTURE_WRAP_T = 0x00002803;
		public const uint TEXTURE0 = 0x000084C0;
		public const uint TEXTURE1 = 0x000084C1;
		public const uint TEXTURE10 = 0x000084CA;
		public const uint TEXTURE11 = 0x000084CB;
		public const uint TEXTURE12 = 0x000084CC;
		public const uint TEXTURE13 = 0x000084CD;
		public const uint TEXTURE14 = 0x000084CE;
		public const uint TEXTURE15 = 0x000084CF;
		public const uint TEXTURE16 = 0x000084D0;
		public const uint TEXTURE17 = 0x000084D1;
		public const uint TEXTURE18 = 0x000084D2;
		public const uint TEXTURE19 = 0x000084D3;
		public const uint TEXTURE2 = 0x000084C2;
		public const uint TEXTURE20 = 0x000084D4;
		public const uint TEXTURE21 = 0x000084D5;
		public const uint TEXTURE22 = 0x000084D6;
		public const uint TEXTURE23 = 0x000084D7;
		public const uint TEXTURE24 = 0x000084D8;
		public const uint TEXTURE25 = 0x000084D9;
		public const uint TEXTURE26 = 0x000084DA;
		public const uint TEXTURE27 = 0x000084DB;
		public const uint TEXTURE28 = 0x000084DC;
		public const uint TEXTURE29 = 0x000084DD;
		public const uint TEXTURE3 = 0x000084C3;
		public const uint TEXTURE30 = 0x000084DE;
		public const uint TEXTURE31 = 0x000084DF;
		public const uint TEXTURE4 = 0x000084C4;
		public const uint TEXTURE5 = 0x000084C5;
		public const uint TEXTURE6 = 0x000084C6;
		public const uint TEXTURE7 = 0x000084C7;
		public const uint TEXTURE8 = 0x000084C8;
		public const uint TEXTURE9 = 0x000084C9;
		public const uint TIME_ELAPSED = 0x000088BF;
		public const uint TIMEOUT_EXPIRED = 0x0000911B;
		public const ulong TIMEOUT_IGNORED = 0xFFFFFFFFFFFFFFFF;
		public const uint TIMESTAMP = 0x00008E28;
		public const uint TRANSFORM_FEEDBACK_BUFFER = 0x00008C8E;
		public const uint TRANSFORM_FEEDBACK_BUFFER_BINDING = 0x00008C8F;
		public const uint TRANSFORM_FEEDBACK_BUFFER_MODE = 0x00008C7F;
		public const uint TRANSFORM_FEEDBACK_BUFFER_SIZE = 0x00008C85;
		public const uint TRANSFORM_FEEDBACK_BUFFER_START = 0x00008C84;
		public const uint TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN = 0x00008C88;
		public const uint TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH = 0x00008C76;
		public const uint TRANSFORM_FEEDBACK_VARYINGS = 0x00008C83;
		public const uint TRIANGLE_FAN = 0x00000006;
		public const uint TRIANGLE_STRIP = 0x00000005;
		public const uint TRIANGLE_STRIP_ADJACENCY = 0x0000000D;
		public const uint TRIANGLES = 0x00000004;
		public const uint TRIANGLES_ADJACENCY = 0x0000000C;
		public const uint TRUE = 0x00000001;
		public const uint UNIFORM_ARRAY_STRIDE = 0x00008A3C;
		public const uint UNIFORM_BLOCK_ACTIVE_UNIFORM_INDICES = 0x00008A43;
		public const uint UNIFORM_BLOCK_ACTIVE_UNIFORMS = 0x00008A42;
		public const uint UNIFORM_BLOCK_BINDING = 0x00008A3F;
		public const uint UNIFORM_BLOCK_DATA_SIZE = 0x00008A40;
		public const uint UNIFORM_BLOCK_INDEX = 0x00008A3A;
		public const uint UNIFORM_BLOCK_NAME_LENGTH = 0x00008A41;
		public const uint UNIFORM_BLOCK_REFERENCED_BY_FRAGMENT_SHADER = 0x00008A46;
		public const uint UNIFORM_BLOCK_REFERENCED_BY_VERTEX_SHADER = 0x00008A44;
		public const uint UNIFORM_BUFFER = 0x00008A11;
		public const uint UNIFORM_BUFFER_BINDING = 0x00008A28;
		public const uint UNIFORM_BUFFER_OFFSET_ALIGNMENT = 0x00008A34;
		public const uint UNIFORM_BUFFER_SIZE = 0x00008A2A;
		public const uint UNIFORM_BUFFER_START = 0x00008A29;
		public const uint UNIFORM_IS_ROW_MAJOR = 0x00008A3E;
		public const uint UNIFORM_MATRIX_STRIDE = 0x00008A3D;
		public const uint UNIFORM_NAME_LENGTH = 0x00008A39;
		public const uint UNIFORM_OFFSET = 0x00008A3B;
		public const uint UNIFORM_SIZE = 0x00008A38;
		public const uint UNIFORM_TYPE = 0x00008A37;
		public const uint UNPACK_ALIGNMENT = 0x00000CF5;
		public const uint UNPACK_IMAGE_HEIGHT = 0x0000806E;
		public const uint UNPACK_LSB_FIRST = 0x00000CF1;
		public const uint UNPACK_ROW_LENGTH = 0x00000CF2;
		public const uint UNPACK_SKIP_IMAGES = 0x0000806D;
		public const uint UNPACK_SKIP_PIXELS = 0x00000CF4;
		public const uint UNPACK_SKIP_ROWS = 0x00000CF3;
		public const uint UNPACK_SWAP_BYTES = 0x00000CF0;
		public const uint UNSIGNALED = 0x00009118;
		public const uint UNSIGNED_BYTE = 0x00001401;
		public const uint UNSIGNED_BYTE_2_3_3_REV = 0x00008362;
		public const uint UNSIGNED_BYTE_3_3_2 = 0x00008032;
		public const uint UNSIGNED_INT = 0x00001405;
		public const uint UNSIGNED_INT_10_10_10_2 = 0x00008036;
		public const uint UNSIGNED_INT_10F_11F_11F_REV = 0x00008C3B;
		public const uint UNSIGNED_INT_2_10_10_10_REV = 0x00008368;
		public const uint UNSIGNED_INT_24_8 = 0x000084FA;
		public const uint UNSIGNED_INT_5_9_9_9_REV = 0x00008C3E;
		public const uint UNSIGNED_INT_8_8_8_8 = 0x00008035;
		public const uint UNSIGNED_INT_8_8_8_8_REV = 0x00008367;
		public const uint UNSIGNED_INT_SAMPLER_1D = 0x00008DD1;
		public const uint UNSIGNED_INT_SAMPLER_1D_ARRAY = 0x00008DD6;
		public const uint UNSIGNED_INT_SAMPLER_2D = 0x00008DD2;
		public const uint UNSIGNED_INT_SAMPLER_2D_ARRAY = 0x00008DD7;
		public const uint UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE = 0x0000910A;
		public const uint UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x0000910D;
		public const uint UNSIGNED_INT_SAMPLER_2D_RECT = 0x00008DD5;
		public const uint UNSIGNED_INT_SAMPLER_3D = 0x00008DD3;
		public const uint UNSIGNED_INT_SAMPLER_BUFFER = 0x00008DD8;
		public const uint UNSIGNED_INT_SAMPLER_CUBE = 0x00008DD4;
		public const uint UNSIGNED_INT_VEC2 = 0x00008DC6;
		public const uint UNSIGNED_INT_VEC3 = 0x00008DC7;
		public const uint UNSIGNED_INT_VEC4 = 0x00008DC8;
		public const uint UNSIGNED_NORMALIZED = 0x00008C17;
		public const uint UNSIGNED_SHORT = 0x00001403;
		public const uint UNSIGNED_SHORT_1_5_5_5_REV = 0x00008366;
		public const uint UNSIGNED_SHORT_4_4_4_4 = 0x00008033;
		public const uint UNSIGNED_SHORT_4_4_4_4_REV = 0x00008365;
		public const uint UNSIGNED_SHORT_5_5_5_1 = 0x00008034;
		public const uint UNSIGNED_SHORT_5_6_5 = 0x00008363;
		public const uint UNSIGNED_SHORT_5_6_5_REV = 0x00008364;
		public const uint UPPER_LEFT = 0x00008CA2;
		public const uint VALIDATE_STATUS = 0x00008B83;
		public const uint VENDOR = 0x00001F00;
		public const uint VERSION = 0x00001F02;
		public const uint VERTEX_ARRAY_BINDING = 0x000085B5;
		public const uint VERTEX_ATTRIB_ARRAY_BUFFER_BINDING = 0x0000889F;
		public const uint VERTEX_ATTRIB_ARRAY_DIVISOR = 0x000088FE;
		public const uint VERTEX_ATTRIB_ARRAY_ENABLED = 0x00008622;
		public const uint VERTEX_ATTRIB_ARRAY_INTEGER = 0x000088FD;
		public const uint VERTEX_ATTRIB_ARRAY_NORMALIZED = 0x0000886A;
		public const uint VERTEX_ATTRIB_ARRAY_POINTER = 0x00008645;
		public const uint VERTEX_ATTRIB_ARRAY_SIZE = 0x00008623;
		public const uint VERTEX_ATTRIB_ARRAY_STRIDE = 0x00008624;
		public const uint VERTEX_ATTRIB_ARRAY_TYPE = 0x00008625;
		public const uint VERTEX_PROGRAM_POINT_SIZE = 0x00008642;
		public const uint VERTEX_SHADER = 0x00008B31;
		public const uint VIEWPORT = 0x00000BA2;
		public const uint WAIT_FAILED = 0x0000911D;
		public const uint WRITE_ONLY = 0x000088B9;
		public const uint XOR = 0x00001506;
		public const uint ZERO = 0x00000000;

		private delegate void GlDelegate_uint(uint p0);
		private delegate void GlDelegate_uint_uint(uint p0, uint p1);
		private delegate void GlDelegate_uint_uint_string(uint p0, uint p1, string p2);
		private delegate void GlDelegate_uint_uint_uint(uint p0, uint p1, uint p2);
		private delegate void GlDelegate_uint_uint_uint_systemintptr_systemintptr(uint p0, uint p1, uint p2, System.IntPtr p3, System.IntPtr p4);
		private delegate void GlDelegate_float_float_float_float(float p0, float p1, float p2, float p3);
		private delegate void GlDelegate_uint_uint_uint_uint(uint p0, uint p1, uint p2, uint p3);
		private delegate void GlDelegate_int_int_int_int_int_int_int_int_uint_uint(int p0, int p1, int p2, int p3, int p4, int p5, int p6, int p7, uint p8, uint p9);
		private delegate void GlDelegate_uint_systemintptr_systemintptr_uint(uint p0, System.IntPtr p1, System.IntPtr p2, uint p3);
		private delegate void GlDelegate_uint_systemintptr_systemintptr_systemintptr(uint p0, System.IntPtr p1, System.IntPtr p2, System.IntPtr p3);
		private delegate uint GlDelegate_uint_Returns_uint(uint p0);
		private delegate void GlDelegate_uint_int_float_int(uint p0, int p1, float p2, int p3);
		private delegate void GlDelegate_uint_int_systemintptr(uint p0, int p1, System.IntPtr p2);
		private delegate void GlDelegate_double(double p0);
		private delegate void GlDelegate_int(int p0);
		private delegate uint GlDelegate_systemintptr_uint_ulong_Returns_uint(System.IntPtr p0, uint p1, ulong p2);
		private delegate void GlDelegate_bool_bool_bool_bool(bool p0, bool p1, bool p2, bool p3);
		private delegate void GlDelegate_uint_bool_bool_bool_bool(uint p0, bool p1, bool p2, bool p3, bool p4);
		private delegate void GlDelegate_uint_int_uint_int_int_int_systemintptr(uint p0, int p1, uint p2, int p3, int p4, int p5, System.IntPtr p6);
		private delegate void GlDelegate_uint_int_uint_int_int_int_int_systemintptr(uint p0, int p1, uint p2, int p3, int p4, int p5, int p6, System.IntPtr p7);
		private delegate void GlDelegate_uint_int_uint_int_int_int_int_int_systemintptr(uint p0, int p1, uint p2, int p3, int p4, int p5, int p6, int p7, System.IntPtr p8);
		private delegate void GlDelegate_uint_int_int_int_uint_int_systemintptr(uint p0, int p1, int p2, int p3, uint p4, int p5, System.IntPtr p6);
		private delegate void GlDelegate_uint_int_int_int_int_int_uint_int_systemintptr(uint p0, int p1, int p2, int p3, int p4, int p5, uint p6, int p7, System.IntPtr p8);
		private delegate void GlDelegate_uint_int_int_int_int_int_int_int_uint_int_systemintptr(uint p0, int p1, int p2, int p3, int p4, int p5, int p6, int p7, uint p8, int p9, System.IntPtr p10);
		private delegate void GlDelegate_uint_uint_systemintptr_systemintptr_systemintptr(uint p0, uint p1, System.IntPtr p2, System.IntPtr p3, System.IntPtr p4);
		private delegate void GlDelegate_uint_int_uint_int_int_int_int(uint p0, int p1, uint p2, int p3, int p4, int p5, int p6);
		private delegate void GlDelegate_uint_int_uint_int_int_int_int_int(uint p0, int p1, uint p2, int p3, int p4, int p5, int p6, int p7);
		private delegate void GlDelegate_uint_int_int_int_int_int(uint p0, int p1, int p2, int p3, int p4, int p5);
		private delegate void GlDelegate_uint_int_int_int_int_int_int_int(uint p0, int p1, int p2, int p3, int p4, int p5, int p6, int p7);
		private delegate void GlDelegate_uint_int_int_int_int_int_int_int_int(uint p0, int p1, int p2, int p3, int p4, int p5, int p6, int p7, int p8);
		private delegate uint GlDelegate_Returns_uint();
		private delegate void GlDelegate_int_systemintptr(int p0, System.IntPtr p1);
		private delegate void GlDelegate_systemintptr(System.IntPtr p0);
		private delegate void GlDelegate_bool(bool p0);
		private delegate void GlDelegate_double_double(double p0, double p1);
		private delegate void GlDelegate_uint_int_int(uint p0, int p1, int p2);
		private delegate void GlDelegate_uint_int_int_int(uint p0, int p1, int p2, int p3);
		private delegate void GlDelegate_uint_int_uint_systemintptr(uint p0, int p1, uint p2, System.IntPtr p3);
		private delegate void GlDelegate_uint_int_uint_systemintptr_int(uint p0, int p1, uint p2, System.IntPtr p3, int p4);
		private delegate void GlDelegate_uint_int_uint_systemintptr_int_int(uint p0, int p1, uint p2, System.IntPtr p3, int p4, int p5);
		private delegate void GlDelegate_uint_uint_uint_int_uint_systemintptr(uint p0, uint p1, uint p2, int p3, uint p4, System.IntPtr p5);
		private delegate void GlDelegate_uint_uint_uint_int_uint_systemintptr_int(uint p0, uint p1, uint p2, int p3, uint p4, System.IntPtr p5, int p6);
		private delegate void GlDelegate();
		private delegate System.IntPtr GlDelegate_uint_uint_Returns_systemintptr(uint p0, uint p1);
		private delegate void GlDelegate_uint_systemintptr_systemintptr(uint p0, System.IntPtr p1, System.IntPtr p2);
		private delegate void GlDelegate_uint_uint_uint_int(uint p0, uint p1, uint p2, int p3);
		private delegate void GlDelegate_uint_uint_uint_uint_int(uint p0, uint p1, uint p2, uint p3, int p4);
		private delegate void GlDelegate_uint_uint_uint_uint_int_int(uint p0, uint p1, uint p2, uint p3, int p4, int p5);
		private delegate void GlDelegate_uint_uint_uint_int_int(uint p0, uint p1, uint p2, int p3, int p4);
		private delegate void GlDelegate_uint_uint_int_systemintptr_systemintptr_systemintptr_string(uint p0, uint p1, int p2, System.IntPtr p3, System.IntPtr p4, System.IntPtr p5, string p6);
		private delegate void GlDelegate_uint_uint_uint_systemintptr(uint p0, uint p1, uint p2, System.IntPtr p3);
		private delegate void GlDelegate_uint_uint_int_systemintptr_systemintptr(uint p0, uint p1, int p2, System.IntPtr p3, System.IntPtr p4);
		private delegate void GlDelegate_uint_int_systemintptr_uint_systemintptr(uint p0, int p1, System.IntPtr p2, uint p3, System.IntPtr p4);
		private delegate void GlDelegate_uint_int_systemintptr_systemintptr(uint p0, int p1, System.IntPtr p2, System.IntPtr p3);
		private delegate int GlDelegate_uint_systemintptr_Returns_int(uint p0, System.IntPtr p1);
		private delegate void GlDelegate_uint_uint_systemintptr(uint p0, uint p1, System.IntPtr p2);
		private delegate void GlDelegate_uint_systemintptr(uint p0, System.IntPtr p1);
		private delegate int GlDelegate_uint_string_Returns_int(uint p0, string p1);
		private delegate void GlDelegate_uint_int_systemintptr_string(uint p0, int p1, System.IntPtr p2, string p3);
		private delegate System.IntPtr GlDelegate_uint_Returns_systemintptr(uint p0);
		private delegate void GlDelegate_systemintptr_uint_int_systemintptr_systemintptr(System.IntPtr p0, uint p1, int p2, System.IntPtr p3, System.IntPtr p4);
		private delegate void GlDelegate_uint_int_uint_uint_systemintptr(uint p0, int p1, uint p2, uint p3, System.IntPtr p4);
		private delegate uint GlDelegate_uint_string_Returns_uint(uint p0, string p1);
		private delegate bool GlDelegate_uint_Returns_bool(uint p0);
		private delegate bool GlDelegate_uint_uint_Returns_bool(uint p0, uint p1);
		private delegate bool GlDelegate_systemintptr_Returns_bool(System.IntPtr p0);
		private delegate void GlDelegate_float(float p0);
		private delegate System.IntPtr GlDelegate_uint_systemintptr_systemintptr_uint_Returns_systemintptr(uint p0, System.IntPtr p1, System.IntPtr p2, uint p3);
		private delegate void GlDelegate_uint_systemintptr_systemintptr_int(uint p0, System.IntPtr p1, System.IntPtr p2, int p3);
		private delegate void GlDelegate_uint_systemintptr_uint_systemintptr_int(uint p0, System.IntPtr p1, uint p2, System.IntPtr p3, int p4);
		private delegate void GlDelegate_uint_systemintptr_uint_systemintptr_int_systemintptr(uint p0, System.IntPtr p1, uint p2, System.IntPtr p3, int p4, System.IntPtr p5);
		private delegate void GlDelegate_uint_float(uint p0, float p1);
		private delegate void GlDelegate_uint_int(uint p0, int p1);
		private delegate void GlDelegate_float_float(float p0, float p1);
		private delegate void GlDelegate_int_int_int_int_uint_uint_systemintptr(int p0, int p1, int p2, int p3, uint p4, uint p5, System.IntPtr p6);
		private delegate void GlDelegate_uint_uint_int_int(uint p0, uint p1, int p2, int p3);
		private delegate void GlDelegate_uint_int_uint_int_int(uint p0, int p1, uint p2, int p3, int p4);
		private delegate void GlDelegate_float_bool(float p0, bool p1);
		private delegate void GlDelegate_int_int_int_int(int p0, int p1, int p2, int p3);
		private delegate void GlDelegate_uint_int_uint(uint p0, int p1, uint p2);
		private delegate void GlDelegate_uint_uint_int_uint(uint p0, uint p1, int p2, uint p3);
		private delegate void GlDelegate_uint_int_int_int_int_uint_uint_systemintptr(uint p0, int p1, int p2, int p3, int p4, uint p5, uint p6, System.IntPtr p7);
		private delegate void GlDelegate_uint_int_int_int_int_int_uint_uint_systemintptr(uint p0, int p1, int p2, int p3, int p4, int p5, uint p6, uint p7, System.IntPtr p8);
		private delegate void GlDelegate_uint_int_uint_int_int_bool(uint p0, int p1, uint p2, int p3, int p4, bool p5);
		private delegate void GlDelegate_uint_int_int_int_int_int_int_uint_uint_systemintptr(uint p0, int p1, int p2, int p3, int p4, int p5, int p6, uint p7, uint p8, System.IntPtr p9);
		private delegate void GlDelegate_uint_int_uint_int_int_int_bool(uint p0, int p1, uint p2, int p3, int p4, int p5, bool p6);
		private delegate void GlDelegate_uint_uint_float(uint p0, uint p1, float p2);
		private delegate void GlDelegate_uint_uint_int(uint p0, uint p1, int p2);
		private delegate void GlDelegate_uint_int_int_int_uint_uint_systemintptr(uint p0, int p1, int p2, int p3, uint p4, uint p5, System.IntPtr p6);
		private delegate void GlDelegate_uint_int_int_int_int_int_int_int_uint_uint_systemintptr(uint p0, int p1, int p2, int p3, int p4, int p5, int p6, int p7, uint p8, uint p9, System.IntPtr p10);
		private delegate void GlDelegate_uint_int_systemintptr_uint(uint p0, int p1, System.IntPtr p2, uint p3);
		private delegate void GlDelegate_int_float(int p0, float p1);
		private delegate void GlDelegate_int_int_systemintptr(int p0, int p1, System.IntPtr p2);
		private delegate void GlDelegate_int_int(int p0, int p1);
		private delegate void GlDelegate_int_uint(int p0, uint p1);
		private delegate void GlDelegate_int_float_float(int p0, float p1, float p2);
		private delegate void GlDelegate_int_int_int(int p0, int p1, int p2);
		private delegate void GlDelegate_int_uint_uint(int p0, uint p1, uint p2);
		private delegate void GlDelegate_int_float_float_float(int p0, float p1, float p2, float p3);
		private delegate void GlDelegate_int_uint_uint_uint(int p0, uint p1, uint p2, uint p3);
		private delegate void GlDelegate_int_float_float_float_float(int p0, float p1, float p2, float p3, float p4);
		private delegate void GlDelegate_int_int_int_int_int(int p0, int p1, int p2, int p3, int p4);
		private delegate void GlDelegate_int_uint_uint_uint_uint(int p0, uint p1, uint p2, uint p3, uint p4);
		private delegate void GlDelegate_int_int_bool_systemintptr(int p0, int p1, bool p2, System.IntPtr p3);
		private delegate void GlDelegate_uint_double(uint p0, double p1);
		private delegate void GlDelegate_uint_short(uint p0, short p1);
		private delegate void GlDelegate_uint_double_double(uint p0, double p1, double p2);
		private delegate void GlDelegate_uint_float_float(uint p0, float p1, float p2);
		private delegate void GlDelegate_uint_short_short(uint p0, short p1, short p2);
		private delegate void GlDelegate_uint_double_double_double(uint p0, double p1, double p2, double p3);
		private delegate void GlDelegate_uint_float_float_float(uint p0, float p1, float p2, float p3);
		private delegate void GlDelegate_uint_short_short_short(uint p0, short p1, short p2, short p3);
		private delegate void GlDelegate_uint_double_double_double_double(uint p0, double p1, double p2, double p3, double p4);
		private delegate void GlDelegate_uint_float_float_float_float(uint p0, float p1, float p2, float p3, float p4);
		private delegate void GlDelegate_uint_byte_byte_byte_byte(uint p0, byte p1, byte p2, byte p3, byte p4);
		private delegate void GlDelegate_uint_short_short_short_short(uint p0, short p1, short p2, short p3, short p4);
		private delegate void GlDelegate_uint_int_int_int_int(uint p0, int p1, int p2, int p3, int p4);
		private delegate void GlDelegate_uint_uint_uint_uint_uint(uint p0, uint p1, uint p2, uint p3, uint p4);
		private delegate void GlDelegate_uint_int_uint_int_systemintptr(uint p0, int p1, uint p2, int p3, System.IntPtr p4);
		private delegate void GlDelegate_uint_int_uint_bool_int_systemintptr(uint p0, int p1, uint p2, bool p3, int p4, System.IntPtr p5);
		private delegate void GlDelegate_systemintptr_uint_ulong(System.IntPtr p0, uint p1, ulong p2);
		private delegate void GlDelegate_uint_uint_bool_uint(uint p0, uint p1, bool p2, uint p3);
		private delegate void GlDelegate_uint_uint_bool_systemintptr(uint p0, uint p1, bool p2, System.IntPtr p3);
		private delegate void GlDelegate_color4(Color4 p0);
		private delegate void GlDelegate_vector2i_vector2i_vector2i_vector2i_uint_uint(Vector2i p0, Vector2i p1, Vector2i p2, Vector2i p3, uint p4, uint p5);
		private delegate void GlDelegate_uint_int_refcolor4(uint p0, int p1, ref Color4 p2);
		private delegate void GlDelegate_uint_int_reffloat(uint p0, int p1, ref float p2);
		private delegate void GlDelegate_uint_int_refcolor4i(uint p0, int p1, ref Color4i p2);
		private delegate void GlDelegate_uint_int_refint(uint p0, int p1, ref int p2);
		private delegate void GlDelegate_uint_int_refcolor4ui(uint p0, int p1, ref Color4ui p2);
		private delegate void GlDelegate_uint_int_refuint(uint p0, int p1, ref uint p2);
		private delegate void GlDelegate_uint_int_box2i_uint_int_systemintptr(uint p0, int p1, Box2i p2, uint p3, int p4, System.IntPtr p5);
		private delegate void GlDelegate_uint_int_box3i_uint_int_systemintptr(uint p0, int p1, Box3i p2, uint p3, int p4, System.IntPtr p5);
		private delegate void GlDelegate_uint_int_uint_vector2i_int_int(uint p0, int p1, uint p2, Vector2i p3, int p4, int p5);
		private delegate void GlDelegate_uint_int_uint_vector2i_vector2i_int(uint p0, int p1, uint p2, Vector2i p3, Vector2i p4, int p5);
		private delegate void GlDelegate_uint_int_uint_box2i_int(uint p0, int p1, uint p2, Box2i p3, int p4);
		private delegate void GlDelegate_uint_int_int_vector2i_int(uint p0, int p1, int p2, Vector2i p3, int p4);
		private delegate void GlDelegate_uint_int_vector2i_vector2i_vector2i(uint p0, int p1, Vector2i p2, Vector2i p3, Vector2i p4);
		private delegate void GlDelegate_uint_int_vector3i_vector2i_vector2i(uint p0, int p1, Vector3i p2, Vector2i p3, Vector2i p4);
		private delegate void GlDelegate_int_uintarray(int p0, uint[] p1);
		private delegate void GlDelegate_int_refuint(int p0, ref uint p1);
		private delegate void GlDelegate_uint_int_uint_bytearray(uint p0, int p1, uint p2, byte[] p3);
		private delegate void GlDelegate_uint_int_uint_ushortarray(uint p0, int p1, uint p2, ushort[] p3);
		private delegate void GlDelegate_uint_int_uint_uintarray(uint p0, int p1, uint p2, uint[] p3);
		private delegate void GlDelegate_uint_int_uint_bytearray_int(uint p0, int p1, uint p2, byte[] p3, int p4);
		private delegate void GlDelegate_uint_int_uint_ushortarray_int(uint p0, int p1, uint p2, ushort[] p3, int p4);
		private delegate void GlDelegate_uint_int_uint_uintarray_int(uint p0, int p1, uint p2, uint[] p3, int p4);
		private delegate void GlDelegate_uint_int_uint_bytearray_int_int(uint p0, int p1, uint p2, byte[] p3, int p4, int p5);
		private delegate void GlDelegate_uint_int_uint_ushortarray_int_int(uint p0, int p1, uint p2, ushort[] p3, int p4, int p5);
		private delegate void GlDelegate_uint_int_uint_uintarray_int_int(uint p0, int p1, uint p2, uint[] p3, int p4, int p5);
		private delegate void GlDelegate_uint_uint_uint_int_uint_bytearray(uint p0, uint p1, uint p2, int p3, uint p4, byte[] p5);
		private delegate void GlDelegate_uint_uint_uint_int_uint_ushortarray(uint p0, uint p1, uint p2, int p3, uint p4, ushort[] p5);
		private delegate void GlDelegate_uint_uint_uint_int_uint_uintarray(uint p0, uint p1, uint p2, int p3, uint p4, uint[] p5);
		private delegate void GlDelegate_uint_uint_uint_int_uint_bytearray_int(uint p0, uint p1, uint p2, int p3, uint p4, byte[] p5, int p6);
		private delegate void GlDelegate_uint_uint_uint_int_uint_ushortarray_int(uint p0, uint p1, uint p2, int p3, uint p4, ushort[] p5, int p6);
		private delegate void GlDelegate_uint_uint_uint_int_uint_uintarray_int(uint p0, uint p1, uint p2, int p3, uint p4, uint[] p5, int p6);
		private delegate void GlDelegate_int_outuint(int p0, out uint p1);
		private delegate void GlDelegate_uint_uint_int_outint_outint_outuint_bytearray(uint p0, uint p1, int p2, out int p3, out int p4, out uint p5, byte[] p6);
		private delegate void GlDelegate_uint_uint_uint_intarray(uint p0, uint p1, uint p2, int[] p3);
		private delegate void GlDelegate_uint_uint_uint_outint(uint p0, uint p1, uint p2, out int p3);
		private delegate void GlDelegate_uint_uint_int_outint_bytearray(uint p0, uint p1, int p2, out int p3, byte[] p4);
		private delegate void GlDelegate_uint_int_uintarray_uint_intarray(uint p0, int p1, uint[] p2, uint p3, int[] p4);
		private delegate void GlDelegate_uint_int_outint_uint_intarray(uint p0, int p1, out int p2, uint p3, int[] p4);
		private delegate void GlDelegate_uint_int_uintarray_uint_refint(uint p0, int p1, uint[] p2, uint p3, ref int p4);
		private delegate void GlDelegate_uint_int_outint_uint_refint(uint p0, int p1, out int p2, uint p3, ref int p4);
		private delegate int GlDelegate_uint_bytearray_Returns_int(uint p0, byte[] p1);
		private delegate void GlDelegate_uint_uint_outbool(uint p0, uint p1, out bool p2);
		private delegate void GlDelegate_uint_outbool(uint p0, out bool p1);
		private delegate void GlDelegate_uint_uint_outlong(uint p0, uint p1, out long p2);
		private delegate void GlDelegate_uint_uint_outint(uint p0, uint p1, out int p2);
		private delegate void GlDelegate_uint_uint_outsystemintptr(uint p0, uint p1, out System.IntPtr p2);
		private delegate void GlDelegate_uint_doublearray(uint p0, double[] p1);
		private delegate void GlDelegate_uint_outdouble(uint p0, out double p1);
		private delegate void GlDelegate_uint_outvector2d(uint p0, out Vector2d p1);
		private delegate void GlDelegate_uint_outvector3d(uint p0, out Vector3d p1);
		private delegate void GlDelegate_uint_outvector4d(uint p0, out Vector4d p1);
		private delegate void GlDelegate_uint_outcolor3d(uint p0, out Color3d p1);
		private delegate void GlDelegate_uint_outcolor4d(uint p0, out Color4d p1);
		private delegate void GlDelegate_uint_outbox2d(uint p0, out Box2d p1);
		private delegate void GlDelegate_uint_outbox3d(uint p0, out Box3d p1);
		private delegate void GlDelegate_uint_floatarray(uint p0, float[] p1);
		private delegate void GlDelegate_uint_outfloat(uint p0, out float p1);
		private delegate void GlDelegate_uint_outvector2(uint p0, out Vector2 p1);
		private delegate void GlDelegate_uint_outvector3(uint p0, out Vector3 p1);
		private delegate void GlDelegate_uint_outvector4(uint p0, out Vector4 p1);
		private delegate void GlDelegate_uint_outcolor3(uint p0, out Color3 p1);
		private delegate void GlDelegate_uint_outcolor4(uint p0, out Color4 p1);
		private delegate void GlDelegate_uint_outbox2(uint p0, out Box2 p1);
		private delegate void GlDelegate_uint_outbox3(uint p0, out Box3 p1);
		private delegate void GlDelegate_uint_uint_longarray(uint p0, uint p1, long[] p2);
		private delegate void GlDelegate_uint_longarray(uint p0, long[] p1);
		private delegate void GlDelegate_uint_outlong(uint p0, out long p1);
		private delegate void GlDelegate_uint_uint_intarray(uint p0, uint p1, int[] p2);
		private delegate void GlDelegate_uint_intarray(uint p0, int[] p1);
		private delegate void GlDelegate_uint_outint(uint p0, out int p1);
		private delegate void GlDelegate_uint_uint_outfloat(uint p0, uint p1, out float p2);
		private delegate void GlDelegate_uint_int_outint_bytearray(uint p0, int p1, out int p2, byte[] p3);
		private delegate void GlDelegate_uint_int_intptrarray_intarray(uint p0, int p1, IntPtr[] p2, int[] p3);
		private delegate void GlDelegate_int_vector2(int p0, Vector2 p1);
		private delegate void GlDelegate_int_vector2i(int p0, Vector2i p1);
		private delegate void GlDelegate_int_vector3(int p0, Vector3 p1);
		private delegate void GlDelegate_int_vector3i(int p0, Vector3i p1);
		private delegate void GlDelegate_int_vector4(int p0, Vector4 p1);
		private delegate void GlDelegate_int_vector4i(int p0, Vector4i p1);
		private delegate void GlDelegate_int_int_bool_floatarray(int p0, int p1, bool p2, float[] p3);
		private delegate void GlDelegate_int_int_bool_refmatrix2(int p0, int p1, bool p2, ref Matrix2 p3);
		private delegate void GlDelegate_int_int_bool_refmatrix3(int p0, int p1, bool p2, ref Matrix3 p3);
		private delegate void GlDelegate_int_int_bool_refmatrix4(int p0, int p1, bool p2, ref Matrix4 p3);
		private delegate void GlDelegate_box2i(Box2i p0);

		private static GlDelegate_uint m_ActiveTexture_0;
		private static GlDelegate_uint_uint m_AttachShader_0;
		private static GlDelegate_uint_uint m_BeginConditionalRender_0;
		private static GlDelegate_uint_uint m_BeginQuery_0;
		private static GlDelegate_uint m_BeginTransformFeedback_0;
		private static GlDelegate_uint_uint_string m_BindAttribLocation_0;
		private static GlDelegate_uint_uint m_BindBuffer_0;
		private static GlDelegate_uint_uint_uint m_BindBufferBase_0;
		private static GlDelegate_uint_uint_uint_systemintptr_systemintptr m_BindBufferRange_0;
		private static GlDelegate_uint_uint_string m_BindFragDataLocation_0;
		private static GlDelegate_uint_uint m_BindFramebuffer_0;
		private static GlDelegate_uint_uint m_BindRenderbuffer_0;
		private static GlDelegate_uint_uint m_BindTexture_0;
		private static GlDelegate_uint m_BindVertexArray_0;
		private static GlDelegate_float_float_float_float m_BlendColor_0;
		private static GlDelegate_color4 m_BlendColor_1;
		private static GlDelegate_uint m_BlendEquation_0;
		private static GlDelegate_uint_uint m_BlendEquationSeparate_0;
		private static GlDelegate_uint_uint m_BlendFunc_0;
		private static GlDelegate_uint_uint_uint_uint m_BlendFuncSeparate_0;
		private static GlDelegate_int_int_int_int_int_int_int_int_uint_uint m_BlitFramebuffer_0;
		private static GlDelegate_vector2i_vector2i_vector2i_vector2i_uint_uint m_BlitFramebuffer_1;
		private static GlDelegate_uint_systemintptr_systemintptr_uint m_BufferData_0;
		private static GlDelegate_uint_systemintptr_systemintptr_systemintptr m_BufferSubData_0;
		private static GlDelegate_uint_Returns_uint m_CheckFramebufferStatus_0;
		private static GlDelegate_uint_uint m_ClampColor_0;
		private static GlDelegate_uint m_Clear_0;
		private static GlDelegate_uint_int_float_int m_ClearBufferfi_0;
		private static GlDelegate_uint_int_systemintptr m_ClearBufferfv_0;
		private static GlDelegate_uint_int_refcolor4 m_ClearBufferfv_1;
		private static GlDelegate_uint_int_reffloat m_ClearBufferfv_2;
		private static GlDelegate_uint_int_systemintptr m_ClearBufferiv_0;
		private static GlDelegate_uint_int_refcolor4i m_ClearBufferiv_1;
		private static GlDelegate_uint_int_refint m_ClearBufferiv_2;
		private static GlDelegate_uint_int_systemintptr m_ClearBufferuiv_0;
		private static GlDelegate_uint_int_refcolor4ui m_ClearBufferuiv_1;
		private static GlDelegate_uint_int_refuint m_ClearBufferuiv_2;
		private static GlDelegate_float_float_float_float m_ClearColor_0;
		private static GlDelegate_color4 m_ClearColor_1;
		private static GlDelegate_double m_ClearDepth_0;
		private static GlDelegate_int m_ClearStencil_0;
		private static GlDelegate_systemintptr_uint_ulong_Returns_uint m_ClientWaitSync_0;
		private static GlDelegate_bool_bool_bool_bool m_ColorMask_0;
		private static GlDelegate_uint_bool_bool_bool_bool m_ColorMaski_0;
		private static GlDelegate_uint m_CompileShader_0;
		private static GlDelegate_uint_int_uint_int_int_int_systemintptr m_CompressedTexImage1D_0;
		private static GlDelegate_uint_int_uint_int_int_int_int_systemintptr m_CompressedTexImage2D_0;
		private static GlDelegate_uint_int_uint_int_int_int_int_int_systemintptr m_CompressedTexImage3D_0;
		private static GlDelegate_uint_int_int_int_uint_int_systemintptr m_CompressedTexSubImage1D_0;
		private static GlDelegate_uint_int_int_int_int_int_uint_int_systemintptr m_CompressedTexSubImage2D_0;
		private static GlDelegate_uint_int_box2i_uint_int_systemintptr m_CompressedTexSubImage2D_1;
		private static GlDelegate_uint_int_int_int_int_int_int_int_uint_int_systemintptr m_CompressedTexSubImage3D_0;
		private static GlDelegate_uint_int_box3i_uint_int_systemintptr m_CompressedTexSubImage3D_1;
		private static GlDelegate_uint_uint_systemintptr_systemintptr_systemintptr m_CopyBufferSubData_0;
		private static GlDelegate_uint_int_uint_int_int_int_int m_CopyTexImage1D_0;
		private static GlDelegate_uint_int_uint_vector2i_int_int m_CopyTexImage1D_1;
		private static GlDelegate_uint_int_uint_int_int_int_int_int m_CopyTexImage2D_0;
		private static GlDelegate_uint_int_uint_vector2i_vector2i_int m_CopyTexImage2D_1;
		private static GlDelegate_uint_int_uint_box2i_int m_CopyTexImage2D_2;
		private static GlDelegate_uint_int_int_int_int_int m_CopyTexSubImage1D_0;
		private static GlDelegate_uint_int_int_vector2i_int m_CopyTexSubImage1D_1;
		private static GlDelegate_uint_int_int_int_int_int_int_int m_CopyTexSubImage2D_0;
		private static GlDelegate_uint_int_vector2i_vector2i_vector2i m_CopyTexSubImage2D_1;
		private static GlDelegate_uint_int_int_int_int_int_int_int_int m_CopyTexSubImage3D_0;
		private static GlDelegate_uint_int_vector3i_vector2i_vector2i m_CopyTexSubImage3D_1;
		private static GlDelegate_Returns_uint m_CreateProgram_0;
		private static GlDelegate_uint_Returns_uint m_CreateShader_0;
		private static GlDelegate_uint m_CullFace_0;
		private static GlDelegate_int_systemintptr m_DeleteBuffers_0;
		private static GlDelegate_int_uintarray m_DeleteBuffers_1;
		private static GlDelegate_int_refuint m_DeleteBuffers_2;
		private static GlDelegate_int_systemintptr m_DeleteFramebuffers_0;
		private static GlDelegate_int_uintarray m_DeleteFramebuffers_1;
		private static GlDelegate_int_refuint m_DeleteFramebuffers_2;
		private static GlDelegate_uint m_DeleteProgram_0;
		private static GlDelegate_int_systemintptr m_DeleteQueries_0;
		private static GlDelegate_int_uintarray m_DeleteQueries_1;
		private static GlDelegate_int_refuint m_DeleteQueries_2;
		private static GlDelegate_int_systemintptr m_DeleteRenderbuffers_0;
		private static GlDelegate_int_uintarray m_DeleteRenderbuffers_1;
		private static GlDelegate_int_refuint m_DeleteRenderbuffers_2;
		private static GlDelegate_uint m_DeleteShader_0;
		private static GlDelegate_systemintptr m_DeleteSync_0;
		private static GlDelegate_int_systemintptr m_DeleteTextures_0;
		private static GlDelegate_int_uintarray m_DeleteTextures_1;
		private static GlDelegate_int_refuint m_DeleteTextures_2;
		private static GlDelegate_int_systemintptr m_DeleteVertexArrays_0;
		private static GlDelegate_int_uintarray m_DeleteVertexArrays_1;
		private static GlDelegate_int_refuint m_DeleteVertexArrays_2;
		private static GlDelegate_uint m_DepthFunc_0;
		private static GlDelegate_bool m_DepthMask_0;
		private static GlDelegate_double_double m_DepthRange_0;
		private static GlDelegate_uint_uint m_DetachShader_0;
		private static GlDelegate_uint m_Disable_0;
		private static GlDelegate_uint_uint m_Disablei_0;
		private static GlDelegate_uint m_DisableVertexAttribArray_0;
		private static GlDelegate_uint_int_int m_DrawArrays_0;
		private static GlDelegate_uint_int_int_int m_DrawArraysInstanced_0;
		private static GlDelegate_uint m_DrawBuffer_0;
		private static GlDelegate_int_systemintptr m_DrawBuffers_0;
		private static GlDelegate_int_uintarray m_DrawBuffers_1;
		private static GlDelegate_int_refuint m_DrawBuffers_2;
		private static GlDelegate_uint_int_uint_systemintptr m_DrawElements_0;
		private static GlDelegate_uint_int_uint_bytearray m_DrawElements_1;
		private static GlDelegate_uint_int_uint_ushortarray m_DrawElements_2;
		private static GlDelegate_uint_int_uint_uintarray m_DrawElements_3;
		private static GlDelegate_uint_int_uint_systemintptr_int m_DrawElementsBaseVertex_0;
		private static GlDelegate_uint_int_uint_bytearray_int m_DrawElementsBaseVertex_1;
		private static GlDelegate_uint_int_uint_ushortarray_int m_DrawElementsBaseVertex_2;
		private static GlDelegate_uint_int_uint_uintarray_int m_DrawElementsBaseVertex_3;
		private static GlDelegate_uint_int_uint_systemintptr_int m_DrawElementsInstanced_0;
		private static GlDelegate_uint_int_uint_bytearray_int m_DrawElementsInstanced_1;
		private static GlDelegate_uint_int_uint_ushortarray_int m_DrawElementsInstanced_2;
		private static GlDelegate_uint_int_uint_uintarray_int m_DrawElementsInstanced_3;
		private static GlDelegate_uint_int_uint_systemintptr_int_int m_DrawElementsInstancedBaseVertex_0;
		private static GlDelegate_uint_int_uint_bytearray_int_int m_DrawElementsInstancedBaseVertex_1;
		private static GlDelegate_uint_int_uint_ushortarray_int_int m_DrawElementsInstancedBaseVertex_2;
		private static GlDelegate_uint_int_uint_uintarray_int_int m_DrawElementsInstancedBaseVertex_3;
		private static GlDelegate_uint_uint_uint_int_uint_systemintptr m_DrawRangeElements_0;
		private static GlDelegate_uint_uint_uint_int_uint_bytearray m_DrawRangeElements_1;
		private static GlDelegate_uint_uint_uint_int_uint_ushortarray m_DrawRangeElements_2;
		private static GlDelegate_uint_uint_uint_int_uint_uintarray m_DrawRangeElements_3;
		private static GlDelegate_uint_uint_uint_int_uint_systemintptr_int m_DrawRangeElementsBaseVertex_0;
		private static GlDelegate_uint_uint_uint_int_uint_bytearray_int m_DrawRangeElementsBaseVertex_1;
		private static GlDelegate_uint_uint_uint_int_uint_ushortarray_int m_DrawRangeElementsBaseVertex_2;
		private static GlDelegate_uint_uint_uint_int_uint_uintarray_int m_DrawRangeElementsBaseVertex_3;
		private static GlDelegate_uint m_Enable_0;
		private static GlDelegate_uint_uint m_Enablei_0;
		private static GlDelegate_uint m_EnableVertexAttribArray_0;
		private static GlDelegate m_EndConditionalRender_0;
		private static GlDelegate_uint m_EndQuery_0;
		private static GlDelegate m_EndTransformFeedback_0;
		private static GlDelegate_uint_uint_Returns_systemintptr m_FenceSync_0;
		private static GlDelegate m_Finish_0;
		private static GlDelegate m_Flush_0;
		private static GlDelegate_uint_systemintptr_systemintptr m_FlushMappedBufferRange_0;
		private static GlDelegate_uint_uint_uint_uint m_FramebufferRenderbuffer_0;
		private static GlDelegate_uint_uint_uint_int m_FramebufferTexture_0;
		private static GlDelegate_uint_uint_uint_uint_int m_FramebufferTexture1D_0;
		private static GlDelegate_uint_uint_uint_uint_int m_FramebufferTexture2D_0;
		private static GlDelegate_uint_uint_uint_uint_int_int m_FramebufferTexture3D_0;
		private static GlDelegate_uint_uint_uint_int_int m_FramebufferTextureLayer_0;
		private static GlDelegate_uint m_FrontFace_0;
		private static GlDelegate_int_systemintptr m_GenBuffers_0;
		private static GlDelegate_int_uintarray m_GenBuffers_1;
		private static GlDelegate_int_outuint m_GenBuffers_2;
		private static GlDelegate_uint m_GenerateMipmap_0;
		private static GlDelegate_int_systemintptr m_GenFramebuffers_0;
		private static GlDelegate_int_uintarray m_GenFramebuffers_1;
		private static GlDelegate_int_outuint m_GenFramebuffers_2;
		private static GlDelegate_int_systemintptr m_GenQueries_0;
		private static GlDelegate_int_uintarray m_GenQueries_1;
		private static GlDelegate_int_outuint m_GenQueries_2;
		private static GlDelegate_int_systemintptr m_GenRenderbuffers_0;
		private static GlDelegate_int_uintarray m_GenRenderbuffers_1;
		private static GlDelegate_int_outuint m_GenRenderbuffers_2;
		private static GlDelegate_int_systemintptr m_GenTextures_0;
		private static GlDelegate_int_uintarray m_GenTextures_1;
		private static GlDelegate_int_outuint m_GenTextures_2;
		private static GlDelegate_int_systemintptr m_GenVertexArrays_0;
		private static GlDelegate_int_uintarray m_GenVertexArrays_1;
		private static GlDelegate_int_outuint m_GenVertexArrays_2;
		private static GlDelegate_uint_uint_int_systemintptr_systemintptr_systemintptr_string m_GetActiveAttrib_0;
		private static GlDelegate_uint_uint_int_outint_outint_outuint_bytearray m_GetActiveAttrib_1;
		private static GlDelegate_uint_uint_int_systemintptr_systemintptr_systemintptr_string m_GetActiveUniform_0;
		private static GlDelegate_uint_uint_int_outint_outint_outuint_bytearray m_GetActiveUniform_1;
		private static GlDelegate_uint_uint_uint_systemintptr m_GetActiveUniformBlockiv_0;
		private static GlDelegate_uint_uint_uint_intarray m_GetActiveUniformBlockiv_1;
		private static GlDelegate_uint_uint_uint_outint m_GetActiveUniformBlockiv_2;
		private static GlDelegate_uint_uint_int_systemintptr_systemintptr m_GetActiveUniformBlockName_0;
		private static GlDelegate_uint_uint_int_outint_bytearray m_GetActiveUniformBlockName_1;
		private static GlDelegate_uint_uint_int_systemintptr_systemintptr m_GetActiveUniformName_0;
		private static GlDelegate_uint_uint_int_outint_bytearray m_GetActiveUniformName_1;
		private static GlDelegate_uint_int_systemintptr_uint_systemintptr m_GetActiveUniformsiv_0;
		private static GlDelegate_uint_int_uintarray_uint_intarray m_GetActiveUniformsiv_1;
		private static GlDelegate_uint_int_outint_uint_intarray m_GetActiveUniformsiv_2;
		private static GlDelegate_uint_int_uintarray_uint_refint m_GetActiveUniformsiv_3;
		private static GlDelegate_uint_int_outint_uint_refint m_GetActiveUniformsiv_4;
		private static GlDelegate_uint_int_systemintptr_systemintptr m_GetAttachedShaders_0;
		private static GlDelegate_uint_int_uint_uintarray m_GetAttachedShaders_1;
		private static GlDelegate_uint_systemintptr_Returns_int m_GetAttribLocation_0;
		private static GlDelegate_uint_bytearray_Returns_int m_GetAttribLocation_1;
		private static GlDelegate_uint_string_Returns_int m_GetAttribLocation_2;
		private static GlDelegate_uint_uint_systemintptr m_GetBooleani_v_0;
		private static GlDelegate_uint_uint_outbool m_GetBooleani_v_1;
		private static GlDelegate_uint_systemintptr m_GetBooleanv_0;
		private static GlDelegate_uint_outbool m_GetBooleanv_1;
		private static GlDelegate_uint_uint_systemintptr m_GetBufferParameteri64v_0;
		private static GlDelegate_uint_uint_outlong m_GetBufferParameteri64v_1;
		private static GlDelegate_uint_uint_systemintptr m_GetBufferParameteriv_0;
		private static GlDelegate_uint_uint_outint m_GetBufferParameteriv_1;
		private static GlDelegate_uint_uint_systemintptr m_GetBufferPointerv_0;
		private static GlDelegate_uint_uint_outsystemintptr m_GetBufferPointerv_1;
		private static GlDelegate_uint_systemintptr_systemintptr_systemintptr m_GetBufferSubData_0;
		private static GlDelegate_uint_int_systemintptr m_GetCompressedTexImage_0;
		private static GlDelegate_uint_systemintptr m_GetDoublev_0;
		private static GlDelegate_uint_doublearray m_GetDoublev_1;
		private static GlDelegate_uint_outdouble m_GetDoublev_2;
		private static GlDelegate_uint_outvector2d m_GetDoublev_3;
		private static GlDelegate_uint_outvector3d m_GetDoublev_4;
		private static GlDelegate_uint_outvector4d m_GetDoublev_5;
		private static GlDelegate_uint_outcolor3d m_GetDoublev_6;
		private static GlDelegate_uint_outcolor4d m_GetDoublev_7;
		private static GlDelegate_uint_outbox2d m_GetDoublev_8;
		private static GlDelegate_uint_outbox3d m_GetDoublev_9;
		private static GlDelegate_Returns_uint m_GetError_0;
		private static GlDelegate_uint_systemintptr m_GetFloatv_0;
		private static GlDelegate_uint_floatarray m_GetFloatv_1;
		private static GlDelegate_uint_outfloat m_GetFloatv_2;
		private static GlDelegate_uint_outvector2 m_GetFloatv_3;
		private static GlDelegate_uint_outvector3 m_GetFloatv_4;
		private static GlDelegate_uint_outvector4 m_GetFloatv_5;
		private static GlDelegate_uint_outcolor3 m_GetFloatv_6;
		private static GlDelegate_uint_outcolor4 m_GetFloatv_7;
		private static GlDelegate_uint_outbox2 m_GetFloatv_8;
		private static GlDelegate_uint_outbox3 m_GetFloatv_9;
		private static GlDelegate_uint_string_Returns_int m_GetFragDataLocation_0;
		private static GlDelegate_uint_uint_uint_systemintptr m_GetFramebufferAttachmentParameteriv_0;
		private static GlDelegate_uint_uint_uint_outint m_GetFramebufferAttachmentParameteriv_1;
		private static GlDelegate_uint_uint_systemintptr m_GetInteger64i_v_0;
		private static GlDelegate_uint_uint_longarray m_GetInteger64i_v_1;
		private static GlDelegate_uint_uint_outlong m_GetInteger64i_v_2;
		private static GlDelegate_uint_systemintptr m_GetInteger64v_0;
		private static GlDelegate_uint_longarray m_GetInteger64v_1;
		private static GlDelegate_uint_outlong m_GetInteger64v_2;
		private static GlDelegate_uint_uint_systemintptr m_GetIntegeri_v_0;
		private static GlDelegate_uint_uint_intarray m_GetIntegeri_v_1;
		private static GlDelegate_uint_uint_outint m_GetIntegeri_v_2;
		private static GlDelegate_uint_systemintptr m_GetIntegerv_0;
		private static GlDelegate_uint_intarray m_GetIntegerv_1;
		private static GlDelegate_uint_outint m_GetIntegerv_2;
		private static GlDelegate_uint_uint_systemintptr m_GetMultisamplefv_0;
		private static GlDelegate_uint_uint_outfloat m_GetMultisamplefv_1;
		private static GlDelegate_uint_int_systemintptr_string m_GetProgramInfoLog_0;
		private static GlDelegate_uint_int_outint_bytearray m_GetProgramInfoLog_1;
		private static GlDelegate_uint_uint_systemintptr m_GetProgramiv_0;
		private static GlDelegate_uint_uint_intarray m_GetProgramiv_1;
		private static GlDelegate_uint_uint_outint m_GetProgramiv_2;
		private static GlDelegate_uint_uint_systemintptr m_GetQueryiv_0;
		private static GlDelegate_uint_uint_systemintptr m_GetQueryObjectiv_0;
		private static GlDelegate_uint_uint_systemintptr m_GetQueryObjectuiv_0;
		private static GlDelegate_uint_uint_systemintptr m_GetRenderbufferParameteriv_0;
		private static GlDelegate_uint_int_systemintptr_string m_GetShaderInfoLog_0;
		private static GlDelegate_uint_int_outint_bytearray m_GetShaderInfoLog_1;
		private static GlDelegate_uint_uint_systemintptr m_GetShaderiv_0;
		private static GlDelegate_uint_uint_intarray m_GetShaderiv_1;
		private static GlDelegate_uint_uint_outint m_GetShaderiv_2;
		private static GlDelegate_uint_int_systemintptr_string m_GetShaderSource_0;
		private static GlDelegate_uint_Returns_systemintptr m_GetString_0;
		private static GlDelegate_uint_uint_Returns_systemintptr m_GetStringi_0;
		private static GlDelegate_systemintptr_uint_int_systemintptr_systemintptr m_GetSynciv_0;
		private static GlDelegate_uint_int_uint_uint_systemintptr m_GetTexImage_0;
		private static GlDelegate_uint_int_uint_systemintptr m_GetTexLevelParameterfv_0;
		private static GlDelegate_uint_int_uint_systemintptr m_GetTexLevelParameteriv_0;
		private static GlDelegate_uint_uint_systemintptr m_GetTexParameterfv_0;
		private static GlDelegate_uint_uint_systemintptr m_GetTexParameterIiv_0;
		private static GlDelegate_uint_uint_systemintptr m_GetTexParameterIuiv_0;
		private static GlDelegate_uint_uint_systemintptr m_GetTexParameteriv_0;
		private static GlDelegate_uint_uint_int_systemintptr_systemintptr_systemintptr_string m_GetTransformFeedbackVarying_0;
		private static GlDelegate_uint_string_Returns_uint m_GetUniformBlockIndex_0;
		private static GlDelegate_uint_int_systemintptr m_GetUniformfv_0;
		private static GlDelegate_uint_int_systemintptr_systemintptr m_GetUniformIndices_0;
		private static GlDelegate_uint_int_systemintptr m_GetUniformiv_0;
		private static GlDelegate_uint_systemintptr_Returns_int m_GetUniformLocation_0;
		private static GlDelegate_uint_bytearray_Returns_int m_GetUniformLocation_1;
		private static GlDelegate_uint_string_Returns_int m_GetUniformLocation_2;
		private static GlDelegate_uint_int_systemintptr m_GetUniformuiv_0;
		private static GlDelegate_uint_uint_systemintptr m_GetVertexAttribdv_0;
		private static GlDelegate_uint_uint_systemintptr m_GetVertexAttribfv_0;
		private static GlDelegate_uint_uint_systemintptr m_GetVertexAttribIiv_0;
		private static GlDelegate_uint_uint_systemintptr m_GetVertexAttribIuiv_0;
		private static GlDelegate_uint_uint_systemintptr m_GetVertexAttribiv_0;
		private static GlDelegate_uint_uint_systemintptr m_GetVertexAttribPointerv_0;
		private static GlDelegate_uint_uint m_Hint_0;
		private static GlDelegate_uint_Returns_bool m_IsBuffer_0;
		private static GlDelegate_uint_Returns_bool m_IsEnabled_0;
		private static GlDelegate_uint_uint_Returns_bool m_IsEnabledi_0;
		private static GlDelegate_uint_Returns_bool m_IsFramebuffer_0;
		private static GlDelegate_uint_Returns_bool m_IsProgram_0;
		private static GlDelegate_uint_Returns_bool m_IsQuery_0;
		private static GlDelegate_uint_Returns_bool m_IsRenderbuffer_0;
		private static GlDelegate_uint_Returns_bool m_IsShader_0;
		private static GlDelegate_systemintptr_Returns_bool m_IsSync_0;
		private static GlDelegate_uint_Returns_bool m_IsTexture_0;
		private static GlDelegate_uint_Returns_bool m_IsVertexArray_0;
		private static GlDelegate_float m_LineWidth_0;
		private static GlDelegate_uint m_LinkProgram_0;
		private static GlDelegate_uint m_LogicOp_0;
		private static GlDelegate_uint_uint_Returns_systemintptr m_MapBuffer_0;
		private static GlDelegate_uint_systemintptr_systemintptr_uint_Returns_systemintptr m_MapBufferRange_0;
		private static GlDelegate_uint_systemintptr_systemintptr_int m_MultiDrawArrays_0;
		private static GlDelegate_uint_systemintptr_uint_systemintptr_int m_MultiDrawElements_0;
		private static GlDelegate_uint_systemintptr_uint_systemintptr_int_systemintptr m_MultiDrawElementsBaseVertex_0;
		private static GlDelegate_uint_float m_PixelStoref_0;
		private static GlDelegate_uint_int m_PixelStorei_0;
		private static GlDelegate_uint_float m_PointParameterf_0;
		private static GlDelegate_uint_systemintptr m_PointParameterfv_0;
		private static GlDelegate_uint_int m_PointParameteri_0;
		private static GlDelegate_uint_systemintptr m_PointParameteriv_0;
		private static GlDelegate_float m_PointSize_0;
		private static GlDelegate_uint_uint m_PolygonMode_0;
		private static GlDelegate_float_float m_PolygonOffset_0;
		private static GlDelegate_uint m_PrimitiveRestartIndex_0;
		private static GlDelegate_uint m_ProvokingVertex_0;
		private static GlDelegate_uint m_ReadBuffer_0;
		private static GlDelegate_int_int_int_int_uint_uint_systemintptr m_ReadPixels_0;
		private static GlDelegate_uint_uint_int_int m_RenderbufferStorage_0;
		private static GlDelegate_uint_int_uint_int_int m_RenderbufferStorageMultisample_0;
		private static GlDelegate_float_bool m_SampleCoverage_0;
		private static GlDelegate_uint_uint m_SampleMaski_0;
		private static GlDelegate_int_int_int_int m_Scissor_0;
		private static GlDelegate_uint_int_systemintptr_systemintptr m_ShaderSource_0;
		private static GlDelegate_uint_int_intptrarray_intarray m_ShaderSource_1;
		private static GlDelegate_uint_int_uint m_StencilFunc_0;
		private static GlDelegate_uint_uint_int_uint m_StencilFuncSeparate_0;
		private static GlDelegate_uint m_StencilMask_0;
		private static GlDelegate_uint_uint m_StencilMaskSeparate_0;
		private static GlDelegate_uint_uint_uint m_StencilOp_0;
		private static GlDelegate_uint_uint_uint_uint m_StencilOpSeparate_0;
		private static GlDelegate_uint_uint_uint m_TexBuffer_0;
		private static GlDelegate_uint_int_int_int_int_uint_uint_systemintptr m_TexImage1D_0;
		private static GlDelegate_uint_int_int_int_int_int_uint_uint_systemintptr m_TexImage2D_0;
		private static GlDelegate_uint_int_uint_int_int_bool m_TexImage2DMultisample_0;
		private static GlDelegate_uint_int_int_int_int_int_int_uint_uint_systemintptr m_TexImage3D_0;
		private static GlDelegate_uint_int_uint_int_int_int_bool m_TexImage3DMultisample_0;
		private static GlDelegate_uint_uint_float m_TexParameterf_0;
		private static GlDelegate_uint_uint_systemintptr m_TexParameterfv_0;
		private static GlDelegate_uint_uint_int m_TexParameteri_0;
		private static GlDelegate_uint_uint_systemintptr m_TexParameterIiv_0;
		private static GlDelegate_uint_uint_systemintptr m_TexParameterIuiv_0;
		private static GlDelegate_uint_uint_systemintptr m_TexParameteriv_0;
		private static GlDelegate_uint_int_int_int_uint_uint_systemintptr m_TexSubImage1D_0;
		private static GlDelegate_uint_int_int_int_int_int_uint_uint_systemintptr m_TexSubImage2D_0;
		private static GlDelegate_uint_int_int_int_int_int_int_int_uint_uint_systemintptr m_TexSubImage3D_0;
		private static GlDelegate_uint_int_systemintptr_uint m_TransformFeedbackVaryings_0;
		private static GlDelegate_int_float m_Uniform1f_0;
		private static GlDelegate_int_int_systemintptr m_Uniform1fv_0;
		private static GlDelegate_int_int m_Uniform1i_0;
		private static GlDelegate_int_int_systemintptr m_Uniform1iv_0;
		private static GlDelegate_int_uint m_Uniform1ui_0;
		private static GlDelegate_int_int_systemintptr m_Uniform1uiv_0;
		private static GlDelegate_int_float_float m_Uniform2f_0;
		private static GlDelegate_int_vector2 m_Uniform2f_1;
		private static GlDelegate_int_int_systemintptr m_Uniform2fv_0;
		private static GlDelegate_int_int_int m_Uniform2i_0;
		private static GlDelegate_int_vector2i m_Uniform2i_1;
		private static GlDelegate_int_int_systemintptr m_Uniform2iv_0;
		private static GlDelegate_int_uint_uint m_Uniform2ui_0;
		private static GlDelegate_int_int_systemintptr m_Uniform2uiv_0;
		private static GlDelegate_int_float_float_float m_Uniform3f_0;
		private static GlDelegate_int_vector3 m_Uniform3f_1;
		private static GlDelegate_int_int_systemintptr m_Uniform3fv_0;
		private static GlDelegate_int_int_int_int m_Uniform3i_0;
		private static GlDelegate_int_vector3i m_Uniform3i_1;
		private static GlDelegate_int_int_systemintptr m_Uniform3iv_0;
		private static GlDelegate_int_uint_uint_uint m_Uniform3ui_0;
		private static GlDelegate_int_int_systemintptr m_Uniform3uiv_0;
		private static GlDelegate_int_float_float_float_float m_Uniform4f_0;
		private static GlDelegate_int_vector4 m_Uniform4f_1;
		private static GlDelegate_int_int_systemintptr m_Uniform4fv_0;
		private static GlDelegate_int_int_int_int_int m_Uniform4i_0;
		private static GlDelegate_int_vector4i m_Uniform4i_1;
		private static GlDelegate_int_int_systemintptr m_Uniform4iv_0;
		private static GlDelegate_int_uint_uint_uint_uint m_Uniform4ui_0;
		private static GlDelegate_int_int_systemintptr m_Uniform4uiv_0;
		private static GlDelegate_uint_uint_uint m_UniformBlockBinding_0;
		private static GlDelegate_int_int_bool_systemintptr m_UniformMatrix2fv_0;
		private static GlDelegate_int_int_bool_floatarray m_UniformMatrix2fv_1;
		private static GlDelegate_int_int_bool_refmatrix2 m_UniformMatrix2fv_2;
		private static GlDelegate_int_int_bool_systemintptr m_UniformMatrix2x3fv_0;
		private static GlDelegate_int_int_bool_systemintptr m_UniformMatrix2x4fv_0;
		private static GlDelegate_int_int_bool_systemintptr m_UniformMatrix3fv_0;
		private static GlDelegate_int_int_bool_floatarray m_UniformMatrix3fv_1;
		private static GlDelegate_int_int_bool_refmatrix3 m_UniformMatrix3fv_2;
		private static GlDelegate_int_int_bool_systemintptr m_UniformMatrix3x2fv_0;
		private static GlDelegate_int_int_bool_systemintptr m_UniformMatrix3x4fv_0;
		private static GlDelegate_int_int_bool_systemintptr m_UniformMatrix4fv_0;
		private static GlDelegate_int_int_bool_floatarray m_UniformMatrix4fv_1;
		private static GlDelegate_int_int_bool_refmatrix4 m_UniformMatrix4fv_2;
		private static GlDelegate_int_int_bool_systemintptr m_UniformMatrix4x2fv_0;
		private static GlDelegate_int_int_bool_systemintptr m_UniformMatrix4x3fv_0;
		private static GlDelegate_uint_Returns_bool m_UnmapBuffer_0;
		private static GlDelegate_uint m_UseProgram_0;
		private static GlDelegate_uint m_ValidateProgram_0;
		private static GlDelegate_uint_double m_VertexAttrib1d_0;
		private static GlDelegate_uint_systemintptr m_VertexAttrib1dv_0;
		private static GlDelegate_uint_float m_VertexAttrib1f_0;
		private static GlDelegate_uint_systemintptr m_VertexAttrib1fv_0;
		private static GlDelegate_uint_short m_VertexAttrib1s_0;
		private static GlDelegate_uint_systemintptr m_VertexAttrib1sv_0;
		private static GlDelegate_uint_double_double m_VertexAttrib2d_0;
		private static GlDelegate_uint_systemintptr m_VertexAttrib2dv_0;
		private static GlDelegate_uint_float_float m_VertexAttrib2f_0;
		private static GlDelegate_uint_systemintptr m_VertexAttrib2fv_0;
		private static GlDelegate_uint_short_short m_VertexAttrib2s_0;
		private static GlDelegate_uint_systemintptr m_VertexAttrib2sv_0;
		private static GlDelegate_uint_double_double_double m_VertexAttrib3d_0;
		private static GlDelegate_uint_systemintptr m_VertexAttrib3dv_0;
		private static GlDelegate_uint_float_float_float m_VertexAttrib3f_0;
		private static GlDelegate_uint_systemintptr m_VertexAttrib3fv_0;
		private static GlDelegate_uint_short_short_short m_VertexAttrib3s_0;
		private static GlDelegate_uint_systemintptr m_VertexAttrib3sv_0;
		private static GlDelegate_uint_systemintptr m_VertexAttrib4bv_0;
		private static GlDelegate_uint_double_double_double_double m_VertexAttrib4d_0;
		private static GlDelegate_uint_systemintptr m_VertexAttrib4dv_0;
		private static GlDelegate_uint_float_float_float_float m_VertexAttrib4f_0;
		private static GlDelegate_uint_systemintptr m_VertexAttrib4fv_0;
		private static GlDelegate_uint_systemintptr m_VertexAttrib4iv_0;
		private static GlDelegate_uint_systemintptr m_VertexAttrib4Nbv_0;
		private static GlDelegate_uint_systemintptr m_VertexAttrib4Niv_0;
		private static GlDelegate_uint_systemintptr m_VertexAttrib4Nsv_0;
		private static GlDelegate_uint_byte_byte_byte_byte m_VertexAttrib4Nub_0;
		private static GlDelegate_uint_systemintptr m_VertexAttrib4Nubv_0;
		private static GlDelegate_uint_systemintptr m_VertexAttrib4Nuiv_0;
		private static GlDelegate_uint_systemintptr m_VertexAttrib4Nusv_0;
		private static GlDelegate_uint_short_short_short_short m_VertexAttrib4s_0;
		private static GlDelegate_uint_systemintptr m_VertexAttrib4sv_0;
		private static GlDelegate_uint_systemintptr m_VertexAttrib4ubv_0;
		private static GlDelegate_uint_systemintptr m_VertexAttrib4uiv_0;
		private static GlDelegate_uint_systemintptr m_VertexAttrib4usv_0;
		private static GlDelegate_uint_int m_VertexAttribI1i_0;
		private static GlDelegate_uint_systemintptr m_VertexAttribI1iv_0;
		private static GlDelegate_uint_uint m_VertexAttribI1ui_0;
		private static GlDelegate_uint_systemintptr m_VertexAttribI1uiv_0;
		private static GlDelegate_uint_int_int m_VertexAttribI2i_0;
		private static GlDelegate_uint_systemintptr m_VertexAttribI2iv_0;
		private static GlDelegate_uint_uint_uint m_VertexAttribI2ui_0;
		private static GlDelegate_uint_systemintptr m_VertexAttribI2uiv_0;
		private static GlDelegate_uint_int_int_int m_VertexAttribI3i_0;
		private static GlDelegate_uint_systemintptr m_VertexAttribI3iv_0;
		private static GlDelegate_uint_uint_uint_uint m_VertexAttribI3ui_0;
		private static GlDelegate_uint_systemintptr m_VertexAttribI3uiv_0;
		private static GlDelegate_uint_systemintptr m_VertexAttribI4bv_0;
		private static GlDelegate_uint_int_int_int_int m_VertexAttribI4i_0;
		private static GlDelegate_uint_systemintptr m_VertexAttribI4iv_0;
		private static GlDelegate_uint_systemintptr m_VertexAttribI4sv_0;
		private static GlDelegate_uint_systemintptr m_VertexAttribI4ubv_0;
		private static GlDelegate_uint_uint_uint_uint_uint m_VertexAttribI4ui_0;
		private static GlDelegate_uint_systemintptr m_VertexAttribI4uiv_0;
		private static GlDelegate_uint_systemintptr m_VertexAttribI4usv_0;
		private static GlDelegate_uint_int_uint_int_systemintptr m_VertexAttribIPointer_0;
		private static GlDelegate_uint_int_uint_bool_int_systemintptr m_VertexAttribPointer_0;
		private static GlDelegate_int_int_int_int m_Viewport_0;
		private static GlDelegate_box2i m_Viewport_1;
		private static GlDelegate_systemintptr_uint_ulong m_WaitSync_0;
		private static GlDelegate_uint_uint_uint_systemintptr m_BindFragDataLocationIndexed_0;
		private static GlDelegate_uint_systemintptr_Returns_int m_GetFragDataIndex_0;
		private static GlDelegate_int_systemintptr m_GenSamplers_0;
		private static GlDelegate_int_uintarray m_GenSamplers_1;
		private static GlDelegate_int_outuint m_GenSamplers_2;
		private static GlDelegate_int_systemintptr m_DeleteSamplers_0;
		private static GlDelegate_int_uintarray m_DeleteSamplers_1;
		private static GlDelegate_int_refuint m_DeleteSamplers_2;
		private static GlDelegate_uint_Returns_bool m_IsSampler_0;
		private static GlDelegate_uint_uint m_BindSampler_0;
		private static GlDelegate_uint_uint_int m_SamplerParameteri_0;
		private static GlDelegate_uint_uint_systemintptr m_SamplerParameteriv_0;
		private static GlDelegate_uint_uint_float m_SamplerParameterf_0;
		private static GlDelegate_uint_uint_systemintptr m_SamplerParameterfv_0;
		private static GlDelegate_uint_uint_systemintptr m_SamplerParameterIiv_0;
		private static GlDelegate_uint_uint_systemintptr m_SamplerParameterIuiv_0;
		private static GlDelegate_uint_uint_systemintptr m_GetSamplerParameteriv_0;
		private static GlDelegate_uint_uint_systemintptr m_GetSamplerParameterIiv_0;
		private static GlDelegate_uint_uint_systemintptr m_GetSamplerParameterfv_0;
		private static GlDelegate_uint_uint_systemintptr m_GetSamplerParameterIuiv_0;
		private static GlDelegate_uint_uint m_QueryCounter_0;
		private static GlDelegate_uint_uint_systemintptr m_GetQueryObjecti64v_0;
		private static GlDelegate_uint_uint_systemintptr m_GetQueryObjectui64v_0;
		private static GlDelegate_uint_uint m_VertexAttribDivisor_0;
		private static GlDelegate_uint_uint_bool_uint m_VertexAttribP1ui_0;
		private static GlDelegate_uint_uint_bool_systemintptr m_VertexAttribP1uiv_0;
		private static GlDelegate_uint_uint_bool_uint m_VertexAttribP2ui_0;
		private static GlDelegate_uint_uint_bool_systemintptr m_VertexAttribP2uiv_0;
		private static GlDelegate_uint_uint_bool_uint m_VertexAttribP3ui_0;
		private static GlDelegate_uint_uint_bool_systemintptr m_VertexAttribP3uiv_0;
		private static GlDelegate_uint_uint_bool_uint m_VertexAttribP4ui_0;
		private static GlDelegate_uint_uint_bool_systemintptr m_VertexAttribP4uiv_0;

		private static void InitializeFunctions()
		{
			m_ActiveTexture_0 = (GlDelegate_uint)GetFunctionDelegate("glActiveTexture", typeof(GlDelegate_uint));
			m_AttachShader_0 = (GlDelegate_uint_uint)GetFunctionDelegate("glAttachShader", typeof(GlDelegate_uint_uint));
			m_BeginConditionalRender_0 = (GlDelegate_uint_uint)GetFunctionDelegate("glBeginConditionalRender", typeof(GlDelegate_uint_uint));
			m_BeginQuery_0 = (GlDelegate_uint_uint)GetFunctionDelegate("glBeginQuery", typeof(GlDelegate_uint_uint));
			m_BeginTransformFeedback_0 = (GlDelegate_uint)GetFunctionDelegate("glBeginTransformFeedback", typeof(GlDelegate_uint));
			m_BindAttribLocation_0 = (GlDelegate_uint_uint_string)GetFunctionDelegate("glBindAttribLocation", typeof(GlDelegate_uint_uint_string));
			m_BindBuffer_0 = (GlDelegate_uint_uint)GetFunctionDelegate("glBindBuffer", typeof(GlDelegate_uint_uint));
			m_BindBufferBase_0 = (GlDelegate_uint_uint_uint)GetFunctionDelegate("glBindBufferBase", typeof(GlDelegate_uint_uint_uint));
			m_BindBufferRange_0 = (GlDelegate_uint_uint_uint_systemintptr_systemintptr)GetFunctionDelegate("glBindBufferRange", typeof(GlDelegate_uint_uint_uint_systemintptr_systemintptr));
			m_BindFragDataLocation_0 = (GlDelegate_uint_uint_string)GetFunctionDelegate("glBindFragDataLocation", typeof(GlDelegate_uint_uint_string));
			m_BindFramebuffer_0 = (GlDelegate_uint_uint)GetFunctionDelegate("glBindFramebuffer", typeof(GlDelegate_uint_uint));
			m_BindRenderbuffer_0 = (GlDelegate_uint_uint)GetFunctionDelegate("glBindRenderbuffer", typeof(GlDelegate_uint_uint));
			m_BindTexture_0 = (GlDelegate_uint_uint)GetFunctionDelegate("glBindTexture", typeof(GlDelegate_uint_uint));
			m_BindVertexArray_0 = (GlDelegate_uint)GetFunctionDelegate("glBindVertexArray", typeof(GlDelegate_uint));
			m_BlendColor_0 = (GlDelegate_float_float_float_float)GetFunctionDelegate("glBlendColor", typeof(GlDelegate_float_float_float_float));
			m_BlendColor_1 = (GlDelegate_color4)GetFunctionDelegate("glBlendColor", typeof(GlDelegate_color4));
			m_BlendEquation_0 = (GlDelegate_uint)GetFunctionDelegate("glBlendEquation", typeof(GlDelegate_uint));
			m_BlendEquationSeparate_0 = (GlDelegate_uint_uint)GetFunctionDelegate("glBlendEquationSeparate", typeof(GlDelegate_uint_uint));
			m_BlendFunc_0 = (GlDelegate_uint_uint)GetFunctionDelegate("glBlendFunc", typeof(GlDelegate_uint_uint));
			m_BlendFuncSeparate_0 = (GlDelegate_uint_uint_uint_uint)GetFunctionDelegate("glBlendFuncSeparate", typeof(GlDelegate_uint_uint_uint_uint));
			m_BlitFramebuffer_0 = (GlDelegate_int_int_int_int_int_int_int_int_uint_uint)GetFunctionDelegate("glBlitFramebuffer", typeof(GlDelegate_int_int_int_int_int_int_int_int_uint_uint));
			m_BlitFramebuffer_1 = (GlDelegate_vector2i_vector2i_vector2i_vector2i_uint_uint)GetFunctionDelegate("glBlitFramebuffer", typeof(GlDelegate_vector2i_vector2i_vector2i_vector2i_uint_uint));
			m_BufferData_0 = (GlDelegate_uint_systemintptr_systemintptr_uint)GetFunctionDelegate("glBufferData", typeof(GlDelegate_uint_systemintptr_systemintptr_uint));
			m_BufferSubData_0 = (GlDelegate_uint_systemintptr_systemintptr_systemintptr)GetFunctionDelegate("glBufferSubData", typeof(GlDelegate_uint_systemintptr_systemintptr_systemintptr));
			m_CheckFramebufferStatus_0 = (GlDelegate_uint_Returns_uint)GetFunctionDelegate("glCheckFramebufferStatus", typeof(GlDelegate_uint_Returns_uint));
			m_ClampColor_0 = (GlDelegate_uint_uint)GetFunctionDelegate("glClampColor", typeof(GlDelegate_uint_uint));
			m_Clear_0 = (GlDelegate_uint)GetFunctionDelegate("glClear", typeof(GlDelegate_uint));
			m_ClearBufferfi_0 = (GlDelegate_uint_int_float_int)GetFunctionDelegate("glClearBufferfi", typeof(GlDelegate_uint_int_float_int));
			m_ClearBufferfv_0 = (GlDelegate_uint_int_systemintptr)GetFunctionDelegate("glClearBufferfv", typeof(GlDelegate_uint_int_systemintptr));
			m_ClearBufferfv_1 = (GlDelegate_uint_int_refcolor4)GetFunctionDelegate("glClearBufferfv", typeof(GlDelegate_uint_int_refcolor4));
			m_ClearBufferfv_2 = (GlDelegate_uint_int_reffloat)GetFunctionDelegate("glClearBufferfv", typeof(GlDelegate_uint_int_reffloat));
			m_ClearBufferiv_0 = (GlDelegate_uint_int_systemintptr)GetFunctionDelegate("glClearBufferiv", typeof(GlDelegate_uint_int_systemintptr));
			m_ClearBufferiv_1 = (GlDelegate_uint_int_refcolor4i)GetFunctionDelegate("glClearBufferiv", typeof(GlDelegate_uint_int_refcolor4i));
			m_ClearBufferiv_2 = (GlDelegate_uint_int_refint)GetFunctionDelegate("glClearBufferiv", typeof(GlDelegate_uint_int_refint));
			m_ClearBufferuiv_0 = (GlDelegate_uint_int_systemintptr)GetFunctionDelegate("glClearBufferuiv", typeof(GlDelegate_uint_int_systemintptr));
			m_ClearBufferuiv_1 = (GlDelegate_uint_int_refcolor4ui)GetFunctionDelegate("glClearBufferuiv", typeof(GlDelegate_uint_int_refcolor4ui));
			m_ClearBufferuiv_2 = (GlDelegate_uint_int_refuint)GetFunctionDelegate("glClearBufferuiv", typeof(GlDelegate_uint_int_refuint));
			m_ClearColor_0 = (GlDelegate_float_float_float_float)GetFunctionDelegate("glClearColor", typeof(GlDelegate_float_float_float_float));
			m_ClearColor_1 = (GlDelegate_color4)GetFunctionDelegate("glClearColor", typeof(GlDelegate_color4));
			m_ClearDepth_0 = (GlDelegate_double)GetFunctionDelegate("glClearDepth", typeof(GlDelegate_double));
			m_ClearStencil_0 = (GlDelegate_int)GetFunctionDelegate("glClearStencil", typeof(GlDelegate_int));
			m_ClientWaitSync_0 = (GlDelegate_systemintptr_uint_ulong_Returns_uint)GetFunctionDelegate("glClientWaitSync", typeof(GlDelegate_systemintptr_uint_ulong_Returns_uint));
			m_ColorMask_0 = (GlDelegate_bool_bool_bool_bool)GetFunctionDelegate("glColorMask", typeof(GlDelegate_bool_bool_bool_bool));
			m_ColorMaski_0 = (GlDelegate_uint_bool_bool_bool_bool)GetFunctionDelegate("glColorMaski", typeof(GlDelegate_uint_bool_bool_bool_bool));
			m_CompileShader_0 = (GlDelegate_uint)GetFunctionDelegate("glCompileShader", typeof(GlDelegate_uint));
			m_CompressedTexImage1D_0 = (GlDelegate_uint_int_uint_int_int_int_systemintptr)GetFunctionDelegate("glCompressedTexImage1D", typeof(GlDelegate_uint_int_uint_int_int_int_systemintptr));
			m_CompressedTexImage2D_0 = (GlDelegate_uint_int_uint_int_int_int_int_systemintptr)GetFunctionDelegate("glCompressedTexImage2D", typeof(GlDelegate_uint_int_uint_int_int_int_int_systemintptr));
			m_CompressedTexImage3D_0 = (GlDelegate_uint_int_uint_int_int_int_int_int_systemintptr)GetFunctionDelegate("glCompressedTexImage3D", typeof(GlDelegate_uint_int_uint_int_int_int_int_int_systemintptr));
			m_CompressedTexSubImage1D_0 = (GlDelegate_uint_int_int_int_uint_int_systemintptr)GetFunctionDelegate("glCompressedTexSubImage1D", typeof(GlDelegate_uint_int_int_int_uint_int_systemintptr));
			m_CompressedTexSubImage2D_0 = (GlDelegate_uint_int_int_int_int_int_uint_int_systemintptr)GetFunctionDelegate("glCompressedTexSubImage2D", typeof(GlDelegate_uint_int_int_int_int_int_uint_int_systemintptr));
			m_CompressedTexSubImage2D_1 = (GlDelegate_uint_int_box2i_uint_int_systemintptr)GetFunctionDelegate("glCompressedTexSubImage2D", typeof(GlDelegate_uint_int_box2i_uint_int_systemintptr));
			m_CompressedTexSubImage3D_0 = (GlDelegate_uint_int_int_int_int_int_int_int_uint_int_systemintptr)GetFunctionDelegate("glCompressedTexSubImage3D", typeof(GlDelegate_uint_int_int_int_int_int_int_int_uint_int_systemintptr));
			m_CompressedTexSubImage3D_1 = (GlDelegate_uint_int_box3i_uint_int_systemintptr)GetFunctionDelegate("glCompressedTexSubImage3D", typeof(GlDelegate_uint_int_box3i_uint_int_systemintptr));
			m_CopyBufferSubData_0 = (GlDelegate_uint_uint_systemintptr_systemintptr_systemintptr)GetFunctionDelegate("glCopyBufferSubData", typeof(GlDelegate_uint_uint_systemintptr_systemintptr_systemintptr));
			m_CopyTexImage1D_0 = (GlDelegate_uint_int_uint_int_int_int_int)GetFunctionDelegate("glCopyTexImage1D", typeof(GlDelegate_uint_int_uint_int_int_int_int));
			m_CopyTexImage1D_1 = (GlDelegate_uint_int_uint_vector2i_int_int)GetFunctionDelegate("glCopyTexImage1D", typeof(GlDelegate_uint_int_uint_vector2i_int_int));
			m_CopyTexImage2D_0 = (GlDelegate_uint_int_uint_int_int_int_int_int)GetFunctionDelegate("glCopyTexImage2D", typeof(GlDelegate_uint_int_uint_int_int_int_int_int));
			m_CopyTexImage2D_1 = (GlDelegate_uint_int_uint_vector2i_vector2i_int)GetFunctionDelegate("glCopyTexImage2D", typeof(GlDelegate_uint_int_uint_vector2i_vector2i_int));
			m_CopyTexImage2D_2 = (GlDelegate_uint_int_uint_box2i_int)GetFunctionDelegate("glCopyTexImage2D", typeof(GlDelegate_uint_int_uint_box2i_int));
			m_CopyTexSubImage1D_0 = (GlDelegate_uint_int_int_int_int_int)GetFunctionDelegate("glCopyTexSubImage1D", typeof(GlDelegate_uint_int_int_int_int_int));
			m_CopyTexSubImage1D_1 = (GlDelegate_uint_int_int_vector2i_int)GetFunctionDelegate("glCopyTexSubImage1D", typeof(GlDelegate_uint_int_int_vector2i_int));
			m_CopyTexSubImage2D_0 = (GlDelegate_uint_int_int_int_int_int_int_int)GetFunctionDelegate("glCopyTexSubImage2D", typeof(GlDelegate_uint_int_int_int_int_int_int_int));
			m_CopyTexSubImage2D_1 = (GlDelegate_uint_int_vector2i_vector2i_vector2i)GetFunctionDelegate("glCopyTexSubImage2D", typeof(GlDelegate_uint_int_vector2i_vector2i_vector2i));
			m_CopyTexSubImage3D_0 = (GlDelegate_uint_int_int_int_int_int_int_int_int)GetFunctionDelegate("glCopyTexSubImage3D", typeof(GlDelegate_uint_int_int_int_int_int_int_int_int));
			m_CopyTexSubImage3D_1 = (GlDelegate_uint_int_vector3i_vector2i_vector2i)GetFunctionDelegate("glCopyTexSubImage3D", typeof(GlDelegate_uint_int_vector3i_vector2i_vector2i));
			m_CreateProgram_0 = (GlDelegate_Returns_uint)GetFunctionDelegate("glCreateProgram", typeof(GlDelegate_Returns_uint));
			m_CreateShader_0 = (GlDelegate_uint_Returns_uint)GetFunctionDelegate("glCreateShader", typeof(GlDelegate_uint_Returns_uint));
			m_CullFace_0 = (GlDelegate_uint)GetFunctionDelegate("glCullFace", typeof(GlDelegate_uint));
			m_DeleteBuffers_0 = (GlDelegate_int_systemintptr)GetFunctionDelegate("glDeleteBuffers", typeof(GlDelegate_int_systemintptr));
			m_DeleteBuffers_1 = (GlDelegate_int_uintarray)GetFunctionDelegate("glDeleteBuffers", typeof(GlDelegate_int_uintarray));
			m_DeleteBuffers_2 = (GlDelegate_int_refuint)GetFunctionDelegate("glDeleteBuffers", typeof(GlDelegate_int_refuint));
			m_DeleteFramebuffers_0 = (GlDelegate_int_systemintptr)GetFunctionDelegate("glDeleteFramebuffers", typeof(GlDelegate_int_systemintptr));
			m_DeleteFramebuffers_1 = (GlDelegate_int_uintarray)GetFunctionDelegate("glDeleteFramebuffers", typeof(GlDelegate_int_uintarray));
			m_DeleteFramebuffers_2 = (GlDelegate_int_refuint)GetFunctionDelegate("glDeleteFramebuffers", typeof(GlDelegate_int_refuint));
			m_DeleteProgram_0 = (GlDelegate_uint)GetFunctionDelegate("glDeleteProgram", typeof(GlDelegate_uint));
			m_DeleteQueries_0 = (GlDelegate_int_systemintptr)GetFunctionDelegate("glDeleteQueries", typeof(GlDelegate_int_systemintptr));
			m_DeleteQueries_1 = (GlDelegate_int_uintarray)GetFunctionDelegate("glDeleteQueries", typeof(GlDelegate_int_uintarray));
			m_DeleteQueries_2 = (GlDelegate_int_refuint)GetFunctionDelegate("glDeleteQueries", typeof(GlDelegate_int_refuint));
			m_DeleteRenderbuffers_0 = (GlDelegate_int_systemintptr)GetFunctionDelegate("glDeleteRenderbuffers", typeof(GlDelegate_int_systemintptr));
			m_DeleteRenderbuffers_1 = (GlDelegate_int_uintarray)GetFunctionDelegate("glDeleteRenderbuffers", typeof(GlDelegate_int_uintarray));
			m_DeleteRenderbuffers_2 = (GlDelegate_int_refuint)GetFunctionDelegate("glDeleteRenderbuffers", typeof(GlDelegate_int_refuint));
			m_DeleteShader_0 = (GlDelegate_uint)GetFunctionDelegate("glDeleteShader", typeof(GlDelegate_uint));
			m_DeleteSync_0 = (GlDelegate_systemintptr)GetFunctionDelegate("glDeleteSync", typeof(GlDelegate_systemintptr));
			m_DeleteTextures_0 = (GlDelegate_int_systemintptr)GetFunctionDelegate("glDeleteTextures", typeof(GlDelegate_int_systemintptr));
			m_DeleteTextures_1 = (GlDelegate_int_uintarray)GetFunctionDelegate("glDeleteTextures", typeof(GlDelegate_int_uintarray));
			m_DeleteTextures_2 = (GlDelegate_int_refuint)GetFunctionDelegate("glDeleteTextures", typeof(GlDelegate_int_refuint));
			m_DeleteVertexArrays_0 = (GlDelegate_int_systemintptr)GetFunctionDelegate("glDeleteVertexArrays", typeof(GlDelegate_int_systemintptr));
			m_DeleteVertexArrays_1 = (GlDelegate_int_uintarray)GetFunctionDelegate("glDeleteVertexArrays", typeof(GlDelegate_int_uintarray));
			m_DeleteVertexArrays_2 = (GlDelegate_int_refuint)GetFunctionDelegate("glDeleteVertexArrays", typeof(GlDelegate_int_refuint));
			m_DepthFunc_0 = (GlDelegate_uint)GetFunctionDelegate("glDepthFunc", typeof(GlDelegate_uint));
			m_DepthMask_0 = (GlDelegate_bool)GetFunctionDelegate("glDepthMask", typeof(GlDelegate_bool));
			m_DepthRange_0 = (GlDelegate_double_double)GetFunctionDelegate("glDepthRange", typeof(GlDelegate_double_double));
			m_DetachShader_0 = (GlDelegate_uint_uint)GetFunctionDelegate("glDetachShader", typeof(GlDelegate_uint_uint));
			m_Disable_0 = (GlDelegate_uint)GetFunctionDelegate("glDisable", typeof(GlDelegate_uint));
			m_Disablei_0 = (GlDelegate_uint_uint)GetFunctionDelegate("glDisablei", typeof(GlDelegate_uint_uint));
			m_DisableVertexAttribArray_0 = (GlDelegate_uint)GetFunctionDelegate("glDisableVertexAttribArray", typeof(GlDelegate_uint));
			m_DrawArrays_0 = (GlDelegate_uint_int_int)GetFunctionDelegate("glDrawArrays", typeof(GlDelegate_uint_int_int));
			m_DrawArraysInstanced_0 = (GlDelegate_uint_int_int_int)GetFunctionDelegate("glDrawArraysInstanced", typeof(GlDelegate_uint_int_int_int));
			m_DrawBuffer_0 = (GlDelegate_uint)GetFunctionDelegate("glDrawBuffer", typeof(GlDelegate_uint));
			m_DrawBuffers_0 = (GlDelegate_int_systemintptr)GetFunctionDelegate("glDrawBuffers", typeof(GlDelegate_int_systemintptr));
			m_DrawBuffers_1 = (GlDelegate_int_uintarray)GetFunctionDelegate("glDrawBuffers", typeof(GlDelegate_int_uintarray));
			m_DrawBuffers_2 = (GlDelegate_int_refuint)GetFunctionDelegate("glDrawBuffers", typeof(GlDelegate_int_refuint));
			m_DrawElements_0 = (GlDelegate_uint_int_uint_systemintptr)GetFunctionDelegate("glDrawElements", typeof(GlDelegate_uint_int_uint_systemintptr));
			m_DrawElements_1 = (GlDelegate_uint_int_uint_bytearray)GetFunctionDelegate("glDrawElements", typeof(GlDelegate_uint_int_uint_bytearray));
			m_DrawElements_2 = (GlDelegate_uint_int_uint_ushortarray)GetFunctionDelegate("glDrawElements", typeof(GlDelegate_uint_int_uint_ushortarray));
			m_DrawElements_3 = (GlDelegate_uint_int_uint_uintarray)GetFunctionDelegate("glDrawElements", typeof(GlDelegate_uint_int_uint_uintarray));
			m_DrawElementsBaseVertex_0 = (GlDelegate_uint_int_uint_systemintptr_int)GetFunctionDelegate("glDrawElementsBaseVertex", typeof(GlDelegate_uint_int_uint_systemintptr_int));
			m_DrawElementsBaseVertex_1 = (GlDelegate_uint_int_uint_bytearray_int)GetFunctionDelegate("glDrawElementsBaseVertex", typeof(GlDelegate_uint_int_uint_bytearray_int));
			m_DrawElementsBaseVertex_2 = (GlDelegate_uint_int_uint_ushortarray_int)GetFunctionDelegate("glDrawElementsBaseVertex", typeof(GlDelegate_uint_int_uint_ushortarray_int));
			m_DrawElementsBaseVertex_3 = (GlDelegate_uint_int_uint_uintarray_int)GetFunctionDelegate("glDrawElementsBaseVertex", typeof(GlDelegate_uint_int_uint_uintarray_int));
			m_DrawElementsInstanced_0 = (GlDelegate_uint_int_uint_systemintptr_int)GetFunctionDelegate("glDrawElementsInstanced", typeof(GlDelegate_uint_int_uint_systemintptr_int));
			m_DrawElementsInstanced_1 = (GlDelegate_uint_int_uint_bytearray_int)GetFunctionDelegate("glDrawElementsInstanced", typeof(GlDelegate_uint_int_uint_bytearray_int));
			m_DrawElementsInstanced_2 = (GlDelegate_uint_int_uint_ushortarray_int)GetFunctionDelegate("glDrawElementsInstanced", typeof(GlDelegate_uint_int_uint_ushortarray_int));
			m_DrawElementsInstanced_3 = (GlDelegate_uint_int_uint_uintarray_int)GetFunctionDelegate("glDrawElementsInstanced", typeof(GlDelegate_uint_int_uint_uintarray_int));
			m_DrawElementsInstancedBaseVertex_0 = (GlDelegate_uint_int_uint_systemintptr_int_int)GetFunctionDelegate("glDrawElementsInstancedBaseVertex", typeof(GlDelegate_uint_int_uint_systemintptr_int_int));
			m_DrawElementsInstancedBaseVertex_1 = (GlDelegate_uint_int_uint_bytearray_int_int)GetFunctionDelegate("glDrawElementsInstancedBaseVertex", typeof(GlDelegate_uint_int_uint_bytearray_int_int));
			m_DrawElementsInstancedBaseVertex_2 = (GlDelegate_uint_int_uint_ushortarray_int_int)GetFunctionDelegate("glDrawElementsInstancedBaseVertex", typeof(GlDelegate_uint_int_uint_ushortarray_int_int));
			m_DrawElementsInstancedBaseVertex_3 = (GlDelegate_uint_int_uint_uintarray_int_int)GetFunctionDelegate("glDrawElementsInstancedBaseVertex", typeof(GlDelegate_uint_int_uint_uintarray_int_int));
			m_DrawRangeElements_0 = (GlDelegate_uint_uint_uint_int_uint_systemintptr)GetFunctionDelegate("glDrawRangeElements", typeof(GlDelegate_uint_uint_uint_int_uint_systemintptr));
			m_DrawRangeElements_1 = (GlDelegate_uint_uint_uint_int_uint_bytearray)GetFunctionDelegate("glDrawRangeElements", typeof(GlDelegate_uint_uint_uint_int_uint_bytearray));
			m_DrawRangeElements_2 = (GlDelegate_uint_uint_uint_int_uint_ushortarray)GetFunctionDelegate("glDrawRangeElements", typeof(GlDelegate_uint_uint_uint_int_uint_ushortarray));
			m_DrawRangeElements_3 = (GlDelegate_uint_uint_uint_int_uint_uintarray)GetFunctionDelegate("glDrawRangeElements", typeof(GlDelegate_uint_uint_uint_int_uint_uintarray));
			m_DrawRangeElementsBaseVertex_0 = (GlDelegate_uint_uint_uint_int_uint_systemintptr_int)GetFunctionDelegate("glDrawRangeElementsBaseVertex", typeof(GlDelegate_uint_uint_uint_int_uint_systemintptr_int));
			m_DrawRangeElementsBaseVertex_1 = (GlDelegate_uint_uint_uint_int_uint_bytearray_int)GetFunctionDelegate("glDrawRangeElementsBaseVertex", typeof(GlDelegate_uint_uint_uint_int_uint_bytearray_int));
			m_DrawRangeElementsBaseVertex_2 = (GlDelegate_uint_uint_uint_int_uint_ushortarray_int)GetFunctionDelegate("glDrawRangeElementsBaseVertex", typeof(GlDelegate_uint_uint_uint_int_uint_ushortarray_int));
			m_DrawRangeElementsBaseVertex_3 = (GlDelegate_uint_uint_uint_int_uint_uintarray_int)GetFunctionDelegate("glDrawRangeElementsBaseVertex", typeof(GlDelegate_uint_uint_uint_int_uint_uintarray_int));
			m_Enable_0 = (GlDelegate_uint)GetFunctionDelegate("glEnable", typeof(GlDelegate_uint));
			m_Enablei_0 = (GlDelegate_uint_uint)GetFunctionDelegate("glEnablei", typeof(GlDelegate_uint_uint));
			m_EnableVertexAttribArray_0 = (GlDelegate_uint)GetFunctionDelegate("glEnableVertexAttribArray", typeof(GlDelegate_uint));
			m_EndConditionalRender_0 = (GlDelegate)GetFunctionDelegate("glEndConditionalRender", typeof(GlDelegate));
			m_EndQuery_0 = (GlDelegate_uint)GetFunctionDelegate("glEndQuery", typeof(GlDelegate_uint));
			m_EndTransformFeedback_0 = (GlDelegate)GetFunctionDelegate("glEndTransformFeedback", typeof(GlDelegate));
			m_FenceSync_0 = (GlDelegate_uint_uint_Returns_systemintptr)GetFunctionDelegate("glFenceSync", typeof(GlDelegate_uint_uint_Returns_systemintptr));
			m_Finish_0 = (GlDelegate)GetFunctionDelegate("glFinish", typeof(GlDelegate));
			m_Flush_0 = (GlDelegate)GetFunctionDelegate("glFlush", typeof(GlDelegate));
			m_FlushMappedBufferRange_0 = (GlDelegate_uint_systemintptr_systemintptr)GetFunctionDelegate("glFlushMappedBufferRange", typeof(GlDelegate_uint_systemintptr_systemintptr));
			m_FramebufferRenderbuffer_0 = (GlDelegate_uint_uint_uint_uint)GetFunctionDelegate("glFramebufferRenderbuffer", typeof(GlDelegate_uint_uint_uint_uint));
			m_FramebufferTexture_0 = (GlDelegate_uint_uint_uint_int)GetFunctionDelegate("glFramebufferTexture", typeof(GlDelegate_uint_uint_uint_int));
			m_FramebufferTexture1D_0 = (GlDelegate_uint_uint_uint_uint_int)GetFunctionDelegate("glFramebufferTexture1D", typeof(GlDelegate_uint_uint_uint_uint_int));
			m_FramebufferTexture2D_0 = (GlDelegate_uint_uint_uint_uint_int)GetFunctionDelegate("glFramebufferTexture2D", typeof(GlDelegate_uint_uint_uint_uint_int));
			m_FramebufferTexture3D_0 = (GlDelegate_uint_uint_uint_uint_int_int)GetFunctionDelegate("glFramebufferTexture3D", typeof(GlDelegate_uint_uint_uint_uint_int_int));
			m_FramebufferTextureLayer_0 = (GlDelegate_uint_uint_uint_int_int)GetFunctionDelegate("glFramebufferTextureLayer", typeof(GlDelegate_uint_uint_uint_int_int));
			m_FrontFace_0 = (GlDelegate_uint)GetFunctionDelegate("glFrontFace", typeof(GlDelegate_uint));
			m_GenBuffers_0 = (GlDelegate_int_systemintptr)GetFunctionDelegate("glGenBuffers", typeof(GlDelegate_int_systemintptr));
			m_GenBuffers_1 = (GlDelegate_int_uintarray)GetFunctionDelegate("glGenBuffers", typeof(GlDelegate_int_uintarray));
			m_GenBuffers_2 = (GlDelegate_int_outuint)GetFunctionDelegate("glGenBuffers", typeof(GlDelegate_int_outuint));
			m_GenerateMipmap_0 = (GlDelegate_uint)GetFunctionDelegate("glGenerateMipmap", typeof(GlDelegate_uint));
			m_GenFramebuffers_0 = (GlDelegate_int_systemintptr)GetFunctionDelegate("glGenFramebuffers", typeof(GlDelegate_int_systemintptr));
			m_GenFramebuffers_1 = (GlDelegate_int_uintarray)GetFunctionDelegate("glGenFramebuffers", typeof(GlDelegate_int_uintarray));
			m_GenFramebuffers_2 = (GlDelegate_int_outuint)GetFunctionDelegate("glGenFramebuffers", typeof(GlDelegate_int_outuint));
			m_GenQueries_0 = (GlDelegate_int_systemintptr)GetFunctionDelegate("glGenQueries", typeof(GlDelegate_int_systemintptr));
			m_GenQueries_1 = (GlDelegate_int_uintarray)GetFunctionDelegate("glGenQueries", typeof(GlDelegate_int_uintarray));
			m_GenQueries_2 = (GlDelegate_int_outuint)GetFunctionDelegate("glGenQueries", typeof(GlDelegate_int_outuint));
			m_GenRenderbuffers_0 = (GlDelegate_int_systemintptr)GetFunctionDelegate("glGenRenderbuffers", typeof(GlDelegate_int_systemintptr));
			m_GenRenderbuffers_1 = (GlDelegate_int_uintarray)GetFunctionDelegate("glGenRenderbuffers", typeof(GlDelegate_int_uintarray));
			m_GenRenderbuffers_2 = (GlDelegate_int_outuint)GetFunctionDelegate("glGenRenderbuffers", typeof(GlDelegate_int_outuint));
			m_GenTextures_0 = (GlDelegate_int_systemintptr)GetFunctionDelegate("glGenTextures", typeof(GlDelegate_int_systemintptr));
			m_GenTextures_1 = (GlDelegate_int_uintarray)GetFunctionDelegate("glGenTextures", typeof(GlDelegate_int_uintarray));
			m_GenTextures_2 = (GlDelegate_int_outuint)GetFunctionDelegate("glGenTextures", typeof(GlDelegate_int_outuint));
			m_GenVertexArrays_0 = (GlDelegate_int_systemintptr)GetFunctionDelegate("glGenVertexArrays", typeof(GlDelegate_int_systemintptr));
			m_GenVertexArrays_1 = (GlDelegate_int_uintarray)GetFunctionDelegate("glGenVertexArrays", typeof(GlDelegate_int_uintarray));
			m_GenVertexArrays_2 = (GlDelegate_int_outuint)GetFunctionDelegate("glGenVertexArrays", typeof(GlDelegate_int_outuint));
			m_GetActiveAttrib_0 = (GlDelegate_uint_uint_int_systemintptr_systemintptr_systemintptr_string)GetFunctionDelegate("glGetActiveAttrib", typeof(GlDelegate_uint_uint_int_systemintptr_systemintptr_systemintptr_string));
			m_GetActiveAttrib_1 = (GlDelegate_uint_uint_int_outint_outint_outuint_bytearray)GetFunctionDelegate("glGetActiveAttrib", typeof(GlDelegate_uint_uint_int_outint_outint_outuint_bytearray));
			m_GetActiveUniform_0 = (GlDelegate_uint_uint_int_systemintptr_systemintptr_systemintptr_string)GetFunctionDelegate("glGetActiveUniform", typeof(GlDelegate_uint_uint_int_systemintptr_systemintptr_systemintptr_string));
			m_GetActiveUniform_1 = (GlDelegate_uint_uint_int_outint_outint_outuint_bytearray)GetFunctionDelegate("glGetActiveUniform", typeof(GlDelegate_uint_uint_int_outint_outint_outuint_bytearray));
			m_GetActiveUniformBlockiv_0 = (GlDelegate_uint_uint_uint_systemintptr)GetFunctionDelegate("glGetActiveUniformBlockiv", typeof(GlDelegate_uint_uint_uint_systemintptr));
			m_GetActiveUniformBlockiv_1 = (GlDelegate_uint_uint_uint_intarray)GetFunctionDelegate("glGetActiveUniformBlockiv", typeof(GlDelegate_uint_uint_uint_intarray));
			m_GetActiveUniformBlockiv_2 = (GlDelegate_uint_uint_uint_outint)GetFunctionDelegate("glGetActiveUniformBlockiv", typeof(GlDelegate_uint_uint_uint_outint));
			m_GetActiveUniformBlockName_0 = (GlDelegate_uint_uint_int_systemintptr_systemintptr)GetFunctionDelegate("glGetActiveUniformBlockName", typeof(GlDelegate_uint_uint_int_systemintptr_systemintptr));
			m_GetActiveUniformBlockName_1 = (GlDelegate_uint_uint_int_outint_bytearray)GetFunctionDelegate("glGetActiveUniformBlockName", typeof(GlDelegate_uint_uint_int_outint_bytearray));
			m_GetActiveUniformName_0 = (GlDelegate_uint_uint_int_systemintptr_systemintptr)GetFunctionDelegate("glGetActiveUniformName", typeof(GlDelegate_uint_uint_int_systemintptr_systemintptr));
			m_GetActiveUniformName_1 = (GlDelegate_uint_uint_int_outint_bytearray)GetFunctionDelegate("glGetActiveUniformName", typeof(GlDelegate_uint_uint_int_outint_bytearray));
			m_GetActiveUniformsiv_0 = (GlDelegate_uint_int_systemintptr_uint_systemintptr)GetFunctionDelegate("glGetActiveUniformsiv", typeof(GlDelegate_uint_int_systemintptr_uint_systemintptr));
			m_GetActiveUniformsiv_1 = (GlDelegate_uint_int_uintarray_uint_intarray)GetFunctionDelegate("glGetActiveUniformsiv", typeof(GlDelegate_uint_int_uintarray_uint_intarray));
			m_GetActiveUniformsiv_2 = (GlDelegate_uint_int_outint_uint_intarray)GetFunctionDelegate("glGetActiveUniformsiv", typeof(GlDelegate_uint_int_outint_uint_intarray));
			m_GetActiveUniformsiv_3 = (GlDelegate_uint_int_uintarray_uint_refint)GetFunctionDelegate("glGetActiveUniformsiv", typeof(GlDelegate_uint_int_uintarray_uint_refint));
			m_GetActiveUniformsiv_4 = (GlDelegate_uint_int_outint_uint_refint)GetFunctionDelegate("glGetActiveUniformsiv", typeof(GlDelegate_uint_int_outint_uint_refint));
			m_GetAttachedShaders_0 = (GlDelegate_uint_int_systemintptr_systemintptr)GetFunctionDelegate("glGetAttachedShaders", typeof(GlDelegate_uint_int_systemintptr_systemintptr));
			m_GetAttachedShaders_1 = (GlDelegate_uint_int_uint_uintarray)GetFunctionDelegate("glGetAttachedShaders", typeof(GlDelegate_uint_int_uint_uintarray));
			m_GetAttribLocation_0 = (GlDelegate_uint_systemintptr_Returns_int)GetFunctionDelegate("glGetAttribLocation", typeof(GlDelegate_uint_systemintptr_Returns_int));
			m_GetAttribLocation_1 = (GlDelegate_uint_bytearray_Returns_int)GetFunctionDelegate("glGetAttribLocation", typeof(GlDelegate_uint_bytearray_Returns_int));
			m_GetAttribLocation_2 = (GlDelegate_uint_string_Returns_int)GetFunctionDelegate("glGetAttribLocation", typeof(GlDelegate_uint_string_Returns_int));
			m_GetBooleani_v_0 = (GlDelegate_uint_uint_systemintptr)GetFunctionDelegate("glGetBooleani_v", typeof(GlDelegate_uint_uint_systemintptr));
			m_GetBooleani_v_1 = (GlDelegate_uint_uint_outbool)GetFunctionDelegate("glGetBooleani_v", typeof(GlDelegate_uint_uint_outbool));
			m_GetBooleanv_0 = (GlDelegate_uint_systemintptr)GetFunctionDelegate("glGetBooleanv", typeof(GlDelegate_uint_systemintptr));
			m_GetBooleanv_1 = (GlDelegate_uint_outbool)GetFunctionDelegate("glGetBooleanv", typeof(GlDelegate_uint_outbool));
			m_GetBufferParameteri64v_0 = (GlDelegate_uint_uint_systemintptr)GetFunctionDelegate("glGetBufferParameteri64v", typeof(GlDelegate_uint_uint_systemintptr));
			m_GetBufferParameteri64v_1 = (GlDelegate_uint_uint_outlong)GetFunctionDelegate("glGetBufferParameteri64v", typeof(GlDelegate_uint_uint_outlong));
			m_GetBufferParameteriv_0 = (GlDelegate_uint_uint_systemintptr)GetFunctionDelegate("glGetBufferParameteriv", typeof(GlDelegate_uint_uint_systemintptr));
			m_GetBufferParameteriv_1 = (GlDelegate_uint_uint_outint)GetFunctionDelegate("glGetBufferParameteriv", typeof(GlDelegate_uint_uint_outint));
			m_GetBufferPointerv_0 = (GlDelegate_uint_uint_systemintptr)GetFunctionDelegate("glGetBufferPointerv", typeof(GlDelegate_uint_uint_systemintptr));
			m_GetBufferPointerv_1 = (GlDelegate_uint_uint_outsystemintptr)GetFunctionDelegate("glGetBufferPointerv", typeof(GlDelegate_uint_uint_outsystemintptr));
			m_GetBufferSubData_0 = (GlDelegate_uint_systemintptr_systemintptr_systemintptr)GetFunctionDelegate("glGetBufferSubData", typeof(GlDelegate_uint_systemintptr_systemintptr_systemintptr));
			m_GetCompressedTexImage_0 = (GlDelegate_uint_int_systemintptr)GetFunctionDelegate("glGetCompressedTexImage", typeof(GlDelegate_uint_int_systemintptr));
			m_GetDoublev_0 = (GlDelegate_uint_systemintptr)GetFunctionDelegate("glGetDoublev", typeof(GlDelegate_uint_systemintptr));
			m_GetDoublev_1 = (GlDelegate_uint_doublearray)GetFunctionDelegate("glGetDoublev", typeof(GlDelegate_uint_doublearray));
			m_GetDoublev_2 = (GlDelegate_uint_outdouble)GetFunctionDelegate("glGetDoublev", typeof(GlDelegate_uint_outdouble));
			m_GetDoublev_3 = (GlDelegate_uint_outvector2d)GetFunctionDelegate("glGetDoublev", typeof(GlDelegate_uint_outvector2d));
			m_GetDoublev_4 = (GlDelegate_uint_outvector3d)GetFunctionDelegate("glGetDoublev", typeof(GlDelegate_uint_outvector3d));
			m_GetDoublev_5 = (GlDelegate_uint_outvector4d)GetFunctionDelegate("glGetDoublev", typeof(GlDelegate_uint_outvector4d));
			m_GetDoublev_6 = (GlDelegate_uint_outcolor3d)GetFunctionDelegate("glGetDoublev", typeof(GlDelegate_uint_outcolor3d));
			m_GetDoublev_7 = (GlDelegate_uint_outcolor4d)GetFunctionDelegate("glGetDoublev", typeof(GlDelegate_uint_outcolor4d));
			m_GetDoublev_8 = (GlDelegate_uint_outbox2d)GetFunctionDelegate("glGetDoublev", typeof(GlDelegate_uint_outbox2d));
			m_GetDoublev_9 = (GlDelegate_uint_outbox3d)GetFunctionDelegate("glGetDoublev", typeof(GlDelegate_uint_outbox3d));
			m_GetError_0 = (GlDelegate_Returns_uint)GetFunctionDelegate("glGetError", typeof(GlDelegate_Returns_uint));
			m_GetFloatv_0 = (GlDelegate_uint_systemintptr)GetFunctionDelegate("glGetFloatv", typeof(GlDelegate_uint_systemintptr));
			m_GetFloatv_1 = (GlDelegate_uint_floatarray)GetFunctionDelegate("glGetFloatv", typeof(GlDelegate_uint_floatarray));
			m_GetFloatv_2 = (GlDelegate_uint_outfloat)GetFunctionDelegate("glGetFloatv", typeof(GlDelegate_uint_outfloat));
			m_GetFloatv_3 = (GlDelegate_uint_outvector2)GetFunctionDelegate("glGetFloatv", typeof(GlDelegate_uint_outvector2));
			m_GetFloatv_4 = (GlDelegate_uint_outvector3)GetFunctionDelegate("glGetFloatv", typeof(GlDelegate_uint_outvector3));
			m_GetFloatv_5 = (GlDelegate_uint_outvector4)GetFunctionDelegate("glGetFloatv", typeof(GlDelegate_uint_outvector4));
			m_GetFloatv_6 = (GlDelegate_uint_outcolor3)GetFunctionDelegate("glGetFloatv", typeof(GlDelegate_uint_outcolor3));
			m_GetFloatv_7 = (GlDelegate_uint_outcolor4)GetFunctionDelegate("glGetFloatv", typeof(GlDelegate_uint_outcolor4));
			m_GetFloatv_8 = (GlDelegate_uint_outbox2)GetFunctionDelegate("glGetFloatv", typeof(GlDelegate_uint_outbox2));
			m_GetFloatv_9 = (GlDelegate_uint_outbox3)GetFunctionDelegate("glGetFloatv", typeof(GlDelegate_uint_outbox3));
			m_GetFragDataLocation_0 = (GlDelegate_uint_string_Returns_int)GetFunctionDelegate("glGetFragDataLocation", typeof(GlDelegate_uint_string_Returns_int));
			m_GetFramebufferAttachmentParameteriv_0 = (GlDelegate_uint_uint_uint_systemintptr)GetFunctionDelegate("glGetFramebufferAttachmentParameteriv", typeof(GlDelegate_uint_uint_uint_systemintptr));
			m_GetFramebufferAttachmentParameteriv_1 = (GlDelegate_uint_uint_uint_outint)GetFunctionDelegate("glGetFramebufferAttachmentParameteriv", typeof(GlDelegate_uint_uint_uint_outint));
			m_GetInteger64i_v_0 = (GlDelegate_uint_uint_systemintptr)GetFunctionDelegate("glGetInteger64i_v", typeof(GlDelegate_uint_uint_systemintptr));
			m_GetInteger64i_v_1 = (GlDelegate_uint_uint_longarray)GetFunctionDelegate("glGetInteger64i_v", typeof(GlDelegate_uint_uint_longarray));
			m_GetInteger64i_v_2 = (GlDelegate_uint_uint_outlong)GetFunctionDelegate("glGetInteger64i_v", typeof(GlDelegate_uint_uint_outlong));
			m_GetInteger64v_0 = (GlDelegate_uint_systemintptr)GetFunctionDelegate("glGetInteger64v", typeof(GlDelegate_uint_systemintptr));
			m_GetInteger64v_1 = (GlDelegate_uint_longarray)GetFunctionDelegate("glGetInteger64v", typeof(GlDelegate_uint_longarray));
			m_GetInteger64v_2 = (GlDelegate_uint_outlong)GetFunctionDelegate("glGetInteger64v", typeof(GlDelegate_uint_outlong));
			m_GetIntegeri_v_0 = (GlDelegate_uint_uint_systemintptr)GetFunctionDelegate("glGetIntegeri_v", typeof(GlDelegate_uint_uint_systemintptr));
			m_GetIntegeri_v_1 = (GlDelegate_uint_uint_intarray)GetFunctionDelegate("glGetIntegeri_v", typeof(GlDelegate_uint_uint_intarray));
			m_GetIntegeri_v_2 = (GlDelegate_uint_uint_outint)GetFunctionDelegate("glGetIntegeri_v", typeof(GlDelegate_uint_uint_outint));
			m_GetIntegerv_0 = (GlDelegate_uint_systemintptr)GetFunctionDelegate("glGetIntegerv", typeof(GlDelegate_uint_systemintptr));
			m_GetIntegerv_1 = (GlDelegate_uint_intarray)GetFunctionDelegate("glGetIntegerv", typeof(GlDelegate_uint_intarray));
			m_GetIntegerv_2 = (GlDelegate_uint_outint)GetFunctionDelegate("glGetIntegerv", typeof(GlDelegate_uint_outint));
			m_GetMultisamplefv_0 = (GlDelegate_uint_uint_systemintptr)GetFunctionDelegate("glGetMultisamplefv", typeof(GlDelegate_uint_uint_systemintptr));
			m_GetMultisamplefv_1 = (GlDelegate_uint_uint_outfloat)GetFunctionDelegate("glGetMultisamplefv", typeof(GlDelegate_uint_uint_outfloat));
			m_GetProgramInfoLog_0 = (GlDelegate_uint_int_systemintptr_string)GetFunctionDelegate("glGetProgramInfoLog", typeof(GlDelegate_uint_int_systemintptr_string));
			m_GetProgramInfoLog_1 = (GlDelegate_uint_int_outint_bytearray)GetFunctionDelegate("glGetProgramInfoLog", typeof(GlDelegate_uint_int_outint_bytearray));
			m_GetProgramiv_0 = (GlDelegate_uint_uint_systemintptr)GetFunctionDelegate("glGetProgramiv", typeof(GlDelegate_uint_uint_systemintptr));
			m_GetProgramiv_1 = (GlDelegate_uint_uint_intarray)GetFunctionDelegate("glGetProgramiv", typeof(GlDelegate_uint_uint_intarray));
			m_GetProgramiv_2 = (GlDelegate_uint_uint_outint)GetFunctionDelegate("glGetProgramiv", typeof(GlDelegate_uint_uint_outint));
			m_GetQueryiv_0 = (GlDelegate_uint_uint_systemintptr)GetFunctionDelegate("glGetQueryiv", typeof(GlDelegate_uint_uint_systemintptr));
			m_GetQueryObjectiv_0 = (GlDelegate_uint_uint_systemintptr)GetFunctionDelegate("glGetQueryObjectiv", typeof(GlDelegate_uint_uint_systemintptr));
			m_GetQueryObjectuiv_0 = (GlDelegate_uint_uint_systemintptr)GetFunctionDelegate("glGetQueryObjectuiv", typeof(GlDelegate_uint_uint_systemintptr));
			m_GetRenderbufferParameteriv_0 = (GlDelegate_uint_uint_systemintptr)GetFunctionDelegate("glGetRenderbufferParameteriv", typeof(GlDelegate_uint_uint_systemintptr));
			m_GetShaderInfoLog_0 = (GlDelegate_uint_int_systemintptr_string)GetFunctionDelegate("glGetShaderInfoLog", typeof(GlDelegate_uint_int_systemintptr_string));
			m_GetShaderInfoLog_1 = (GlDelegate_uint_int_outint_bytearray)GetFunctionDelegate("glGetShaderInfoLog", typeof(GlDelegate_uint_int_outint_bytearray));
			m_GetShaderiv_0 = (GlDelegate_uint_uint_systemintptr)GetFunctionDelegate("glGetShaderiv", typeof(GlDelegate_uint_uint_systemintptr));
			m_GetShaderiv_1 = (GlDelegate_uint_uint_intarray)GetFunctionDelegate("glGetShaderiv", typeof(GlDelegate_uint_uint_intarray));
			m_GetShaderiv_2 = (GlDelegate_uint_uint_outint)GetFunctionDelegate("glGetShaderiv", typeof(GlDelegate_uint_uint_outint));
			m_GetShaderSource_0 = (GlDelegate_uint_int_systemintptr_string)GetFunctionDelegate("glGetShaderSource", typeof(GlDelegate_uint_int_systemintptr_string));
			m_GetString_0 = (GlDelegate_uint_Returns_systemintptr)GetFunctionDelegate("glGetString", typeof(GlDelegate_uint_Returns_systemintptr));
			m_GetStringi_0 = (GlDelegate_uint_uint_Returns_systemintptr)GetFunctionDelegate("glGetStringi", typeof(GlDelegate_uint_uint_Returns_systemintptr));
			m_GetSynciv_0 = (GlDelegate_systemintptr_uint_int_systemintptr_systemintptr)GetFunctionDelegate("glGetSynciv", typeof(GlDelegate_systemintptr_uint_int_systemintptr_systemintptr));
			m_GetTexImage_0 = (GlDelegate_uint_int_uint_uint_systemintptr)GetFunctionDelegate("glGetTexImage", typeof(GlDelegate_uint_int_uint_uint_systemintptr));
			m_GetTexLevelParameterfv_0 = (GlDelegate_uint_int_uint_systemintptr)GetFunctionDelegate("glGetTexLevelParameterfv", typeof(GlDelegate_uint_int_uint_systemintptr));
			m_GetTexLevelParameteriv_0 = (GlDelegate_uint_int_uint_systemintptr)GetFunctionDelegate("glGetTexLevelParameteriv", typeof(GlDelegate_uint_int_uint_systemintptr));
			m_GetTexParameterfv_0 = (GlDelegate_uint_uint_systemintptr)GetFunctionDelegate("glGetTexParameterfv", typeof(GlDelegate_uint_uint_systemintptr));
			m_GetTexParameterIiv_0 = (GlDelegate_uint_uint_systemintptr)GetFunctionDelegate("glGetTexParameterIiv", typeof(GlDelegate_uint_uint_systemintptr));
			m_GetTexParameterIuiv_0 = (GlDelegate_uint_uint_systemintptr)GetFunctionDelegate("glGetTexParameterIuiv", typeof(GlDelegate_uint_uint_systemintptr));
			m_GetTexParameteriv_0 = (GlDelegate_uint_uint_systemintptr)GetFunctionDelegate("glGetTexParameteriv", typeof(GlDelegate_uint_uint_systemintptr));
			m_GetTransformFeedbackVarying_0 = (GlDelegate_uint_uint_int_systemintptr_systemintptr_systemintptr_string)GetFunctionDelegate("glGetTransformFeedbackVarying", typeof(GlDelegate_uint_uint_int_systemintptr_systemintptr_systemintptr_string));
			m_GetUniformBlockIndex_0 = (GlDelegate_uint_string_Returns_uint)GetFunctionDelegate("glGetUniformBlockIndex", typeof(GlDelegate_uint_string_Returns_uint));
			m_GetUniformfv_0 = (GlDelegate_uint_int_systemintptr)GetFunctionDelegate("glGetUniformfv", typeof(GlDelegate_uint_int_systemintptr));
			m_GetUniformIndices_0 = (GlDelegate_uint_int_systemintptr_systemintptr)GetFunctionDelegate("glGetUniformIndices", typeof(GlDelegate_uint_int_systemintptr_systemintptr));
			m_GetUniformiv_0 = (GlDelegate_uint_int_systemintptr)GetFunctionDelegate("glGetUniformiv", typeof(GlDelegate_uint_int_systemintptr));
			m_GetUniformLocation_0 = (GlDelegate_uint_systemintptr_Returns_int)GetFunctionDelegate("glGetUniformLocation", typeof(GlDelegate_uint_systemintptr_Returns_int));
			m_GetUniformLocation_1 = (GlDelegate_uint_bytearray_Returns_int)GetFunctionDelegate("glGetUniformLocation", typeof(GlDelegate_uint_bytearray_Returns_int));
			m_GetUniformLocation_2 = (GlDelegate_uint_string_Returns_int)GetFunctionDelegate("glGetUniformLocation", typeof(GlDelegate_uint_string_Returns_int));
			m_GetUniformuiv_0 = (GlDelegate_uint_int_systemintptr)GetFunctionDelegate("glGetUniformuiv", typeof(GlDelegate_uint_int_systemintptr));
			m_GetVertexAttribdv_0 = (GlDelegate_uint_uint_systemintptr)GetFunctionDelegate("glGetVertexAttribdv", typeof(GlDelegate_uint_uint_systemintptr));
			m_GetVertexAttribfv_0 = (GlDelegate_uint_uint_systemintptr)GetFunctionDelegate("glGetVertexAttribfv", typeof(GlDelegate_uint_uint_systemintptr));
			m_GetVertexAttribIiv_0 = (GlDelegate_uint_uint_systemintptr)GetFunctionDelegate("glGetVertexAttribIiv", typeof(GlDelegate_uint_uint_systemintptr));
			m_GetVertexAttribIuiv_0 = (GlDelegate_uint_uint_systemintptr)GetFunctionDelegate("glGetVertexAttribIuiv", typeof(GlDelegate_uint_uint_systemintptr));
			m_GetVertexAttribiv_0 = (GlDelegate_uint_uint_systemintptr)GetFunctionDelegate("glGetVertexAttribiv", typeof(GlDelegate_uint_uint_systemintptr));
			m_GetVertexAttribPointerv_0 = (GlDelegate_uint_uint_systemintptr)GetFunctionDelegate("glGetVertexAttribPointerv", typeof(GlDelegate_uint_uint_systemintptr));
			m_Hint_0 = (GlDelegate_uint_uint)GetFunctionDelegate("glHint", typeof(GlDelegate_uint_uint));
			m_IsBuffer_0 = (GlDelegate_uint_Returns_bool)GetFunctionDelegate("glIsBuffer", typeof(GlDelegate_uint_Returns_bool));
			m_IsEnabled_0 = (GlDelegate_uint_Returns_bool)GetFunctionDelegate("glIsEnabled", typeof(GlDelegate_uint_Returns_bool));
			m_IsEnabledi_0 = (GlDelegate_uint_uint_Returns_bool)GetFunctionDelegate("glIsEnabledi", typeof(GlDelegate_uint_uint_Returns_bool));
			m_IsFramebuffer_0 = (GlDelegate_uint_Returns_bool)GetFunctionDelegate("glIsFramebuffer", typeof(GlDelegate_uint_Returns_bool));
			m_IsProgram_0 = (GlDelegate_uint_Returns_bool)GetFunctionDelegate("glIsProgram", typeof(GlDelegate_uint_Returns_bool));
			m_IsQuery_0 = (GlDelegate_uint_Returns_bool)GetFunctionDelegate("glIsQuery", typeof(GlDelegate_uint_Returns_bool));
			m_IsRenderbuffer_0 = (GlDelegate_uint_Returns_bool)GetFunctionDelegate("glIsRenderbuffer", typeof(GlDelegate_uint_Returns_bool));
			m_IsShader_0 = (GlDelegate_uint_Returns_bool)GetFunctionDelegate("glIsShader", typeof(GlDelegate_uint_Returns_bool));
			m_IsSync_0 = (GlDelegate_systemintptr_Returns_bool)GetFunctionDelegate("glIsSync", typeof(GlDelegate_systemintptr_Returns_bool));
			m_IsTexture_0 = (GlDelegate_uint_Returns_bool)GetFunctionDelegate("glIsTexture", typeof(GlDelegate_uint_Returns_bool));
			m_IsVertexArray_0 = (GlDelegate_uint_Returns_bool)GetFunctionDelegate("glIsVertexArray", typeof(GlDelegate_uint_Returns_bool));
			m_LineWidth_0 = (GlDelegate_float)GetFunctionDelegate("glLineWidth", typeof(GlDelegate_float));
			m_LinkProgram_0 = (GlDelegate_uint)GetFunctionDelegate("glLinkProgram", typeof(GlDelegate_uint));
			m_LogicOp_0 = (GlDelegate_uint)GetFunctionDelegate("glLogicOp", typeof(GlDelegate_uint));
			m_MapBuffer_0 = (GlDelegate_uint_uint_Returns_systemintptr)GetFunctionDelegate("glMapBuffer", typeof(GlDelegate_uint_uint_Returns_systemintptr));
			m_MapBufferRange_0 = (GlDelegate_uint_systemintptr_systemintptr_uint_Returns_systemintptr)GetFunctionDelegate("glMapBufferRange", typeof(GlDelegate_uint_systemintptr_systemintptr_uint_Returns_systemintptr));
			m_MultiDrawArrays_0 = (GlDelegate_uint_systemintptr_systemintptr_int)GetFunctionDelegate("glMultiDrawArrays", typeof(GlDelegate_uint_systemintptr_systemintptr_int));
			m_MultiDrawElements_0 = (GlDelegate_uint_systemintptr_uint_systemintptr_int)GetFunctionDelegate("glMultiDrawElements", typeof(GlDelegate_uint_systemintptr_uint_systemintptr_int));
			m_MultiDrawElementsBaseVertex_0 = (GlDelegate_uint_systemintptr_uint_systemintptr_int_systemintptr)GetFunctionDelegate("glMultiDrawElementsBaseVertex", typeof(GlDelegate_uint_systemintptr_uint_systemintptr_int_systemintptr));
			m_PixelStoref_0 = (GlDelegate_uint_float)GetFunctionDelegate("glPixelStoref", typeof(GlDelegate_uint_float));
			m_PixelStorei_0 = (GlDelegate_uint_int)GetFunctionDelegate("glPixelStorei", typeof(GlDelegate_uint_int));
			m_PointParameterf_0 = (GlDelegate_uint_float)GetFunctionDelegate("glPointParameterf", typeof(GlDelegate_uint_float));
			m_PointParameterfv_0 = (GlDelegate_uint_systemintptr)GetFunctionDelegate("glPointParameterfv", typeof(GlDelegate_uint_systemintptr));
			m_PointParameteri_0 = (GlDelegate_uint_int)GetFunctionDelegate("glPointParameteri", typeof(GlDelegate_uint_int));
			m_PointParameteriv_0 = (GlDelegate_uint_systemintptr)GetFunctionDelegate("glPointParameteriv", typeof(GlDelegate_uint_systemintptr));
			m_PointSize_0 = (GlDelegate_float)GetFunctionDelegate("glPointSize", typeof(GlDelegate_float));
			m_PolygonMode_0 = (GlDelegate_uint_uint)GetFunctionDelegate("glPolygonMode", typeof(GlDelegate_uint_uint));
			m_PolygonOffset_0 = (GlDelegate_float_float)GetFunctionDelegate("glPolygonOffset", typeof(GlDelegate_float_float));
			m_PrimitiveRestartIndex_0 = (GlDelegate_uint)GetFunctionDelegate("glPrimitiveRestartIndex", typeof(GlDelegate_uint));
			m_ProvokingVertex_0 = (GlDelegate_uint)GetFunctionDelegate("glProvokingVertex", typeof(GlDelegate_uint));
			m_ReadBuffer_0 = (GlDelegate_uint)GetFunctionDelegate("glReadBuffer", typeof(GlDelegate_uint));
			m_ReadPixels_0 = (GlDelegate_int_int_int_int_uint_uint_systemintptr)GetFunctionDelegate("glReadPixels", typeof(GlDelegate_int_int_int_int_uint_uint_systemintptr));
			m_RenderbufferStorage_0 = (GlDelegate_uint_uint_int_int)GetFunctionDelegate("glRenderbufferStorage", typeof(GlDelegate_uint_uint_int_int));
			m_RenderbufferStorageMultisample_0 = (GlDelegate_uint_int_uint_int_int)GetFunctionDelegate("glRenderbufferStorageMultisample", typeof(GlDelegate_uint_int_uint_int_int));
			m_SampleCoverage_0 = (GlDelegate_float_bool)GetFunctionDelegate("glSampleCoverage", typeof(GlDelegate_float_bool));
			m_SampleMaski_0 = (GlDelegate_uint_uint)GetFunctionDelegate("glSampleMaski", typeof(GlDelegate_uint_uint));
			m_Scissor_0 = (GlDelegate_int_int_int_int)GetFunctionDelegate("glScissor", typeof(GlDelegate_int_int_int_int));
			m_ShaderSource_0 = (GlDelegate_uint_int_systemintptr_systemintptr)GetFunctionDelegate("glShaderSource", typeof(GlDelegate_uint_int_systemintptr_systemintptr));
			m_ShaderSource_1 = (GlDelegate_uint_int_intptrarray_intarray)GetFunctionDelegate("glShaderSource", typeof(GlDelegate_uint_int_intptrarray_intarray));
			m_StencilFunc_0 = (GlDelegate_uint_int_uint)GetFunctionDelegate("glStencilFunc", typeof(GlDelegate_uint_int_uint));
			m_StencilFuncSeparate_0 = (GlDelegate_uint_uint_int_uint)GetFunctionDelegate("glStencilFuncSeparate", typeof(GlDelegate_uint_uint_int_uint));
			m_StencilMask_0 = (GlDelegate_uint)GetFunctionDelegate("glStencilMask", typeof(GlDelegate_uint));
			m_StencilMaskSeparate_0 = (GlDelegate_uint_uint)GetFunctionDelegate("glStencilMaskSeparate", typeof(GlDelegate_uint_uint));
			m_StencilOp_0 = (GlDelegate_uint_uint_uint)GetFunctionDelegate("glStencilOp", typeof(GlDelegate_uint_uint_uint));
			m_StencilOpSeparate_0 = (GlDelegate_uint_uint_uint_uint)GetFunctionDelegate("glStencilOpSeparate", typeof(GlDelegate_uint_uint_uint_uint));
			m_TexBuffer_0 = (GlDelegate_uint_uint_uint)GetFunctionDelegate("glTexBuffer", typeof(GlDelegate_uint_uint_uint));
			m_TexImage1D_0 = (GlDelegate_uint_int_int_int_int_uint_uint_systemintptr)GetFunctionDelegate("glTexImage1D", typeof(GlDelegate_uint_int_int_int_int_uint_uint_systemintptr));
			m_TexImage2D_0 = (GlDelegate_uint_int_int_int_int_int_uint_uint_systemintptr)GetFunctionDelegate("glTexImage2D", typeof(GlDelegate_uint_int_int_int_int_int_uint_uint_systemintptr));
			m_TexImage2DMultisample_0 = (GlDelegate_uint_int_uint_int_int_bool)GetFunctionDelegate("glTexImage2DMultisample", typeof(GlDelegate_uint_int_uint_int_int_bool));
			m_TexImage3D_0 = (GlDelegate_uint_int_int_int_int_int_int_uint_uint_systemintptr)GetFunctionDelegate("glTexImage3D", typeof(GlDelegate_uint_int_int_int_int_int_int_uint_uint_systemintptr));
			m_TexImage3DMultisample_0 = (GlDelegate_uint_int_uint_int_int_int_bool)GetFunctionDelegate("glTexImage3DMultisample", typeof(GlDelegate_uint_int_uint_int_int_int_bool));
			m_TexParameterf_0 = (GlDelegate_uint_uint_float)GetFunctionDelegate("glTexParameterf", typeof(GlDelegate_uint_uint_float));
			m_TexParameterfv_0 = (GlDelegate_uint_uint_systemintptr)GetFunctionDelegate("glTexParameterfv", typeof(GlDelegate_uint_uint_systemintptr));
			m_TexParameteri_0 = (GlDelegate_uint_uint_int)GetFunctionDelegate("glTexParameteri", typeof(GlDelegate_uint_uint_int));
			m_TexParameterIiv_0 = (GlDelegate_uint_uint_systemintptr)GetFunctionDelegate("glTexParameterIiv", typeof(GlDelegate_uint_uint_systemintptr));
			m_TexParameterIuiv_0 = (GlDelegate_uint_uint_systemintptr)GetFunctionDelegate("glTexParameterIuiv", typeof(GlDelegate_uint_uint_systemintptr));
			m_TexParameteriv_0 = (GlDelegate_uint_uint_systemintptr)GetFunctionDelegate("glTexParameteriv", typeof(GlDelegate_uint_uint_systemintptr));
			m_TexSubImage1D_0 = (GlDelegate_uint_int_int_int_uint_uint_systemintptr)GetFunctionDelegate("glTexSubImage1D", typeof(GlDelegate_uint_int_int_int_uint_uint_systemintptr));
			m_TexSubImage2D_0 = (GlDelegate_uint_int_int_int_int_int_uint_uint_systemintptr)GetFunctionDelegate("glTexSubImage2D", typeof(GlDelegate_uint_int_int_int_int_int_uint_uint_systemintptr));
			m_TexSubImage3D_0 = (GlDelegate_uint_int_int_int_int_int_int_int_uint_uint_systemintptr)GetFunctionDelegate("glTexSubImage3D", typeof(GlDelegate_uint_int_int_int_int_int_int_int_uint_uint_systemintptr));
			m_TransformFeedbackVaryings_0 = (GlDelegate_uint_int_systemintptr_uint)GetFunctionDelegate("glTransformFeedbackVaryings", typeof(GlDelegate_uint_int_systemintptr_uint));
			m_Uniform1f_0 = (GlDelegate_int_float)GetFunctionDelegate("glUniform1f", typeof(GlDelegate_int_float));
			m_Uniform1fv_0 = (GlDelegate_int_int_systemintptr)GetFunctionDelegate("glUniform1fv", typeof(GlDelegate_int_int_systemintptr));
			m_Uniform1i_0 = (GlDelegate_int_int)GetFunctionDelegate("glUniform1i", typeof(GlDelegate_int_int));
			m_Uniform1iv_0 = (GlDelegate_int_int_systemintptr)GetFunctionDelegate("glUniform1iv", typeof(GlDelegate_int_int_systemintptr));
			m_Uniform1ui_0 = (GlDelegate_int_uint)GetFunctionDelegate("glUniform1ui", typeof(GlDelegate_int_uint));
			m_Uniform1uiv_0 = (GlDelegate_int_int_systemintptr)GetFunctionDelegate("glUniform1uiv", typeof(GlDelegate_int_int_systemintptr));
			m_Uniform2f_0 = (GlDelegate_int_float_float)GetFunctionDelegate("glUniform2f", typeof(GlDelegate_int_float_float));
			m_Uniform2f_1 = (GlDelegate_int_vector2)GetFunctionDelegate("glUniform2f", typeof(GlDelegate_int_vector2));
			m_Uniform2fv_0 = (GlDelegate_int_int_systemintptr)GetFunctionDelegate("glUniform2fv", typeof(GlDelegate_int_int_systemintptr));
			m_Uniform2i_0 = (GlDelegate_int_int_int)GetFunctionDelegate("glUniform2i", typeof(GlDelegate_int_int_int));
			m_Uniform2i_1 = (GlDelegate_int_vector2i)GetFunctionDelegate("glUniform2i", typeof(GlDelegate_int_vector2i));
			m_Uniform2iv_0 = (GlDelegate_int_int_systemintptr)GetFunctionDelegate("glUniform2iv", typeof(GlDelegate_int_int_systemintptr));
			m_Uniform2ui_0 = (GlDelegate_int_uint_uint)GetFunctionDelegate("glUniform2ui", typeof(GlDelegate_int_uint_uint));
			m_Uniform2uiv_0 = (GlDelegate_int_int_systemintptr)GetFunctionDelegate("glUniform2uiv", typeof(GlDelegate_int_int_systemintptr));
			m_Uniform3f_0 = (GlDelegate_int_float_float_float)GetFunctionDelegate("glUniform3f", typeof(GlDelegate_int_float_float_float));
			m_Uniform3f_1 = (GlDelegate_int_vector3)GetFunctionDelegate("glUniform3f", typeof(GlDelegate_int_vector3));
			m_Uniform3fv_0 = (GlDelegate_int_int_systemintptr)GetFunctionDelegate("glUniform3fv", typeof(GlDelegate_int_int_systemintptr));
			m_Uniform3i_0 = (GlDelegate_int_int_int_int)GetFunctionDelegate("glUniform3i", typeof(GlDelegate_int_int_int_int));
			m_Uniform3i_1 = (GlDelegate_int_vector3i)GetFunctionDelegate("glUniform3i", typeof(GlDelegate_int_vector3i));
			m_Uniform3iv_0 = (GlDelegate_int_int_systemintptr)GetFunctionDelegate("glUniform3iv", typeof(GlDelegate_int_int_systemintptr));
			m_Uniform3ui_0 = (GlDelegate_int_uint_uint_uint)GetFunctionDelegate("glUniform3ui", typeof(GlDelegate_int_uint_uint_uint));
			m_Uniform3uiv_0 = (GlDelegate_int_int_systemintptr)GetFunctionDelegate("glUniform3uiv", typeof(GlDelegate_int_int_systemintptr));
			m_Uniform4f_0 = (GlDelegate_int_float_float_float_float)GetFunctionDelegate("glUniform4f", typeof(GlDelegate_int_float_float_float_float));
			m_Uniform4f_1 = (GlDelegate_int_vector4)GetFunctionDelegate("glUniform4f", typeof(GlDelegate_int_vector4));
			m_Uniform4fv_0 = (GlDelegate_int_int_systemintptr)GetFunctionDelegate("glUniform4fv", typeof(GlDelegate_int_int_systemintptr));
			m_Uniform4i_0 = (GlDelegate_int_int_int_int_int)GetFunctionDelegate("glUniform4i", typeof(GlDelegate_int_int_int_int_int));
			m_Uniform4i_1 = (GlDelegate_int_vector4i)GetFunctionDelegate("glUniform4i", typeof(GlDelegate_int_vector4i));
			m_Uniform4iv_0 = (GlDelegate_int_int_systemintptr)GetFunctionDelegate("glUniform4iv", typeof(GlDelegate_int_int_systemintptr));
			m_Uniform4ui_0 = (GlDelegate_int_uint_uint_uint_uint)GetFunctionDelegate("glUniform4ui", typeof(GlDelegate_int_uint_uint_uint_uint));
			m_Uniform4uiv_0 = (GlDelegate_int_int_systemintptr)GetFunctionDelegate("glUniform4uiv", typeof(GlDelegate_int_int_systemintptr));
			m_UniformBlockBinding_0 = (GlDelegate_uint_uint_uint)GetFunctionDelegate("glUniformBlockBinding", typeof(GlDelegate_uint_uint_uint));
			m_UniformMatrix2fv_0 = (GlDelegate_int_int_bool_systemintptr)GetFunctionDelegate("glUniformMatrix2fv", typeof(GlDelegate_int_int_bool_systemintptr));
			m_UniformMatrix2fv_1 = (GlDelegate_int_int_bool_floatarray)GetFunctionDelegate("glUniformMatrix2fv", typeof(GlDelegate_int_int_bool_floatarray));
			m_UniformMatrix2fv_2 = (GlDelegate_int_int_bool_refmatrix2)GetFunctionDelegate("glUniformMatrix2fv", typeof(GlDelegate_int_int_bool_refmatrix2));
			m_UniformMatrix2x3fv_0 = (GlDelegate_int_int_bool_systemintptr)GetFunctionDelegate("glUniformMatrix2x3fv", typeof(GlDelegate_int_int_bool_systemintptr));
			m_UniformMatrix2x4fv_0 = (GlDelegate_int_int_bool_systemintptr)GetFunctionDelegate("glUniformMatrix2x4fv", typeof(GlDelegate_int_int_bool_systemintptr));
			m_UniformMatrix3fv_0 = (GlDelegate_int_int_bool_systemintptr)GetFunctionDelegate("glUniformMatrix3fv", typeof(GlDelegate_int_int_bool_systemintptr));
			m_UniformMatrix3fv_1 = (GlDelegate_int_int_bool_floatarray)GetFunctionDelegate("glUniformMatrix3fv", typeof(GlDelegate_int_int_bool_floatarray));
			m_UniformMatrix3fv_2 = (GlDelegate_int_int_bool_refmatrix3)GetFunctionDelegate("glUniformMatrix3fv", typeof(GlDelegate_int_int_bool_refmatrix3));
			m_UniformMatrix3x2fv_0 = (GlDelegate_int_int_bool_systemintptr)GetFunctionDelegate("glUniformMatrix3x2fv", typeof(GlDelegate_int_int_bool_systemintptr));
			m_UniformMatrix3x4fv_0 = (GlDelegate_int_int_bool_systemintptr)GetFunctionDelegate("glUniformMatrix3x4fv", typeof(GlDelegate_int_int_bool_systemintptr));
			m_UniformMatrix4fv_0 = (GlDelegate_int_int_bool_systemintptr)GetFunctionDelegate("glUniformMatrix4fv", typeof(GlDelegate_int_int_bool_systemintptr));
			m_UniformMatrix4fv_1 = (GlDelegate_int_int_bool_floatarray)GetFunctionDelegate("glUniformMatrix4fv", typeof(GlDelegate_int_int_bool_floatarray));
			m_UniformMatrix4fv_2 = (GlDelegate_int_int_bool_refmatrix4)GetFunctionDelegate("glUniformMatrix4fv", typeof(GlDelegate_int_int_bool_refmatrix4));
			m_UniformMatrix4x2fv_0 = (GlDelegate_int_int_bool_systemintptr)GetFunctionDelegate("glUniformMatrix4x2fv", typeof(GlDelegate_int_int_bool_systemintptr));
			m_UniformMatrix4x3fv_0 = (GlDelegate_int_int_bool_systemintptr)GetFunctionDelegate("glUniformMatrix4x3fv", typeof(GlDelegate_int_int_bool_systemintptr));
			m_UnmapBuffer_0 = (GlDelegate_uint_Returns_bool)GetFunctionDelegate("glUnmapBuffer", typeof(GlDelegate_uint_Returns_bool));
			m_UseProgram_0 = (GlDelegate_uint)GetFunctionDelegate("glUseProgram", typeof(GlDelegate_uint));
			m_ValidateProgram_0 = (GlDelegate_uint)GetFunctionDelegate("glValidateProgram", typeof(GlDelegate_uint));
			m_VertexAttrib1d_0 = (GlDelegate_uint_double)GetFunctionDelegate("glVertexAttrib1d", typeof(GlDelegate_uint_double));
			m_VertexAttrib1dv_0 = (GlDelegate_uint_systemintptr)GetFunctionDelegate("glVertexAttrib1dv", typeof(GlDelegate_uint_systemintptr));
			m_VertexAttrib1f_0 = (GlDelegate_uint_float)GetFunctionDelegate("glVertexAttrib1f", typeof(GlDelegate_uint_float));
			m_VertexAttrib1fv_0 = (GlDelegate_uint_systemintptr)GetFunctionDelegate("glVertexAttrib1fv", typeof(GlDelegate_uint_systemintptr));
			m_VertexAttrib1s_0 = (GlDelegate_uint_short)GetFunctionDelegate("glVertexAttrib1s", typeof(GlDelegate_uint_short));
			m_VertexAttrib1sv_0 = (GlDelegate_uint_systemintptr)GetFunctionDelegate("glVertexAttrib1sv", typeof(GlDelegate_uint_systemintptr));
			m_VertexAttrib2d_0 = (GlDelegate_uint_double_double)GetFunctionDelegate("glVertexAttrib2d", typeof(GlDelegate_uint_double_double));
			m_VertexAttrib2dv_0 = (GlDelegate_uint_systemintptr)GetFunctionDelegate("glVertexAttrib2dv", typeof(GlDelegate_uint_systemintptr));
			m_VertexAttrib2f_0 = (GlDelegate_uint_float_float)GetFunctionDelegate("glVertexAttrib2f", typeof(GlDelegate_uint_float_float));
			m_VertexAttrib2fv_0 = (GlDelegate_uint_systemintptr)GetFunctionDelegate("glVertexAttrib2fv", typeof(GlDelegate_uint_systemintptr));
			m_VertexAttrib2s_0 = (GlDelegate_uint_short_short)GetFunctionDelegate("glVertexAttrib2s", typeof(GlDelegate_uint_short_short));
			m_VertexAttrib2sv_0 = (GlDelegate_uint_systemintptr)GetFunctionDelegate("glVertexAttrib2sv", typeof(GlDelegate_uint_systemintptr));
			m_VertexAttrib3d_0 = (GlDelegate_uint_double_double_double)GetFunctionDelegate("glVertexAttrib3d", typeof(GlDelegate_uint_double_double_double));
			m_VertexAttrib3dv_0 = (GlDelegate_uint_systemintptr)GetFunctionDelegate("glVertexAttrib3dv", typeof(GlDelegate_uint_systemintptr));
			m_VertexAttrib3f_0 = (GlDelegate_uint_float_float_float)GetFunctionDelegate("glVertexAttrib3f", typeof(GlDelegate_uint_float_float_float));
			m_VertexAttrib3fv_0 = (GlDelegate_uint_systemintptr)GetFunctionDelegate("glVertexAttrib3fv", typeof(GlDelegate_uint_systemintptr));
			m_VertexAttrib3s_0 = (GlDelegate_uint_short_short_short)GetFunctionDelegate("glVertexAttrib3s", typeof(GlDelegate_uint_short_short_short));
			m_VertexAttrib3sv_0 = (GlDelegate_uint_systemintptr)GetFunctionDelegate("glVertexAttrib3sv", typeof(GlDelegate_uint_systemintptr));
			m_VertexAttrib4bv_0 = (GlDelegate_uint_systemintptr)GetFunctionDelegate("glVertexAttrib4bv", typeof(GlDelegate_uint_systemintptr));
			m_VertexAttrib4d_0 = (GlDelegate_uint_double_double_double_double)GetFunctionDelegate("glVertexAttrib4d", typeof(GlDelegate_uint_double_double_double_double));
			m_VertexAttrib4dv_0 = (GlDelegate_uint_systemintptr)GetFunctionDelegate("glVertexAttrib4dv", typeof(GlDelegate_uint_systemintptr));
			m_VertexAttrib4f_0 = (GlDelegate_uint_float_float_float_float)GetFunctionDelegate("glVertexAttrib4f", typeof(GlDelegate_uint_float_float_float_float));
			m_VertexAttrib4fv_0 = (GlDelegate_uint_systemintptr)GetFunctionDelegate("glVertexAttrib4fv", typeof(GlDelegate_uint_systemintptr));
			m_VertexAttrib4iv_0 = (GlDelegate_uint_systemintptr)GetFunctionDelegate("glVertexAttrib4iv", typeof(GlDelegate_uint_systemintptr));
			m_VertexAttrib4Nbv_0 = (GlDelegate_uint_systemintptr)GetFunctionDelegate("glVertexAttrib4Nbv", typeof(GlDelegate_uint_systemintptr));
			m_VertexAttrib4Niv_0 = (GlDelegate_uint_systemintptr)GetFunctionDelegate("glVertexAttrib4Niv", typeof(GlDelegate_uint_systemintptr));
			m_VertexAttrib4Nsv_0 = (GlDelegate_uint_systemintptr)GetFunctionDelegate("glVertexAttrib4Nsv", typeof(GlDelegate_uint_systemintptr));
			m_VertexAttrib4Nub_0 = (GlDelegate_uint_byte_byte_byte_byte)GetFunctionDelegate("glVertexAttrib4Nub", typeof(GlDelegate_uint_byte_byte_byte_byte));
			m_VertexAttrib4Nubv_0 = (GlDelegate_uint_systemintptr)GetFunctionDelegate("glVertexAttrib4Nubv", typeof(GlDelegate_uint_systemintptr));
			m_VertexAttrib4Nuiv_0 = (GlDelegate_uint_systemintptr)GetFunctionDelegate("glVertexAttrib4Nuiv", typeof(GlDelegate_uint_systemintptr));
			m_VertexAttrib4Nusv_0 = (GlDelegate_uint_systemintptr)GetFunctionDelegate("glVertexAttrib4Nusv", typeof(GlDelegate_uint_systemintptr));
			m_VertexAttrib4s_0 = (GlDelegate_uint_short_short_short_short)GetFunctionDelegate("glVertexAttrib4s", typeof(GlDelegate_uint_short_short_short_short));
			m_VertexAttrib4sv_0 = (GlDelegate_uint_systemintptr)GetFunctionDelegate("glVertexAttrib4sv", typeof(GlDelegate_uint_systemintptr));
			m_VertexAttrib4ubv_0 = (GlDelegate_uint_systemintptr)GetFunctionDelegate("glVertexAttrib4ubv", typeof(GlDelegate_uint_systemintptr));
			m_VertexAttrib4uiv_0 = (GlDelegate_uint_systemintptr)GetFunctionDelegate("glVertexAttrib4uiv", typeof(GlDelegate_uint_systemintptr));
			m_VertexAttrib4usv_0 = (GlDelegate_uint_systemintptr)GetFunctionDelegate("glVertexAttrib4usv", typeof(GlDelegate_uint_systemintptr));
			m_VertexAttribI1i_0 = (GlDelegate_uint_int)GetFunctionDelegate("glVertexAttribI1i", typeof(GlDelegate_uint_int));
			m_VertexAttribI1iv_0 = (GlDelegate_uint_systemintptr)GetFunctionDelegate("glVertexAttribI1iv", typeof(GlDelegate_uint_systemintptr));
			m_VertexAttribI1ui_0 = (GlDelegate_uint_uint)GetFunctionDelegate("glVertexAttribI1ui", typeof(GlDelegate_uint_uint));
			m_VertexAttribI1uiv_0 = (GlDelegate_uint_systemintptr)GetFunctionDelegate("glVertexAttribI1uiv", typeof(GlDelegate_uint_systemintptr));
			m_VertexAttribI2i_0 = (GlDelegate_uint_int_int)GetFunctionDelegate("glVertexAttribI2i", typeof(GlDelegate_uint_int_int));
			m_VertexAttribI2iv_0 = (GlDelegate_uint_systemintptr)GetFunctionDelegate("glVertexAttribI2iv", typeof(GlDelegate_uint_systemintptr));
			m_VertexAttribI2ui_0 = (GlDelegate_uint_uint_uint)GetFunctionDelegate("glVertexAttribI2ui", typeof(GlDelegate_uint_uint_uint));
			m_VertexAttribI2uiv_0 = (GlDelegate_uint_systemintptr)GetFunctionDelegate("glVertexAttribI2uiv", typeof(GlDelegate_uint_systemintptr));
			m_VertexAttribI3i_0 = (GlDelegate_uint_int_int_int)GetFunctionDelegate("glVertexAttribI3i", typeof(GlDelegate_uint_int_int_int));
			m_VertexAttribI3iv_0 = (GlDelegate_uint_systemintptr)GetFunctionDelegate("glVertexAttribI3iv", typeof(GlDelegate_uint_systemintptr));
			m_VertexAttribI3ui_0 = (GlDelegate_uint_uint_uint_uint)GetFunctionDelegate("glVertexAttribI3ui", typeof(GlDelegate_uint_uint_uint_uint));
			m_VertexAttribI3uiv_0 = (GlDelegate_uint_systemintptr)GetFunctionDelegate("glVertexAttribI3uiv", typeof(GlDelegate_uint_systemintptr));
			m_VertexAttribI4bv_0 = (GlDelegate_uint_systemintptr)GetFunctionDelegate("glVertexAttribI4bv", typeof(GlDelegate_uint_systemintptr));
			m_VertexAttribI4i_0 = (GlDelegate_uint_int_int_int_int)GetFunctionDelegate("glVertexAttribI4i", typeof(GlDelegate_uint_int_int_int_int));
			m_VertexAttribI4iv_0 = (GlDelegate_uint_systemintptr)GetFunctionDelegate("glVertexAttribI4iv", typeof(GlDelegate_uint_systemintptr));
			m_VertexAttribI4sv_0 = (GlDelegate_uint_systemintptr)GetFunctionDelegate("glVertexAttribI4sv", typeof(GlDelegate_uint_systemintptr));
			m_VertexAttribI4ubv_0 = (GlDelegate_uint_systemintptr)GetFunctionDelegate("glVertexAttribI4ubv", typeof(GlDelegate_uint_systemintptr));
			m_VertexAttribI4ui_0 = (GlDelegate_uint_uint_uint_uint_uint)GetFunctionDelegate("glVertexAttribI4ui", typeof(GlDelegate_uint_uint_uint_uint_uint));
			m_VertexAttribI4uiv_0 = (GlDelegate_uint_systemintptr)GetFunctionDelegate("glVertexAttribI4uiv", typeof(GlDelegate_uint_systemintptr));
			m_VertexAttribI4usv_0 = (GlDelegate_uint_systemintptr)GetFunctionDelegate("glVertexAttribI4usv", typeof(GlDelegate_uint_systemintptr));
			m_VertexAttribIPointer_0 = (GlDelegate_uint_int_uint_int_systemintptr)GetFunctionDelegate("glVertexAttribIPointer", typeof(GlDelegate_uint_int_uint_int_systemintptr));
			m_VertexAttribPointer_0 = (GlDelegate_uint_int_uint_bool_int_systemintptr)GetFunctionDelegate("glVertexAttribPointer", typeof(GlDelegate_uint_int_uint_bool_int_systemintptr));
			m_Viewport_0 = (GlDelegate_int_int_int_int)GetFunctionDelegate("glViewport", typeof(GlDelegate_int_int_int_int));
			m_Viewport_1 = (GlDelegate_box2i)GetFunctionDelegate("glViewport", typeof(GlDelegate_box2i));
			m_WaitSync_0 = (GlDelegate_systemintptr_uint_ulong)GetFunctionDelegate("glWaitSync", typeof(GlDelegate_systemintptr_uint_ulong));
			m_BindFragDataLocationIndexed_0 = (GlDelegate_uint_uint_uint_systemintptr)GetFunctionDelegate("glBindFragDataLocationIndexed", typeof(GlDelegate_uint_uint_uint_systemintptr));
			m_GetFragDataIndex_0 = (GlDelegate_uint_systemintptr_Returns_int)GetFunctionDelegate("glGetFragDataIndex", typeof(GlDelegate_uint_systemintptr_Returns_int));
			m_GenSamplers_0 = (GlDelegate_int_systemintptr)GetFunctionDelegate("glGenSamplers", typeof(GlDelegate_int_systemintptr));
			m_GenSamplers_1 = (GlDelegate_int_uintarray)GetFunctionDelegate("glGenSamplers", typeof(GlDelegate_int_uintarray));
			m_GenSamplers_2 = (GlDelegate_int_outuint)GetFunctionDelegate("glGenSamplers", typeof(GlDelegate_int_outuint));
			m_DeleteSamplers_0 = (GlDelegate_int_systemintptr)GetFunctionDelegate("glDeleteSamplers", typeof(GlDelegate_int_systemintptr));
			m_DeleteSamplers_1 = (GlDelegate_int_uintarray)GetFunctionDelegate("glDeleteSamplers", typeof(GlDelegate_int_uintarray));
			m_DeleteSamplers_2 = (GlDelegate_int_refuint)GetFunctionDelegate("glDeleteSamplers", typeof(GlDelegate_int_refuint));
			m_IsSampler_0 = (GlDelegate_uint_Returns_bool)GetFunctionDelegate("glIsSampler", typeof(GlDelegate_uint_Returns_bool));
			m_BindSampler_0 = (GlDelegate_uint_uint)GetFunctionDelegate("glBindSampler", typeof(GlDelegate_uint_uint));
			m_SamplerParameteri_0 = (GlDelegate_uint_uint_int)GetFunctionDelegate("glSamplerParameteri", typeof(GlDelegate_uint_uint_int));
			m_SamplerParameteriv_0 = (GlDelegate_uint_uint_systemintptr)GetFunctionDelegate("glSamplerParameteriv", typeof(GlDelegate_uint_uint_systemintptr));
			m_SamplerParameterf_0 = (GlDelegate_uint_uint_float)GetFunctionDelegate("glSamplerParameterf", typeof(GlDelegate_uint_uint_float));
			m_SamplerParameterfv_0 = (GlDelegate_uint_uint_systemintptr)GetFunctionDelegate("glSamplerParameterfv", typeof(GlDelegate_uint_uint_systemintptr));
			m_SamplerParameterIiv_0 = (GlDelegate_uint_uint_systemintptr)GetFunctionDelegate("glSamplerParameterIiv", typeof(GlDelegate_uint_uint_systemintptr));
			m_SamplerParameterIuiv_0 = (GlDelegate_uint_uint_systemintptr)GetFunctionDelegate("glSamplerParameterIuiv", typeof(GlDelegate_uint_uint_systemintptr));
			m_GetSamplerParameteriv_0 = (GlDelegate_uint_uint_systemintptr)GetFunctionDelegate("glGetSamplerParameteriv", typeof(GlDelegate_uint_uint_systemintptr));
			m_GetSamplerParameterIiv_0 = (GlDelegate_uint_uint_systemintptr)GetFunctionDelegate("glGetSamplerParameterIiv", typeof(GlDelegate_uint_uint_systemintptr));
			m_GetSamplerParameterfv_0 = (GlDelegate_uint_uint_systemintptr)GetFunctionDelegate("glGetSamplerParameterfv", typeof(GlDelegate_uint_uint_systemintptr));
			m_GetSamplerParameterIuiv_0 = (GlDelegate_uint_uint_systemintptr)GetFunctionDelegate("glGetSamplerParameterIuiv", typeof(GlDelegate_uint_uint_systemintptr));
			m_QueryCounter_0 = (GlDelegate_uint_uint)GetFunctionDelegate("glQueryCounter", typeof(GlDelegate_uint_uint));
			m_GetQueryObjecti64v_0 = (GlDelegate_uint_uint_systemintptr)GetFunctionDelegate("glGetQueryObjecti64v", typeof(GlDelegate_uint_uint_systemintptr));
			m_GetQueryObjectui64v_0 = (GlDelegate_uint_uint_systemintptr)GetFunctionDelegate("glGetQueryObjectui64v", typeof(GlDelegate_uint_uint_systemintptr));
			m_VertexAttribDivisor_0 = (GlDelegate_uint_uint)GetFunctionDelegate("glVertexAttribDivisor", typeof(GlDelegate_uint_uint));
			m_VertexAttribP1ui_0 = (GlDelegate_uint_uint_bool_uint)GetFunctionDelegate("glVertexAttribP1ui", typeof(GlDelegate_uint_uint_bool_uint));
			m_VertexAttribP1uiv_0 = (GlDelegate_uint_uint_bool_systemintptr)GetFunctionDelegate("glVertexAttribP1uiv", typeof(GlDelegate_uint_uint_bool_systemintptr));
			m_VertexAttribP2ui_0 = (GlDelegate_uint_uint_bool_uint)GetFunctionDelegate("glVertexAttribP2ui", typeof(GlDelegate_uint_uint_bool_uint));
			m_VertexAttribP2uiv_0 = (GlDelegate_uint_uint_bool_systemintptr)GetFunctionDelegate("glVertexAttribP2uiv", typeof(GlDelegate_uint_uint_bool_systemintptr));
			m_VertexAttribP3ui_0 = (GlDelegate_uint_uint_bool_uint)GetFunctionDelegate("glVertexAttribP3ui", typeof(GlDelegate_uint_uint_bool_uint));
			m_VertexAttribP3uiv_0 = (GlDelegate_uint_uint_bool_systemintptr)GetFunctionDelegate("glVertexAttribP3uiv", typeof(GlDelegate_uint_uint_bool_systemintptr));
			m_VertexAttribP4ui_0 = (GlDelegate_uint_uint_bool_uint)GetFunctionDelegate("glVertexAttribP4ui", typeof(GlDelegate_uint_uint_bool_uint));
			m_VertexAttribP4uiv_0 = (GlDelegate_uint_uint_bool_systemintptr)GetFunctionDelegate("glVertexAttribP4uiv", typeof(GlDelegate_uint_uint_bool_systemintptr));
		}

		private static void UninitializeFunctions()
		{
			m_ActiveTexture_0 = null;
			m_AttachShader_0 = null;
			m_BeginConditionalRender_0 = null;
			m_BeginQuery_0 = null;
			m_BeginTransformFeedback_0 = null;
			m_BindAttribLocation_0 = null;
			m_BindBuffer_0 = null;
			m_BindBufferBase_0 = null;
			m_BindBufferRange_0 = null;
			m_BindFragDataLocation_0 = null;
			m_BindFramebuffer_0 = null;
			m_BindRenderbuffer_0 = null;
			m_BindTexture_0 = null;
			m_BindVertexArray_0 = null;
			m_BlendColor_0 = null;
			m_BlendColor_1 = null;
			m_BlendEquation_0 = null;
			m_BlendEquationSeparate_0 = null;
			m_BlendFunc_0 = null;
			m_BlendFuncSeparate_0 = null;
			m_BlitFramebuffer_0 = null;
			m_BlitFramebuffer_1 = null;
			m_BufferData_0 = null;
			m_BufferSubData_0 = null;
			m_CheckFramebufferStatus_0 = null;
			m_ClampColor_0 = null;
			m_Clear_0 = null;
			m_ClearBufferfi_0 = null;
			m_ClearBufferfv_0 = null;
			m_ClearBufferfv_1 = null;
			m_ClearBufferfv_2 = null;
			m_ClearBufferiv_0 = null;
			m_ClearBufferiv_1 = null;
			m_ClearBufferiv_2 = null;
			m_ClearBufferuiv_0 = null;
			m_ClearBufferuiv_1 = null;
			m_ClearBufferuiv_2 = null;
			m_ClearColor_0 = null;
			m_ClearColor_1 = null;
			m_ClearDepth_0 = null;
			m_ClearStencil_0 = null;
			m_ClientWaitSync_0 = null;
			m_ColorMask_0 = null;
			m_ColorMaski_0 = null;
			m_CompileShader_0 = null;
			m_CompressedTexImage1D_0 = null;
			m_CompressedTexImage2D_0 = null;
			m_CompressedTexImage3D_0 = null;
			m_CompressedTexSubImage1D_0 = null;
			m_CompressedTexSubImage2D_0 = null;
			m_CompressedTexSubImage2D_1 = null;
			m_CompressedTexSubImage3D_0 = null;
			m_CompressedTexSubImage3D_1 = null;
			m_CopyBufferSubData_0 = null;
			m_CopyTexImage1D_0 = null;
			m_CopyTexImage1D_1 = null;
			m_CopyTexImage2D_0 = null;
			m_CopyTexImage2D_1 = null;
			m_CopyTexImage2D_2 = null;
			m_CopyTexSubImage1D_0 = null;
			m_CopyTexSubImage1D_1 = null;
			m_CopyTexSubImage2D_0 = null;
			m_CopyTexSubImage2D_1 = null;
			m_CopyTexSubImage3D_0 = null;
			m_CopyTexSubImage3D_1 = null;
			m_CreateProgram_0 = null;
			m_CreateShader_0 = null;
			m_CullFace_0 = null;
			m_DeleteBuffers_0 = null;
			m_DeleteBuffers_1 = null;
			m_DeleteBuffers_2 = null;
			m_DeleteFramebuffers_0 = null;
			m_DeleteFramebuffers_1 = null;
			m_DeleteFramebuffers_2 = null;
			m_DeleteProgram_0 = null;
			m_DeleteQueries_0 = null;
			m_DeleteQueries_1 = null;
			m_DeleteQueries_2 = null;
			m_DeleteRenderbuffers_0 = null;
			m_DeleteRenderbuffers_1 = null;
			m_DeleteRenderbuffers_2 = null;
			m_DeleteShader_0 = null;
			m_DeleteSync_0 = null;
			m_DeleteTextures_0 = null;
			m_DeleteTextures_1 = null;
			m_DeleteTextures_2 = null;
			m_DeleteVertexArrays_0 = null;
			m_DeleteVertexArrays_1 = null;
			m_DeleteVertexArrays_2 = null;
			m_DepthFunc_0 = null;
			m_DepthMask_0 = null;
			m_DepthRange_0 = null;
			m_DetachShader_0 = null;
			m_Disable_0 = null;
			m_Disablei_0 = null;
			m_DisableVertexAttribArray_0 = null;
			m_DrawArrays_0 = null;
			m_DrawArraysInstanced_0 = null;
			m_DrawBuffer_0 = null;
			m_DrawBuffers_0 = null;
			m_DrawBuffers_1 = null;
			m_DrawBuffers_2 = null;
			m_DrawElements_0 = null;
			m_DrawElements_1 = null;
			m_DrawElements_2 = null;
			m_DrawElements_3 = null;
			m_DrawElementsBaseVertex_0 = null;
			m_DrawElementsBaseVertex_1 = null;
			m_DrawElementsBaseVertex_2 = null;
			m_DrawElementsBaseVertex_3 = null;
			m_DrawElementsInstanced_0 = null;
			m_DrawElementsInstanced_1 = null;
			m_DrawElementsInstanced_2 = null;
			m_DrawElementsInstanced_3 = null;
			m_DrawElementsInstancedBaseVertex_0 = null;
			m_DrawElementsInstancedBaseVertex_1 = null;
			m_DrawElementsInstancedBaseVertex_2 = null;
			m_DrawElementsInstancedBaseVertex_3 = null;
			m_DrawRangeElements_0 = null;
			m_DrawRangeElements_1 = null;
			m_DrawRangeElements_2 = null;
			m_DrawRangeElements_3 = null;
			m_DrawRangeElementsBaseVertex_0 = null;
			m_DrawRangeElementsBaseVertex_1 = null;
			m_DrawRangeElementsBaseVertex_2 = null;
			m_DrawRangeElementsBaseVertex_3 = null;
			m_Enable_0 = null;
			m_Enablei_0 = null;
			m_EnableVertexAttribArray_0 = null;
			m_EndConditionalRender_0 = null;
			m_EndQuery_0 = null;
			m_EndTransformFeedback_0 = null;
			m_FenceSync_0 = null;
			m_Finish_0 = null;
			m_Flush_0 = null;
			m_FlushMappedBufferRange_0 = null;
			m_FramebufferRenderbuffer_0 = null;
			m_FramebufferTexture_0 = null;
			m_FramebufferTexture1D_0 = null;
			m_FramebufferTexture2D_0 = null;
			m_FramebufferTexture3D_0 = null;
			m_FramebufferTextureLayer_0 = null;
			m_FrontFace_0 = null;
			m_GenBuffers_0 = null;
			m_GenBuffers_1 = null;
			m_GenBuffers_2 = null;
			m_GenerateMipmap_0 = null;
			m_GenFramebuffers_0 = null;
			m_GenFramebuffers_1 = null;
			m_GenFramebuffers_2 = null;
			m_GenQueries_0 = null;
			m_GenQueries_1 = null;
			m_GenQueries_2 = null;
			m_GenRenderbuffers_0 = null;
			m_GenRenderbuffers_1 = null;
			m_GenRenderbuffers_2 = null;
			m_GenTextures_0 = null;
			m_GenTextures_1 = null;
			m_GenTextures_2 = null;
			m_GenVertexArrays_0 = null;
			m_GenVertexArrays_1 = null;
			m_GenVertexArrays_2 = null;
			m_GetActiveAttrib_0 = null;
			m_GetActiveAttrib_1 = null;
			m_GetActiveUniform_0 = null;
			m_GetActiveUniform_1 = null;
			m_GetActiveUniformBlockiv_0 = null;
			m_GetActiveUniformBlockiv_1 = null;
			m_GetActiveUniformBlockiv_2 = null;
			m_GetActiveUniformBlockName_0 = null;
			m_GetActiveUniformBlockName_1 = null;
			m_GetActiveUniformName_0 = null;
			m_GetActiveUniformName_1 = null;
			m_GetActiveUniformsiv_0 = null;
			m_GetActiveUniformsiv_1 = null;
			m_GetActiveUniformsiv_2 = null;
			m_GetActiveUniformsiv_3 = null;
			m_GetActiveUniformsiv_4 = null;
			m_GetAttachedShaders_0 = null;
			m_GetAttachedShaders_1 = null;
			m_GetAttribLocation_0 = null;
			m_GetAttribLocation_1 = null;
			m_GetAttribLocation_2 = null;
			m_GetBooleani_v_0 = null;
			m_GetBooleani_v_1 = null;
			m_GetBooleanv_0 = null;
			m_GetBooleanv_1 = null;
			m_GetBufferParameteri64v_0 = null;
			m_GetBufferParameteri64v_1 = null;
			m_GetBufferParameteriv_0 = null;
			m_GetBufferParameteriv_1 = null;
			m_GetBufferPointerv_0 = null;
			m_GetBufferPointerv_1 = null;
			m_GetBufferSubData_0 = null;
			m_GetCompressedTexImage_0 = null;
			m_GetDoublev_0 = null;
			m_GetDoublev_1 = null;
			m_GetDoublev_2 = null;
			m_GetDoublev_3 = null;
			m_GetDoublev_4 = null;
			m_GetDoublev_5 = null;
			m_GetDoublev_6 = null;
			m_GetDoublev_7 = null;
			m_GetDoublev_8 = null;
			m_GetDoublev_9 = null;
			m_GetError_0 = null;
			m_GetFloatv_0 = null;
			m_GetFloatv_1 = null;
			m_GetFloatv_2 = null;
			m_GetFloatv_3 = null;
			m_GetFloatv_4 = null;
			m_GetFloatv_5 = null;
			m_GetFloatv_6 = null;
			m_GetFloatv_7 = null;
			m_GetFloatv_8 = null;
			m_GetFloatv_9 = null;
			m_GetFragDataLocation_0 = null;
			m_GetFramebufferAttachmentParameteriv_0 = null;
			m_GetFramebufferAttachmentParameteriv_1 = null;
			m_GetInteger64i_v_0 = null;
			m_GetInteger64i_v_1 = null;
			m_GetInteger64i_v_2 = null;
			m_GetInteger64v_0 = null;
			m_GetInteger64v_1 = null;
			m_GetInteger64v_2 = null;
			m_GetIntegeri_v_0 = null;
			m_GetIntegeri_v_1 = null;
			m_GetIntegeri_v_2 = null;
			m_GetIntegerv_0 = null;
			m_GetIntegerv_1 = null;
			m_GetIntegerv_2 = null;
			m_GetMultisamplefv_0 = null;
			m_GetMultisamplefv_1 = null;
			m_GetProgramInfoLog_0 = null;
			m_GetProgramInfoLog_1 = null;
			m_GetProgramiv_0 = null;
			m_GetProgramiv_1 = null;
			m_GetProgramiv_2 = null;
			m_GetQueryiv_0 = null;
			m_GetQueryObjectiv_0 = null;
			m_GetQueryObjectuiv_0 = null;
			m_GetRenderbufferParameteriv_0 = null;
			m_GetShaderInfoLog_0 = null;
			m_GetShaderInfoLog_1 = null;
			m_GetShaderiv_0 = null;
			m_GetShaderiv_1 = null;
			m_GetShaderiv_2 = null;
			m_GetShaderSource_0 = null;
			m_GetString_0 = null;
			m_GetStringi_0 = null;
			m_GetSynciv_0 = null;
			m_GetTexImage_0 = null;
			m_GetTexLevelParameterfv_0 = null;
			m_GetTexLevelParameteriv_0 = null;
			m_GetTexParameterfv_0 = null;
			m_GetTexParameterIiv_0 = null;
			m_GetTexParameterIuiv_0 = null;
			m_GetTexParameteriv_0 = null;
			m_GetTransformFeedbackVarying_0 = null;
			m_GetUniformBlockIndex_0 = null;
			m_GetUniformfv_0 = null;
			m_GetUniformIndices_0 = null;
			m_GetUniformiv_0 = null;
			m_GetUniformLocation_0 = null;
			m_GetUniformLocation_1 = null;
			m_GetUniformLocation_2 = null;
			m_GetUniformuiv_0 = null;
			m_GetVertexAttribdv_0 = null;
			m_GetVertexAttribfv_0 = null;
			m_GetVertexAttribIiv_0 = null;
			m_GetVertexAttribIuiv_0 = null;
			m_GetVertexAttribiv_0 = null;
			m_GetVertexAttribPointerv_0 = null;
			m_Hint_0 = null;
			m_IsBuffer_0 = null;
			m_IsEnabled_0 = null;
			m_IsEnabledi_0 = null;
			m_IsFramebuffer_0 = null;
			m_IsProgram_0 = null;
			m_IsQuery_0 = null;
			m_IsRenderbuffer_0 = null;
			m_IsShader_0 = null;
			m_IsSync_0 = null;
			m_IsTexture_0 = null;
			m_IsVertexArray_0 = null;
			m_LineWidth_0 = null;
			m_LinkProgram_0 = null;
			m_LogicOp_0 = null;
			m_MapBuffer_0 = null;
			m_MapBufferRange_0 = null;
			m_MultiDrawArrays_0 = null;
			m_MultiDrawElements_0 = null;
			m_MultiDrawElementsBaseVertex_0 = null;
			m_PixelStoref_0 = null;
			m_PixelStorei_0 = null;
			m_PointParameterf_0 = null;
			m_PointParameterfv_0 = null;
			m_PointParameteri_0 = null;
			m_PointParameteriv_0 = null;
			m_PointSize_0 = null;
			m_PolygonMode_0 = null;
			m_PolygonOffset_0 = null;
			m_PrimitiveRestartIndex_0 = null;
			m_ProvokingVertex_0 = null;
			m_ReadBuffer_0 = null;
			m_ReadPixels_0 = null;
			m_RenderbufferStorage_0 = null;
			m_RenderbufferStorageMultisample_0 = null;
			m_SampleCoverage_0 = null;
			m_SampleMaski_0 = null;
			m_Scissor_0 = null;
			m_ShaderSource_0 = null;
			m_ShaderSource_1 = null;
			m_StencilFunc_0 = null;
			m_StencilFuncSeparate_0 = null;
			m_StencilMask_0 = null;
			m_StencilMaskSeparate_0 = null;
			m_StencilOp_0 = null;
			m_StencilOpSeparate_0 = null;
			m_TexBuffer_0 = null;
			m_TexImage1D_0 = null;
			m_TexImage2D_0 = null;
			m_TexImage2DMultisample_0 = null;
			m_TexImage3D_0 = null;
			m_TexImage3DMultisample_0 = null;
			m_TexParameterf_0 = null;
			m_TexParameterfv_0 = null;
			m_TexParameteri_0 = null;
			m_TexParameterIiv_0 = null;
			m_TexParameterIuiv_0 = null;
			m_TexParameteriv_0 = null;
			m_TexSubImage1D_0 = null;
			m_TexSubImage2D_0 = null;
			m_TexSubImage3D_0 = null;
			m_TransformFeedbackVaryings_0 = null;
			m_Uniform1f_0 = null;
			m_Uniform1fv_0 = null;
			m_Uniform1i_0 = null;
			m_Uniform1iv_0 = null;
			m_Uniform1ui_0 = null;
			m_Uniform1uiv_0 = null;
			m_Uniform2f_0 = null;
			m_Uniform2f_1 = null;
			m_Uniform2fv_0 = null;
			m_Uniform2i_0 = null;
			m_Uniform2i_1 = null;
			m_Uniform2iv_0 = null;
			m_Uniform2ui_0 = null;
			m_Uniform2uiv_0 = null;
			m_Uniform3f_0 = null;
			m_Uniform3f_1 = null;
			m_Uniform3fv_0 = null;
			m_Uniform3i_0 = null;
			m_Uniform3i_1 = null;
			m_Uniform3iv_0 = null;
			m_Uniform3ui_0 = null;
			m_Uniform3uiv_0 = null;
			m_Uniform4f_0 = null;
			m_Uniform4f_1 = null;
			m_Uniform4fv_0 = null;
			m_Uniform4i_0 = null;
			m_Uniform4i_1 = null;
			m_Uniform4iv_0 = null;
			m_Uniform4ui_0 = null;
			m_Uniform4uiv_0 = null;
			m_UniformBlockBinding_0 = null;
			m_UniformMatrix2fv_0 = null;
			m_UniformMatrix2fv_1 = null;
			m_UniformMatrix2fv_2 = null;
			m_UniformMatrix2x3fv_0 = null;
			m_UniformMatrix2x4fv_0 = null;
			m_UniformMatrix3fv_0 = null;
			m_UniformMatrix3fv_1 = null;
			m_UniformMatrix3fv_2 = null;
			m_UniformMatrix3x2fv_0 = null;
			m_UniformMatrix3x4fv_0 = null;
			m_UniformMatrix4fv_0 = null;
			m_UniformMatrix4fv_1 = null;
			m_UniformMatrix4fv_2 = null;
			m_UniformMatrix4x2fv_0 = null;
			m_UniformMatrix4x3fv_0 = null;
			m_UnmapBuffer_0 = null;
			m_UseProgram_0 = null;
			m_ValidateProgram_0 = null;
			m_VertexAttrib1d_0 = null;
			m_VertexAttrib1dv_0 = null;
			m_VertexAttrib1f_0 = null;
			m_VertexAttrib1fv_0 = null;
			m_VertexAttrib1s_0 = null;
			m_VertexAttrib1sv_0 = null;
			m_VertexAttrib2d_0 = null;
			m_VertexAttrib2dv_0 = null;
			m_VertexAttrib2f_0 = null;
			m_VertexAttrib2fv_0 = null;
			m_VertexAttrib2s_0 = null;
			m_VertexAttrib2sv_0 = null;
			m_VertexAttrib3d_0 = null;
			m_VertexAttrib3dv_0 = null;
			m_VertexAttrib3f_0 = null;
			m_VertexAttrib3fv_0 = null;
			m_VertexAttrib3s_0 = null;
			m_VertexAttrib3sv_0 = null;
			m_VertexAttrib4bv_0 = null;
			m_VertexAttrib4d_0 = null;
			m_VertexAttrib4dv_0 = null;
			m_VertexAttrib4f_0 = null;
			m_VertexAttrib4fv_0 = null;
			m_VertexAttrib4iv_0 = null;
			m_VertexAttrib4Nbv_0 = null;
			m_VertexAttrib4Niv_0 = null;
			m_VertexAttrib4Nsv_0 = null;
			m_VertexAttrib4Nub_0 = null;
			m_VertexAttrib4Nubv_0 = null;
			m_VertexAttrib4Nuiv_0 = null;
			m_VertexAttrib4Nusv_0 = null;
			m_VertexAttrib4s_0 = null;
			m_VertexAttrib4sv_0 = null;
			m_VertexAttrib4ubv_0 = null;
			m_VertexAttrib4uiv_0 = null;
			m_VertexAttrib4usv_0 = null;
			m_VertexAttribI1i_0 = null;
			m_VertexAttribI1iv_0 = null;
			m_VertexAttribI1ui_0 = null;
			m_VertexAttribI1uiv_0 = null;
			m_VertexAttribI2i_0 = null;
			m_VertexAttribI2iv_0 = null;
			m_VertexAttribI2ui_0 = null;
			m_VertexAttribI2uiv_0 = null;
			m_VertexAttribI3i_0 = null;
			m_VertexAttribI3iv_0 = null;
			m_VertexAttribI3ui_0 = null;
			m_VertexAttribI3uiv_0 = null;
			m_VertexAttribI4bv_0 = null;
			m_VertexAttribI4i_0 = null;
			m_VertexAttribI4iv_0 = null;
			m_VertexAttribI4sv_0 = null;
			m_VertexAttribI4ubv_0 = null;
			m_VertexAttribI4ui_0 = null;
			m_VertexAttribI4uiv_0 = null;
			m_VertexAttribI4usv_0 = null;
			m_VertexAttribIPointer_0 = null;
			m_VertexAttribPointer_0 = null;
			m_Viewport_0 = null;
			m_Viewport_1 = null;
			m_WaitSync_0 = null;
			m_BindFragDataLocationIndexed_0 = null;
			m_GetFragDataIndex_0 = null;
			m_GenSamplers_0 = null;
			m_GenSamplers_1 = null;
			m_GenSamplers_2 = null;
			m_DeleteSamplers_0 = null;
			m_DeleteSamplers_1 = null;
			m_DeleteSamplers_2 = null;
			m_IsSampler_0 = null;
			m_BindSampler_0 = null;
			m_SamplerParameteri_0 = null;
			m_SamplerParameteriv_0 = null;
			m_SamplerParameterf_0 = null;
			m_SamplerParameterfv_0 = null;
			m_SamplerParameterIiv_0 = null;
			m_SamplerParameterIuiv_0 = null;
			m_GetSamplerParameteriv_0 = null;
			m_GetSamplerParameterIiv_0 = null;
			m_GetSamplerParameterfv_0 = null;
			m_GetSamplerParameterIuiv_0 = null;
			m_QueryCounter_0 = null;
			m_GetQueryObjecti64v_0 = null;
			m_GetQueryObjectui64v_0 = null;
			m_VertexAttribDivisor_0 = null;
			m_VertexAttribP1ui_0 = null;
			m_VertexAttribP1uiv_0 = null;
			m_VertexAttribP2ui_0 = null;
			m_VertexAttribP2uiv_0 = null;
			m_VertexAttribP3ui_0 = null;
			m_VertexAttribP3uiv_0 = null;
			m_VertexAttribP4ui_0 = null;
			m_VertexAttribP4uiv_0 = null;
		}

		public static void ActiveTexture(uint texture)
		{
						m_ActiveTexture_0(texture);
			if(m_debug) CheckError("ActiveTexture");
					}

		public static void AttachShader(uint program, uint shader)
		{
						m_AttachShader_0(program, shader);
			if(m_debug) CheckError("AttachShader");
					}

		public static void BeginConditionalRender(uint id, uint mode)
		{
						m_BeginConditionalRender_0(id, mode);
			if(m_debug) CheckError("BeginConditionalRender");
					}

		public static void BeginQuery(uint target, uint id)
		{
						m_BeginQuery_0(target, id);
			if(m_debug) CheckError("BeginQuery");
					}

		public static void BeginTransformFeedback(uint primitiveMode)
		{
						m_BeginTransformFeedback_0(primitiveMode);
			if(m_debug) CheckError("BeginTransformFeedback");
					}

		public static void BindAttribLocation(uint program, uint index, string name)
		{
						m_BindAttribLocation_0(program, index, name);
			if(m_debug) CheckError("BindAttribLocation");
					}

		public static void BindBuffer(uint target, uint buffer)
		{
						m_BindBuffer_0(target, buffer);
			if(m_debug) CheckError("BindBuffer");
					}

		public static void BindBufferBase(uint target, uint index, uint buffer)
		{
						m_BindBufferBase_0(target, index, buffer);
			if(m_debug) CheckError("BindBufferBase");
					}

		public static void BindBufferRange(uint target, uint index, uint buffer, System.IntPtr offset, System.IntPtr size)
		{
						m_BindBufferRange_0(target, index, buffer, offset, size);
			if(m_debug) CheckError("BindBufferRange");
					}

		public static void BindFragDataLocation(uint program, uint color, string name)
		{
						m_BindFragDataLocation_0(program, color, name);
			if(m_debug) CheckError("BindFragDataLocation");
					}

		public static void BindFramebuffer(uint target, uint framebuffer)
		{
						m_BindFramebuffer_0(target, framebuffer);
			if(m_debug) CheckError("BindFramebuffer");
					}

		public static void BindRenderbuffer(uint target, uint renderbuffer)
		{
						m_BindRenderbuffer_0(target, renderbuffer);
			if(m_debug) CheckError("BindRenderbuffer");
					}

		public static void BindTexture(uint target, uint texture)
		{
						m_BindTexture_0(target, texture);
			if(m_debug) CheckError("BindTexture");
					}

		public static void BindVertexArray(uint array)
		{
						m_BindVertexArray_0(array);
			if(m_debug) CheckError("BindVertexArray");
					}

		public static void BlendColor(float red, float green, float blue, float alpha)
		{
						m_BlendColor_0(red, green, blue, alpha);
			if(m_debug) CheckError("BlendColor");
					}

		public static void BlendColor(Color4 color)
		{
						m_BlendColor_1(color);
			if(m_debug) CheckError("BlendColor");
					}

		public static void BlendEquation(uint mode)
		{
						m_BlendEquation_0(mode);
			if(m_debug) CheckError("BlendEquation");
					}

		public static void BlendEquationSeparate(uint modeRGB, uint modeAlpha)
		{
						m_BlendEquationSeparate_0(modeRGB, modeAlpha);
			if(m_debug) CheckError("BlendEquationSeparate");
					}

		public static void BlendFunc(uint sfactor, uint dfactor)
		{
						m_BlendFunc_0(sfactor, dfactor);
			if(m_debug) CheckError("BlendFunc");
					}

		public static void BlendFuncSeparate(uint sfactorRGB, uint dfactorRGB, uint sfactorAlpha, uint dfactorAlpha)
		{
						m_BlendFuncSeparate_0(sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha);
			if(m_debug) CheckError("BlendFuncSeparate");
					}

		public static void BlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter)
		{
						m_BlitFramebuffer_0(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
			if(m_debug) CheckError("BlitFramebuffer");
					}

		public static void BlitFramebuffer(Vector2i src0, Vector2i src1, Vector2i dst0, Vector2i dst1, uint mask, uint filter)
		{
						m_BlitFramebuffer_1(src0, src1, dst0, dst1, mask, filter);
			if(m_debug) CheckError("BlitFramebuffer");
					}

		public static void BufferData(uint target, System.IntPtr size, System.IntPtr data, uint usage)
		{
						m_BufferData_0(target, size, data, usage);
			if(m_debug) CheckError("BufferData");
					}

		public static void BufferSubData(uint target, System.IntPtr offset, System.IntPtr size, System.IntPtr data)
		{
						m_BufferSubData_0(target, offset, size, data);
			if(m_debug) CheckError("BufferSubData");
					}

		public static uint CheckFramebufferStatus(uint target)
		{
						var result = m_CheckFramebufferStatus_0(target);
			if(m_debug) CheckError("CheckFramebufferStatus");
			return result;
					}

		public static void ClampColor(uint target, uint clamp)
		{
						m_ClampColor_0(target, clamp);
			if(m_debug) CheckError("ClampColor");
					}

		public static void Clear(uint mask)
		{
						m_Clear_0(mask);
			if(m_debug) CheckError("Clear");
					}

		public static void ClearBufferfi(uint buffer, int drawbuffer, float depth, int stencil)
		{
						m_ClearBufferfi_0(buffer, drawbuffer, depth, stencil);
			if(m_debug) CheckError("ClearBufferfi");
					}

		public static void ClearBufferfv(uint buffer, int drawbuffer, System.IntPtr value)
		{
						m_ClearBufferfv_0(buffer, drawbuffer, value);
			if(m_debug) CheckError("ClearBufferfv");
					}

		public static void ClearBufferfv(uint buffer, int drawbuffer, ref Color4 value)
		{
						m_ClearBufferfv_1(buffer, drawbuffer, ref value);
			if(m_debug) CheckError("ClearBufferfv");
					}

		public static void ClearBufferfv(uint buffer, int drawbuffer, ref float value)
		{
						m_ClearBufferfv_2(buffer, drawbuffer, ref value);
			if(m_debug) CheckError("ClearBufferfv");
					}

		public static void ClearBufferiv(uint buffer, int drawbuffer, System.IntPtr value)
		{
						m_ClearBufferiv_0(buffer, drawbuffer, value);
			if(m_debug) CheckError("ClearBufferiv");
					}

		public static void ClearBufferiv(uint buffer, int drawbuffer, ref Color4i value)
		{
						m_ClearBufferiv_1(buffer, drawbuffer, ref value);
			if(m_debug) CheckError("ClearBufferiv");
					}

		public static void ClearBufferiv(uint buffer, int drawbuffer, ref int value)
		{
						m_ClearBufferiv_2(buffer, drawbuffer, ref value);
			if(m_debug) CheckError("ClearBufferiv");
					}

		public static void ClearBufferuiv(uint buffer, int drawbuffer, System.IntPtr value)
		{
						m_ClearBufferuiv_0(buffer, drawbuffer, value);
			if(m_debug) CheckError("ClearBufferuiv");
					}

		public static void ClearBufferuiv(uint buffer, int drawbuffer, ref Color4ui value)
		{
						m_ClearBufferuiv_1(buffer, drawbuffer, ref value);
			if(m_debug) CheckError("ClearBufferuiv");
					}

		public static void ClearBufferuiv(uint buffer, int drawbuffer, ref uint value)
		{
						m_ClearBufferuiv_2(buffer, drawbuffer, ref value);
			if(m_debug) CheckError("ClearBufferuiv");
					}

		public static void ClearColor(float red, float green, float blue, float alpha)
		{
						m_ClearColor_0(red, green, blue, alpha);
			if(m_debug) CheckError("ClearColor");
					}

		public static void ClearColor(Color4 color)
		{
						m_ClearColor_1(color);
			if(m_debug) CheckError("ClearColor");
					}

		public static void ClearDepth(double depth)
		{
						m_ClearDepth_0(depth);
			if(m_debug) CheckError("ClearDepth");
					}

		public static void ClearStencil(int s)
		{
						m_ClearStencil_0(s);
			if(m_debug) CheckError("ClearStencil");
					}

		public static uint ClientWaitSync(System.IntPtr sync, uint flags, ulong timeout)
		{
						var result = m_ClientWaitSync_0(sync, flags, timeout);
			if(m_debug) CheckError("ClientWaitSync");
			return result;
					}

		public static void ColorMask(bool red, bool green, bool blue, bool alpha)
		{
						m_ColorMask_0(red, green, blue, alpha);
			if(m_debug) CheckError("ColorMask");
					}

		public static void ColorMaski(uint index, bool r, bool g, bool b, bool a)
		{
						m_ColorMaski_0(index, r, g, b, a);
			if(m_debug) CheckError("ColorMaski");
					}

		public static void CompileShader(uint shader)
		{
						m_CompileShader_0(shader);
			if(m_debug) CheckError("CompileShader");
					}

		public static void CompressedTexImage1D(uint target, int level, uint internalformat, int width, int border, int imageSize, System.IntPtr data)
		{
						m_CompressedTexImage1D_0(target, level, internalformat, width, border, imageSize, data);
			if(m_debug) CheckError("CompressedTexImage1D");
					}

		public static void CompressedTexImage2D(uint target, int level, uint internalformat, int width, int height, int border, int imageSize, System.IntPtr data)
		{
						m_CompressedTexImage2D_0(target, level, internalformat, width, height, border, imageSize, data);
			if(m_debug) CheckError("CompressedTexImage2D");
					}

		public static void CompressedTexImage3D(uint target, int level, uint internalformat, int width, int height, int depth, int border, int imageSize, System.IntPtr data)
		{
						m_CompressedTexImage3D_0(target, level, internalformat, width, height, depth, border, imageSize, data);
			if(m_debug) CheckError("CompressedTexImage3D");
					}

		public static void CompressedTexSubImage1D(uint target, int level, int xoffset, int width, uint format, int imageSize, System.IntPtr data)
		{
						m_CompressedTexSubImage1D_0(target, level, xoffset, width, format, imageSize, data);
			if(m_debug) CheckError("CompressedTexSubImage1D");
					}

		public static void CompressedTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, System.IntPtr data)
		{
						m_CompressedTexSubImage2D_0(target, level, xoffset, yoffset, width, height, format, imageSize, data);
			if(m_debug) CheckError("CompressedTexSubImage2D");
					}

		public static void CompressedTexSubImage2D(uint target, int level, Box2i imagePosition, uint format, int imageSize, System.IntPtr data)
		{
						m_CompressedTexSubImage2D_1(target, level, imagePosition, format, imageSize, data);
			if(m_debug) CheckError("CompressedTexSubImage2D");
					}

		public static void CompressedTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, System.IntPtr data)
		{
						m_CompressedTexSubImage3D_0(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
			if(m_debug) CheckError("CompressedTexSubImage3D");
					}

		public static void CompressedTexSubImage3D(uint target, int level, Box3i imagePosition, uint format, int imageSize, System.IntPtr data)
		{
						m_CompressedTexSubImage3D_1(target, level, imagePosition, format, imageSize, data);
			if(m_debug) CheckError("CompressedTexSubImage3D");
					}

		public static void CopyBufferSubData(uint readTarget, uint writeTarget, System.IntPtr readOffset, System.IntPtr writeOffset, System.IntPtr size)
		{
						m_CopyBufferSubData_0(readTarget, writeTarget, readOffset, writeOffset, size);
			if(m_debug) CheckError("CopyBufferSubData");
					}

		public static void CopyTexImage1D(uint target, int level, uint internalformat, int x, int y, int width, int border)
		{
						m_CopyTexImage1D_0(target, level, internalformat, x, y, width, border);
			if(m_debug) CheckError("CopyTexImage1D");
					}

		public static void CopyTexImage1D(uint target, int level, uint internalformat, Vector2i imagePosition, int width, int border)
		{
						m_CopyTexImage1D_1(target, level, internalformat, imagePosition, width, border);
			if(m_debug) CheckError("CopyTexImage1D");
					}

		public static void CopyTexImage2D(uint target, int level, uint internalformat, int x, int y, int width, int height, int border)
		{
						m_CopyTexImage2D_0(target, level, internalformat, x, y, width, height, border);
			if(m_debug) CheckError("CopyTexImage2D");
					}

		public static void CopyTexImage2D(uint target, int level, uint internalformat, Vector2i imagePosition, Vector2i imageSize, int border)
		{
						m_CopyTexImage2D_1(target, level, internalformat, imagePosition, imageSize, border);
			if(m_debug) CheckError("CopyTexImage2D");
					}

		public static void CopyTexImage2D(uint target, int level, uint internalformat, Box2i image, int border)
		{
						m_CopyTexImage2D_2(target, level, internalformat, image, border);
			if(m_debug) CheckError("CopyTexImage2D");
					}

		public static void CopyTexSubImage1D(uint target, int level, int xoffset, int x, int y, int width)
		{
						m_CopyTexSubImage1D_0(target, level, xoffset, x, y, width);
			if(m_debug) CheckError("CopyTexSubImage1D");
					}

		public static void CopyTexSubImage1D(uint target, int level, int xoffset, Vector2i imagePosition, int width)
		{
						m_CopyTexSubImage1D_1(target, level, xoffset, imagePosition, width);
			if(m_debug) CheckError("CopyTexSubImage1D");
					}

		public static void CopyTexSubImage2D(uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height)
		{
						m_CopyTexSubImage2D_0(target, level, xoffset, yoffset, x, y, width, height);
			if(m_debug) CheckError("CopyTexSubImage2D");
					}

		public static void CopyTexSubImage2D(uint target, int level, Vector2i texturePosition, Vector2i imagePosition, Vector2i size)
		{
						m_CopyTexSubImage2D_1(target, level, texturePosition, imagePosition, size);
			if(m_debug) CheckError("CopyTexSubImage2D");
					}

		public static void CopyTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height)
		{
						m_CopyTexSubImage3D_0(target, level, xoffset, yoffset, zoffset, x, y, width, height);
			if(m_debug) CheckError("CopyTexSubImage3D");
					}

		public static void CopyTexSubImage3D(uint target, int level, Vector3i texturePosition, Vector2i imagePosition, Vector2i size)
		{
						m_CopyTexSubImage3D_1(target, level, texturePosition, imagePosition, size);
			if(m_debug) CheckError("CopyTexSubImage3D");
					}

		public static uint CreateProgram()
		{
						var result = m_CreateProgram_0();
			if(m_debug) CheckError("CreateProgram");
			return result;
					}

		public static uint CreateShader(uint type)
		{
						var result = m_CreateShader_0(type);
			if(m_debug) CheckError("CreateShader");
			return result;
					}

		public static void CullFace(uint mode)
		{
						m_CullFace_0(mode);
			if(m_debug) CheckError("CullFace");
					}

		public static void DeleteBuffers(int n, System.IntPtr buffers)
		{
						m_DeleteBuffers_0(n, buffers);
			if(m_debug) CheckError("DeleteBuffers");
					}

		public static void DeleteBuffers(int n, uint[] buffers)
		{
						m_DeleteBuffers_1(n, buffers);
			if(m_debug) CheckError("DeleteBuffers");
					}

		public static void DeleteBuffers(int n, ref uint buffers)
		{
						m_DeleteBuffers_2(n, ref buffers);
			if(m_debug) CheckError("DeleteBuffers");
					}

		public static void DeleteFramebuffers(int n, System.IntPtr framebuffers)
		{
						m_DeleteFramebuffers_0(n, framebuffers);
			if(m_debug) CheckError("DeleteFramebuffers");
					}

		public static void DeleteFramebuffers(int n, uint[] framebuffers)
		{
						m_DeleteFramebuffers_1(n, framebuffers);
			if(m_debug) CheckError("DeleteFramebuffers");
					}

		public static void DeleteFramebuffers(int n, ref uint framebuffers)
		{
						m_DeleteFramebuffers_2(n, ref framebuffers);
			if(m_debug) CheckError("DeleteFramebuffers");
					}

		public static void DeleteProgram(uint program)
		{
						m_DeleteProgram_0(program);
			if(m_debug) CheckError("DeleteProgram");
					}

		public static void DeleteQueries(int n, System.IntPtr ids)
		{
						m_DeleteQueries_0(n, ids);
			if(m_debug) CheckError("DeleteQueries");
					}

		public static void DeleteQueries(int n, uint[] ids)
		{
						m_DeleteQueries_1(n, ids);
			if(m_debug) CheckError("DeleteQueries");
					}

		public static void DeleteQueries(int n, ref uint ids)
		{
						m_DeleteQueries_2(n, ref ids);
			if(m_debug) CheckError("DeleteQueries");
					}

		public static void DeleteRenderbuffers(int n, System.IntPtr renderbuffers)
		{
						m_DeleteRenderbuffers_0(n, renderbuffers);
			if(m_debug) CheckError("DeleteRenderbuffers");
					}

		public static void DeleteRenderbuffers(int n, uint[] renderbuffers)
		{
						m_DeleteRenderbuffers_1(n, renderbuffers);
			if(m_debug) CheckError("DeleteRenderbuffers");
					}

		public static void DeleteRenderbuffers(int n, ref uint renderbuffers)
		{
						m_DeleteRenderbuffers_2(n, ref renderbuffers);
			if(m_debug) CheckError("DeleteRenderbuffers");
					}

		public static void DeleteShader(uint shader)
		{
						m_DeleteShader_0(shader);
			if(m_debug) CheckError("DeleteShader");
					}

		public static void DeleteSync(System.IntPtr sync)
		{
						m_DeleteSync_0(sync);
			if(m_debug) CheckError("DeleteSync");
					}

		private static void DeleteTextures(int n, System.IntPtr textures)
		{
						m_DeleteTextures_0(n, textures);
			if(m_debug) CheckError("DeleteTextures");
					}

		private static void DeleteTextures(int n, uint[] textures)
		{
						m_DeleteTextures_1(n, textures);
			if(m_debug) CheckError("DeleteTextures");
					}

		private static void DeleteTextures(int n, ref uint textures)
		{
						m_DeleteTextures_2(n, ref textures);
			if(m_debug) CheckError("DeleteTextures");
					}

		public static void DeleteVertexArrays(int n, System.IntPtr arrays)
		{
						m_DeleteVertexArrays_0(n, arrays);
			if(m_debug) CheckError("DeleteVertexArrays");
					}

		public static void DeleteVertexArrays(int n, uint[] arrays)
		{
						m_DeleteVertexArrays_1(n, arrays);
			if(m_debug) CheckError("DeleteVertexArrays");
					}

		public static void DeleteVertexArrays(int n, ref uint arrays)
		{
						m_DeleteVertexArrays_2(n, ref arrays);
			if(m_debug) CheckError("DeleteVertexArrays");
					}

		public static void DepthFunc(uint func)
		{
						m_DepthFunc_0(func);
			if(m_debug) CheckError("DepthFunc");
					}

		public static void DepthMask(bool flag)
		{
						m_DepthMask_0(flag);
			if(m_debug) CheckError("DepthMask");
					}

		public static void DepthRange(double near, double far)
		{
						m_DepthRange_0(near, far);
			if(m_debug) CheckError("DepthRange");
					}

		public static void DetachShader(uint program, uint shader)
		{
						m_DetachShader_0(program, shader);
			if(m_debug) CheckError("DetachShader");
					}

		public static void Disable(uint cap)
		{
						m_Disable_0(cap);
			if(m_debug) CheckError("Disable");
					}

		public static void Disablei(uint target, uint index)
		{
						m_Disablei_0(target, index);
			if(m_debug) CheckError("Disablei");
					}

		public static void DisableVertexAttribArray(uint index)
		{
						m_DisableVertexAttribArray_0(index);
			if(m_debug) CheckError("DisableVertexAttribArray");
					}

		public static void DrawArrays(uint mode, int first, int count)
		{
						m_DrawArrays_0(mode, first, count);
			if(m_debug) CheckError("DrawArrays");
					}

		public static void DrawArraysInstanced(uint mode, int first, int count, int instancecount)
		{
						m_DrawArraysInstanced_0(mode, first, count, instancecount);
			if(m_debug) CheckError("DrawArraysInstanced");
					}

		public static void DrawBuffer(uint mode)
		{
						m_DrawBuffer_0(mode);
			if(m_debug) CheckError("DrawBuffer");
					}

		public static void DrawBuffers(int n, System.IntPtr bufs)
		{
						m_DrawBuffers_0(n, bufs);
			if(m_debug) CheckError("DrawBuffers");
					}

		public static void DrawBuffers(int n, uint[] bufs)
		{
						m_DrawBuffers_1(n, bufs);
			if(m_debug) CheckError("DrawBuffers");
					}

		public static void DrawBuffers(int n, ref uint bufs)
		{
						m_DrawBuffers_2(n, ref bufs);
			if(m_debug) CheckError("DrawBuffers");
					}

		public static void DrawElements(uint mode, int count, uint type, System.IntPtr indices)
		{
						m_DrawElements_0(mode, count, type, indices);
			if(m_debug) CheckError("DrawElements");
					}

		public static void DrawElements(uint mode, int count, uint type, byte[] indices)
		{
						m_DrawElements_1(mode, count, type, indices);
			if(m_debug) CheckError("DrawElements");
					}

		public static void DrawElements(uint mode, int count, uint type, ushort[] indices)
		{
						m_DrawElements_2(mode, count, type, indices);
			if(m_debug) CheckError("DrawElements");
					}

		public static void DrawElements(uint mode, int count, uint type, uint[] indices)
		{
						m_DrawElements_3(mode, count, type, indices);
			if(m_debug) CheckError("DrawElements");
					}

		public static void DrawElementsBaseVertex(uint mode, int count, uint type, System.IntPtr indices, int basevertex)
		{
						m_DrawElementsBaseVertex_0(mode, count, type, indices, basevertex);
			if(m_debug) CheckError("DrawElementsBaseVertex");
					}

		public static void DrawElementsBaseVertex(uint mode, int count, uint type, byte[] indices, int basevertex)
		{
						m_DrawElementsBaseVertex_1(mode, count, type, indices, basevertex);
			if(m_debug) CheckError("DrawElementsBaseVertex");
					}

		public static void DrawElementsBaseVertex(uint mode, int count, uint type, ushort[] indices, int basevertex)
		{
						m_DrawElementsBaseVertex_2(mode, count, type, indices, basevertex);
			if(m_debug) CheckError("DrawElementsBaseVertex");
					}

		public static void DrawElementsBaseVertex(uint mode, int count, uint type, uint[] indices, int basevertex)
		{
						m_DrawElementsBaseVertex_3(mode, count, type, indices, basevertex);
			if(m_debug) CheckError("DrawElementsBaseVertex");
					}

		public static void DrawElementsInstanced(uint mode, int count, uint type, System.IntPtr indices, int instancecount)
		{
						m_DrawElementsInstanced_0(mode, count, type, indices, instancecount);
			if(m_debug) CheckError("DrawElementsInstanced");
					}

		public static void DrawElementsInstanced(uint mode, int count, uint type, byte[] indices, int instancecount)
		{
						m_DrawElementsInstanced_1(mode, count, type, indices, instancecount);
			if(m_debug) CheckError("DrawElementsInstanced");
					}

		public static void DrawElementsInstanced(uint mode, int count, uint type, ushort[] indices, int instancecount)
		{
						m_DrawElementsInstanced_2(mode, count, type, indices, instancecount);
			if(m_debug) CheckError("DrawElementsInstanced");
					}

		public static void DrawElementsInstanced(uint mode, int count, uint type, uint[] indices, int instancecount)
		{
						m_DrawElementsInstanced_3(mode, count, type, indices, instancecount);
			if(m_debug) CheckError("DrawElementsInstanced");
					}

		public static void DrawElementsInstancedBaseVertex(uint mode, int count, uint type, System.IntPtr indices, int instancecount, int basevertex)
		{
						m_DrawElementsInstancedBaseVertex_0(mode, count, type, indices, instancecount, basevertex);
			if(m_debug) CheckError("DrawElementsInstancedBaseVertex");
					}

		public static void DrawElementsInstancedBaseVertex(uint mode, int count, uint type, byte[] indices, int instancecount, int basevertex)
		{
						m_DrawElementsInstancedBaseVertex_1(mode, count, type, indices, instancecount, basevertex);
			if(m_debug) CheckError("DrawElementsInstancedBaseVertex");
					}

		public static void DrawElementsInstancedBaseVertex(uint mode, int count, uint type, ushort[] indices, int instancecount, int basevertex)
		{
						m_DrawElementsInstancedBaseVertex_2(mode, count, type, indices, instancecount, basevertex);
			if(m_debug) CheckError("DrawElementsInstancedBaseVertex");
					}

		public static void DrawElementsInstancedBaseVertex(uint mode, int count, uint type, uint[] indices, int instancecount, int basevertex)
		{
						m_DrawElementsInstancedBaseVertex_3(mode, count, type, indices, instancecount, basevertex);
			if(m_debug) CheckError("DrawElementsInstancedBaseVertex");
					}

		public static void DrawRangeElements(uint mode, uint start, uint end, int count, uint type, System.IntPtr indices)
		{
						m_DrawRangeElements_0(mode, start, end, count, type, indices);
			if(m_debug) CheckError("DrawRangeElements");
					}

		public static void DrawRangeElements(uint mode, uint start, uint end, int count, uint type, byte[] indices)
		{
						m_DrawRangeElements_1(mode, start, end, count, type, indices);
			if(m_debug) CheckError("DrawRangeElements");
					}

		public static void DrawRangeElements(uint mode, uint start, uint end, int count, uint type, ushort[] indices)
		{
						m_DrawRangeElements_2(mode, start, end, count, type, indices);
			if(m_debug) CheckError("DrawRangeElements");
					}

		public static void DrawRangeElements(uint mode, uint start, uint end, int count, uint type, uint[] indices)
		{
						m_DrawRangeElements_3(mode, start, end, count, type, indices);
			if(m_debug) CheckError("DrawRangeElements");
					}

		public static void DrawRangeElementsBaseVertex(uint mode, uint start, uint end, int count, uint type, System.IntPtr indices, int basevertex)
		{
						m_DrawRangeElementsBaseVertex_0(mode, start, end, count, type, indices, basevertex);
			if(m_debug) CheckError("DrawRangeElementsBaseVertex");
					}

		public static void DrawRangeElementsBaseVertex(uint mode, uint start, uint end, int count, uint type, byte[] indices, int basevertex)
		{
						m_DrawRangeElementsBaseVertex_1(mode, start, end, count, type, indices, basevertex);
			if(m_debug) CheckError("DrawRangeElementsBaseVertex");
					}

		public static void DrawRangeElementsBaseVertex(uint mode, uint start, uint end, int count, uint type, ushort[] indices, int basevertex)
		{
						m_DrawRangeElementsBaseVertex_2(mode, start, end, count, type, indices, basevertex);
			if(m_debug) CheckError("DrawRangeElementsBaseVertex");
					}

		public static void DrawRangeElementsBaseVertex(uint mode, uint start, uint end, int count, uint type, uint[] indices, int basevertex)
		{
						m_DrawRangeElementsBaseVertex_3(mode, start, end, count, type, indices, basevertex);
			if(m_debug) CheckError("DrawRangeElementsBaseVertex");
					}

		public static void Enable(uint cap)
		{
						m_Enable_0(cap);
			if(m_debug) CheckError("Enable");
					}

		public static void Enablei(uint target, uint index)
		{
						m_Enablei_0(target, index);
			if(m_debug) CheckError("Enablei");
					}

		public static void EnableVertexAttribArray(uint index)
		{
						m_EnableVertexAttribArray_0(index);
			if(m_debug) CheckError("EnableVertexAttribArray");
					}

		public static void EndConditionalRender()
		{
						m_EndConditionalRender_0();
			if(m_debug) CheckError("EndConditionalRender");
					}

		public static void EndQuery(uint target)
		{
						m_EndQuery_0(target);
			if(m_debug) CheckError("EndQuery");
					}

		public static void EndTransformFeedback()
		{
						m_EndTransformFeedback_0();
			if(m_debug) CheckError("EndTransformFeedback");
					}

		public static System.IntPtr FenceSync(uint condition, uint flags)
		{
						var result = m_FenceSync_0(condition, flags);
			if(m_debug) CheckError("FenceSync");
			return result;
					}

		public static void Finish()
		{
						m_Finish_0();
			if(m_debug) CheckError("Finish");
					}

		public static void Flush()
		{
						m_Flush_0();
			if(m_debug) CheckError("Flush");
					}

		public static void FlushMappedBufferRange(uint target, System.IntPtr offset, System.IntPtr length)
		{
						m_FlushMappedBufferRange_0(target, offset, length);
			if(m_debug) CheckError("FlushMappedBufferRange");
					}

		public static void FramebufferRenderbuffer(uint target, uint attachment, uint renderbuffertarget, uint renderbuffer)
		{
						m_FramebufferRenderbuffer_0(target, attachment, renderbuffertarget, renderbuffer);
			if(m_debug) CheckError("FramebufferRenderbuffer");
					}

		public static void FramebufferTexture(uint target, uint attachment, uint texture, int level)
		{
						m_FramebufferTexture_0(target, attachment, texture, level);
			if(m_debug) CheckError("FramebufferTexture");
					}

		public static void FramebufferTexture1D(uint target, uint attachment, uint textarget, uint texture, int level)
		{
						m_FramebufferTexture1D_0(target, attachment, textarget, texture, level);
			if(m_debug) CheckError("FramebufferTexture1D");
					}

		public static void FramebufferTexture2D(uint target, uint attachment, uint textarget, uint texture, int level)
		{
						m_FramebufferTexture2D_0(target, attachment, textarget, texture, level);
			if(m_debug) CheckError("FramebufferTexture2D");
					}

		public static void FramebufferTexture3D(uint target, uint attachment, uint textarget, uint texture, int level, int zoffset)
		{
						m_FramebufferTexture3D_0(target, attachment, textarget, texture, level, zoffset);
			if(m_debug) CheckError("FramebufferTexture3D");
					}

		public static void FramebufferTextureLayer(uint target, uint attachment, uint texture, int level, int layer)
		{
						m_FramebufferTextureLayer_0(target, attachment, texture, level, layer);
			if(m_debug) CheckError("FramebufferTextureLayer");
					}

		public static void FrontFace(uint mode)
		{
						m_FrontFace_0(mode);
			if(m_debug) CheckError("FrontFace");
					}

		public static void GenBuffers(int n, System.IntPtr buffers)
		{
						m_GenBuffers_0(n, buffers);
			if(m_debug) CheckError("GenBuffers");
					}

		public static void GenBuffers(int n, uint[] buffers)
		{
						m_GenBuffers_1(n, buffers);
			if(m_debug) CheckError("GenBuffers");
					}

		public static void GenBuffers(int n, out uint buffers)
		{
						m_GenBuffers_2(n, out buffers);
			if(m_debug) CheckError("GenBuffers");
					}

		public static void GenerateMipmap(uint target)
		{
						m_GenerateMipmap_0(target);
			if(m_debug) CheckError("GenerateMipmap");
					}

		public static void GenFramebuffers(int n, System.IntPtr framebuffers)
		{
						m_GenFramebuffers_0(n, framebuffers);
			if(m_debug) CheckError("GenFramebuffers");
					}

		public static void GenFramebuffers(int n, uint[] framebuffers)
		{
						m_GenFramebuffers_1(n, framebuffers);
			if(m_debug) CheckError("GenFramebuffers");
					}

		public static void GenFramebuffers(int n, out uint framebuffers)
		{
						m_GenFramebuffers_2(n, out framebuffers);
			if(m_debug) CheckError("GenFramebuffers");
					}

		public static void GenQueries(int n, System.IntPtr ids)
		{
						m_GenQueries_0(n, ids);
			if(m_debug) CheckError("GenQueries");
					}

		public static void GenQueries(int n, uint[] ids)
		{
						m_GenQueries_1(n, ids);
			if(m_debug) CheckError("GenQueries");
					}

		public static void GenQueries(int n, out uint ids)
		{
						m_GenQueries_2(n, out ids);
			if(m_debug) CheckError("GenQueries");
					}

		public static void GenRenderbuffers(int n, System.IntPtr renderbuffers)
		{
						m_GenRenderbuffers_0(n, renderbuffers);
			if(m_debug) CheckError("GenRenderbuffers");
					}

		public static void GenRenderbuffers(int n, uint[] renderbuffers)
		{
						m_GenRenderbuffers_1(n, renderbuffers);
			if(m_debug) CheckError("GenRenderbuffers");
					}

		public static void GenRenderbuffers(int n, out uint renderbuffers)
		{
						m_GenRenderbuffers_2(n, out renderbuffers);
			if(m_debug) CheckError("GenRenderbuffers");
					}

		private static void GenTextures(int n, System.IntPtr textures)
		{
						m_GenTextures_0(n, textures);
			if(m_debug) CheckError("GenTextures");
					}

		private static void GenTextures(int n, uint[] textures)
		{
						m_GenTextures_1(n, textures);
			if(m_debug) CheckError("GenTextures");
					}

		private static void GenTextures(int n, out uint textures)
		{
						m_GenTextures_2(n, out textures);
			if(m_debug) CheckError("GenTextures");
					}

		public static void GenVertexArrays(int n, System.IntPtr arrays)
		{
						m_GenVertexArrays_0(n, arrays);
			if(m_debug) CheckError("GenVertexArrays");
					}

		public static void GenVertexArrays(int n, uint[] arrays)
		{
						m_GenVertexArrays_1(n, arrays);
			if(m_debug) CheckError("GenVertexArrays");
					}

		public static void GenVertexArrays(int n, out uint arrays)
		{
						m_GenVertexArrays_2(n, out arrays);
			if(m_debug) CheckError("GenVertexArrays");
					}

		public static void GetActiveAttrib(uint program, uint index, int bufSize, System.IntPtr length, System.IntPtr size, System.IntPtr type, string name)
		{
						m_GetActiveAttrib_0(program, index, bufSize, length, size, type, name);
			if(m_debug) CheckError("GetActiveAttrib");
					}

		public static void GetActiveAttrib(uint program, uint index, int bufSize, out int length, out int size, out uint type, byte[] name)
		{
						m_GetActiveAttrib_1(program, index, bufSize, out length, out size, out type, name);
			if(m_debug) CheckError("GetActiveAttrib");
					}

		public static void GetActiveUniform(uint program, uint index, int bufSize, System.IntPtr length, System.IntPtr size, System.IntPtr type, string name)
		{
						m_GetActiveUniform_0(program, index, bufSize, length, size, type, name);
			if(m_debug) CheckError("GetActiveUniform");
					}

		public static void GetActiveUniform(uint program, uint index, int bufSize, out int length, out int size, out uint type, byte[] name)
		{
						m_GetActiveUniform_1(program, index, bufSize, out length, out size, out type, name);
			if(m_debug) CheckError("GetActiveUniform");
					}

		public static void GetActiveUniformBlockiv(uint program, uint uniformBlockIndex, uint pname, System.IntPtr _params)
		{
						m_GetActiveUniformBlockiv_0(program, uniformBlockIndex, pname, _params);
			if(m_debug) CheckError("GetActiveUniformBlockiv");
					}

		public static void GetActiveUniformBlockiv(uint program, uint uniformBlockIndex, uint pname, int[] _params)
		{
						m_GetActiveUniformBlockiv_1(program, uniformBlockIndex, pname, _params);
			if(m_debug) CheckError("GetActiveUniformBlockiv");
					}

		public static void GetActiveUniformBlockiv(uint program, uint uniformBlockIndex, uint pname, out int _params)
		{
						m_GetActiveUniformBlockiv_2(program, uniformBlockIndex, pname, out _params);
			if(m_debug) CheckError("GetActiveUniformBlockiv");
					}

		public static void GetActiveUniformBlockName(uint program, uint uniformBlockIndex, int bufSize, System.IntPtr length, System.IntPtr uniformBlockName)
		{
						m_GetActiveUniformBlockName_0(program, uniformBlockIndex, bufSize, length, uniformBlockName);
			if(m_debug) CheckError("GetActiveUniformBlockName");
					}

		public static void GetActiveUniformBlockName(uint program, uint uniformBlockIndex, int bufSize, out int length, byte[] uniformBlockName)
		{
						m_GetActiveUniformBlockName_1(program, uniformBlockIndex, bufSize, out length, uniformBlockName);
			if(m_debug) CheckError("GetActiveUniformBlockName");
					}

		public static void GetActiveUniformName(uint program, uint uniformIndex, int bufSize, System.IntPtr length, System.IntPtr uniformName)
		{
						m_GetActiveUniformName_0(program, uniformIndex, bufSize, length, uniformName);
			if(m_debug) CheckError("GetActiveUniformName");
					}

		public static void GetActiveUniformName(uint program, uint uniformIndex, int bufSize, out int length, byte[] uniformName)
		{
						m_GetActiveUniformName_1(program, uniformIndex, bufSize, out length, uniformName);
			if(m_debug) CheckError("GetActiveUniformName");
					}

		public static void GetActiveUniformsiv(uint program, int uniformCount, System.IntPtr uniformIndices, uint pname, System.IntPtr _params)
		{
						m_GetActiveUniformsiv_0(program, uniformCount, uniformIndices, pname, _params);
			if(m_debug) CheckError("GetActiveUniformsiv");
					}

		public static void GetActiveUniformsiv(uint program, int uniformCount, uint[] uniformIndices, uint pname, int[] _params)
		{
						m_GetActiveUniformsiv_1(program, uniformCount, uniformIndices, pname, _params);
			if(m_debug) CheckError("GetActiveUniformsiv");
					}

		public static void GetActiveUniformsiv(uint program, int uniformCount, out int uniformIndices, uint pname, int[] _params)
		{
						m_GetActiveUniformsiv_2(program, uniformCount, out uniformIndices, pname, _params);
			if(m_debug) CheckError("GetActiveUniformsiv");
					}

		public static void GetActiveUniformsiv(uint program, int uniformCount, uint[] uniformIndices, uint pname, ref int _params)
		{
						m_GetActiveUniformsiv_3(program, uniformCount, uniformIndices, pname, ref _params);
			if(m_debug) CheckError("GetActiveUniformsiv");
					}

		public static void GetActiveUniformsiv(uint program, int uniformCount, out int uniformIndices, uint pname, ref int _params)
		{
						m_GetActiveUniformsiv_4(program, uniformCount, out uniformIndices, pname, ref _params);
			if(m_debug) CheckError("GetActiveUniformsiv");
					}

		public static void GetAttachedShaders(uint program, int maxCount, System.IntPtr count, System.IntPtr shaders)
		{
						m_GetAttachedShaders_0(program, maxCount, count, shaders);
			if(m_debug) CheckError("GetAttachedShaders");
					}

		public static void GetAttachedShaders(uint program, int maxCount, uint count, uint[] shaders)
		{
						m_GetAttachedShaders_1(program, maxCount, count, shaders);
			if(m_debug) CheckError("GetAttachedShaders");
					}

		public static int GetAttribLocation(uint program, System.IntPtr name)
		{
						var result = m_GetAttribLocation_0(program, name);
			if(m_debug) CheckError("GetAttribLocation");
			return result;
					}

		public static int GetAttribLocation(uint program, byte[] name)
		{
						var result = m_GetAttribLocation_1(program, name);
			if(m_debug) CheckError("GetAttribLocation");
			return result;
					}

		public static int GetAttribLocation(uint program, string name)
		{
						var result = m_GetAttribLocation_2(program, name);
			if(m_debug) CheckError("GetAttribLocation");
			return result;
					}

		public static void GetBooleani_v(uint target, uint index, System.IntPtr data)
		{
						m_GetBooleani_v_0(target, index, data);
			if(m_debug) CheckError("GetBooleani_v");
					}

		public static void GetBooleani_v(uint target, uint index, out bool data)
		{
						m_GetBooleani_v_1(target, index, out data);
			if(m_debug) CheckError("GetBooleani_v");
					}

		public static void GetBooleanv(uint pname, System.IntPtr data)
		{
						m_GetBooleanv_0(pname, data);
			if(m_debug) CheckError("GetBooleanv");
					}

		public static void GetBooleanv(uint pname, out bool data)
		{
						m_GetBooleanv_1(pname, out data);
			if(m_debug) CheckError("GetBooleanv");
					}

		public static void GetBufferParameteri64v(uint target, uint pname, System.IntPtr _params)
		{
						m_GetBufferParameteri64v_0(target, pname, _params);
			if(m_debug) CheckError("GetBufferParameteri64v");
					}

		public static void GetBufferParameteri64v(uint target, uint pname, out long _params)
		{
						m_GetBufferParameteri64v_1(target, pname, out _params);
			if(m_debug) CheckError("GetBufferParameteri64v");
					}

		public static void GetBufferParameteriv(uint target, uint pname, System.IntPtr _params)
		{
						m_GetBufferParameteriv_0(target, pname, _params);
			if(m_debug) CheckError("GetBufferParameteriv");
					}

		public static void GetBufferParameteriv(uint target, uint pname, out int _params)
		{
						m_GetBufferParameteriv_1(target, pname, out _params);
			if(m_debug) CheckError("GetBufferParameteriv");
					}

		public static void GetBufferPointerv(uint target, uint pname, System.IntPtr _params)
		{
						m_GetBufferPointerv_0(target, pname, _params);
			if(m_debug) CheckError("GetBufferPointerv");
					}

		public static void GetBufferPointerv(uint target, uint pname, out System.IntPtr _params)
		{
						m_GetBufferPointerv_1(target, pname, out _params);
			if(m_debug) CheckError("GetBufferPointerv");
					}

		public static void GetBufferSubData(uint target, System.IntPtr offset, System.IntPtr size, System.IntPtr data)
		{
						m_GetBufferSubData_0(target, offset, size, data);
			if(m_debug) CheckError("GetBufferSubData");
					}

		public static void GetCompressedTexImage(uint target, int level, System.IntPtr img)
		{
						m_GetCompressedTexImage_0(target, level, img);
			if(m_debug) CheckError("GetCompressedTexImage");
					}

		public static void GetDoublev(uint pname, System.IntPtr data)
		{
						m_GetDoublev_0(pname, data);
			if(m_debug) CheckError("GetDoublev");
					}

		public static void GetDoublev(uint pname, double[] data)
		{
						m_GetDoublev_1(pname, data);
			if(m_debug) CheckError("GetDoublev");
					}

		public static void GetDoublev(uint pname, out double data)
		{
						m_GetDoublev_2(pname, out data);
			if(m_debug) CheckError("GetDoublev");
					}

		public static void GetDoublev(uint pname, out Vector2d data)
		{
						m_GetDoublev_3(pname, out data);
			if(m_debug) CheckError("GetDoublev");
					}

		public static void GetDoublev(uint pname, out Vector3d data)
		{
						m_GetDoublev_4(pname, out data);
			if(m_debug) CheckError("GetDoublev");
					}

		public static void GetDoublev(uint pname, out Vector4d data)
		{
						m_GetDoublev_5(pname, out data);
			if(m_debug) CheckError("GetDoublev");
					}

		public static void GetDoublev(uint pname, out Color3d data)
		{
						m_GetDoublev_6(pname, out data);
			if(m_debug) CheckError("GetDoublev");
					}

		public static void GetDoublev(uint pname, out Color4d data)
		{
						m_GetDoublev_7(pname, out data);
			if(m_debug) CheckError("GetDoublev");
					}

		public static void GetDoublev(uint pname, out Box2d data)
		{
						m_GetDoublev_8(pname, out data);
			if(m_debug) CheckError("GetDoublev");
					}

		public static void GetDoublev(uint pname, out Box3d data)
		{
						m_GetDoublev_9(pname, out data);
			if(m_debug) CheckError("GetDoublev");
					}

		public static uint GetError()
		{
						var result = m_GetError_0();
			if(m_debug) CheckError("GetError");
			return result;
					}

		public static void GetFloatv(uint pname, System.IntPtr data)
		{
						m_GetFloatv_0(pname, data);
			if(m_debug) CheckError("GetFloatv");
					}

		public static void GetFloatv(uint pname, float[] data)
		{
						m_GetFloatv_1(pname, data);
			if(m_debug) CheckError("GetFloatv");
					}

		public static void GetFloatv(uint pname, out float data)
		{
						m_GetFloatv_2(pname, out data);
			if(m_debug) CheckError("GetFloatv");
					}

		public static void GetFloatv(uint pname, out Vector2 data)
		{
						m_GetFloatv_3(pname, out data);
			if(m_debug) CheckError("GetFloatv");
					}

		public static void GetFloatv(uint pname, out Vector3 data)
		{
						m_GetFloatv_4(pname, out data);
			if(m_debug) CheckError("GetFloatv");
					}

		public static void GetFloatv(uint pname, out Vector4 data)
		{
						m_GetFloatv_5(pname, out data);
			if(m_debug) CheckError("GetFloatv");
					}

		public static void GetFloatv(uint pname, out Color3 data)
		{
						m_GetFloatv_6(pname, out data);
			if(m_debug) CheckError("GetFloatv");
					}

		public static void GetFloatv(uint pname, out Color4 data)
		{
						m_GetFloatv_7(pname, out data);
			if(m_debug) CheckError("GetFloatv");
					}

		public static void GetFloatv(uint pname, out Box2 data)
		{
						m_GetFloatv_8(pname, out data);
			if(m_debug) CheckError("GetFloatv");
					}

		public static void GetFloatv(uint pname, out Box3 data)
		{
						m_GetFloatv_9(pname, out data);
			if(m_debug) CheckError("GetFloatv");
					}

		public static int GetFragDataLocation(uint program, string name)
		{
						var result = m_GetFragDataLocation_0(program, name);
			if(m_debug) CheckError("GetFragDataLocation");
			return result;
					}

		public static void GetFramebufferAttachmentParameteriv(uint target, uint attachment, uint pname, System.IntPtr _params)
		{
						m_GetFramebufferAttachmentParameteriv_0(target, attachment, pname, _params);
			if(m_debug) CheckError("GetFramebufferAttachmentParameteriv");
					}

		public static void GetFramebufferAttachmentParameteriv(uint target, uint attachment, uint pname, out int _params)
		{
						m_GetFramebufferAttachmentParameteriv_1(target, attachment, pname, out _params);
			if(m_debug) CheckError("GetFramebufferAttachmentParameteriv");
					}

		public static void GetInteger64i_v(uint target, uint index, System.IntPtr data)
		{
						m_GetInteger64i_v_0(target, index, data);
			if(m_debug) CheckError("GetInteger64i_v");
					}

		public static void GetInteger64i_v(uint target, uint index, long[] data)
		{
						m_GetInteger64i_v_1(target, index, data);
			if(m_debug) CheckError("GetInteger64i_v");
					}

		public static void GetInteger64i_v(uint target, uint index, out long data)
		{
						m_GetInteger64i_v_2(target, index, out data);
			if(m_debug) CheckError("GetInteger64i_v");
					}

		public static void GetInteger64v(uint pname, System.IntPtr data)
		{
						m_GetInteger64v_0(pname, data);
			if(m_debug) CheckError("GetInteger64v");
					}

		public static void GetInteger64v(uint pname, long[] data)
		{
						m_GetInteger64v_1(pname, data);
			if(m_debug) CheckError("GetInteger64v");
					}

		public static void GetInteger64v(uint pname, out long data)
		{
						m_GetInteger64v_2(pname, out data);
			if(m_debug) CheckError("GetInteger64v");
					}

		public static void GetIntegeri_v(uint target, uint index, System.IntPtr data)
		{
						m_GetIntegeri_v_0(target, index, data);
			if(m_debug) CheckError("GetIntegeri_v");
					}

		public static void GetIntegeri_v(uint target, uint index, int[] data)
		{
						m_GetIntegeri_v_1(target, index, data);
			if(m_debug) CheckError("GetIntegeri_v");
					}

		public static void GetIntegeri_v(uint target, uint index, out int data)
		{
						m_GetIntegeri_v_2(target, index, out data);
			if(m_debug) CheckError("GetIntegeri_v");
					}

		public static void GetIntegerv(uint pname, System.IntPtr data)
		{
						m_GetIntegerv_0(pname, data);
			if(m_debug) CheckError("GetIntegerv");
					}

		public static void GetIntegerv(uint pname, int[] data)
		{
						m_GetIntegerv_1(pname, data);
			if(m_debug) CheckError("GetIntegerv");
					}

		public static void GetIntegerv(uint pname, out int data)
		{
						m_GetIntegerv_2(pname, out data);
			if(m_debug) CheckError("GetIntegerv");
					}

		public static void GetMultisamplefv(uint pname, uint index, System.IntPtr val)
		{
						m_GetMultisamplefv_0(pname, index, val);
			if(m_debug) CheckError("GetMultisamplefv");
					}

		public static void GetMultisamplefv(uint pname, uint index, out float val)
		{
						m_GetMultisamplefv_1(pname, index, out val);
			if(m_debug) CheckError("GetMultisamplefv");
					}

		public static void GetProgramInfoLog(uint program, int bufSize, System.IntPtr length, string infoLog)
		{
						m_GetProgramInfoLog_0(program, bufSize, length, infoLog);
			if(m_debug) CheckError("GetProgramInfoLog");
					}

		public static void GetProgramInfoLog(uint program, int bufSize, out int length, byte[] infoLog)
		{
						m_GetProgramInfoLog_1(program, bufSize, out length, infoLog);
			if(m_debug) CheckError("GetProgramInfoLog");
					}

		public static void GetProgramiv(uint program, uint pname, System.IntPtr _params)
		{
						m_GetProgramiv_0(program, pname, _params);
			if(m_debug) CheckError("GetProgramiv");
					}

		public static void GetProgramiv(uint program, uint pname, int[] _params)
		{
						m_GetProgramiv_1(program, pname, _params);
			if(m_debug) CheckError("GetProgramiv");
					}

		public static void GetProgramiv(uint program, uint pname, out int _params)
		{
						m_GetProgramiv_2(program, pname, out _params);
			if(m_debug) CheckError("GetProgramiv");
					}

		public static void GetQueryiv(uint target, uint pname, System.IntPtr _params)
		{
						m_GetQueryiv_0(target, pname, _params);
			if(m_debug) CheckError("GetQueryiv");
					}

		public static void GetQueryObjectiv(uint id, uint pname, System.IntPtr _params)
		{
						m_GetQueryObjectiv_0(id, pname, _params);
			if(m_debug) CheckError("GetQueryObjectiv");
					}

		public static void GetQueryObjectuiv(uint id, uint pname, System.IntPtr _params)
		{
						m_GetQueryObjectuiv_0(id, pname, _params);
			if(m_debug) CheckError("GetQueryObjectuiv");
					}

		public static void GetRenderbufferParameteriv(uint target, uint pname, System.IntPtr _params)
		{
						m_GetRenderbufferParameteriv_0(target, pname, _params);
			if(m_debug) CheckError("GetRenderbufferParameteriv");
					}

		public static void GetShaderInfoLog(uint shader, int bufSize, System.IntPtr length, string infoLog)
		{
						m_GetShaderInfoLog_0(shader, bufSize, length, infoLog);
			if(m_debug) CheckError("GetShaderInfoLog");
					}

		public static void GetShaderInfoLog(uint shader, int bufSize, out int length, byte[] infoLog)
		{
						m_GetShaderInfoLog_1(shader, bufSize, out length, infoLog);
			if(m_debug) CheckError("GetShaderInfoLog");
					}

		public static void GetShaderiv(uint shader, uint pname, System.IntPtr _params)
		{
						m_GetShaderiv_0(shader, pname, _params);
			if(m_debug) CheckError("GetShaderiv");
					}

		public static void GetShaderiv(uint shader, uint pname, int[] _params)
		{
						m_GetShaderiv_1(shader, pname, _params);
			if(m_debug) CheckError("GetShaderiv");
					}

		public static void GetShaderiv(uint shader, uint pname, out int _params)
		{
						m_GetShaderiv_2(shader, pname, out _params);
			if(m_debug) CheckError("GetShaderiv");
					}

		public static void GetShaderSource(uint shader, int bufSize, System.IntPtr length, string source)
		{
						m_GetShaderSource_0(shader, bufSize, length, source);
			if(m_debug) CheckError("GetShaderSource");
					}

		public static System.IntPtr GetString(uint name)
		{
						var result = m_GetString_0(name);
			if(m_debug) CheckError("GetString");
			return result;
					}

		public static System.IntPtr GetStringi(uint name, uint index)
		{
						var result = m_GetStringi_0(name, index);
			if(m_debug) CheckError("GetStringi");
			return result;
					}

		public static void GetSynciv(System.IntPtr sync, uint pname, int bufSize, System.IntPtr length, System.IntPtr values)
		{
						m_GetSynciv_0(sync, pname, bufSize, length, values);
			if(m_debug) CheckError("GetSynciv");
					}

		public static void GetTexImage(uint target, int level, uint format, uint type, System.IntPtr pixels)
		{
						m_GetTexImage_0(target, level, format, type, pixels);
			if(m_debug) CheckError("GetTexImage");
					}

		public static void GetTexLevelParameterfv(uint target, int level, uint pname, System.IntPtr _params)
		{
						m_GetTexLevelParameterfv_0(target, level, pname, _params);
			if(m_debug) CheckError("GetTexLevelParameterfv");
					}

		public static void GetTexLevelParameteriv(uint target, int level, uint pname, System.IntPtr _params)
		{
						m_GetTexLevelParameteriv_0(target, level, pname, _params);
			if(m_debug) CheckError("GetTexLevelParameteriv");
					}

		public static void GetTexParameterfv(uint target, uint pname, System.IntPtr _params)
		{
						m_GetTexParameterfv_0(target, pname, _params);
			if(m_debug) CheckError("GetTexParameterfv");
					}

		public static void GetTexParameterIiv(uint target, uint pname, System.IntPtr _params)
		{
						m_GetTexParameterIiv_0(target, pname, _params);
			if(m_debug) CheckError("GetTexParameterIiv");
					}

		public static void GetTexParameterIuiv(uint target, uint pname, System.IntPtr _params)
		{
						m_GetTexParameterIuiv_0(target, pname, _params);
			if(m_debug) CheckError("GetTexParameterIuiv");
					}

		public static void GetTexParameteriv(uint target, uint pname, System.IntPtr _params)
		{
						m_GetTexParameteriv_0(target, pname, _params);
			if(m_debug) CheckError("GetTexParameteriv");
					}

		public static void GetTransformFeedbackVarying(uint program, uint index, int bufSize, System.IntPtr length, System.IntPtr size, System.IntPtr type, string name)
		{
						m_GetTransformFeedbackVarying_0(program, index, bufSize, length, size, type, name);
			if(m_debug) CheckError("GetTransformFeedbackVarying");
					}

		public static uint GetUniformBlockIndex(uint program, string uniformBlockName)
		{
						var result = m_GetUniformBlockIndex_0(program, uniformBlockName);
			if(m_debug) CheckError("GetUniformBlockIndex");
			return result;
					}

		public static void GetUniformfv(uint program, int location, System.IntPtr _params)
		{
						m_GetUniformfv_0(program, location, _params);
			if(m_debug) CheckError("GetUniformfv");
					}

		public static void GetUniformIndices(uint program, int uniformCount, System.IntPtr uniformNames, System.IntPtr uniformIndices)
		{
						m_GetUniformIndices_0(program, uniformCount, uniformNames, uniformIndices);
			if(m_debug) CheckError("GetUniformIndices");
					}

		public static void GetUniformiv(uint program, int location, System.IntPtr _params)
		{
						m_GetUniformiv_0(program, location, _params);
			if(m_debug) CheckError("GetUniformiv");
					}

		public static int GetUniformLocation(uint program, System.IntPtr name)
		{
						var result = m_GetUniformLocation_0(program, name);
			if(m_debug) CheckError("GetUniformLocation");
			return result;
					}

		public static int GetUniformLocation(uint program, byte[] name)
		{
						var result = m_GetUniformLocation_1(program, name);
			if(m_debug) CheckError("GetUniformLocation");
			return result;
					}

		public static int GetUniformLocation(uint program, string name)
		{
						var result = m_GetUniformLocation_2(program, name);
			if(m_debug) CheckError("GetUniformLocation");
			return result;
					}

		public static void GetUniformuiv(uint program, int location, System.IntPtr _params)
		{
						m_GetUniformuiv_0(program, location, _params);
			if(m_debug) CheckError("GetUniformuiv");
					}

		public static void GetVertexAttribdv(uint index, uint pname, System.IntPtr _params)
		{
						m_GetVertexAttribdv_0(index, pname, _params);
			if(m_debug) CheckError("GetVertexAttribdv");
					}

		public static void GetVertexAttribfv(uint index, uint pname, System.IntPtr _params)
		{
						m_GetVertexAttribfv_0(index, pname, _params);
			if(m_debug) CheckError("GetVertexAttribfv");
					}

		public static void GetVertexAttribIiv(uint index, uint pname, System.IntPtr _params)
		{
						m_GetVertexAttribIiv_0(index, pname, _params);
			if(m_debug) CheckError("GetVertexAttribIiv");
					}

		public static void GetVertexAttribIuiv(uint index, uint pname, System.IntPtr _params)
		{
						m_GetVertexAttribIuiv_0(index, pname, _params);
			if(m_debug) CheckError("GetVertexAttribIuiv");
					}

		public static void GetVertexAttribiv(uint index, uint pname, System.IntPtr _params)
		{
						m_GetVertexAttribiv_0(index, pname, _params);
			if(m_debug) CheckError("GetVertexAttribiv");
					}

		public static void GetVertexAttribPointerv(uint index, uint pname, System.IntPtr pointer)
		{
						m_GetVertexAttribPointerv_0(index, pname, pointer);
			if(m_debug) CheckError("GetVertexAttribPointerv");
					}

		public static void Hint(uint target, uint mode)
		{
						m_Hint_0(target, mode);
			if(m_debug) CheckError("Hint");
					}

		public static bool IsBuffer(uint buffer)
		{
						var result = m_IsBuffer_0(buffer);
			if(m_debug) CheckError("IsBuffer");
			return result;
					}

		public static bool IsEnabled(uint cap)
		{
						var result = m_IsEnabled_0(cap);
			if(m_debug) CheckError("IsEnabled");
			return result;
					}

		public static bool IsEnabledi(uint target, uint index)
		{
						var result = m_IsEnabledi_0(target, index);
			if(m_debug) CheckError("IsEnabledi");
			return result;
					}

		public static bool IsFramebuffer(uint framebuffer)
		{
						var result = m_IsFramebuffer_0(framebuffer);
			if(m_debug) CheckError("IsFramebuffer");
			return result;
					}

		public static bool IsProgram(uint program)
		{
						var result = m_IsProgram_0(program);
			if(m_debug) CheckError("IsProgram");
			return result;
					}

		public static bool IsQuery(uint id)
		{
						var result = m_IsQuery_0(id);
			if(m_debug) CheckError("IsQuery");
			return result;
					}

		public static bool IsRenderbuffer(uint renderbuffer)
		{
						var result = m_IsRenderbuffer_0(renderbuffer);
			if(m_debug) CheckError("IsRenderbuffer");
			return result;
					}

		public static bool IsShader(uint shader)
		{
						var result = m_IsShader_0(shader);
			if(m_debug) CheckError("IsShader");
			return result;
					}

		public static bool IsSync(System.IntPtr sync)
		{
						var result = m_IsSync_0(sync);
			if(m_debug) CheckError("IsSync");
			return result;
					}

		public static bool IsTexture(uint texture)
		{
						var result = m_IsTexture_0(texture);
			if(m_debug) CheckError("IsTexture");
			return result;
					}

		public static bool IsVertexArray(uint array)
		{
						var result = m_IsVertexArray_0(array);
			if(m_debug) CheckError("IsVertexArray");
			return result;
					}

		public static void LineWidth(float width)
		{
						m_LineWidth_0(width);
			if(m_debug) CheckError("LineWidth");
					}

		public static void LinkProgram(uint program)
		{
						m_LinkProgram_0(program);
			if(m_debug) CheckError("LinkProgram");
					}

		public static void LogicOp(uint opcode)
		{
						m_LogicOp_0(opcode);
			if(m_debug) CheckError("LogicOp");
					}

		public static System.IntPtr MapBuffer(uint target, uint access)
		{
						var result = m_MapBuffer_0(target, access);
			if(m_debug) CheckError("MapBuffer");
			return result;
					}

		public static System.IntPtr MapBufferRange(uint target, System.IntPtr offset, System.IntPtr length, uint access)
		{
						var result = m_MapBufferRange_0(target, offset, length, access);
			if(m_debug) CheckError("MapBufferRange");
			return result;
					}

		public static void MultiDrawArrays(uint mode, System.IntPtr first, System.IntPtr count, int drawcount)
		{
						m_MultiDrawArrays_0(mode, first, count, drawcount);
			if(m_debug) CheckError("MultiDrawArrays");
					}

		public static void MultiDrawElements(uint mode, System.IntPtr count, uint type, System.IntPtr indices, int drawcount)
		{
						m_MultiDrawElements_0(mode, count, type, indices, drawcount);
			if(m_debug) CheckError("MultiDrawElements");
					}

		public static void MultiDrawElementsBaseVertex(uint mode, System.IntPtr count, uint type, System.IntPtr indices, int drawcount, System.IntPtr basevertex)
		{
						m_MultiDrawElementsBaseVertex_0(mode, count, type, indices, drawcount, basevertex);
			if(m_debug) CheckError("MultiDrawElementsBaseVertex");
					}

		public static void PixelStoref(uint pname, float param)
		{
						m_PixelStoref_0(pname, param);
			if(m_debug) CheckError("PixelStoref");
					}

		public static void PixelStorei(uint pname, int param)
		{
						m_PixelStorei_0(pname, param);
			if(m_debug) CheckError("PixelStorei");
					}

		public static void PointParameterf(uint pname, float param)
		{
						m_PointParameterf_0(pname, param);
			if(m_debug) CheckError("PointParameterf");
					}

		public static void PointParameterfv(uint pname, System.IntPtr _params)
		{
						m_PointParameterfv_0(pname, _params);
			if(m_debug) CheckError("PointParameterfv");
					}

		public static void PointParameteri(uint pname, int param)
		{
						m_PointParameteri_0(pname, param);
			if(m_debug) CheckError("PointParameteri");
					}

		public static void PointParameteriv(uint pname, System.IntPtr _params)
		{
						m_PointParameteriv_0(pname, _params);
			if(m_debug) CheckError("PointParameteriv");
					}

		public static void PointSize(float size)
		{
						m_PointSize_0(size);
			if(m_debug) CheckError("PointSize");
					}

		public static void PolygonMode(uint face, uint mode)
		{
						m_PolygonMode_0(face, mode);
			if(m_debug) CheckError("PolygonMode");
					}

		public static void PolygonOffset(float factor, float units)
		{
						m_PolygonOffset_0(factor, units);
			if(m_debug) CheckError("PolygonOffset");
					}

		public static void PrimitiveRestartIndex(uint index)
		{
						m_PrimitiveRestartIndex_0(index);
			if(m_debug) CheckError("PrimitiveRestartIndex");
					}

		public static void ProvokingVertex(uint mode)
		{
						m_ProvokingVertex_0(mode);
			if(m_debug) CheckError("ProvokingVertex");
					}

		public static void ReadBuffer(uint mode)
		{
						m_ReadBuffer_0(mode);
			if(m_debug) CheckError("ReadBuffer");
					}

		public static void ReadPixels(int x, int y, int width, int height, uint format, uint type, System.IntPtr pixels)
		{
						m_ReadPixels_0(x, y, width, height, format, type, pixels);
			if(m_debug) CheckError("ReadPixels");
					}

		public static void RenderbufferStorage(uint target, uint internalformat, int width, int height)
		{
						m_RenderbufferStorage_0(target, internalformat, width, height);
			if(m_debug) CheckError("RenderbufferStorage");
					}

		public static void RenderbufferStorageMultisample(uint target, int samples, uint internalformat, int width, int height)
		{
						m_RenderbufferStorageMultisample_0(target, samples, internalformat, width, height);
			if(m_debug) CheckError("RenderbufferStorageMultisample");
					}

		public static void SampleCoverage(float value, bool invert)
		{
						m_SampleCoverage_0(value, invert);
			if(m_debug) CheckError("SampleCoverage");
					}

		public static void SampleMaski(uint index, uint mask)
		{
						m_SampleMaski_0(index, mask);
			if(m_debug) CheckError("SampleMaski");
					}

		public static void Scissor(int x, int y, int width, int height)
		{
						m_Scissor_0(x, y, width, height);
			if(m_debug) CheckError("Scissor");
					}

		public static void ShaderSource(uint shader, int count, System.IntPtr _string, System.IntPtr length)
		{
						m_ShaderSource_0(shader, count, _string, length);
			if(m_debug) CheckError("ShaderSource");
					}

		public static void ShaderSource(uint shader, int count, IntPtr[] _string, int[] length)
		{
						m_ShaderSource_1(shader, count, _string, length);
			if(m_debug) CheckError("ShaderSource");
					}

		public static void StencilFunc(uint func, int _ref, uint mask)
		{
						m_StencilFunc_0(func, _ref, mask);
			if(m_debug) CheckError("StencilFunc");
					}

		public static void StencilFuncSeparate(uint face, uint func, int _ref, uint mask)
		{
						m_StencilFuncSeparate_0(face, func, _ref, mask);
			if(m_debug) CheckError("StencilFuncSeparate");
					}

		public static void StencilMask(uint mask)
		{
						m_StencilMask_0(mask);
			if(m_debug) CheckError("StencilMask");
					}

		public static void StencilMaskSeparate(uint face, uint mask)
		{
						m_StencilMaskSeparate_0(face, mask);
			if(m_debug) CheckError("StencilMaskSeparate");
					}

		public static void StencilOp(uint fail, uint zfail, uint zpass)
		{
						m_StencilOp_0(fail, zfail, zpass);
			if(m_debug) CheckError("StencilOp");
					}

		public static void StencilOpSeparate(uint face, uint sfail, uint dpfail, uint dppass)
		{
						m_StencilOpSeparate_0(face, sfail, dpfail, dppass);
			if(m_debug) CheckError("StencilOpSeparate");
					}

		public static void TexBuffer(uint target, uint internalformat, uint buffer)
		{
						m_TexBuffer_0(target, internalformat, buffer);
			if(m_debug) CheckError("TexBuffer");
					}

		public static void TexImage1D(uint target, int level, int internalformat, int width, int border, uint format, uint type, System.IntPtr pixels)
		{
						m_TexImage1D_0(target, level, internalformat, width, border, format, type, pixels);
			if(m_debug) CheckError("TexImage1D");
					}

		public static void TexImage2D(uint target, int level, int internalformat, int width, int height, int border, uint format, uint type, System.IntPtr pixels)
		{
						m_TexImage2D_0(target, level, internalformat, width, height, border, format, type, pixels);
			if(m_debug) CheckError("TexImage2D");
					}

		public static void TexImage2DMultisample(uint target, int samples, uint internalformat, int width, int height, bool fixedsamplelocations)
		{
						m_TexImage2DMultisample_0(target, samples, internalformat, width, height, fixedsamplelocations);
			if(m_debug) CheckError("TexImage2DMultisample");
					}

		public static void TexImage3D(uint target, int level, int internalformat, int width, int height, int depth, int border, uint format, uint type, System.IntPtr pixels)
		{
						m_TexImage3D_0(target, level, internalformat, width, height, depth, border, format, type, pixels);
			if(m_debug) CheckError("TexImage3D");
					}

		public static void TexImage3DMultisample(uint target, int samples, uint internalformat, int width, int height, int depth, bool fixedsamplelocations)
		{
						m_TexImage3DMultisample_0(target, samples, internalformat, width, height, depth, fixedsamplelocations);
			if(m_debug) CheckError("TexImage3DMultisample");
					}

		public static void TexParameterf(uint target, uint pname, float param)
		{
						m_TexParameterf_0(target, pname, param);
			if(m_debug) CheckError("TexParameterf");
					}

		public static void TexParameterfv(uint target, uint pname, System.IntPtr _params)
		{
						m_TexParameterfv_0(target, pname, _params);
			if(m_debug) CheckError("TexParameterfv");
					}

		public static void TexParameteri(uint target, uint pname, int param)
		{
						m_TexParameteri_0(target, pname, param);
			if(m_debug) CheckError("TexParameteri");
					}

		public static void TexParameterIiv(uint target, uint pname, System.IntPtr _params)
		{
						m_TexParameterIiv_0(target, pname, _params);
			if(m_debug) CheckError("TexParameterIiv");
					}

		public static void TexParameterIuiv(uint target, uint pname, System.IntPtr _params)
		{
						m_TexParameterIuiv_0(target, pname, _params);
			if(m_debug) CheckError("TexParameterIuiv");
					}

		public static void TexParameteriv(uint target, uint pname, System.IntPtr _params)
		{
						m_TexParameteriv_0(target, pname, _params);
			if(m_debug) CheckError("TexParameteriv");
					}

		public static void TexSubImage1D(uint target, int level, int xoffset, int width, uint format, uint type, System.IntPtr pixels)
		{
						m_TexSubImage1D_0(target, level, xoffset, width, format, type, pixels);
			if(m_debug) CheckError("TexSubImage1D");
					}

		public static void TexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, System.IntPtr pixels)
		{
						m_TexSubImage2D_0(target, level, xoffset, yoffset, width, height, format, type, pixels);
			if(m_debug) CheckError("TexSubImage2D");
					}

		public static void TexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, System.IntPtr pixels)
		{
						m_TexSubImage3D_0(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
			if(m_debug) CheckError("TexSubImage3D");
					}

		public static void TransformFeedbackVaryings(uint program, int count, System.IntPtr varyings, uint bufferMode)
		{
						m_TransformFeedbackVaryings_0(program, count, varyings, bufferMode);
			if(m_debug) CheckError("TransformFeedbackVaryings");
					}

		public static void Uniform1f(int location, float v0)
		{
						m_Uniform1f_0(location, v0);
			if(m_debug) CheckError("Uniform1f");
					}

		public static void Uniform1fv(int location, int count, System.IntPtr value)
		{
						m_Uniform1fv_0(location, count, value);
			if(m_debug) CheckError("Uniform1fv");
					}

		public static void Uniform1i(int location, int v0)
		{
						m_Uniform1i_0(location, v0);
			if(m_debug) CheckError("Uniform1i");
					}

		public static void Uniform1iv(int location, int count, System.IntPtr value)
		{
						m_Uniform1iv_0(location, count, value);
			if(m_debug) CheckError("Uniform1iv");
					}

		public static void Uniform1ui(int location, uint v0)
		{
						m_Uniform1ui_0(location, v0);
			if(m_debug) CheckError("Uniform1ui");
					}

		public static void Uniform1uiv(int location, int count, System.IntPtr value)
		{
						m_Uniform1uiv_0(location, count, value);
			if(m_debug) CheckError("Uniform1uiv");
					}

		public static void Uniform2f(int location, float v0, float v1)
		{
						m_Uniform2f_0(location, v0, v1);
			if(m_debug) CheckError("Uniform2f");
					}

		public static void Uniform2f(int location, Vector2 value)
		{
						m_Uniform2f_1(location, value);
			if(m_debug) CheckError("Uniform2f");
					}

		public static void Uniform2fv(int location, int count, System.IntPtr value)
		{
						m_Uniform2fv_0(location, count, value);
			if(m_debug) CheckError("Uniform2fv");
					}

		public static void Uniform2i(int location, int v0, int v1)
		{
						m_Uniform2i_0(location, v0, v1);
			if(m_debug) CheckError("Uniform2i");
					}

		public static void Uniform2i(int location, Vector2i value)
		{
						m_Uniform2i_1(location, value);
			if(m_debug) CheckError("Uniform2i");
					}

		public static void Uniform2iv(int location, int count, System.IntPtr value)
		{
						m_Uniform2iv_0(location, count, value);
			if(m_debug) CheckError("Uniform2iv");
					}

		public static void Uniform2ui(int location, uint v0, uint v1)
		{
						m_Uniform2ui_0(location, v0, v1);
			if(m_debug) CheckError("Uniform2ui");
					}

		public static void Uniform2uiv(int location, int count, System.IntPtr value)
		{
						m_Uniform2uiv_0(location, count, value);
			if(m_debug) CheckError("Uniform2uiv");
					}

		public static void Uniform3f(int location, float v0, float v1, float v2)
		{
						m_Uniform3f_0(location, v0, v1, v2);
			if(m_debug) CheckError("Uniform3f");
					}

		public static void Uniform3f(int location, Vector3 value)
		{
						m_Uniform3f_1(location, value);
			if(m_debug) CheckError("Uniform3f");
					}

		public static void Uniform3fv(int location, int count, System.IntPtr value)
		{
						m_Uniform3fv_0(location, count, value);
			if(m_debug) CheckError("Uniform3fv");
					}

		public static void Uniform3i(int location, int v0, int v1, int v2)
		{
						m_Uniform3i_0(location, v0, v1, v2);
			if(m_debug) CheckError("Uniform3i");
					}

		public static void Uniform3i(int location, Vector3i value)
		{
						m_Uniform3i_1(location, value);
			if(m_debug) CheckError("Uniform3i");
					}

		public static void Uniform3iv(int location, int count, System.IntPtr value)
		{
						m_Uniform3iv_0(location, count, value);
			if(m_debug) CheckError("Uniform3iv");
					}

		public static void Uniform3ui(int location, uint v0, uint v1, uint v2)
		{
						m_Uniform3ui_0(location, v0, v1, v2);
			if(m_debug) CheckError("Uniform3ui");
					}

		public static void Uniform3uiv(int location, int count, System.IntPtr value)
		{
						m_Uniform3uiv_0(location, count, value);
			if(m_debug) CheckError("Uniform3uiv");
					}

		public static void Uniform4f(int location, float v0, float v1, float v2, float v3)
		{
						m_Uniform4f_0(location, v0, v1, v2, v3);
			if(m_debug) CheckError("Uniform4f");
					}

		public static void Uniform4f(int location, Vector4 value)
		{
						m_Uniform4f_1(location, value);
			if(m_debug) CheckError("Uniform4f");
					}

		public static void Uniform4fv(int location, int count, System.IntPtr value)
		{
						m_Uniform4fv_0(location, count, value);
			if(m_debug) CheckError("Uniform4fv");
					}

		public static void Uniform4i(int location, int v0, int v1, int v2, int v3)
		{
						m_Uniform4i_0(location, v0, v1, v2, v3);
			if(m_debug) CheckError("Uniform4i");
					}

		public static void Uniform4i(int location, Vector4i value)
		{
						m_Uniform4i_1(location, value);
			if(m_debug) CheckError("Uniform4i");
					}

		public static void Uniform4iv(int location, int count, System.IntPtr value)
		{
						m_Uniform4iv_0(location, count, value);
			if(m_debug) CheckError("Uniform4iv");
					}

		public static void Uniform4ui(int location, uint v0, uint v1, uint v2, uint v3)
		{
						m_Uniform4ui_0(location, v0, v1, v2, v3);
			if(m_debug) CheckError("Uniform4ui");
					}

		public static void Uniform4uiv(int location, int count, System.IntPtr value)
		{
						m_Uniform4uiv_0(location, count, value);
			if(m_debug) CheckError("Uniform4uiv");
					}

		public static void UniformBlockBinding(uint program, uint uniformBlockIndex, uint uniformBlockBinding)
		{
						m_UniformBlockBinding_0(program, uniformBlockIndex, uniformBlockBinding);
			if(m_debug) CheckError("UniformBlockBinding");
					}

		public static void UniformMatrix2fv(int location, int count, bool transpose, System.IntPtr value)
		{
						m_UniformMatrix2fv_0(location, count, transpose, value);
			if(m_debug) CheckError("UniformMatrix2fv");
					}

		public static void UniformMatrix2fv(int location, int count, bool transpose, float[] value)
		{
						m_UniformMatrix2fv_1(location, count, transpose, value);
			if(m_debug) CheckError("UniformMatrix2fv");
					}

		public static void UniformMatrix2fv(int location, int count, bool transpose, ref Matrix2 value)
		{
						m_UniformMatrix2fv_2(location, count, transpose, ref value);
			if(m_debug) CheckError("UniformMatrix2fv");
					}

		public static void UniformMatrix2x3fv(int location, int count, bool transpose, System.IntPtr value)
		{
						m_UniformMatrix2x3fv_0(location, count, transpose, value);
			if(m_debug) CheckError("UniformMatrix2x3fv");
					}

		public static void UniformMatrix2x4fv(int location, int count, bool transpose, System.IntPtr value)
		{
						m_UniformMatrix2x4fv_0(location, count, transpose, value);
			if(m_debug) CheckError("UniformMatrix2x4fv");
					}

		public static void UniformMatrix3fv(int location, int count, bool transpose, System.IntPtr value)
		{
						m_UniformMatrix3fv_0(location, count, transpose, value);
			if(m_debug) CheckError("UniformMatrix3fv");
					}

		public static void UniformMatrix3fv(int location, int count, bool transpose, float[] value)
		{
						m_UniformMatrix3fv_1(location, count, transpose, value);
			if(m_debug) CheckError("UniformMatrix3fv");
					}

		public static void UniformMatrix3fv(int location, int count, bool transpose, ref Matrix3 value)
		{
						m_UniformMatrix3fv_2(location, count, transpose, ref value);
			if(m_debug) CheckError("UniformMatrix3fv");
					}

		public static void UniformMatrix3x2fv(int location, int count, bool transpose, System.IntPtr value)
		{
						m_UniformMatrix3x2fv_0(location, count, transpose, value);
			if(m_debug) CheckError("UniformMatrix3x2fv");
					}

		public static void UniformMatrix3x4fv(int location, int count, bool transpose, System.IntPtr value)
		{
						m_UniformMatrix3x4fv_0(location, count, transpose, value);
			if(m_debug) CheckError("UniformMatrix3x4fv");
					}

		public static void UniformMatrix4fv(int location, int count, bool transpose, System.IntPtr value)
		{
						m_UniformMatrix4fv_0(location, count, transpose, value);
			if(m_debug) CheckError("UniformMatrix4fv");
					}

		public static void UniformMatrix4fv(int location, int count, bool transpose, float[] value)
		{
						m_UniformMatrix4fv_1(location, count, transpose, value);
			if(m_debug) CheckError("UniformMatrix4fv");
					}

		public static void UniformMatrix4fv(int location, int count, bool transpose, ref Matrix4 value)
		{
						m_UniformMatrix4fv_2(location, count, transpose, ref value);
			if(m_debug) CheckError("UniformMatrix4fv");
					}

		public static void UniformMatrix4x2fv(int location, int count, bool transpose, System.IntPtr value)
		{
						m_UniformMatrix4x2fv_0(location, count, transpose, value);
			if(m_debug) CheckError("UniformMatrix4x2fv");
					}

		public static void UniformMatrix4x3fv(int location, int count, bool transpose, System.IntPtr value)
		{
						m_UniformMatrix4x3fv_0(location, count, transpose, value);
			if(m_debug) CheckError("UniformMatrix4x3fv");
					}

		public static bool UnmapBuffer(uint target)
		{
						var result = m_UnmapBuffer_0(target);
			if(m_debug) CheckError("UnmapBuffer");
			return result;
					}

		public static void UseProgram(uint program)
		{
						m_UseProgram_0(program);
			if(m_debug) CheckError("UseProgram");
					}

		public static void ValidateProgram(uint program)
		{
						m_ValidateProgram_0(program);
			if(m_debug) CheckError("ValidateProgram");
					}

		public static void VertexAttrib1d(uint index, double x)
		{
						m_VertexAttrib1d_0(index, x);
			if(m_debug) CheckError("VertexAttrib1d");
					}

		public static void VertexAttrib1dv(uint index, System.IntPtr v)
		{
						m_VertexAttrib1dv_0(index, v);
			if(m_debug) CheckError("VertexAttrib1dv");
					}

		public static void VertexAttrib1f(uint index, float x)
		{
						m_VertexAttrib1f_0(index, x);
			if(m_debug) CheckError("VertexAttrib1f");
					}

		public static void VertexAttrib1fv(uint index, System.IntPtr v)
		{
						m_VertexAttrib1fv_0(index, v);
			if(m_debug) CheckError("VertexAttrib1fv");
					}

		public static void VertexAttrib1s(uint index, short x)
		{
						m_VertexAttrib1s_0(index, x);
			if(m_debug) CheckError("VertexAttrib1s");
					}

		public static void VertexAttrib1sv(uint index, System.IntPtr v)
		{
						m_VertexAttrib1sv_0(index, v);
			if(m_debug) CheckError("VertexAttrib1sv");
					}

		public static void VertexAttrib2d(uint index, double x, double y)
		{
						m_VertexAttrib2d_0(index, x, y);
			if(m_debug) CheckError("VertexAttrib2d");
					}

		public static void VertexAttrib2dv(uint index, System.IntPtr v)
		{
						m_VertexAttrib2dv_0(index, v);
			if(m_debug) CheckError("VertexAttrib2dv");
					}

		public static void VertexAttrib2f(uint index, float x, float y)
		{
						m_VertexAttrib2f_0(index, x, y);
			if(m_debug) CheckError("VertexAttrib2f");
					}

		public static void VertexAttrib2fv(uint index, System.IntPtr v)
		{
						m_VertexAttrib2fv_0(index, v);
			if(m_debug) CheckError("VertexAttrib2fv");
					}

		public static void VertexAttrib2s(uint index, short x, short y)
		{
						m_VertexAttrib2s_0(index, x, y);
			if(m_debug) CheckError("VertexAttrib2s");
					}

		public static void VertexAttrib2sv(uint index, System.IntPtr v)
		{
						m_VertexAttrib2sv_0(index, v);
			if(m_debug) CheckError("VertexAttrib2sv");
					}

		public static void VertexAttrib3d(uint index, double x, double y, double z)
		{
						m_VertexAttrib3d_0(index, x, y, z);
			if(m_debug) CheckError("VertexAttrib3d");
					}

		public static void VertexAttrib3dv(uint index, System.IntPtr v)
		{
						m_VertexAttrib3dv_0(index, v);
			if(m_debug) CheckError("VertexAttrib3dv");
					}

		public static void VertexAttrib3f(uint index, float x, float y, float z)
		{
						m_VertexAttrib3f_0(index, x, y, z);
			if(m_debug) CheckError("VertexAttrib3f");
					}

		public static void VertexAttrib3fv(uint index, System.IntPtr v)
		{
						m_VertexAttrib3fv_0(index, v);
			if(m_debug) CheckError("VertexAttrib3fv");
					}

		public static void VertexAttrib3s(uint index, short x, short y, short z)
		{
						m_VertexAttrib3s_0(index, x, y, z);
			if(m_debug) CheckError("VertexAttrib3s");
					}

		public static void VertexAttrib3sv(uint index, System.IntPtr v)
		{
						m_VertexAttrib3sv_0(index, v);
			if(m_debug) CheckError("VertexAttrib3sv");
					}

		public static void VertexAttrib4bv(uint index, System.IntPtr v)
		{
						m_VertexAttrib4bv_0(index, v);
			if(m_debug) CheckError("VertexAttrib4bv");
					}

		public static void VertexAttrib4d(uint index, double x, double y, double z, double w)
		{
						m_VertexAttrib4d_0(index, x, y, z, w);
			if(m_debug) CheckError("VertexAttrib4d");
					}

		public static void VertexAttrib4dv(uint index, System.IntPtr v)
		{
						m_VertexAttrib4dv_0(index, v);
			if(m_debug) CheckError("VertexAttrib4dv");
					}

		public static void VertexAttrib4f(uint index, float x, float y, float z, float w)
		{
						m_VertexAttrib4f_0(index, x, y, z, w);
			if(m_debug) CheckError("VertexAttrib4f");
					}

		public static void VertexAttrib4fv(uint index, System.IntPtr v)
		{
						m_VertexAttrib4fv_0(index, v);
			if(m_debug) CheckError("VertexAttrib4fv");
					}

		public static void VertexAttrib4iv(uint index, System.IntPtr v)
		{
						m_VertexAttrib4iv_0(index, v);
			if(m_debug) CheckError("VertexAttrib4iv");
					}

		public static void VertexAttrib4Nbv(uint index, System.IntPtr v)
		{
						m_VertexAttrib4Nbv_0(index, v);
			if(m_debug) CheckError("VertexAttrib4Nbv");
					}

		public static void VertexAttrib4Niv(uint index, System.IntPtr v)
		{
						m_VertexAttrib4Niv_0(index, v);
			if(m_debug) CheckError("VertexAttrib4Niv");
					}

		public static void VertexAttrib4Nsv(uint index, System.IntPtr v)
		{
						m_VertexAttrib4Nsv_0(index, v);
			if(m_debug) CheckError("VertexAttrib4Nsv");
					}

		public static void VertexAttrib4Nub(uint index, byte x, byte y, byte z, byte w)
		{
						m_VertexAttrib4Nub_0(index, x, y, z, w);
			if(m_debug) CheckError("VertexAttrib4Nub");
					}

		public static void VertexAttrib4Nubv(uint index, System.IntPtr v)
		{
						m_VertexAttrib4Nubv_0(index, v);
			if(m_debug) CheckError("VertexAttrib4Nubv");
					}

		public static void VertexAttrib4Nuiv(uint index, System.IntPtr v)
		{
						m_VertexAttrib4Nuiv_0(index, v);
			if(m_debug) CheckError("VertexAttrib4Nuiv");
					}

		public static void VertexAttrib4Nusv(uint index, System.IntPtr v)
		{
						m_VertexAttrib4Nusv_0(index, v);
			if(m_debug) CheckError("VertexAttrib4Nusv");
					}

		public static void VertexAttrib4s(uint index, short x, short y, short z, short w)
		{
						m_VertexAttrib4s_0(index, x, y, z, w);
			if(m_debug) CheckError("VertexAttrib4s");
					}

		public static void VertexAttrib4sv(uint index, System.IntPtr v)
		{
						m_VertexAttrib4sv_0(index, v);
			if(m_debug) CheckError("VertexAttrib4sv");
					}

		public static void VertexAttrib4ubv(uint index, System.IntPtr v)
		{
						m_VertexAttrib4ubv_0(index, v);
			if(m_debug) CheckError("VertexAttrib4ubv");
					}

		public static void VertexAttrib4uiv(uint index, System.IntPtr v)
		{
						m_VertexAttrib4uiv_0(index, v);
			if(m_debug) CheckError("VertexAttrib4uiv");
					}

		public static void VertexAttrib4usv(uint index, System.IntPtr v)
		{
						m_VertexAttrib4usv_0(index, v);
			if(m_debug) CheckError("VertexAttrib4usv");
					}

		public static void VertexAttribI1i(uint index, int x)
		{
						m_VertexAttribI1i_0(index, x);
			if(m_debug) CheckError("VertexAttribI1i");
					}

		public static void VertexAttribI1iv(uint index, System.IntPtr v)
		{
						m_VertexAttribI1iv_0(index, v);
			if(m_debug) CheckError("VertexAttribI1iv");
					}

		public static void VertexAttribI1ui(uint index, uint x)
		{
						m_VertexAttribI1ui_0(index, x);
			if(m_debug) CheckError("VertexAttribI1ui");
					}

		public static void VertexAttribI1uiv(uint index, System.IntPtr v)
		{
						m_VertexAttribI1uiv_0(index, v);
			if(m_debug) CheckError("VertexAttribI1uiv");
					}

		public static void VertexAttribI2i(uint index, int x, int y)
		{
						m_VertexAttribI2i_0(index, x, y);
			if(m_debug) CheckError("VertexAttribI2i");
					}

		public static void VertexAttribI2iv(uint index, System.IntPtr v)
		{
						m_VertexAttribI2iv_0(index, v);
			if(m_debug) CheckError("VertexAttribI2iv");
					}

		public static void VertexAttribI2ui(uint index, uint x, uint y)
		{
						m_VertexAttribI2ui_0(index, x, y);
			if(m_debug) CheckError("VertexAttribI2ui");
					}

		public static void VertexAttribI2uiv(uint index, System.IntPtr v)
		{
						m_VertexAttribI2uiv_0(index, v);
			if(m_debug) CheckError("VertexAttribI2uiv");
					}

		public static void VertexAttribI3i(uint index, int x, int y, int z)
		{
						m_VertexAttribI3i_0(index, x, y, z);
			if(m_debug) CheckError("VertexAttribI3i");
					}

		public static void VertexAttribI3iv(uint index, System.IntPtr v)
		{
						m_VertexAttribI3iv_0(index, v);
			if(m_debug) CheckError("VertexAttribI3iv");
					}

		public static void VertexAttribI3ui(uint index, uint x, uint y, uint z)
		{
						m_VertexAttribI3ui_0(index, x, y, z);
			if(m_debug) CheckError("VertexAttribI3ui");
					}

		public static void VertexAttribI3uiv(uint index, System.IntPtr v)
		{
						m_VertexAttribI3uiv_0(index, v);
			if(m_debug) CheckError("VertexAttribI3uiv");
					}

		public static void VertexAttribI4bv(uint index, System.IntPtr v)
		{
						m_VertexAttribI4bv_0(index, v);
			if(m_debug) CheckError("VertexAttribI4bv");
					}

		public static void VertexAttribI4i(uint index, int x, int y, int z, int w)
		{
						m_VertexAttribI4i_0(index, x, y, z, w);
			if(m_debug) CheckError("VertexAttribI4i");
					}

		public static void VertexAttribI4iv(uint index, System.IntPtr v)
		{
						m_VertexAttribI4iv_0(index, v);
			if(m_debug) CheckError("VertexAttribI4iv");
					}

		public static void VertexAttribI4sv(uint index, System.IntPtr v)
		{
						m_VertexAttribI4sv_0(index, v);
			if(m_debug) CheckError("VertexAttribI4sv");
					}

		public static void VertexAttribI4ubv(uint index, System.IntPtr v)
		{
						m_VertexAttribI4ubv_0(index, v);
			if(m_debug) CheckError("VertexAttribI4ubv");
					}

		public static void VertexAttribI4ui(uint index, uint x, uint y, uint z, uint w)
		{
						m_VertexAttribI4ui_0(index, x, y, z, w);
			if(m_debug) CheckError("VertexAttribI4ui");
					}

		public static void VertexAttribI4uiv(uint index, System.IntPtr v)
		{
						m_VertexAttribI4uiv_0(index, v);
			if(m_debug) CheckError("VertexAttribI4uiv");
					}

		public static void VertexAttribI4usv(uint index, System.IntPtr v)
		{
						m_VertexAttribI4usv_0(index, v);
			if(m_debug) CheckError("VertexAttribI4usv");
					}

		public static void VertexAttribIPointer(uint index, int size, uint type, int stride, System.IntPtr pointer)
		{
						m_VertexAttribIPointer_0(index, size, type, stride, pointer);
			if(m_debug) CheckError("VertexAttribIPointer");
					}

		public static void VertexAttribPointer(uint index, int size, uint type, bool normalized, int stride, System.IntPtr pointer)
		{
						m_VertexAttribPointer_0(index, size, type, normalized, stride, pointer);
			if(m_debug) CheckError("VertexAttribPointer");
					}

		public static void Viewport(int x, int y, int width, int height)
		{
						m_Viewport_0(x, y, width, height);
			if(m_debug) CheckError("Viewport");
					}

		public static void Viewport(Box2i dimensions)
		{
						m_Viewport_1(dimensions);
			if(m_debug) CheckError("Viewport");
					}

		public static void WaitSync(System.IntPtr sync, uint flags, ulong timeout)
		{
						m_WaitSync_0(sync, flags, timeout);
			if(m_debug) CheckError("WaitSync");
					}

		public static void BindFragDataLocationIndexed(uint program, uint colorNumber, uint index, System.IntPtr name)
		{
						m_BindFragDataLocationIndexed_0(program, colorNumber, index, name);
			if(m_debug) CheckError("BindFragDataLocationIndexed");
					}

		public static int GetFragDataIndex(uint program, System.IntPtr name)
		{
						var result = m_GetFragDataIndex_0(program, name);
			if(m_debug) CheckError("GetFragDataIndex");
			return result;
					}

		public static void GenSamplers(int count, System.IntPtr samplers)
		{
						m_GenSamplers_0(count, samplers);
			if(m_debug) CheckError("GenSamplers");
					}

		public static void GenSamplers(int n, uint[] samplers)
		{
						m_GenSamplers_1(n, samplers);
			if(m_debug) CheckError("GenSamplers");
					}

		public static void GenSamplers(int n, out uint samplers)
		{
						m_GenSamplers_2(n, out samplers);
			if(m_debug) CheckError("GenSamplers");
					}

		public static void DeleteSamplers(int count, System.IntPtr samplers)
		{
						m_DeleteSamplers_0(count, samplers);
			if(m_debug) CheckError("DeleteSamplers");
					}

		public static void DeleteSamplers(int n, uint[] samplers)
		{
						m_DeleteSamplers_1(n, samplers);
			if(m_debug) CheckError("DeleteSamplers");
					}

		public static void DeleteSamplers(int n, ref uint samplers)
		{
						m_DeleteSamplers_2(n, ref samplers);
			if(m_debug) CheckError("DeleteSamplers");
					}

		public static bool IsSampler(uint shader)
		{
						var result = m_IsSampler_0(shader);
			if(m_debug) CheckError("IsSampler");
			return result;
					}

		public static void BindSampler(uint unit, uint sampler)
		{
						m_BindSampler_0(unit, sampler);
			if(m_debug) CheckError("BindSampler");
					}

		public static void SamplerParameteri(uint sampler, uint pname, int param)
		{
						m_SamplerParameteri_0(sampler, pname, param);
			if(m_debug) CheckError("SamplerParameteri");
					}

		public static void SamplerParameteriv(uint sampler, uint pname, System.IntPtr param)
		{
						m_SamplerParameteriv_0(sampler, pname, param);
			if(m_debug) CheckError("SamplerParameteriv");
					}

		public static void SamplerParameterf(uint sampler, uint pname, float param)
		{
						m_SamplerParameterf_0(sampler, pname, param);
			if(m_debug) CheckError("SamplerParameterf");
					}

		public static void SamplerParameterfv(uint sampler, uint pname, System.IntPtr param)
		{
						m_SamplerParameterfv_0(sampler, pname, param);
			if(m_debug) CheckError("SamplerParameterfv");
					}

		public static void SamplerParameterIiv(uint sampler, uint pname, System.IntPtr param)
		{
						m_SamplerParameterIiv_0(sampler, pname, param);
			if(m_debug) CheckError("SamplerParameterIiv");
					}

		public static void SamplerParameterIuiv(uint sampler, uint pname, System.IntPtr param)
		{
						m_SamplerParameterIuiv_0(sampler, pname, param);
			if(m_debug) CheckError("SamplerParameterIuiv");
					}

		public static void GetSamplerParameteriv(uint sampler, uint pname, System.IntPtr _params)
		{
						m_GetSamplerParameteriv_0(sampler, pname, _params);
			if(m_debug) CheckError("GetSamplerParameteriv");
					}

		public static void GetSamplerParameterIiv(uint sampler, uint pname, System.IntPtr _params)
		{
						m_GetSamplerParameterIiv_0(sampler, pname, _params);
			if(m_debug) CheckError("GetSamplerParameterIiv");
					}

		public static void GetSamplerParameterfv(uint sampler, uint pname, System.IntPtr _params)
		{
						m_GetSamplerParameterfv_0(sampler, pname, _params);
			if(m_debug) CheckError("GetSamplerParameterfv");
					}

		public static void GetSamplerParameterIuiv(uint sampler, uint pname, System.IntPtr _params)
		{
						m_GetSamplerParameterIuiv_0(sampler, pname, _params);
			if(m_debug) CheckError("GetSamplerParameterIuiv");
					}

		public static void QueryCounter(uint id, uint target)
		{
						m_QueryCounter_0(id, target);
			if(m_debug) CheckError("QueryCounter");
					}

		public static void GetQueryObjecti64v(uint id, uint pname, System.IntPtr _params)
		{
						m_GetQueryObjecti64v_0(id, pname, _params);
			if(m_debug) CheckError("GetQueryObjecti64v");
					}

		public static void GetQueryObjectui64v(uint id, uint pname, System.IntPtr _params)
		{
						m_GetQueryObjectui64v_0(id, pname, _params);
			if(m_debug) CheckError("GetQueryObjectui64v");
					}

		public static void VertexAttribDivisor(uint index, uint divisor)
		{
						m_VertexAttribDivisor_0(index, divisor);
			if(m_debug) CheckError("VertexAttribDivisor");
					}

		public static void VertexAttribP1ui(uint index, uint type, bool normalized, uint value)
		{
						m_VertexAttribP1ui_0(index, type, normalized, value);
			if(m_debug) CheckError("VertexAttribP1ui");
					}

		public static void VertexAttribP1uiv(uint index, uint type, bool normalized, System.IntPtr value)
		{
						m_VertexAttribP1uiv_0(index, type, normalized, value);
			if(m_debug) CheckError("VertexAttribP1uiv");
					}

		public static void VertexAttribP2ui(uint index, uint type, bool normalized, uint value)
		{
						m_VertexAttribP2ui_0(index, type, normalized, value);
			if(m_debug) CheckError("VertexAttribP2ui");
					}

		public static void VertexAttribP2uiv(uint index, uint type, bool normalized, System.IntPtr value)
		{
						m_VertexAttribP2uiv_0(index, type, normalized, value);
			if(m_debug) CheckError("VertexAttribP2uiv");
					}

		public static void VertexAttribP3ui(uint index, uint type, bool normalized, uint value)
		{
						m_VertexAttribP3ui_0(index, type, normalized, value);
			if(m_debug) CheckError("VertexAttribP3ui");
					}

		public static void VertexAttribP3uiv(uint index, uint type, bool normalized, System.IntPtr value)
		{
						m_VertexAttribP3uiv_0(index, type, normalized, value);
			if(m_debug) CheckError("VertexAttribP3uiv");
					}

		public static void VertexAttribP4ui(uint index, uint type, bool normalized, uint value)
		{
						m_VertexAttribP4ui_0(index, type, normalized, value);
			if(m_debug) CheckError("VertexAttribP4ui");
					}

		public static void VertexAttribP4uiv(uint index, uint type, bool normalized, System.IntPtr value)
		{
						m_VertexAttribP4uiv_0(index, type, normalized, value);
			if(m_debug) CheckError("VertexAttribP4uiv");
					}


	}
}

