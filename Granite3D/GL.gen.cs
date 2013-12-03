







using System;
using System.Runtime.InteropServices;

namespace Granite3D
{
	public partial class GL
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



		private delegate void Delegate_ActiveTexture_0(uint texture);

		private delegate void Delegate_AttachShader_0(uint program, uint shader);

		private delegate void Delegate_BeginConditionalRender_0(uint id, uint mode);

		private delegate void Delegate_BeginQuery_0(uint target, uint id);

		private delegate void Delegate_BeginTransformFeedback_0(uint primitiveMode);

		private delegate void Delegate_BindAttribLocation_0(uint program, uint index, string name);

		private delegate void Delegate_BindBuffer_0(uint target, uint buffer);

		private delegate void Delegate_BindBufferBase_0(uint target, uint index, uint buffer);

		private delegate void Delegate_BindBufferRange_0(uint target, uint index, uint buffer, System.IntPtr offset, System.IntPtr size);

		private delegate void Delegate_BindFragDataLocation_0(uint program, uint color, string name);

		private delegate void Delegate_BindFramebuffer_0(uint target, uint framebuffer);

		private delegate void Delegate_BindRenderbuffer_0(uint target, uint renderbuffer);

		private delegate void Delegate_BindTexture_0(uint target, uint texture);

		private delegate void Delegate_BindVertexArray_0(uint array);

		private delegate void Delegate_BlendColor_0(float red, float green, float blue, float alpha);

		private delegate void Delegate_BlendColor_1(Color4 color);

		private delegate void Delegate_BlendEquation_0(uint mode);

		private delegate void Delegate_BlendEquationSeparate_0(uint modeRGB, uint modeAlpha);

		private delegate void Delegate_BlendFunc_0(uint sfactor, uint dfactor);

		private delegate void Delegate_BlendFuncSeparate_0(uint sfactorRGB, uint dfactorRGB, uint sfactorAlpha, uint dfactorAlpha);

		private delegate void Delegate_BlitFramebuffer_0(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter);

		private delegate void Delegate_BlitFramebuffer_1(Vector2i src0, Vector2i src1, Vector2i dst0, Vector2i dst1, uint mask, uint filter);

		private delegate void Delegate_BufferData_0(uint target, System.IntPtr size, System.IntPtr data, uint usage);

		private delegate void Delegate_BufferSubData_0(uint target, System.IntPtr offset, System.IntPtr size, System.IntPtr data);

		private delegate uint Delegate_CheckFramebufferStatus_0(uint target);

		private delegate void Delegate_ClampColor_0(uint target, uint clamp);

		private delegate void Delegate_Clear_0(uint mask);

		private delegate void Delegate_ClearBufferfi_0(uint buffer, int drawbuffer, float depth, int stencil);

		private delegate void Delegate_ClearBufferfv_0(uint buffer, int drawbuffer, System.IntPtr value);

		private delegate void Delegate_ClearBufferfv_1(uint buffer, int drawbuffer, ref Color4 value);

		private delegate void Delegate_ClearBufferfv_2(uint buffer, int drawbuffer, ref float value);

		private delegate void Delegate_ClearBufferiv_0(uint buffer, int drawbuffer, System.IntPtr value);

		private delegate void Delegate_ClearBufferiv_1(uint buffer, int drawbuffer, ref Color4i value);

		private delegate void Delegate_ClearBufferiv_2(uint buffer, int drawbuffer, ref int value);

		private delegate void Delegate_ClearBufferuiv_0(uint buffer, int drawbuffer, System.IntPtr value);

		private delegate void Delegate_ClearBufferuiv_1(uint buffer, int drawbuffer, ref Color4ui value);

		private delegate void Delegate_ClearBufferuiv_2(uint buffer, int drawbuffer, ref uint value);

		private delegate void Delegate_ClearColor_0(float red, float green, float blue, float alpha);

		private delegate void Delegate_ClearColor_1(Color4 color);

		private delegate void Delegate_ClearDepth_0(double depth);

		private delegate void Delegate_ClearStencil_0(int s);

		private delegate uint Delegate_ClientWaitSync_0(System.IntPtr sync, uint flags, ulong timeout);

		private delegate void Delegate_ColorMask_0(bool red, bool green, bool blue, bool alpha);

		private delegate void Delegate_ColorMaski_0(uint index, bool r, bool g, bool b, bool a);

		private delegate void Delegate_CompileShader_0(uint shader);

		private delegate void Delegate_CompressedTexImage1D_0(uint target, int level, uint internalformat, int width, int border, int imageSize, System.IntPtr data);

		private delegate void Delegate_CompressedTexImage2D_0(uint target, int level, uint internalformat, int width, int height, int border, int imageSize, System.IntPtr data);

		private delegate void Delegate_CompressedTexImage3D_0(uint target, int level, uint internalformat, int width, int height, int depth, int border, int imageSize, System.IntPtr data);

		private delegate void Delegate_CompressedTexSubImage1D_0(uint target, int level, int xoffset, int width, uint format, int imageSize, System.IntPtr data);

		private delegate void Delegate_CompressedTexSubImage2D_0(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, System.IntPtr data);

		private delegate void Delegate_CompressedTexSubImage2D_1(uint target, int level, Box2i imagePosition, uint format, int imageSize, System.IntPtr data);

		private delegate void Delegate_CompressedTexSubImage3D_0(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, System.IntPtr data);

		private delegate void Delegate_CompressedTexSubImage3D_1(uint target, int level, Box3i imagePosition, uint format, int imageSize, System.IntPtr data);

		private delegate void Delegate_CopyBufferSubData_0(uint readTarget, uint writeTarget, System.IntPtr readOffset, System.IntPtr writeOffset, System.IntPtr size);

		private delegate void Delegate_CopyTexImage1D_0(uint target, int level, uint internalformat, int x, int y, int width, int border);

		private delegate void Delegate_CopyTexImage1D_1(uint target, int level, uint internalformat, Vector2i imagePosition, int width, int border);

		private delegate void Delegate_CopyTexImage2D_0(uint target, int level, uint internalformat, int x, int y, int width, int height, int border);

		private delegate void Delegate_CopyTexImage2D_1(uint target, int level, uint internalformat, Vector2i imagePosition, Vector2i imageSize, int border);

		private delegate void Delegate_CopyTexImage2D_2(uint target, int level, uint internalformat, Box2i image, int border);

		private delegate void Delegate_CopyTexSubImage1D_0(uint target, int level, int xoffset, int x, int y, int width);

		private delegate void Delegate_CopyTexSubImage1D_1(uint target, int level, int xoffset, Vector2i imagePosition, int width);

		private delegate void Delegate_CopyTexSubImage2D_0(uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height);

		private delegate void Delegate_CopyTexSubImage2D_1(uint target, int level, Vector2i texturePosition, Vector2i imagePosition, Vector2i size);

		private delegate void Delegate_CopyTexSubImage3D_0(uint target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);

		private delegate void Delegate_CopyTexSubImage3D_1(uint target, int level, Vector3i texturePosition, Vector2i imagePosition, Vector2i size);

		private delegate uint Delegate_CreateProgram_0();

		private delegate uint Delegate_CreateShader_0(uint type);

		private delegate void Delegate_CullFace_0(uint mode);

		private delegate void Delegate_DeleteBuffers_0(int n, System.IntPtr buffers);

		private delegate void Delegate_DeleteBuffers_1(int n, uint[] buffers);

		private delegate void Delegate_DeleteBuffers_2(int n, ref uint buffers);

		private delegate void Delegate_DeleteFramebuffers_0(int n, System.IntPtr framebuffers);

		private delegate void Delegate_DeleteFramebuffers_1(int n, uint[] framebuffers);

		private delegate void Delegate_DeleteFramebuffers_2(int n, ref uint framebuffers);

		private delegate void Delegate_DeleteProgram_0(uint program);

		private delegate void Delegate_DeleteQueries_0(int n, System.IntPtr ids);

		private delegate void Delegate_DeleteQueries_1(int n, uint[] ids);

		private delegate void Delegate_DeleteQueries_2(int n, ref uint ids);

		private delegate void Delegate_DeleteRenderbuffers_0(int n, System.IntPtr renderbuffers);

		private delegate void Delegate_DeleteRenderbuffers_1(int n, uint[] renderbuffers);

		private delegate void Delegate_DeleteRenderbuffers_2(int n, ref uint renderbuffers);

		private delegate void Delegate_DeleteShader_0(uint shader);

		private delegate void Delegate_DeleteSync_0(System.IntPtr sync);

		private delegate void Delegate_DeleteTextures_0(int n, System.IntPtr textures);

		private delegate void Delegate_DeleteTextures_1(int n, uint[] textures);

		private delegate void Delegate_DeleteTextures_2(int n, ref uint textures);

		private delegate void Delegate_DeleteVertexArrays_0(int n, System.IntPtr arrays);

		private delegate void Delegate_DeleteVertexArrays_1(int n, uint[] arrays);

		private delegate void Delegate_DeleteVertexArrays_2(int n, ref uint arrays);

		private delegate void Delegate_DepthFunc_0(uint func);

		private delegate void Delegate_DepthMask_0(bool flag);

		private delegate void Delegate_DepthRange_0(double near, double far);

		private delegate void Delegate_DetachShader_0(uint program, uint shader);

		private delegate void Delegate_Disable_0(uint cap);

		private delegate void Delegate_Disablei_0(uint target, uint index);

		private delegate void Delegate_DisableVertexAttribArray_0(uint index);

		private delegate void Delegate_DrawArrays_0(uint mode, int first, int count);

		private delegate void Delegate_DrawArraysInstanced_0(uint mode, int first, int count, int instancecount);

		private delegate void Delegate_DrawBuffer_0(uint mode);

		private delegate void Delegate_DrawBuffers_0(int n, System.IntPtr bufs);

		private delegate void Delegate_DrawBuffers_1(int n, uint[] bufs);

		private delegate void Delegate_DrawBuffers_2(int n, ref uint bufs);

		private delegate void Delegate_DrawElements_0(uint mode, int count, uint type, System.IntPtr indices);

		private delegate void Delegate_DrawElements_1(uint mode, int count, uint type, byte[] indices);

		private delegate void Delegate_DrawElements_2(uint mode, int count, uint type, ushort[] indices);

		private delegate void Delegate_DrawElements_3(uint mode, int count, uint type, uint[] indices);

		private delegate void Delegate_DrawElementsBaseVertex_0(uint mode, int count, uint type, System.IntPtr indices, int basevertex);

		private delegate void Delegate_DrawElementsBaseVertex_1(uint mode, int count, uint type, byte[] indices, int basevertex);

		private delegate void Delegate_DrawElementsBaseVertex_2(uint mode, int count, uint type, ushort[] indices, int basevertex);

		private delegate void Delegate_DrawElementsBaseVertex_3(uint mode, int count, uint type, uint[] indices, int basevertex);

		private delegate void Delegate_DrawElementsInstanced_0(uint mode, int count, uint type, System.IntPtr indices, int instancecount);

		private delegate void Delegate_DrawElementsInstanced_1(uint mode, int count, uint type, byte[] indices, int instancecount);

		private delegate void Delegate_DrawElementsInstanced_2(uint mode, int count, uint type, ushort[] indices, int instancecount);

		private delegate void Delegate_DrawElementsInstanced_3(uint mode, int count, uint type, uint[] indices, int instancecount);

		private delegate void Delegate_DrawElementsInstancedBaseVertex_0(uint mode, int count, uint type, System.IntPtr indices, int instancecount, int basevertex);

		private delegate void Delegate_DrawElementsInstancedBaseVertex_1(uint mode, int count, uint type, byte[] indices, int instancecount, int basevertex);

		private delegate void Delegate_DrawElementsInstancedBaseVertex_2(uint mode, int count, uint type, ushort[] indices, int instancecount, int basevertex);

		private delegate void Delegate_DrawElementsInstancedBaseVertex_3(uint mode, int count, uint type, uint[] indices, int instancecount, int basevertex);

		private delegate void Delegate_DrawRangeElements_0(uint mode, uint start, uint end, int count, uint type, System.IntPtr indices);

		private delegate void Delegate_DrawRangeElements_1(uint mode, uint start, uint end, int count, uint type, byte[] indices);

		private delegate void Delegate_DrawRangeElements_2(uint mode, uint start, uint end, int count, uint type, ushort[] indices);

		private delegate void Delegate_DrawRangeElements_3(uint mode, uint start, uint end, int count, uint type, uint[] indices);

		private delegate void Delegate_DrawRangeElementsBaseVertex_0(uint mode, uint start, uint end, int count, uint type, System.IntPtr indices, int basevertex);

		private delegate void Delegate_DrawRangeElementsBaseVertex_1(uint mode, uint start, uint end, int count, uint type, byte[] indices, int basevertex);

		private delegate void Delegate_DrawRangeElementsBaseVertex_2(uint mode, uint start, uint end, int count, uint type, ushort[] indices, int basevertex);

		private delegate void Delegate_DrawRangeElementsBaseVertex_3(uint mode, uint start, uint end, int count, uint type, uint[] indices, int basevertex);

		private delegate void Delegate_Enable_0(uint cap);

		private delegate void Delegate_Enablei_0(uint target, uint index);

		private delegate void Delegate_EnableVertexAttribArray_0(uint index);

		private delegate void Delegate_EndConditionalRender_0();

		private delegate void Delegate_EndQuery_0(uint target);

		private delegate void Delegate_EndTransformFeedback_0();

		private delegate System.IntPtr Delegate_FenceSync_0(uint condition, uint flags);

		private delegate void Delegate_Finish_0();

		private delegate void Delegate_Flush_0();

		private delegate void Delegate_FlushMappedBufferRange_0(uint target, System.IntPtr offset, System.IntPtr length);

		private delegate void Delegate_FramebufferRenderbuffer_0(uint target, uint attachment, uint renderbuffertarget, uint renderbuffer);

		private delegate void Delegate_FramebufferTexture_0(uint target, uint attachment, uint texture, int level);

		private delegate void Delegate_FramebufferTexture1D_0(uint target, uint attachment, uint textarget, uint texture, int level);

		private delegate void Delegate_FramebufferTexture2D_0(uint target, uint attachment, uint textarget, uint texture, int level);

		private delegate void Delegate_FramebufferTexture3D_0(uint target, uint attachment, uint textarget, uint texture, int level, int zoffset);

		private delegate void Delegate_FramebufferTextureLayer_0(uint target, uint attachment, uint texture, int level, int layer);

		private delegate void Delegate_FrontFace_0(uint mode);

		private delegate void Delegate_GenBuffers_0(int n, System.IntPtr buffers);

		private delegate void Delegate_GenBuffers_1(int n, uint[] buffers);

		private delegate void Delegate_GenBuffers_2(int n, out uint buffers);

		private delegate void Delegate_GenerateMipmap_0(uint target);

		private delegate void Delegate_GenFramebuffers_0(int n, System.IntPtr framebuffers);

		private delegate void Delegate_GenFramebuffers_1(int n, uint[] framebuffers);

		private delegate void Delegate_GenFramebuffers_2(int n, out uint framebuffers);

		private delegate void Delegate_GenQueries_0(int n, System.IntPtr ids);

		private delegate void Delegate_GenQueries_1(int n, uint[] ids);

		private delegate void Delegate_GenQueries_2(int n, out uint ids);

		private delegate void Delegate_GenRenderbuffers_0(int n, System.IntPtr renderbuffers);

		private delegate void Delegate_GenRenderbuffers_1(int n, uint[] renderbuffers);

		private delegate void Delegate_GenRenderbuffers_2(int n, out uint renderbuffers);

		private delegate void Delegate_GenTextures_0(int n, System.IntPtr textures);

		private delegate void Delegate_GenTextures_1(int n, uint[] textures);

		private delegate void Delegate_GenTextures_2(int n, out uint textures);

		private delegate void Delegate_GenVertexArrays_0(int n, System.IntPtr arrays);

		private delegate void Delegate_GenVertexArrays_1(int n, uint[] arrays);

		private delegate void Delegate_GenVertexArrays_2(int n, out uint arrays);

		private delegate void Delegate_GetActiveAttrib_0(uint program, uint index, int bufSize, System.IntPtr length, System.IntPtr size, System.IntPtr type, string name);

		private delegate void Delegate_GetActiveAttrib_1(uint program, uint index, int bufSize, out int length, out int size, out uint type, byte[] name);

		private delegate void Delegate_GetActiveUniform_0(uint program, uint index, int bufSize, System.IntPtr length, System.IntPtr size, System.IntPtr type, string name);

		private delegate void Delegate_GetActiveUniform_1(uint program, uint index, int bufSize, out int length, out int size, out uint type, byte[] name);

		private delegate void Delegate_GetActiveUniformBlockiv_0(uint program, uint uniformBlockIndex, uint pname, System.IntPtr _params);

		private delegate void Delegate_GetActiveUniformBlockiv_1(uint program, uint uniformBlockIndex, uint pname, int[] _params);

		private delegate void Delegate_GetActiveUniformBlockiv_2(uint program, uint uniformBlockIndex, uint pname, out int _params);

		private delegate void Delegate_GetActiveUniformBlockName_0(uint program, uint uniformBlockIndex, int bufSize, System.IntPtr length, System.IntPtr uniformBlockName);

		private delegate void Delegate_GetActiveUniformBlockName_1(uint program, uint uniformBlockIndex, int bufSize, out int length, byte[] uniformBlockName);

		private delegate void Delegate_GetActiveUniformName_0(uint program, uint uniformIndex, int bufSize, System.IntPtr length, System.IntPtr uniformName);

		private delegate void Delegate_GetActiveUniformName_1(uint program, uint uniformIndex, int bufSize, out int length, byte[] uniformName);

		private delegate void Delegate_GetActiveUniformsiv_0(uint program, int uniformCount, System.IntPtr uniformIndices, uint pname, System.IntPtr _params);

		private delegate void Delegate_GetActiveUniformsiv_1(uint program, int uniformCount, uint[] uniformIndices, uint pname, int[] _params);

		private delegate void Delegate_GetActiveUniformsiv_2(uint program, int uniformCount, out int uniformIndices, uint pname, int[] _params);

		private delegate void Delegate_GetActiveUniformsiv_3(uint program, int uniformCount, uint[] uniformIndices, uint pname, ref int _params);

		private delegate void Delegate_GetActiveUniformsiv_4(uint program, int uniformCount, out int uniformIndices, uint pname, ref int _params);

		private delegate void Delegate_GetAttachedShaders_0(uint program, int maxCount, System.IntPtr count, System.IntPtr shaders);

		private delegate void Delegate_GetAttachedShaders_1(uint program, int maxCount, uint count, uint[] shaders);

		private delegate int Delegate_GetAttribLocation_0(uint program, System.IntPtr name);

		private delegate int Delegate_GetAttribLocation_1(uint program, byte[] name);

		private delegate int Delegate_GetAttribLocation_2(uint program, string name);

		private delegate void Delegate_GetBooleani_v_0(uint target, uint index, System.IntPtr data);

		private delegate void Delegate_GetBooleani_v_1(uint target, uint index, out bool data);

		private delegate void Delegate_GetBooleanv_0(uint pname, System.IntPtr data);

		private delegate void Delegate_GetBooleanv_1(uint pname, out bool data);

		private delegate void Delegate_GetBufferParameteri64v_0(uint target, uint pname, System.IntPtr _params);

		private delegate void Delegate_GetBufferParameteri64v_1(uint target, uint pname, out long _params);

		private delegate void Delegate_GetBufferParameteriv_0(uint target, uint pname, System.IntPtr _params);

		private delegate void Delegate_GetBufferParameteriv_1(uint target, uint pname, out int _params);

		private delegate void Delegate_GetBufferPointerv_0(uint target, uint pname, System.IntPtr _params);

		private delegate void Delegate_GetBufferPointerv_1(uint target, uint pname, out System.IntPtr _params);

		private delegate void Delegate_GetBufferSubData_0(uint target, System.IntPtr offset, System.IntPtr size, System.IntPtr data);

		private delegate void Delegate_GetCompressedTexImage_0(uint target, int level, System.IntPtr img);

		private delegate void Delegate_GetDoublev_0(uint pname, System.IntPtr data);

		private delegate void Delegate_GetDoublev_1(uint pname, double[] data);

		private delegate void Delegate_GetDoublev_2(uint pname, out double data);

		private delegate void Delegate_GetDoublev_3(uint pname, out Vector2d data);

		private delegate void Delegate_GetDoublev_4(uint pname, out Vector3d data);

		private delegate void Delegate_GetDoublev_5(uint pname, out Vector4d data);

		private delegate void Delegate_GetDoublev_6(uint pname, out Color3d data);

		private delegate void Delegate_GetDoublev_7(uint pname, out Color4d data);

		private delegate void Delegate_GetDoublev_8(uint pname, out Box2d data);

		private delegate void Delegate_GetDoublev_9(uint pname, out Box3d data);

		private delegate uint Delegate_GetError_0();

		private delegate void Delegate_GetFloatv_0(uint pname, System.IntPtr data);

		private delegate void Delegate_GetFloatv_1(uint pname, float[] data);

		private delegate void Delegate_GetFloatv_2(uint pname, out float data);

		private delegate void Delegate_GetFloatv_3(uint pname, out Vector2 data);

		private delegate void Delegate_GetFloatv_4(uint pname, out Vector3 data);

		private delegate void Delegate_GetFloatv_5(uint pname, out Vector4 data);

		private delegate void Delegate_GetFloatv_6(uint pname, out Color3 data);

		private delegate void Delegate_GetFloatv_7(uint pname, out Color4 data);

		private delegate void Delegate_GetFloatv_8(uint pname, out Box2 data);

		private delegate void Delegate_GetFloatv_9(uint pname, out Box3 data);

		private delegate int Delegate_GetFragDataLocation_0(uint program, string name);

		private delegate void Delegate_GetFramebufferAttachmentParameteriv_0(uint target, uint attachment, uint pname, System.IntPtr _params);

		private delegate void Delegate_GetFramebufferAttachmentParameteriv_1(uint target, uint attachment, uint pname, out int _params);

		private delegate void Delegate_GetInteger64i_v_0(uint target, uint index, System.IntPtr data);

		private delegate void Delegate_GetInteger64i_v_1(uint target, uint index, long[] data);

		private delegate void Delegate_GetInteger64i_v_2(uint target, uint index, out long data);

		private delegate void Delegate_GetInteger64v_0(uint pname, System.IntPtr data);

		private delegate void Delegate_GetInteger64v_1(uint pname, long[] data);

		private delegate void Delegate_GetInteger64v_2(uint pname, out long data);

		private delegate void Delegate_GetIntegeri_v_0(uint target, uint index, System.IntPtr data);

		private delegate void Delegate_GetIntegeri_v_1(uint target, uint index, int[] data);

		private delegate void Delegate_GetIntegeri_v_2(uint target, uint index, out int data);

		private delegate void Delegate_GetIntegerv_0(uint pname, System.IntPtr data);

		private delegate void Delegate_GetIntegerv_1(uint pname, int[] data);

		private delegate void Delegate_GetIntegerv_2(uint pname, out int data);

		private delegate void Delegate_GetMultisamplefv_0(uint pname, uint index, System.IntPtr val);

		private delegate void Delegate_GetMultisamplefv_1(uint pname, uint index, out float val);

		private delegate void Delegate_GetProgramInfoLog_0(uint program, int bufSize, System.IntPtr length, string infoLog);

		private delegate void Delegate_GetProgramInfoLog_1(uint program, int bufSize, out int length, byte[] infoLog);

		private delegate void Delegate_GetProgramiv_0(uint program, uint pname, System.IntPtr _params);

		private delegate void Delegate_GetProgramiv_1(uint program, uint pname, int[] _params);

		private delegate void Delegate_GetProgramiv_2(uint program, uint pname, out int _params);

		private delegate void Delegate_GetQueryiv_0(uint target, uint pname, System.IntPtr _params);

		private delegate void Delegate_GetQueryObjectiv_0(uint id, uint pname, System.IntPtr _params);

		private delegate void Delegate_GetQueryObjectuiv_0(uint id, uint pname, System.IntPtr _params);

		private delegate void Delegate_GetRenderbufferParameteriv_0(uint target, uint pname, System.IntPtr _params);

		private delegate void Delegate_GetShaderInfoLog_0(uint shader, int bufSize, System.IntPtr length, string infoLog);

		private delegate void Delegate_GetShaderInfoLog_1(uint shader, int bufSize, out int length, byte[] infoLog);

		private delegate void Delegate_GetShaderiv_0(uint shader, uint pname, System.IntPtr _params);

		private delegate void Delegate_GetShaderiv_1(uint shader, uint pname, int[] _params);

		private delegate void Delegate_GetShaderiv_2(uint shader, uint pname, out int _params);

		private delegate void Delegate_GetShaderSource_0(uint shader, int bufSize, System.IntPtr length, string source);

		private delegate System.IntPtr Delegate_GetString_0(uint name);

		private delegate System.IntPtr Delegate_GetStringi_0(uint name, uint index);

		private delegate void Delegate_GetSynciv_0(System.IntPtr sync, uint pname, int bufSize, System.IntPtr length, System.IntPtr values);

		private delegate void Delegate_GetTexImage_0(uint target, int level, uint format, uint type, System.IntPtr pixels);

		private delegate void Delegate_GetTexLevelParameterfv_0(uint target, int level, uint pname, System.IntPtr _params);

		private delegate void Delegate_GetTexLevelParameteriv_0(uint target, int level, uint pname, System.IntPtr _params);

		private delegate void Delegate_GetTexParameterfv_0(uint target, uint pname, System.IntPtr _params);

		private delegate void Delegate_GetTexParameterIiv_0(uint target, uint pname, System.IntPtr _params);

		private delegate void Delegate_GetTexParameterIuiv_0(uint target, uint pname, System.IntPtr _params);

		private delegate void Delegate_GetTexParameteriv_0(uint target, uint pname, System.IntPtr _params);

		private delegate void Delegate_GetTransformFeedbackVarying_0(uint program, uint index, int bufSize, System.IntPtr length, System.IntPtr size, System.IntPtr type, string name);

		private delegate uint Delegate_GetUniformBlockIndex_0(uint program, string uniformBlockName);

		private delegate void Delegate_GetUniformfv_0(uint program, int location, System.IntPtr _params);

		private delegate void Delegate_GetUniformIndices_0(uint program, int uniformCount, System.IntPtr uniformNames, System.IntPtr uniformIndices);

		private delegate void Delegate_GetUniformiv_0(uint program, int location, System.IntPtr _params);

		private delegate int Delegate_GetUniformLocation_0(uint program, System.IntPtr name);

		private delegate int Delegate_GetUniformLocation_1(uint program, byte[] name);

		private delegate int Delegate_GetUniformLocation_2(uint program, string name);

		private delegate void Delegate_GetUniformuiv_0(uint program, int location, System.IntPtr _params);

		private delegate void Delegate_GetVertexAttribdv_0(uint index, uint pname, System.IntPtr _params);

		private delegate void Delegate_GetVertexAttribfv_0(uint index, uint pname, System.IntPtr _params);

		private delegate void Delegate_GetVertexAttribIiv_0(uint index, uint pname, System.IntPtr _params);

		private delegate void Delegate_GetVertexAttribIuiv_0(uint index, uint pname, System.IntPtr _params);

		private delegate void Delegate_GetVertexAttribiv_0(uint index, uint pname, System.IntPtr _params);

		private delegate void Delegate_GetVertexAttribPointerv_0(uint index, uint pname, System.IntPtr pointer);

		private delegate void Delegate_Hint_0(uint target, uint mode);

		private delegate bool Delegate_IsBuffer_0(uint buffer);

		private delegate bool Delegate_IsEnabled_0(uint cap);

		private delegate bool Delegate_IsEnabledi_0(uint target, uint index);

		private delegate bool Delegate_IsFramebuffer_0(uint framebuffer);

		private delegate bool Delegate_IsProgram_0(uint program);

		private delegate bool Delegate_IsQuery_0(uint id);

		private delegate bool Delegate_IsRenderbuffer_0(uint renderbuffer);

		private delegate bool Delegate_IsShader_0(uint shader);

		private delegate bool Delegate_IsSync_0(System.IntPtr sync);

		private delegate bool Delegate_IsTexture_0(uint texture);

		private delegate bool Delegate_IsVertexArray_0(uint array);

		private delegate void Delegate_LineWidth_0(float width);

		private delegate void Delegate_LinkProgram_0(uint program);

		private delegate void Delegate_LogicOp_0(uint opcode);

		private delegate System.IntPtr Delegate_MapBuffer_0(uint target, uint access);

		private delegate System.IntPtr Delegate_MapBufferRange_0(uint target, System.IntPtr offset, System.IntPtr length, uint access);

		private delegate void Delegate_MultiDrawArrays_0(uint mode, System.IntPtr first, System.IntPtr count, int drawcount);

		private delegate void Delegate_MultiDrawElements_0(uint mode, System.IntPtr count, uint type, System.IntPtr indices, int drawcount);

		private delegate void Delegate_MultiDrawElementsBaseVertex_0(uint mode, System.IntPtr count, uint type, System.IntPtr indices, int drawcount, System.IntPtr basevertex);

		private delegate void Delegate_PixelStoref_0(uint pname, float param);

		private delegate void Delegate_PixelStorei_0(uint pname, int param);

		private delegate void Delegate_PointParameterf_0(uint pname, float param);

		private delegate void Delegate_PointParameterfv_0(uint pname, System.IntPtr _params);

		private delegate void Delegate_PointParameteri_0(uint pname, int param);

		private delegate void Delegate_PointParameteriv_0(uint pname, System.IntPtr _params);

		private delegate void Delegate_PointSize_0(float size);

		private delegate void Delegate_PolygonMode_0(uint face, uint mode);

		private delegate void Delegate_PolygonOffset_0(float factor, float units);

		private delegate void Delegate_PrimitiveRestartIndex_0(uint index);

		private delegate void Delegate_ProvokingVertex_0(uint mode);

		private delegate void Delegate_ReadBuffer_0(uint mode);

		private delegate void Delegate_ReadPixels_0(int x, int y, int width, int height, uint format, uint type, System.IntPtr pixels);

		private delegate void Delegate_RenderbufferStorage_0(uint target, uint internalformat, int width, int height);

		private delegate void Delegate_RenderbufferStorageMultisample_0(uint target, int samples, uint internalformat, int width, int height);

		private delegate void Delegate_SampleCoverage_0(float value, bool invert);

		private delegate void Delegate_SampleMaski_0(uint index, uint mask);

		private delegate void Delegate_Scissor_0(int x, int y, int width, int height);

		private delegate void Delegate_ShaderSource_0(uint shader, int count, System.IntPtr _string, System.IntPtr length);

		private delegate void Delegate_ShaderSource_1(uint shader, int count, IntPtr[] _string, int[] length);

		private delegate void Delegate_StencilFunc_0(uint func, int _ref, uint mask);

		private delegate void Delegate_StencilFuncSeparate_0(uint face, uint func, int _ref, uint mask);

		private delegate void Delegate_StencilMask_0(uint mask);

		private delegate void Delegate_StencilMaskSeparate_0(uint face, uint mask);

		private delegate void Delegate_StencilOp_0(uint fail, uint zfail, uint zpass);

		private delegate void Delegate_StencilOpSeparate_0(uint face, uint sfail, uint dpfail, uint dppass);

		private delegate void Delegate_TexBuffer_0(uint target, uint internalformat, uint buffer);

		private delegate void Delegate_TexImage1D_0(uint target, int level, int internalformat, int width, int border, uint format, uint type, System.IntPtr pixels);

		private delegate void Delegate_TexImage2D_0(uint target, int level, int internalformat, int width, int height, int border, uint format, uint type, System.IntPtr pixels);

		private delegate void Delegate_TexImage2DMultisample_0(uint target, int samples, uint internalformat, int width, int height, bool fixedsamplelocations);

		private delegate void Delegate_TexImage3D_0(uint target, int level, int internalformat, int width, int height, int depth, int border, uint format, uint type, System.IntPtr pixels);

		private delegate void Delegate_TexImage3DMultisample_0(uint target, int samples, uint internalformat, int width, int height, int depth, bool fixedsamplelocations);

		private delegate void Delegate_TexParameterf_0(uint target, uint pname, float param);

		private delegate void Delegate_TexParameterfv_0(uint target, uint pname, System.IntPtr _params);

		private delegate void Delegate_TexParameteri_0(uint target, uint pname, int param);

		private delegate void Delegate_TexParameterIiv_0(uint target, uint pname, System.IntPtr _params);

		private delegate void Delegate_TexParameterIuiv_0(uint target, uint pname, System.IntPtr _params);

		private delegate void Delegate_TexParameteriv_0(uint target, uint pname, System.IntPtr _params);

		private delegate void Delegate_TexSubImage1D_0(uint target, int level, int xoffset, int width, uint format, uint type, System.IntPtr pixels);

		private delegate void Delegate_TexSubImage2D_0(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, System.IntPtr pixels);

		private delegate void Delegate_TexSubImage3D_0(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, System.IntPtr pixels);

		private delegate void Delegate_TransformFeedbackVaryings_0(uint program, int count, System.IntPtr varyings, uint bufferMode);

		private delegate void Delegate_Uniform1f_0(int location, float v0);

		private delegate void Delegate_Uniform1fv_0(int location, int count, System.IntPtr value);

		private delegate void Delegate_Uniform1i_0(int location, int v0);

		private delegate void Delegate_Uniform1iv_0(int location, int count, System.IntPtr value);

		private delegate void Delegate_Uniform1ui_0(int location, uint v0);

		private delegate void Delegate_Uniform1uiv_0(int location, int count, System.IntPtr value);

		private delegate void Delegate_Uniform2f_0(int location, float v0, float v1);

		private delegate void Delegate_Uniform2fv_0(int location, int count, System.IntPtr value);

		private delegate void Delegate_Uniform2i_0(int location, int v0, int v1);

		private delegate void Delegate_Uniform2iv_0(int location, int count, System.IntPtr value);

		private delegate void Delegate_Uniform2ui_0(int location, uint v0, uint v1);

		private delegate void Delegate_Uniform2uiv_0(int location, int count, System.IntPtr value);

		private delegate void Delegate_Uniform3f_0(int location, float v0, float v1, float v2);

		private delegate void Delegate_Uniform3fv_0(int location, int count, System.IntPtr value);

		private delegate void Delegate_Uniform3i_0(int location, int v0, int v1, int v2);

		private delegate void Delegate_Uniform3iv_0(int location, int count, System.IntPtr value);

		private delegate void Delegate_Uniform3ui_0(int location, uint v0, uint v1, uint v2);

		private delegate void Delegate_Uniform3uiv_0(int location, int count, System.IntPtr value);

		private delegate void Delegate_Uniform4f_0(int location, float v0, float v1, float v2, float v3);

		private delegate void Delegate_Uniform4fv_0(int location, int count, System.IntPtr value);

		private delegate void Delegate_Uniform4i_0(int location, int v0, int v1, int v2, int v3);

		private delegate void Delegate_Uniform4iv_0(int location, int count, System.IntPtr value);

		private delegate void Delegate_Uniform4ui_0(int location, uint v0, uint v1, uint v2, uint v3);

		private delegate void Delegate_Uniform4uiv_0(int location, int count, System.IntPtr value);

		private delegate void Delegate_UniformBlockBinding_0(uint program, uint uniformBlockIndex, uint uniformBlockBinding);

		private delegate void Delegate_UniformMatrix2fv_0(int location, int count, bool transpose, System.IntPtr value);

		private delegate void Delegate_UniformMatrix2fv_1(int location, int count, bool transpose, float[] value);

		private delegate void Delegate_UniformMatrix2fv_2(int location, int count, bool transpose, ref Matrix2 value);

		private delegate void Delegate_UniformMatrix2x3fv_0(int location, int count, bool transpose, System.IntPtr value);

		private delegate void Delegate_UniformMatrix2x4fv_0(int location, int count, bool transpose, System.IntPtr value);

		private delegate void Delegate_UniformMatrix3fv_0(int location, int count, bool transpose, System.IntPtr value);

		private delegate void Delegate_UniformMatrix3fv_1(int location, int count, bool transpose, float[] value);

		private delegate void Delegate_UniformMatrix3fv_2(int location, int count, bool transpose, ref Matrix3 value);

		private delegate void Delegate_UniformMatrix3x2fv_0(int location, int count, bool transpose, System.IntPtr value);

		private delegate void Delegate_UniformMatrix3x4fv_0(int location, int count, bool transpose, System.IntPtr value);

		private delegate void Delegate_UniformMatrix4fv_0(int location, int count, bool transpose, System.IntPtr value);

		private delegate void Delegate_UniformMatrix4fv_1(int location, int count, bool transpose, float[] value);

		private delegate void Delegate_UniformMatrix4fv_2(int location, int count, bool transpose, ref Matrix4 value);

		private delegate void Delegate_UniformMatrix4x2fv_0(int location, int count, bool transpose, System.IntPtr value);

		private delegate void Delegate_UniformMatrix4x3fv_0(int location, int count, bool transpose, System.IntPtr value);

		private delegate bool Delegate_UnmapBuffer_0(uint target);

		private delegate void Delegate_UseProgram_0(uint program);

		private delegate void Delegate_ValidateProgram_0(uint program);

		private delegate void Delegate_VertexAttrib1d_0(uint index, double x);

		private delegate void Delegate_VertexAttrib1dv_0(uint index, System.IntPtr v);

		private delegate void Delegate_VertexAttrib1f_0(uint index, float x);

		private delegate void Delegate_VertexAttrib1fv_0(uint index, System.IntPtr v);

		private delegate void Delegate_VertexAttrib1s_0(uint index, short x);

		private delegate void Delegate_VertexAttrib1sv_0(uint index, System.IntPtr v);

		private delegate void Delegate_VertexAttrib2d_0(uint index, double x, double y);

		private delegate void Delegate_VertexAttrib2dv_0(uint index, System.IntPtr v);

		private delegate void Delegate_VertexAttrib2f_0(uint index, float x, float y);

		private delegate void Delegate_VertexAttrib2fv_0(uint index, System.IntPtr v);

		private delegate void Delegate_VertexAttrib2s_0(uint index, short x, short y);

		private delegate void Delegate_VertexAttrib2sv_0(uint index, System.IntPtr v);

		private delegate void Delegate_VertexAttrib3d_0(uint index, double x, double y, double z);

		private delegate void Delegate_VertexAttrib3dv_0(uint index, System.IntPtr v);

		private delegate void Delegate_VertexAttrib3f_0(uint index, float x, float y, float z);

		private delegate void Delegate_VertexAttrib3fv_0(uint index, System.IntPtr v);

		private delegate void Delegate_VertexAttrib3s_0(uint index, short x, short y, short z);

		private delegate void Delegate_VertexAttrib3sv_0(uint index, System.IntPtr v);

		private delegate void Delegate_VertexAttrib4bv_0(uint index, System.IntPtr v);

		private delegate void Delegate_VertexAttrib4d_0(uint index, double x, double y, double z, double w);

		private delegate void Delegate_VertexAttrib4dv_0(uint index, System.IntPtr v);

		private delegate void Delegate_VertexAttrib4f_0(uint index, float x, float y, float z, float w);

		private delegate void Delegate_VertexAttrib4fv_0(uint index, System.IntPtr v);

		private delegate void Delegate_VertexAttrib4iv_0(uint index, System.IntPtr v);

		private delegate void Delegate_VertexAttrib4Nbv_0(uint index, System.IntPtr v);

		private delegate void Delegate_VertexAttrib4Niv_0(uint index, System.IntPtr v);

		private delegate void Delegate_VertexAttrib4Nsv_0(uint index, System.IntPtr v);

		private delegate void Delegate_VertexAttrib4Nub_0(uint index, byte x, byte y, byte z, byte w);

		private delegate void Delegate_VertexAttrib4Nubv_0(uint index, System.IntPtr v);

		private delegate void Delegate_VertexAttrib4Nuiv_0(uint index, System.IntPtr v);

		private delegate void Delegate_VertexAttrib4Nusv_0(uint index, System.IntPtr v);

		private delegate void Delegate_VertexAttrib4s_0(uint index, short x, short y, short z, short w);

		private delegate void Delegate_VertexAttrib4sv_0(uint index, System.IntPtr v);

		private delegate void Delegate_VertexAttrib4ubv_0(uint index, System.IntPtr v);

		private delegate void Delegate_VertexAttrib4uiv_0(uint index, System.IntPtr v);

		private delegate void Delegate_VertexAttrib4usv_0(uint index, System.IntPtr v);

		private delegate void Delegate_VertexAttribI1i_0(uint index, int x);

		private delegate void Delegate_VertexAttribI1iv_0(uint index, System.IntPtr v);

		private delegate void Delegate_VertexAttribI1ui_0(uint index, uint x);

		private delegate void Delegate_VertexAttribI1uiv_0(uint index, System.IntPtr v);

		private delegate void Delegate_VertexAttribI2i_0(uint index, int x, int y);

		private delegate void Delegate_VertexAttribI2iv_0(uint index, System.IntPtr v);

		private delegate void Delegate_VertexAttribI2ui_0(uint index, uint x, uint y);

		private delegate void Delegate_VertexAttribI2uiv_0(uint index, System.IntPtr v);

		private delegate void Delegate_VertexAttribI3i_0(uint index, int x, int y, int z);

		private delegate void Delegate_VertexAttribI3iv_0(uint index, System.IntPtr v);

		private delegate void Delegate_VertexAttribI3ui_0(uint index, uint x, uint y, uint z);

		private delegate void Delegate_VertexAttribI3uiv_0(uint index, System.IntPtr v);

		private delegate void Delegate_VertexAttribI4bv_0(uint index, System.IntPtr v);

		private delegate void Delegate_VertexAttribI4i_0(uint index, int x, int y, int z, int w);

		private delegate void Delegate_VertexAttribI4iv_0(uint index, System.IntPtr v);

		private delegate void Delegate_VertexAttribI4sv_0(uint index, System.IntPtr v);

		private delegate void Delegate_VertexAttribI4ubv_0(uint index, System.IntPtr v);

		private delegate void Delegate_VertexAttribI4ui_0(uint index, uint x, uint y, uint z, uint w);

		private delegate void Delegate_VertexAttribI4uiv_0(uint index, System.IntPtr v);

		private delegate void Delegate_VertexAttribI4usv_0(uint index, System.IntPtr v);

		private delegate void Delegate_VertexAttribIPointer_0(uint index, int size, uint type, int stride, System.IntPtr pointer);

		private delegate void Delegate_VertexAttribPointer_0(uint index, int size, uint type, bool normalized, int stride, System.IntPtr pointer);

		private delegate void Delegate_Viewport_0(int x, int y, int width, int height);

		private delegate void Delegate_Viewport_1(Box2i dimensions);

		private delegate void Delegate_WaitSync_0(System.IntPtr sync, uint flags, ulong timeout);

		private delegate void Delegate_BindFragDataLocationIndexed_0(uint program, uint colorNumber, uint index, System.IntPtr name);

		private delegate int Delegate_GetFragDataIndex_0(uint program, System.IntPtr name);

		private delegate void Delegate_GenSamplers_0(int count, System.IntPtr samplers);

		private delegate void Delegate_GenSamplers_1(int n, uint[] samplers);

		private delegate void Delegate_GenSamplers_2(int n, out uint samplers);

		private delegate void Delegate_DeleteSamplers_0(int count, System.IntPtr samplers);

		private delegate void Delegate_DeleteSamplers_1(int n, uint[] samplers);

		private delegate void Delegate_DeleteSamplers_2(int n, ref uint samplers);

		private delegate bool Delegate_IsSampler_0(uint shader);

		private delegate void Delegate_BindSampler_0(uint unit, uint sampler);

		private delegate void Delegate_SamplerParameteri_0(uint sampler, uint pname, int param);

		private delegate void Delegate_SamplerParameteriv_0(uint sampler, uint pname, System.IntPtr param);

		private delegate void Delegate_SamplerParameterf_0(uint sampler, uint pname, float param);

		private delegate void Delegate_SamplerParameterfv_0(uint sampler, uint pname, System.IntPtr param);

		private delegate void Delegate_SamplerParameterIiv_0(uint sampler, uint pname, System.IntPtr param);

		private delegate void Delegate_SamplerParameterIuiv_0(uint sampler, uint pname, System.IntPtr param);

		private delegate void Delegate_GetSamplerParameteriv_0(uint sampler, uint pname, System.IntPtr _params);

		private delegate void Delegate_GetSamplerParameterIiv_0(uint sampler, uint pname, System.IntPtr _params);

		private delegate void Delegate_GetSamplerParameterfv_0(uint sampler, uint pname, System.IntPtr _params);

		private delegate void Delegate_GetSamplerParameterIuiv_0(uint sampler, uint pname, System.IntPtr _params);

		private delegate void Delegate_QueryCounter_0(uint id, uint target);

		private delegate void Delegate_GetQueryObjecti64v_0(uint id, uint pname, System.IntPtr _params);

		private delegate void Delegate_GetQueryObjectui64v_0(uint id, uint pname, System.IntPtr _params);

		private delegate void Delegate_VertexAttribDivisor_0(uint index, uint divisor);

		private delegate void Delegate_VertexAttribP1ui_0(uint index, uint type, bool normalized, uint value);

		private delegate void Delegate_VertexAttribP1uiv_0(uint index, uint type, bool normalized, System.IntPtr value);

		private delegate void Delegate_VertexAttribP2ui_0(uint index, uint type, bool normalized, uint value);

		private delegate void Delegate_VertexAttribP2uiv_0(uint index, uint type, bool normalized, System.IntPtr value);

		private delegate void Delegate_VertexAttribP3ui_0(uint index, uint type, bool normalized, uint value);

		private delegate void Delegate_VertexAttribP3uiv_0(uint index, uint type, bool normalized, System.IntPtr value);

		private delegate void Delegate_VertexAttribP4ui_0(uint index, uint type, bool normalized, uint value);

		private delegate void Delegate_VertexAttribP4uiv_0(uint index, uint type, bool normalized, System.IntPtr value);



		private readonly Delegate_ActiveTexture_0 m_ActiveTexture_0;

		private readonly Delegate_AttachShader_0 m_AttachShader_0;

		private readonly Delegate_BeginConditionalRender_0 m_BeginConditionalRender_0;

		private readonly Delegate_BeginQuery_0 m_BeginQuery_0;

		private readonly Delegate_BeginTransformFeedback_0 m_BeginTransformFeedback_0;

		private readonly Delegate_BindAttribLocation_0 m_BindAttribLocation_0;

		private readonly Delegate_BindBuffer_0 m_BindBuffer_0;

		private readonly Delegate_BindBufferBase_0 m_BindBufferBase_0;

		private readonly Delegate_BindBufferRange_0 m_BindBufferRange_0;

		private readonly Delegate_BindFragDataLocation_0 m_BindFragDataLocation_0;

		private readonly Delegate_BindFramebuffer_0 m_BindFramebuffer_0;

		private readonly Delegate_BindRenderbuffer_0 m_BindRenderbuffer_0;

		private readonly Delegate_BindTexture_0 m_BindTexture_0;

		private readonly Delegate_BindVertexArray_0 m_BindVertexArray_0;

		private readonly Delegate_BlendColor_0 m_BlendColor_0;

		private readonly Delegate_BlendColor_1 m_BlendColor_1;

		private readonly Delegate_BlendEquation_0 m_BlendEquation_0;

		private readonly Delegate_BlendEquationSeparate_0 m_BlendEquationSeparate_0;

		private readonly Delegate_BlendFunc_0 m_BlendFunc_0;

		private readonly Delegate_BlendFuncSeparate_0 m_BlendFuncSeparate_0;

		private readonly Delegate_BlitFramebuffer_0 m_BlitFramebuffer_0;

		private readonly Delegate_BlitFramebuffer_1 m_BlitFramebuffer_1;

		private readonly Delegate_BufferData_0 m_BufferData_0;

		private readonly Delegate_BufferSubData_0 m_BufferSubData_0;

		private readonly Delegate_CheckFramebufferStatus_0 m_CheckFramebufferStatus_0;

		private readonly Delegate_ClampColor_0 m_ClampColor_0;

		private readonly Delegate_Clear_0 m_Clear_0;

		private readonly Delegate_ClearBufferfi_0 m_ClearBufferfi_0;

		private readonly Delegate_ClearBufferfv_0 m_ClearBufferfv_0;

		private readonly Delegate_ClearBufferfv_1 m_ClearBufferfv_1;

		private readonly Delegate_ClearBufferfv_2 m_ClearBufferfv_2;

		private readonly Delegate_ClearBufferiv_0 m_ClearBufferiv_0;

		private readonly Delegate_ClearBufferiv_1 m_ClearBufferiv_1;

		private readonly Delegate_ClearBufferiv_2 m_ClearBufferiv_2;

		private readonly Delegate_ClearBufferuiv_0 m_ClearBufferuiv_0;

		private readonly Delegate_ClearBufferuiv_1 m_ClearBufferuiv_1;

		private readonly Delegate_ClearBufferuiv_2 m_ClearBufferuiv_2;

		private readonly Delegate_ClearColor_0 m_ClearColor_0;

		private readonly Delegate_ClearColor_1 m_ClearColor_1;

		private readonly Delegate_ClearDepth_0 m_ClearDepth_0;

		private readonly Delegate_ClearStencil_0 m_ClearStencil_0;

		private readonly Delegate_ClientWaitSync_0 m_ClientWaitSync_0;

		private readonly Delegate_ColorMask_0 m_ColorMask_0;

		private readonly Delegate_ColorMaski_0 m_ColorMaski_0;

		private readonly Delegate_CompileShader_0 m_CompileShader_0;

		private readonly Delegate_CompressedTexImage1D_0 m_CompressedTexImage1D_0;

		private readonly Delegate_CompressedTexImage2D_0 m_CompressedTexImage2D_0;

		private readonly Delegate_CompressedTexImage3D_0 m_CompressedTexImage3D_0;

		private readonly Delegate_CompressedTexSubImage1D_0 m_CompressedTexSubImage1D_0;

		private readonly Delegate_CompressedTexSubImage2D_0 m_CompressedTexSubImage2D_0;

		private readonly Delegate_CompressedTexSubImage2D_1 m_CompressedTexSubImage2D_1;

		private readonly Delegate_CompressedTexSubImage3D_0 m_CompressedTexSubImage3D_0;

		private readonly Delegate_CompressedTexSubImage3D_1 m_CompressedTexSubImage3D_1;

		private readonly Delegate_CopyBufferSubData_0 m_CopyBufferSubData_0;

		private readonly Delegate_CopyTexImage1D_0 m_CopyTexImage1D_0;

		private readonly Delegate_CopyTexImage1D_1 m_CopyTexImage1D_1;

		private readonly Delegate_CopyTexImage2D_0 m_CopyTexImage2D_0;

		private readonly Delegate_CopyTexImage2D_1 m_CopyTexImage2D_1;

		private readonly Delegate_CopyTexImage2D_2 m_CopyTexImage2D_2;

		private readonly Delegate_CopyTexSubImage1D_0 m_CopyTexSubImage1D_0;

		private readonly Delegate_CopyTexSubImage1D_1 m_CopyTexSubImage1D_1;

		private readonly Delegate_CopyTexSubImage2D_0 m_CopyTexSubImage2D_0;

		private readonly Delegate_CopyTexSubImage2D_1 m_CopyTexSubImage2D_1;

		private readonly Delegate_CopyTexSubImage3D_0 m_CopyTexSubImage3D_0;

		private readonly Delegate_CopyTexSubImage3D_1 m_CopyTexSubImage3D_1;

		private readonly Delegate_CreateProgram_0 m_CreateProgram_0;

		private readonly Delegate_CreateShader_0 m_CreateShader_0;

		private readonly Delegate_CullFace_0 m_CullFace_0;

		private readonly Delegate_DeleteBuffers_0 m_DeleteBuffers_0;

		private readonly Delegate_DeleteBuffers_1 m_DeleteBuffers_1;

		private readonly Delegate_DeleteBuffers_2 m_DeleteBuffers_2;

		private readonly Delegate_DeleteFramebuffers_0 m_DeleteFramebuffers_0;

		private readonly Delegate_DeleteFramebuffers_1 m_DeleteFramebuffers_1;

		private readonly Delegate_DeleteFramebuffers_2 m_DeleteFramebuffers_2;

		private readonly Delegate_DeleteProgram_0 m_DeleteProgram_0;

		private readonly Delegate_DeleteQueries_0 m_DeleteQueries_0;

		private readonly Delegate_DeleteQueries_1 m_DeleteQueries_1;

		private readonly Delegate_DeleteQueries_2 m_DeleteQueries_2;

		private readonly Delegate_DeleteRenderbuffers_0 m_DeleteRenderbuffers_0;

		private readonly Delegate_DeleteRenderbuffers_1 m_DeleteRenderbuffers_1;

		private readonly Delegate_DeleteRenderbuffers_2 m_DeleteRenderbuffers_2;

		private readonly Delegate_DeleteShader_0 m_DeleteShader_0;

		private readonly Delegate_DeleteSync_0 m_DeleteSync_0;

		private readonly Delegate_DeleteTextures_0 m_DeleteTextures_0;

		private readonly Delegate_DeleteTextures_1 m_DeleteTextures_1;

		private readonly Delegate_DeleteTextures_2 m_DeleteTextures_2;

		private readonly Delegate_DeleteVertexArrays_0 m_DeleteVertexArrays_0;

		private readonly Delegate_DeleteVertexArrays_1 m_DeleteVertexArrays_1;

		private readonly Delegate_DeleteVertexArrays_2 m_DeleteVertexArrays_2;

		private readonly Delegate_DepthFunc_0 m_DepthFunc_0;

		private readonly Delegate_DepthMask_0 m_DepthMask_0;

		private readonly Delegate_DepthRange_0 m_DepthRange_0;

		private readonly Delegate_DetachShader_0 m_DetachShader_0;

		private readonly Delegate_Disable_0 m_Disable_0;

		private readonly Delegate_Disablei_0 m_Disablei_0;

		private readonly Delegate_DisableVertexAttribArray_0 m_DisableVertexAttribArray_0;

		private readonly Delegate_DrawArrays_0 m_DrawArrays_0;

		private readonly Delegate_DrawArraysInstanced_0 m_DrawArraysInstanced_0;

		private readonly Delegate_DrawBuffer_0 m_DrawBuffer_0;

		private readonly Delegate_DrawBuffers_0 m_DrawBuffers_0;

		private readonly Delegate_DrawBuffers_1 m_DrawBuffers_1;

		private readonly Delegate_DrawBuffers_2 m_DrawBuffers_2;

		private readonly Delegate_DrawElements_0 m_DrawElements_0;

		private readonly Delegate_DrawElements_1 m_DrawElements_1;

		private readonly Delegate_DrawElements_2 m_DrawElements_2;

		private readonly Delegate_DrawElements_3 m_DrawElements_3;

		private readonly Delegate_DrawElementsBaseVertex_0 m_DrawElementsBaseVertex_0;

		private readonly Delegate_DrawElementsBaseVertex_1 m_DrawElementsBaseVertex_1;

		private readonly Delegate_DrawElementsBaseVertex_2 m_DrawElementsBaseVertex_2;

		private readonly Delegate_DrawElementsBaseVertex_3 m_DrawElementsBaseVertex_3;

		private readonly Delegate_DrawElementsInstanced_0 m_DrawElementsInstanced_0;

		private readonly Delegate_DrawElementsInstanced_1 m_DrawElementsInstanced_1;

		private readonly Delegate_DrawElementsInstanced_2 m_DrawElementsInstanced_2;

		private readonly Delegate_DrawElementsInstanced_3 m_DrawElementsInstanced_3;

		private readonly Delegate_DrawElementsInstancedBaseVertex_0 m_DrawElementsInstancedBaseVertex_0;

		private readonly Delegate_DrawElementsInstancedBaseVertex_1 m_DrawElementsInstancedBaseVertex_1;

		private readonly Delegate_DrawElementsInstancedBaseVertex_2 m_DrawElementsInstancedBaseVertex_2;

		private readonly Delegate_DrawElementsInstancedBaseVertex_3 m_DrawElementsInstancedBaseVertex_3;

		private readonly Delegate_DrawRangeElements_0 m_DrawRangeElements_0;

		private readonly Delegate_DrawRangeElements_1 m_DrawRangeElements_1;

		private readonly Delegate_DrawRangeElements_2 m_DrawRangeElements_2;

		private readonly Delegate_DrawRangeElements_3 m_DrawRangeElements_3;

		private readonly Delegate_DrawRangeElementsBaseVertex_0 m_DrawRangeElementsBaseVertex_0;

		private readonly Delegate_DrawRangeElementsBaseVertex_1 m_DrawRangeElementsBaseVertex_1;

		private readonly Delegate_DrawRangeElementsBaseVertex_2 m_DrawRangeElementsBaseVertex_2;

		private readonly Delegate_DrawRangeElementsBaseVertex_3 m_DrawRangeElementsBaseVertex_3;

		private readonly Delegate_Enable_0 m_Enable_0;

		private readonly Delegate_Enablei_0 m_Enablei_0;

		private readonly Delegate_EnableVertexAttribArray_0 m_EnableVertexAttribArray_0;

		private readonly Delegate_EndConditionalRender_0 m_EndConditionalRender_0;

		private readonly Delegate_EndQuery_0 m_EndQuery_0;

		private readonly Delegate_EndTransformFeedback_0 m_EndTransformFeedback_0;

		private readonly Delegate_FenceSync_0 m_FenceSync_0;

		private readonly Delegate_Finish_0 m_Finish_0;

		private readonly Delegate_Flush_0 m_Flush_0;

		private readonly Delegate_FlushMappedBufferRange_0 m_FlushMappedBufferRange_0;

		private readonly Delegate_FramebufferRenderbuffer_0 m_FramebufferRenderbuffer_0;

		private readonly Delegate_FramebufferTexture_0 m_FramebufferTexture_0;

		private readonly Delegate_FramebufferTexture1D_0 m_FramebufferTexture1D_0;

		private readonly Delegate_FramebufferTexture2D_0 m_FramebufferTexture2D_0;

		private readonly Delegate_FramebufferTexture3D_0 m_FramebufferTexture3D_0;

		private readonly Delegate_FramebufferTextureLayer_0 m_FramebufferTextureLayer_0;

		private readonly Delegate_FrontFace_0 m_FrontFace_0;

		private readonly Delegate_GenBuffers_0 m_GenBuffers_0;

		private readonly Delegate_GenBuffers_1 m_GenBuffers_1;

		private readonly Delegate_GenBuffers_2 m_GenBuffers_2;

		private readonly Delegate_GenerateMipmap_0 m_GenerateMipmap_0;

		private readonly Delegate_GenFramebuffers_0 m_GenFramebuffers_0;

		private readonly Delegate_GenFramebuffers_1 m_GenFramebuffers_1;

		private readonly Delegate_GenFramebuffers_2 m_GenFramebuffers_2;

		private readonly Delegate_GenQueries_0 m_GenQueries_0;

		private readonly Delegate_GenQueries_1 m_GenQueries_1;

		private readonly Delegate_GenQueries_2 m_GenQueries_2;

		private readonly Delegate_GenRenderbuffers_0 m_GenRenderbuffers_0;

		private readonly Delegate_GenRenderbuffers_1 m_GenRenderbuffers_1;

		private readonly Delegate_GenRenderbuffers_2 m_GenRenderbuffers_2;

		private readonly Delegate_GenTextures_0 m_GenTextures_0;

		private readonly Delegate_GenTextures_1 m_GenTextures_1;

		private readonly Delegate_GenTextures_2 m_GenTextures_2;

		private readonly Delegate_GenVertexArrays_0 m_GenVertexArrays_0;

		private readonly Delegate_GenVertexArrays_1 m_GenVertexArrays_1;

		private readonly Delegate_GenVertexArrays_2 m_GenVertexArrays_2;

		private readonly Delegate_GetActiveAttrib_0 m_GetActiveAttrib_0;

		private readonly Delegate_GetActiveAttrib_1 m_GetActiveAttrib_1;

		private readonly Delegate_GetActiveUniform_0 m_GetActiveUniform_0;

		private readonly Delegate_GetActiveUniform_1 m_GetActiveUniform_1;

		private readonly Delegate_GetActiveUniformBlockiv_0 m_GetActiveUniformBlockiv_0;

		private readonly Delegate_GetActiveUniformBlockiv_1 m_GetActiveUniformBlockiv_1;

		private readonly Delegate_GetActiveUniformBlockiv_2 m_GetActiveUniformBlockiv_2;

		private readonly Delegate_GetActiveUniformBlockName_0 m_GetActiveUniformBlockName_0;

		private readonly Delegate_GetActiveUniformBlockName_1 m_GetActiveUniformBlockName_1;

		private readonly Delegate_GetActiveUniformName_0 m_GetActiveUniformName_0;

		private readonly Delegate_GetActiveUniformName_1 m_GetActiveUniformName_1;

		private readonly Delegate_GetActiveUniformsiv_0 m_GetActiveUniformsiv_0;

		private readonly Delegate_GetActiveUniformsiv_1 m_GetActiveUniformsiv_1;

		private readonly Delegate_GetActiveUniformsiv_2 m_GetActiveUniformsiv_2;

		private readonly Delegate_GetActiveUniformsiv_3 m_GetActiveUniformsiv_3;

		private readonly Delegate_GetActiveUniformsiv_4 m_GetActiveUniformsiv_4;

		private readonly Delegate_GetAttachedShaders_0 m_GetAttachedShaders_0;

		private readonly Delegate_GetAttachedShaders_1 m_GetAttachedShaders_1;

		private readonly Delegate_GetAttribLocation_0 m_GetAttribLocation_0;

		private readonly Delegate_GetAttribLocation_1 m_GetAttribLocation_1;

		private readonly Delegate_GetAttribLocation_2 m_GetAttribLocation_2;

		private readonly Delegate_GetBooleani_v_0 m_GetBooleani_v_0;

		private readonly Delegate_GetBooleani_v_1 m_GetBooleani_v_1;

		private readonly Delegate_GetBooleanv_0 m_GetBooleanv_0;

		private readonly Delegate_GetBooleanv_1 m_GetBooleanv_1;

		private readonly Delegate_GetBufferParameteri64v_0 m_GetBufferParameteri64v_0;

		private readonly Delegate_GetBufferParameteri64v_1 m_GetBufferParameteri64v_1;

		private readonly Delegate_GetBufferParameteriv_0 m_GetBufferParameteriv_0;

		private readonly Delegate_GetBufferParameteriv_1 m_GetBufferParameteriv_1;

		private readonly Delegate_GetBufferPointerv_0 m_GetBufferPointerv_0;

		private readonly Delegate_GetBufferPointerv_1 m_GetBufferPointerv_1;

		private readonly Delegate_GetBufferSubData_0 m_GetBufferSubData_0;

		private readonly Delegate_GetCompressedTexImage_0 m_GetCompressedTexImage_0;

		private readonly Delegate_GetDoublev_0 m_GetDoublev_0;

		private readonly Delegate_GetDoublev_1 m_GetDoublev_1;

		private readonly Delegate_GetDoublev_2 m_GetDoublev_2;

		private readonly Delegate_GetDoublev_3 m_GetDoublev_3;

		private readonly Delegate_GetDoublev_4 m_GetDoublev_4;

		private readonly Delegate_GetDoublev_5 m_GetDoublev_5;

		private readonly Delegate_GetDoublev_6 m_GetDoublev_6;

		private readonly Delegate_GetDoublev_7 m_GetDoublev_7;

		private readonly Delegate_GetDoublev_8 m_GetDoublev_8;

		private readonly Delegate_GetDoublev_9 m_GetDoublev_9;

		private readonly Delegate_GetError_0 m_GetError_0;

		private readonly Delegate_GetFloatv_0 m_GetFloatv_0;

		private readonly Delegate_GetFloatv_1 m_GetFloatv_1;

		private readonly Delegate_GetFloatv_2 m_GetFloatv_2;

		private readonly Delegate_GetFloatv_3 m_GetFloatv_3;

		private readonly Delegate_GetFloatv_4 m_GetFloatv_4;

		private readonly Delegate_GetFloatv_5 m_GetFloatv_5;

		private readonly Delegate_GetFloatv_6 m_GetFloatv_6;

		private readonly Delegate_GetFloatv_7 m_GetFloatv_7;

		private readonly Delegate_GetFloatv_8 m_GetFloatv_8;

		private readonly Delegate_GetFloatv_9 m_GetFloatv_9;

		private readonly Delegate_GetFragDataLocation_0 m_GetFragDataLocation_0;

		private readonly Delegate_GetFramebufferAttachmentParameteriv_0 m_GetFramebufferAttachmentParameteriv_0;

		private readonly Delegate_GetFramebufferAttachmentParameteriv_1 m_GetFramebufferAttachmentParameteriv_1;

		private readonly Delegate_GetInteger64i_v_0 m_GetInteger64i_v_0;

		private readonly Delegate_GetInteger64i_v_1 m_GetInteger64i_v_1;

		private readonly Delegate_GetInteger64i_v_2 m_GetInteger64i_v_2;

		private readonly Delegate_GetInteger64v_0 m_GetInteger64v_0;

		private readonly Delegate_GetInteger64v_1 m_GetInteger64v_1;

		private readonly Delegate_GetInteger64v_2 m_GetInteger64v_2;

		private readonly Delegate_GetIntegeri_v_0 m_GetIntegeri_v_0;

		private readonly Delegate_GetIntegeri_v_1 m_GetIntegeri_v_1;

		private readonly Delegate_GetIntegeri_v_2 m_GetIntegeri_v_2;

		private readonly Delegate_GetIntegerv_0 m_GetIntegerv_0;

		private readonly Delegate_GetIntegerv_1 m_GetIntegerv_1;

		private readonly Delegate_GetIntegerv_2 m_GetIntegerv_2;

		private readonly Delegate_GetMultisamplefv_0 m_GetMultisamplefv_0;

		private readonly Delegate_GetMultisamplefv_1 m_GetMultisamplefv_1;

		private readonly Delegate_GetProgramInfoLog_0 m_GetProgramInfoLog_0;

		private readonly Delegate_GetProgramInfoLog_1 m_GetProgramInfoLog_1;

		private readonly Delegate_GetProgramiv_0 m_GetProgramiv_0;

		private readonly Delegate_GetProgramiv_1 m_GetProgramiv_1;

		private readonly Delegate_GetProgramiv_2 m_GetProgramiv_2;

		private readonly Delegate_GetQueryiv_0 m_GetQueryiv_0;

		private readonly Delegate_GetQueryObjectiv_0 m_GetQueryObjectiv_0;

		private readonly Delegate_GetQueryObjectuiv_0 m_GetQueryObjectuiv_0;

		private readonly Delegate_GetRenderbufferParameteriv_0 m_GetRenderbufferParameteriv_0;

		private readonly Delegate_GetShaderInfoLog_0 m_GetShaderInfoLog_0;

		private readonly Delegate_GetShaderInfoLog_1 m_GetShaderInfoLog_1;

		private readonly Delegate_GetShaderiv_0 m_GetShaderiv_0;

		private readonly Delegate_GetShaderiv_1 m_GetShaderiv_1;

		private readonly Delegate_GetShaderiv_2 m_GetShaderiv_2;

		private readonly Delegate_GetShaderSource_0 m_GetShaderSource_0;

		private readonly Delegate_GetString_0 m_GetString_0;

		private readonly Delegate_GetStringi_0 m_GetStringi_0;

		private readonly Delegate_GetSynciv_0 m_GetSynciv_0;

		private readonly Delegate_GetTexImage_0 m_GetTexImage_0;

		private readonly Delegate_GetTexLevelParameterfv_0 m_GetTexLevelParameterfv_0;

		private readonly Delegate_GetTexLevelParameteriv_0 m_GetTexLevelParameteriv_0;

		private readonly Delegate_GetTexParameterfv_0 m_GetTexParameterfv_0;

		private readonly Delegate_GetTexParameterIiv_0 m_GetTexParameterIiv_0;

		private readonly Delegate_GetTexParameterIuiv_0 m_GetTexParameterIuiv_0;

		private readonly Delegate_GetTexParameteriv_0 m_GetTexParameteriv_0;

		private readonly Delegate_GetTransformFeedbackVarying_0 m_GetTransformFeedbackVarying_0;

		private readonly Delegate_GetUniformBlockIndex_0 m_GetUniformBlockIndex_0;

		private readonly Delegate_GetUniformfv_0 m_GetUniformfv_0;

		private readonly Delegate_GetUniformIndices_0 m_GetUniformIndices_0;

		private readonly Delegate_GetUniformiv_0 m_GetUniformiv_0;

		private readonly Delegate_GetUniformLocation_0 m_GetUniformLocation_0;

		private readonly Delegate_GetUniformLocation_1 m_GetUniformLocation_1;

		private readonly Delegate_GetUniformLocation_2 m_GetUniformLocation_2;

		private readonly Delegate_GetUniformuiv_0 m_GetUniformuiv_0;

		private readonly Delegate_GetVertexAttribdv_0 m_GetVertexAttribdv_0;

		private readonly Delegate_GetVertexAttribfv_0 m_GetVertexAttribfv_0;

		private readonly Delegate_GetVertexAttribIiv_0 m_GetVertexAttribIiv_0;

		private readonly Delegate_GetVertexAttribIuiv_0 m_GetVertexAttribIuiv_0;

		private readonly Delegate_GetVertexAttribiv_0 m_GetVertexAttribiv_0;

		private readonly Delegate_GetVertexAttribPointerv_0 m_GetVertexAttribPointerv_0;

		private readonly Delegate_Hint_0 m_Hint_0;

		private readonly Delegate_IsBuffer_0 m_IsBuffer_0;

		private readonly Delegate_IsEnabled_0 m_IsEnabled_0;

		private readonly Delegate_IsEnabledi_0 m_IsEnabledi_0;

		private readonly Delegate_IsFramebuffer_0 m_IsFramebuffer_0;

		private readonly Delegate_IsProgram_0 m_IsProgram_0;

		private readonly Delegate_IsQuery_0 m_IsQuery_0;

		private readonly Delegate_IsRenderbuffer_0 m_IsRenderbuffer_0;

		private readonly Delegate_IsShader_0 m_IsShader_0;

		private readonly Delegate_IsSync_0 m_IsSync_0;

		private readonly Delegate_IsTexture_0 m_IsTexture_0;

		private readonly Delegate_IsVertexArray_0 m_IsVertexArray_0;

		private readonly Delegate_LineWidth_0 m_LineWidth_0;

		private readonly Delegate_LinkProgram_0 m_LinkProgram_0;

		private readonly Delegate_LogicOp_0 m_LogicOp_0;

		private readonly Delegate_MapBuffer_0 m_MapBuffer_0;

		private readonly Delegate_MapBufferRange_0 m_MapBufferRange_0;

		private readonly Delegate_MultiDrawArrays_0 m_MultiDrawArrays_0;

		private readonly Delegate_MultiDrawElements_0 m_MultiDrawElements_0;

		private readonly Delegate_MultiDrawElementsBaseVertex_0 m_MultiDrawElementsBaseVertex_0;

		private readonly Delegate_PixelStoref_0 m_PixelStoref_0;

		private readonly Delegate_PixelStorei_0 m_PixelStorei_0;

		private readonly Delegate_PointParameterf_0 m_PointParameterf_0;

		private readonly Delegate_PointParameterfv_0 m_PointParameterfv_0;

		private readonly Delegate_PointParameteri_0 m_PointParameteri_0;

		private readonly Delegate_PointParameteriv_0 m_PointParameteriv_0;

		private readonly Delegate_PointSize_0 m_PointSize_0;

		private readonly Delegate_PolygonMode_0 m_PolygonMode_0;

		private readonly Delegate_PolygonOffset_0 m_PolygonOffset_0;

		private readonly Delegate_PrimitiveRestartIndex_0 m_PrimitiveRestartIndex_0;

		private readonly Delegate_ProvokingVertex_0 m_ProvokingVertex_0;

		private readonly Delegate_ReadBuffer_0 m_ReadBuffer_0;

		private readonly Delegate_ReadPixels_0 m_ReadPixels_0;

		private readonly Delegate_RenderbufferStorage_0 m_RenderbufferStorage_0;

		private readonly Delegate_RenderbufferStorageMultisample_0 m_RenderbufferStorageMultisample_0;

		private readonly Delegate_SampleCoverage_0 m_SampleCoverage_0;

		private readonly Delegate_SampleMaski_0 m_SampleMaski_0;

		private readonly Delegate_Scissor_0 m_Scissor_0;

		private readonly Delegate_ShaderSource_0 m_ShaderSource_0;

		private readonly Delegate_ShaderSource_1 m_ShaderSource_1;

		private readonly Delegate_StencilFunc_0 m_StencilFunc_0;

		private readonly Delegate_StencilFuncSeparate_0 m_StencilFuncSeparate_0;

		private readonly Delegate_StencilMask_0 m_StencilMask_0;

		private readonly Delegate_StencilMaskSeparate_0 m_StencilMaskSeparate_0;

		private readonly Delegate_StencilOp_0 m_StencilOp_0;

		private readonly Delegate_StencilOpSeparate_0 m_StencilOpSeparate_0;

		private readonly Delegate_TexBuffer_0 m_TexBuffer_0;

		private readonly Delegate_TexImage1D_0 m_TexImage1D_0;

		private readonly Delegate_TexImage2D_0 m_TexImage2D_0;

		private readonly Delegate_TexImage2DMultisample_0 m_TexImage2DMultisample_0;

		private readonly Delegate_TexImage3D_0 m_TexImage3D_0;

		private readonly Delegate_TexImage3DMultisample_0 m_TexImage3DMultisample_0;

		private readonly Delegate_TexParameterf_0 m_TexParameterf_0;

		private readonly Delegate_TexParameterfv_0 m_TexParameterfv_0;

		private readonly Delegate_TexParameteri_0 m_TexParameteri_0;

		private readonly Delegate_TexParameterIiv_0 m_TexParameterIiv_0;

		private readonly Delegate_TexParameterIuiv_0 m_TexParameterIuiv_0;

		private readonly Delegate_TexParameteriv_0 m_TexParameteriv_0;

		private readonly Delegate_TexSubImage1D_0 m_TexSubImage1D_0;

		private readonly Delegate_TexSubImage2D_0 m_TexSubImage2D_0;

		private readonly Delegate_TexSubImage3D_0 m_TexSubImage3D_0;

		private readonly Delegate_TransformFeedbackVaryings_0 m_TransformFeedbackVaryings_0;

		private readonly Delegate_Uniform1f_0 m_Uniform1f_0;

		private readonly Delegate_Uniform1fv_0 m_Uniform1fv_0;

		private readonly Delegate_Uniform1i_0 m_Uniform1i_0;

		private readonly Delegate_Uniform1iv_0 m_Uniform1iv_0;

		private readonly Delegate_Uniform1ui_0 m_Uniform1ui_0;

		private readonly Delegate_Uniform1uiv_0 m_Uniform1uiv_0;

		private readonly Delegate_Uniform2f_0 m_Uniform2f_0;

		private readonly Delegate_Uniform2fv_0 m_Uniform2fv_0;

		private readonly Delegate_Uniform2i_0 m_Uniform2i_0;

		private readonly Delegate_Uniform2iv_0 m_Uniform2iv_0;

		private readonly Delegate_Uniform2ui_0 m_Uniform2ui_0;

		private readonly Delegate_Uniform2uiv_0 m_Uniform2uiv_0;

		private readonly Delegate_Uniform3f_0 m_Uniform3f_0;

		private readonly Delegate_Uniform3fv_0 m_Uniform3fv_0;

		private readonly Delegate_Uniform3i_0 m_Uniform3i_0;

		private readonly Delegate_Uniform3iv_0 m_Uniform3iv_0;

		private readonly Delegate_Uniform3ui_0 m_Uniform3ui_0;

		private readonly Delegate_Uniform3uiv_0 m_Uniform3uiv_0;

		private readonly Delegate_Uniform4f_0 m_Uniform4f_0;

		private readonly Delegate_Uniform4fv_0 m_Uniform4fv_0;

		private readonly Delegate_Uniform4i_0 m_Uniform4i_0;

		private readonly Delegate_Uniform4iv_0 m_Uniform4iv_0;

		private readonly Delegate_Uniform4ui_0 m_Uniform4ui_0;

		private readonly Delegate_Uniform4uiv_0 m_Uniform4uiv_0;

		private readonly Delegate_UniformBlockBinding_0 m_UniformBlockBinding_0;

		private readonly Delegate_UniformMatrix2fv_0 m_UniformMatrix2fv_0;

		private readonly Delegate_UniformMatrix2fv_1 m_UniformMatrix2fv_1;

		private readonly Delegate_UniformMatrix2fv_2 m_UniformMatrix2fv_2;

		private readonly Delegate_UniformMatrix2x3fv_0 m_UniformMatrix2x3fv_0;

		private readonly Delegate_UniformMatrix2x4fv_0 m_UniformMatrix2x4fv_0;

		private readonly Delegate_UniformMatrix3fv_0 m_UniformMatrix3fv_0;

		private readonly Delegate_UniformMatrix3fv_1 m_UniformMatrix3fv_1;

		private readonly Delegate_UniformMatrix3fv_2 m_UniformMatrix3fv_2;

		private readonly Delegate_UniformMatrix3x2fv_0 m_UniformMatrix3x2fv_0;

		private readonly Delegate_UniformMatrix3x4fv_0 m_UniformMatrix3x4fv_0;

		private readonly Delegate_UniformMatrix4fv_0 m_UniformMatrix4fv_0;

		private readonly Delegate_UniformMatrix4fv_1 m_UniformMatrix4fv_1;

		private readonly Delegate_UniformMatrix4fv_2 m_UniformMatrix4fv_2;

		private readonly Delegate_UniformMatrix4x2fv_0 m_UniformMatrix4x2fv_0;

		private readonly Delegate_UniformMatrix4x3fv_0 m_UniformMatrix4x3fv_0;

		private readonly Delegate_UnmapBuffer_0 m_UnmapBuffer_0;

		private readonly Delegate_UseProgram_0 m_UseProgram_0;

		private readonly Delegate_ValidateProgram_0 m_ValidateProgram_0;

		private readonly Delegate_VertexAttrib1d_0 m_VertexAttrib1d_0;

		private readonly Delegate_VertexAttrib1dv_0 m_VertexAttrib1dv_0;

		private readonly Delegate_VertexAttrib1f_0 m_VertexAttrib1f_0;

		private readonly Delegate_VertexAttrib1fv_0 m_VertexAttrib1fv_0;

		private readonly Delegate_VertexAttrib1s_0 m_VertexAttrib1s_0;

		private readonly Delegate_VertexAttrib1sv_0 m_VertexAttrib1sv_0;

		private readonly Delegate_VertexAttrib2d_0 m_VertexAttrib2d_0;

		private readonly Delegate_VertexAttrib2dv_0 m_VertexAttrib2dv_0;

		private readonly Delegate_VertexAttrib2f_0 m_VertexAttrib2f_0;

		private readonly Delegate_VertexAttrib2fv_0 m_VertexAttrib2fv_0;

		private readonly Delegate_VertexAttrib2s_0 m_VertexAttrib2s_0;

		private readonly Delegate_VertexAttrib2sv_0 m_VertexAttrib2sv_0;

		private readonly Delegate_VertexAttrib3d_0 m_VertexAttrib3d_0;

		private readonly Delegate_VertexAttrib3dv_0 m_VertexAttrib3dv_0;

		private readonly Delegate_VertexAttrib3f_0 m_VertexAttrib3f_0;

		private readonly Delegate_VertexAttrib3fv_0 m_VertexAttrib3fv_0;

		private readonly Delegate_VertexAttrib3s_0 m_VertexAttrib3s_0;

		private readonly Delegate_VertexAttrib3sv_0 m_VertexAttrib3sv_0;

		private readonly Delegate_VertexAttrib4bv_0 m_VertexAttrib4bv_0;

		private readonly Delegate_VertexAttrib4d_0 m_VertexAttrib4d_0;

		private readonly Delegate_VertexAttrib4dv_0 m_VertexAttrib4dv_0;

		private readonly Delegate_VertexAttrib4f_0 m_VertexAttrib4f_0;

		private readonly Delegate_VertexAttrib4fv_0 m_VertexAttrib4fv_0;

		private readonly Delegate_VertexAttrib4iv_0 m_VertexAttrib4iv_0;

		private readonly Delegate_VertexAttrib4Nbv_0 m_VertexAttrib4Nbv_0;

		private readonly Delegate_VertexAttrib4Niv_0 m_VertexAttrib4Niv_0;

		private readonly Delegate_VertexAttrib4Nsv_0 m_VertexAttrib4Nsv_0;

		private readonly Delegate_VertexAttrib4Nub_0 m_VertexAttrib4Nub_0;

		private readonly Delegate_VertexAttrib4Nubv_0 m_VertexAttrib4Nubv_0;

		private readonly Delegate_VertexAttrib4Nuiv_0 m_VertexAttrib4Nuiv_0;

		private readonly Delegate_VertexAttrib4Nusv_0 m_VertexAttrib4Nusv_0;

		private readonly Delegate_VertexAttrib4s_0 m_VertexAttrib4s_0;

		private readonly Delegate_VertexAttrib4sv_0 m_VertexAttrib4sv_0;

		private readonly Delegate_VertexAttrib4ubv_0 m_VertexAttrib4ubv_0;

		private readonly Delegate_VertexAttrib4uiv_0 m_VertexAttrib4uiv_0;

		private readonly Delegate_VertexAttrib4usv_0 m_VertexAttrib4usv_0;

		private readonly Delegate_VertexAttribI1i_0 m_VertexAttribI1i_0;

		private readonly Delegate_VertexAttribI1iv_0 m_VertexAttribI1iv_0;

		private readonly Delegate_VertexAttribI1ui_0 m_VertexAttribI1ui_0;

		private readonly Delegate_VertexAttribI1uiv_0 m_VertexAttribI1uiv_0;

		private readonly Delegate_VertexAttribI2i_0 m_VertexAttribI2i_0;

		private readonly Delegate_VertexAttribI2iv_0 m_VertexAttribI2iv_0;

		private readonly Delegate_VertexAttribI2ui_0 m_VertexAttribI2ui_0;

		private readonly Delegate_VertexAttribI2uiv_0 m_VertexAttribI2uiv_0;

		private readonly Delegate_VertexAttribI3i_0 m_VertexAttribI3i_0;

		private readonly Delegate_VertexAttribI3iv_0 m_VertexAttribI3iv_0;

		private readonly Delegate_VertexAttribI3ui_0 m_VertexAttribI3ui_0;

		private readonly Delegate_VertexAttribI3uiv_0 m_VertexAttribI3uiv_0;

		private readonly Delegate_VertexAttribI4bv_0 m_VertexAttribI4bv_0;

		private readonly Delegate_VertexAttribI4i_0 m_VertexAttribI4i_0;

		private readonly Delegate_VertexAttribI4iv_0 m_VertexAttribI4iv_0;

		private readonly Delegate_VertexAttribI4sv_0 m_VertexAttribI4sv_0;

		private readonly Delegate_VertexAttribI4ubv_0 m_VertexAttribI4ubv_0;

		private readonly Delegate_VertexAttribI4ui_0 m_VertexAttribI4ui_0;

		private readonly Delegate_VertexAttribI4uiv_0 m_VertexAttribI4uiv_0;

		private readonly Delegate_VertexAttribI4usv_0 m_VertexAttribI4usv_0;

		private readonly Delegate_VertexAttribIPointer_0 m_VertexAttribIPointer_0;

		private readonly Delegate_VertexAttribPointer_0 m_VertexAttribPointer_0;

		private readonly Delegate_Viewport_0 m_Viewport_0;

		private readonly Delegate_Viewport_1 m_Viewport_1;

		private readonly Delegate_WaitSync_0 m_WaitSync_0;

		private readonly Delegate_BindFragDataLocationIndexed_0 m_BindFragDataLocationIndexed_0;

		private readonly Delegate_GetFragDataIndex_0 m_GetFragDataIndex_0;

		private readonly Delegate_GenSamplers_0 m_GenSamplers_0;

		private readonly Delegate_GenSamplers_1 m_GenSamplers_1;

		private readonly Delegate_GenSamplers_2 m_GenSamplers_2;

		private readonly Delegate_DeleteSamplers_0 m_DeleteSamplers_0;

		private readonly Delegate_DeleteSamplers_1 m_DeleteSamplers_1;

		private readonly Delegate_DeleteSamplers_2 m_DeleteSamplers_2;

		private readonly Delegate_IsSampler_0 m_IsSampler_0;

		private readonly Delegate_BindSampler_0 m_BindSampler_0;

		private readonly Delegate_SamplerParameteri_0 m_SamplerParameteri_0;

		private readonly Delegate_SamplerParameteriv_0 m_SamplerParameteriv_0;

		private readonly Delegate_SamplerParameterf_0 m_SamplerParameterf_0;

		private readonly Delegate_SamplerParameterfv_0 m_SamplerParameterfv_0;

		private readonly Delegate_SamplerParameterIiv_0 m_SamplerParameterIiv_0;

		private readonly Delegate_SamplerParameterIuiv_0 m_SamplerParameterIuiv_0;

		private readonly Delegate_GetSamplerParameteriv_0 m_GetSamplerParameteriv_0;

		private readonly Delegate_GetSamplerParameterIiv_0 m_GetSamplerParameterIiv_0;

		private readonly Delegate_GetSamplerParameterfv_0 m_GetSamplerParameterfv_0;

		private readonly Delegate_GetSamplerParameterIuiv_0 m_GetSamplerParameterIuiv_0;

		private readonly Delegate_QueryCounter_0 m_QueryCounter_0;

		private readonly Delegate_GetQueryObjecti64v_0 m_GetQueryObjecti64v_0;

		private readonly Delegate_GetQueryObjectui64v_0 m_GetQueryObjectui64v_0;

		private readonly Delegate_VertexAttribDivisor_0 m_VertexAttribDivisor_0;

		private readonly Delegate_VertexAttribP1ui_0 m_VertexAttribP1ui_0;

		private readonly Delegate_VertexAttribP1uiv_0 m_VertexAttribP1uiv_0;

		private readonly Delegate_VertexAttribP2ui_0 m_VertexAttribP2ui_0;

		private readonly Delegate_VertexAttribP2uiv_0 m_VertexAttribP2uiv_0;

		private readonly Delegate_VertexAttribP3ui_0 m_VertexAttribP3ui_0;

		private readonly Delegate_VertexAttribP3uiv_0 m_VertexAttribP3uiv_0;

		private readonly Delegate_VertexAttribP4ui_0 m_VertexAttribP4ui_0;

		private readonly Delegate_VertexAttribP4uiv_0 m_VertexAttribP4uiv_0;


		public GL()
		{

			var ActiveTextureAddress = GetFunctionAddress("glActiveTexture");

			var AttachShaderAddress = GetFunctionAddress("glAttachShader");

			var BeginConditionalRenderAddress = GetFunctionAddress("glBeginConditionalRender");

			var BeginQueryAddress = GetFunctionAddress("glBeginQuery");

			var BeginTransformFeedbackAddress = GetFunctionAddress("glBeginTransformFeedback");

			var BindAttribLocationAddress = GetFunctionAddress("glBindAttribLocation");

			var BindBufferAddress = GetFunctionAddress("glBindBuffer");

			var BindBufferBaseAddress = GetFunctionAddress("glBindBufferBase");

			var BindBufferRangeAddress = GetFunctionAddress("glBindBufferRange");

			var BindFragDataLocationAddress = GetFunctionAddress("glBindFragDataLocation");

			var BindFramebufferAddress = GetFunctionAddress("glBindFramebuffer");

			var BindRenderbufferAddress = GetFunctionAddress("glBindRenderbuffer");

			var BindTextureAddress = GetFunctionAddress("glBindTexture");

			var BindVertexArrayAddress = GetFunctionAddress("glBindVertexArray");

			var BlendColorAddress = GetFunctionAddress("glBlendColor");

			var BlendEquationAddress = GetFunctionAddress("glBlendEquation");

			var BlendEquationSeparateAddress = GetFunctionAddress("glBlendEquationSeparate");

			var BlendFuncAddress = GetFunctionAddress("glBlendFunc");

			var BlendFuncSeparateAddress = GetFunctionAddress("glBlendFuncSeparate");

			var BlitFramebufferAddress = GetFunctionAddress("glBlitFramebuffer");

			var BufferDataAddress = GetFunctionAddress("glBufferData");

			var BufferSubDataAddress = GetFunctionAddress("glBufferSubData");

			var CheckFramebufferStatusAddress = GetFunctionAddress("glCheckFramebufferStatus");

			var ClampColorAddress = GetFunctionAddress("glClampColor");

			var ClearAddress = GetFunctionAddress("glClear");

			var ClearBufferfiAddress = GetFunctionAddress("glClearBufferfi");

			var ClearBufferfvAddress = GetFunctionAddress("glClearBufferfv");

			var ClearBufferivAddress = GetFunctionAddress("glClearBufferiv");

			var ClearBufferuivAddress = GetFunctionAddress("glClearBufferuiv");

			var ClearColorAddress = GetFunctionAddress("glClearColor");

			var ClearDepthAddress = GetFunctionAddress("glClearDepth");

			var ClearStencilAddress = GetFunctionAddress("glClearStencil");

			var ClientWaitSyncAddress = GetFunctionAddress("glClientWaitSync");

			var ColorMaskAddress = GetFunctionAddress("glColorMask");

			var ColorMaskiAddress = GetFunctionAddress("glColorMaski");

			var CompileShaderAddress = GetFunctionAddress("glCompileShader");

			var CompressedTexImage1DAddress = GetFunctionAddress("glCompressedTexImage1D");

			var CompressedTexImage2DAddress = GetFunctionAddress("glCompressedTexImage2D");

			var CompressedTexImage3DAddress = GetFunctionAddress("glCompressedTexImage3D");

			var CompressedTexSubImage1DAddress = GetFunctionAddress("glCompressedTexSubImage1D");

			var CompressedTexSubImage2DAddress = GetFunctionAddress("glCompressedTexSubImage2D");

			var CompressedTexSubImage3DAddress = GetFunctionAddress("glCompressedTexSubImage3D");

			var CopyBufferSubDataAddress = GetFunctionAddress("glCopyBufferSubData");

			var CopyTexImage1DAddress = GetFunctionAddress("glCopyTexImage1D");

			var CopyTexImage2DAddress = GetFunctionAddress("glCopyTexImage2D");

			var CopyTexSubImage1DAddress = GetFunctionAddress("glCopyTexSubImage1D");

			var CopyTexSubImage2DAddress = GetFunctionAddress("glCopyTexSubImage2D");

			var CopyTexSubImage3DAddress = GetFunctionAddress("glCopyTexSubImage3D");

			var CreateProgramAddress = GetFunctionAddress("glCreateProgram");

			var CreateShaderAddress = GetFunctionAddress("glCreateShader");

			var CullFaceAddress = GetFunctionAddress("glCullFace");

			var DeleteBuffersAddress = GetFunctionAddress("glDeleteBuffers");

			var DeleteFramebuffersAddress = GetFunctionAddress("glDeleteFramebuffers");

			var DeleteProgramAddress = GetFunctionAddress("glDeleteProgram");

			var DeleteQueriesAddress = GetFunctionAddress("glDeleteQueries");

			var DeleteRenderbuffersAddress = GetFunctionAddress("glDeleteRenderbuffers");

			var DeleteShaderAddress = GetFunctionAddress("glDeleteShader");

			var DeleteSyncAddress = GetFunctionAddress("glDeleteSync");

			var DeleteTexturesAddress = GetFunctionAddress("glDeleteTextures");

			var DeleteVertexArraysAddress = GetFunctionAddress("glDeleteVertexArrays");

			var DepthFuncAddress = GetFunctionAddress("glDepthFunc");

			var DepthMaskAddress = GetFunctionAddress("glDepthMask");

			var DepthRangeAddress = GetFunctionAddress("glDepthRange");

			var DetachShaderAddress = GetFunctionAddress("glDetachShader");

			var DisableAddress = GetFunctionAddress("glDisable");

			var DisableiAddress = GetFunctionAddress("glDisablei");

			var DisableVertexAttribArrayAddress = GetFunctionAddress("glDisableVertexAttribArray");

			var DrawArraysAddress = GetFunctionAddress("glDrawArrays");

			var DrawArraysInstancedAddress = GetFunctionAddress("glDrawArraysInstanced");

			var DrawBufferAddress = GetFunctionAddress("glDrawBuffer");

			var DrawBuffersAddress = GetFunctionAddress("glDrawBuffers");

			var DrawElementsAddress = GetFunctionAddress("glDrawElements");

			var DrawElementsBaseVertexAddress = GetFunctionAddress("glDrawElementsBaseVertex");

			var DrawElementsInstancedAddress = GetFunctionAddress("glDrawElementsInstanced");

			var DrawElementsInstancedBaseVertexAddress = GetFunctionAddress("glDrawElementsInstancedBaseVertex");

			var DrawRangeElementsAddress = GetFunctionAddress("glDrawRangeElements");

			var DrawRangeElementsBaseVertexAddress = GetFunctionAddress("glDrawRangeElementsBaseVertex");

			var EnableAddress = GetFunctionAddress("glEnable");

			var EnableiAddress = GetFunctionAddress("glEnablei");

			var EnableVertexAttribArrayAddress = GetFunctionAddress("glEnableVertexAttribArray");

			var EndConditionalRenderAddress = GetFunctionAddress("glEndConditionalRender");

			var EndQueryAddress = GetFunctionAddress("glEndQuery");

			var EndTransformFeedbackAddress = GetFunctionAddress("glEndTransformFeedback");

			var FenceSyncAddress = GetFunctionAddress("glFenceSync");

			var FinishAddress = GetFunctionAddress("glFinish");

			var FlushAddress = GetFunctionAddress("glFlush");

			var FlushMappedBufferRangeAddress = GetFunctionAddress("glFlushMappedBufferRange");

			var FramebufferRenderbufferAddress = GetFunctionAddress("glFramebufferRenderbuffer");

			var FramebufferTextureAddress = GetFunctionAddress("glFramebufferTexture");

			var FramebufferTexture1DAddress = GetFunctionAddress("glFramebufferTexture1D");

			var FramebufferTexture2DAddress = GetFunctionAddress("glFramebufferTexture2D");

			var FramebufferTexture3DAddress = GetFunctionAddress("glFramebufferTexture3D");

			var FramebufferTextureLayerAddress = GetFunctionAddress("glFramebufferTextureLayer");

			var FrontFaceAddress = GetFunctionAddress("glFrontFace");

			var GenBuffersAddress = GetFunctionAddress("glGenBuffers");

			var GenerateMipmapAddress = GetFunctionAddress("glGenerateMipmap");

			var GenFramebuffersAddress = GetFunctionAddress("glGenFramebuffers");

			var GenQueriesAddress = GetFunctionAddress("glGenQueries");

			var GenRenderbuffersAddress = GetFunctionAddress("glGenRenderbuffers");

			var GenTexturesAddress = GetFunctionAddress("glGenTextures");

			var GenVertexArraysAddress = GetFunctionAddress("glGenVertexArrays");

			var GetActiveAttribAddress = GetFunctionAddress("glGetActiveAttrib");

			var GetActiveUniformAddress = GetFunctionAddress("glGetActiveUniform");

			var GetActiveUniformBlockivAddress = GetFunctionAddress("glGetActiveUniformBlockiv");

			var GetActiveUniformBlockNameAddress = GetFunctionAddress("glGetActiveUniformBlockName");

			var GetActiveUniformNameAddress = GetFunctionAddress("glGetActiveUniformName");

			var GetActiveUniformsivAddress = GetFunctionAddress("glGetActiveUniformsiv");

			var GetAttachedShadersAddress = GetFunctionAddress("glGetAttachedShaders");

			var GetAttribLocationAddress = GetFunctionAddress("glGetAttribLocation");

			var GetBooleani_vAddress = GetFunctionAddress("glGetBooleani_v");

			var GetBooleanvAddress = GetFunctionAddress("glGetBooleanv");

			var GetBufferParameteri64vAddress = GetFunctionAddress("glGetBufferParameteri64v");

			var GetBufferParameterivAddress = GetFunctionAddress("glGetBufferParameteriv");

			var GetBufferPointervAddress = GetFunctionAddress("glGetBufferPointerv");

			var GetBufferSubDataAddress = GetFunctionAddress("glGetBufferSubData");

			var GetCompressedTexImageAddress = GetFunctionAddress("glGetCompressedTexImage");

			var GetDoublevAddress = GetFunctionAddress("glGetDoublev");

			var GetErrorAddress = GetFunctionAddress("glGetError");

			var GetFloatvAddress = GetFunctionAddress("glGetFloatv");

			var GetFragDataLocationAddress = GetFunctionAddress("glGetFragDataLocation");

			var GetFramebufferAttachmentParameterivAddress = GetFunctionAddress("glGetFramebufferAttachmentParameteriv");

			var GetInteger64i_vAddress = GetFunctionAddress("glGetInteger64i_v");

			var GetInteger64vAddress = GetFunctionAddress("glGetInteger64v");

			var GetIntegeri_vAddress = GetFunctionAddress("glGetIntegeri_v");

			var GetIntegervAddress = GetFunctionAddress("glGetIntegerv");

			var GetMultisamplefvAddress = GetFunctionAddress("glGetMultisamplefv");

			var GetProgramInfoLogAddress = GetFunctionAddress("glGetProgramInfoLog");

			var GetProgramivAddress = GetFunctionAddress("glGetProgramiv");

			var GetQueryivAddress = GetFunctionAddress("glGetQueryiv");

			var GetQueryObjectivAddress = GetFunctionAddress("glGetQueryObjectiv");

			var GetQueryObjectuivAddress = GetFunctionAddress("glGetQueryObjectuiv");

			var GetRenderbufferParameterivAddress = GetFunctionAddress("glGetRenderbufferParameteriv");

			var GetShaderInfoLogAddress = GetFunctionAddress("glGetShaderInfoLog");

			var GetShaderivAddress = GetFunctionAddress("glGetShaderiv");

			var GetShaderSourceAddress = GetFunctionAddress("glGetShaderSource");

			var GetStringAddress = GetFunctionAddress("glGetString");

			var GetStringiAddress = GetFunctionAddress("glGetStringi");

			var GetSyncivAddress = GetFunctionAddress("glGetSynciv");

			var GetTexImageAddress = GetFunctionAddress("glGetTexImage");

			var GetTexLevelParameterfvAddress = GetFunctionAddress("glGetTexLevelParameterfv");

			var GetTexLevelParameterivAddress = GetFunctionAddress("glGetTexLevelParameteriv");

			var GetTexParameterfvAddress = GetFunctionAddress("glGetTexParameterfv");

			var GetTexParameterIivAddress = GetFunctionAddress("glGetTexParameterIiv");

			var GetTexParameterIuivAddress = GetFunctionAddress("glGetTexParameterIuiv");

			var GetTexParameterivAddress = GetFunctionAddress("glGetTexParameteriv");

			var GetTransformFeedbackVaryingAddress = GetFunctionAddress("glGetTransformFeedbackVarying");

			var GetUniformBlockIndexAddress = GetFunctionAddress("glGetUniformBlockIndex");

			var GetUniformfvAddress = GetFunctionAddress("glGetUniformfv");

			var GetUniformIndicesAddress = GetFunctionAddress("glGetUniformIndices");

			var GetUniformivAddress = GetFunctionAddress("glGetUniformiv");

			var GetUniformLocationAddress = GetFunctionAddress("glGetUniformLocation");

			var GetUniformuivAddress = GetFunctionAddress("glGetUniformuiv");

			var GetVertexAttribdvAddress = GetFunctionAddress("glGetVertexAttribdv");

			var GetVertexAttribfvAddress = GetFunctionAddress("glGetVertexAttribfv");

			var GetVertexAttribIivAddress = GetFunctionAddress("glGetVertexAttribIiv");

			var GetVertexAttribIuivAddress = GetFunctionAddress("glGetVertexAttribIuiv");

			var GetVertexAttribivAddress = GetFunctionAddress("glGetVertexAttribiv");

			var GetVertexAttribPointervAddress = GetFunctionAddress("glGetVertexAttribPointerv");

			var HintAddress = GetFunctionAddress("glHint");

			var IsBufferAddress = GetFunctionAddress("glIsBuffer");

			var IsEnabledAddress = GetFunctionAddress("glIsEnabled");

			var IsEnablediAddress = GetFunctionAddress("glIsEnabledi");

			var IsFramebufferAddress = GetFunctionAddress("glIsFramebuffer");

			var IsProgramAddress = GetFunctionAddress("glIsProgram");

			var IsQueryAddress = GetFunctionAddress("glIsQuery");

			var IsRenderbufferAddress = GetFunctionAddress("glIsRenderbuffer");

			var IsShaderAddress = GetFunctionAddress("glIsShader");

			var IsSyncAddress = GetFunctionAddress("glIsSync");

			var IsTextureAddress = GetFunctionAddress("glIsTexture");

			var IsVertexArrayAddress = GetFunctionAddress("glIsVertexArray");

			var LineWidthAddress = GetFunctionAddress("glLineWidth");

			var LinkProgramAddress = GetFunctionAddress("glLinkProgram");

			var LogicOpAddress = GetFunctionAddress("glLogicOp");

			var MapBufferAddress = GetFunctionAddress("glMapBuffer");

			var MapBufferRangeAddress = GetFunctionAddress("glMapBufferRange");

			var MultiDrawArraysAddress = GetFunctionAddress("glMultiDrawArrays");

			var MultiDrawElementsAddress = GetFunctionAddress("glMultiDrawElements");

			var MultiDrawElementsBaseVertexAddress = GetFunctionAddress("glMultiDrawElementsBaseVertex");

			var PixelStorefAddress = GetFunctionAddress("glPixelStoref");

			var PixelStoreiAddress = GetFunctionAddress("glPixelStorei");

			var PointParameterfAddress = GetFunctionAddress("glPointParameterf");

			var PointParameterfvAddress = GetFunctionAddress("glPointParameterfv");

			var PointParameteriAddress = GetFunctionAddress("glPointParameteri");

			var PointParameterivAddress = GetFunctionAddress("glPointParameteriv");

			var PointSizeAddress = GetFunctionAddress("glPointSize");

			var PolygonModeAddress = GetFunctionAddress("glPolygonMode");

			var PolygonOffsetAddress = GetFunctionAddress("glPolygonOffset");

			var PrimitiveRestartIndexAddress = GetFunctionAddress("glPrimitiveRestartIndex");

			var ProvokingVertexAddress = GetFunctionAddress("glProvokingVertex");

			var ReadBufferAddress = GetFunctionAddress("glReadBuffer");

			var ReadPixelsAddress = GetFunctionAddress("glReadPixels");

			var RenderbufferStorageAddress = GetFunctionAddress("glRenderbufferStorage");

			var RenderbufferStorageMultisampleAddress = GetFunctionAddress("glRenderbufferStorageMultisample");

			var SampleCoverageAddress = GetFunctionAddress("glSampleCoverage");

			var SampleMaskiAddress = GetFunctionAddress("glSampleMaski");

			var ScissorAddress = GetFunctionAddress("glScissor");

			var ShaderSourceAddress = GetFunctionAddress("glShaderSource");

			var StencilFuncAddress = GetFunctionAddress("glStencilFunc");

			var StencilFuncSeparateAddress = GetFunctionAddress("glStencilFuncSeparate");

			var StencilMaskAddress = GetFunctionAddress("glStencilMask");

			var StencilMaskSeparateAddress = GetFunctionAddress("glStencilMaskSeparate");

			var StencilOpAddress = GetFunctionAddress("glStencilOp");

			var StencilOpSeparateAddress = GetFunctionAddress("glStencilOpSeparate");

			var TexBufferAddress = GetFunctionAddress("glTexBuffer");

			var TexImage1DAddress = GetFunctionAddress("glTexImage1D");

			var TexImage2DAddress = GetFunctionAddress("glTexImage2D");

			var TexImage2DMultisampleAddress = GetFunctionAddress("glTexImage2DMultisample");

			var TexImage3DAddress = GetFunctionAddress("glTexImage3D");

			var TexImage3DMultisampleAddress = GetFunctionAddress("glTexImage3DMultisample");

			var TexParameterfAddress = GetFunctionAddress("glTexParameterf");

			var TexParameterfvAddress = GetFunctionAddress("glTexParameterfv");

			var TexParameteriAddress = GetFunctionAddress("glTexParameteri");

			var TexParameterIivAddress = GetFunctionAddress("glTexParameterIiv");

			var TexParameterIuivAddress = GetFunctionAddress("glTexParameterIuiv");

			var TexParameterivAddress = GetFunctionAddress("glTexParameteriv");

			var TexSubImage1DAddress = GetFunctionAddress("glTexSubImage1D");

			var TexSubImage2DAddress = GetFunctionAddress("glTexSubImage2D");

			var TexSubImage3DAddress = GetFunctionAddress("glTexSubImage3D");

			var TransformFeedbackVaryingsAddress = GetFunctionAddress("glTransformFeedbackVaryings");

			var Uniform1fAddress = GetFunctionAddress("glUniform1f");

			var Uniform1fvAddress = GetFunctionAddress("glUniform1fv");

			var Uniform1iAddress = GetFunctionAddress("glUniform1i");

			var Uniform1ivAddress = GetFunctionAddress("glUniform1iv");

			var Uniform1uiAddress = GetFunctionAddress("glUniform1ui");

			var Uniform1uivAddress = GetFunctionAddress("glUniform1uiv");

			var Uniform2fAddress = GetFunctionAddress("glUniform2f");

			var Uniform2fvAddress = GetFunctionAddress("glUniform2fv");

			var Uniform2iAddress = GetFunctionAddress("glUniform2i");

			var Uniform2ivAddress = GetFunctionAddress("glUniform2iv");

			var Uniform2uiAddress = GetFunctionAddress("glUniform2ui");

			var Uniform2uivAddress = GetFunctionAddress("glUniform2uiv");

			var Uniform3fAddress = GetFunctionAddress("glUniform3f");

			var Uniform3fvAddress = GetFunctionAddress("glUniform3fv");

			var Uniform3iAddress = GetFunctionAddress("glUniform3i");

			var Uniform3ivAddress = GetFunctionAddress("glUniform3iv");

			var Uniform3uiAddress = GetFunctionAddress("glUniform3ui");

			var Uniform3uivAddress = GetFunctionAddress("glUniform3uiv");

			var Uniform4fAddress = GetFunctionAddress("glUniform4f");

			var Uniform4fvAddress = GetFunctionAddress("glUniform4fv");

			var Uniform4iAddress = GetFunctionAddress("glUniform4i");

			var Uniform4ivAddress = GetFunctionAddress("glUniform4iv");

			var Uniform4uiAddress = GetFunctionAddress("glUniform4ui");

			var Uniform4uivAddress = GetFunctionAddress("glUniform4uiv");

			var UniformBlockBindingAddress = GetFunctionAddress("glUniformBlockBinding");

			var UniformMatrix2fvAddress = GetFunctionAddress("glUniformMatrix2fv");

			var UniformMatrix2x3fvAddress = GetFunctionAddress("glUniformMatrix2x3fv");

			var UniformMatrix2x4fvAddress = GetFunctionAddress("glUniformMatrix2x4fv");

			var UniformMatrix3fvAddress = GetFunctionAddress("glUniformMatrix3fv");

			var UniformMatrix3x2fvAddress = GetFunctionAddress("glUniformMatrix3x2fv");

			var UniformMatrix3x4fvAddress = GetFunctionAddress("glUniformMatrix3x4fv");

			var UniformMatrix4fvAddress = GetFunctionAddress("glUniformMatrix4fv");

			var UniformMatrix4x2fvAddress = GetFunctionAddress("glUniformMatrix4x2fv");

			var UniformMatrix4x3fvAddress = GetFunctionAddress("glUniformMatrix4x3fv");

			var UnmapBufferAddress = GetFunctionAddress("glUnmapBuffer");

			var UseProgramAddress = GetFunctionAddress("glUseProgram");

			var ValidateProgramAddress = GetFunctionAddress("glValidateProgram");

			var VertexAttrib1dAddress = GetFunctionAddress("glVertexAttrib1d");

			var VertexAttrib1dvAddress = GetFunctionAddress("glVertexAttrib1dv");

			var VertexAttrib1fAddress = GetFunctionAddress("glVertexAttrib1f");

			var VertexAttrib1fvAddress = GetFunctionAddress("glVertexAttrib1fv");

			var VertexAttrib1sAddress = GetFunctionAddress("glVertexAttrib1s");

			var VertexAttrib1svAddress = GetFunctionAddress("glVertexAttrib1sv");

			var VertexAttrib2dAddress = GetFunctionAddress("glVertexAttrib2d");

			var VertexAttrib2dvAddress = GetFunctionAddress("glVertexAttrib2dv");

			var VertexAttrib2fAddress = GetFunctionAddress("glVertexAttrib2f");

			var VertexAttrib2fvAddress = GetFunctionAddress("glVertexAttrib2fv");

			var VertexAttrib2sAddress = GetFunctionAddress("glVertexAttrib2s");

			var VertexAttrib2svAddress = GetFunctionAddress("glVertexAttrib2sv");

			var VertexAttrib3dAddress = GetFunctionAddress("glVertexAttrib3d");

			var VertexAttrib3dvAddress = GetFunctionAddress("glVertexAttrib3dv");

			var VertexAttrib3fAddress = GetFunctionAddress("glVertexAttrib3f");

			var VertexAttrib3fvAddress = GetFunctionAddress("glVertexAttrib3fv");

			var VertexAttrib3sAddress = GetFunctionAddress("glVertexAttrib3s");

			var VertexAttrib3svAddress = GetFunctionAddress("glVertexAttrib3sv");

			var VertexAttrib4bvAddress = GetFunctionAddress("glVertexAttrib4bv");

			var VertexAttrib4dAddress = GetFunctionAddress("glVertexAttrib4d");

			var VertexAttrib4dvAddress = GetFunctionAddress("glVertexAttrib4dv");

			var VertexAttrib4fAddress = GetFunctionAddress("glVertexAttrib4f");

			var VertexAttrib4fvAddress = GetFunctionAddress("glVertexAttrib4fv");

			var VertexAttrib4ivAddress = GetFunctionAddress("glVertexAttrib4iv");

			var VertexAttrib4NbvAddress = GetFunctionAddress("glVertexAttrib4Nbv");

			var VertexAttrib4NivAddress = GetFunctionAddress("glVertexAttrib4Niv");

			var VertexAttrib4NsvAddress = GetFunctionAddress("glVertexAttrib4Nsv");

			var VertexAttrib4NubAddress = GetFunctionAddress("glVertexAttrib4Nub");

			var VertexAttrib4NubvAddress = GetFunctionAddress("glVertexAttrib4Nubv");

			var VertexAttrib4NuivAddress = GetFunctionAddress("glVertexAttrib4Nuiv");

			var VertexAttrib4NusvAddress = GetFunctionAddress("glVertexAttrib4Nusv");

			var VertexAttrib4sAddress = GetFunctionAddress("glVertexAttrib4s");

			var VertexAttrib4svAddress = GetFunctionAddress("glVertexAttrib4sv");

			var VertexAttrib4ubvAddress = GetFunctionAddress("glVertexAttrib4ubv");

			var VertexAttrib4uivAddress = GetFunctionAddress("glVertexAttrib4uiv");

			var VertexAttrib4usvAddress = GetFunctionAddress("glVertexAttrib4usv");

			var VertexAttribI1iAddress = GetFunctionAddress("glVertexAttribI1i");

			var VertexAttribI1ivAddress = GetFunctionAddress("glVertexAttribI1iv");

			var VertexAttribI1uiAddress = GetFunctionAddress("glVertexAttribI1ui");

			var VertexAttribI1uivAddress = GetFunctionAddress("glVertexAttribI1uiv");

			var VertexAttribI2iAddress = GetFunctionAddress("glVertexAttribI2i");

			var VertexAttribI2ivAddress = GetFunctionAddress("glVertexAttribI2iv");

			var VertexAttribI2uiAddress = GetFunctionAddress("glVertexAttribI2ui");

			var VertexAttribI2uivAddress = GetFunctionAddress("glVertexAttribI2uiv");

			var VertexAttribI3iAddress = GetFunctionAddress("glVertexAttribI3i");

			var VertexAttribI3ivAddress = GetFunctionAddress("glVertexAttribI3iv");

			var VertexAttribI3uiAddress = GetFunctionAddress("glVertexAttribI3ui");

			var VertexAttribI3uivAddress = GetFunctionAddress("glVertexAttribI3uiv");

			var VertexAttribI4bvAddress = GetFunctionAddress("glVertexAttribI4bv");

			var VertexAttribI4iAddress = GetFunctionAddress("glVertexAttribI4i");

			var VertexAttribI4ivAddress = GetFunctionAddress("glVertexAttribI4iv");

			var VertexAttribI4svAddress = GetFunctionAddress("glVertexAttribI4sv");

			var VertexAttribI4ubvAddress = GetFunctionAddress("glVertexAttribI4ubv");

			var VertexAttribI4uiAddress = GetFunctionAddress("glVertexAttribI4ui");

			var VertexAttribI4uivAddress = GetFunctionAddress("glVertexAttribI4uiv");

			var VertexAttribI4usvAddress = GetFunctionAddress("glVertexAttribI4usv");

			var VertexAttribIPointerAddress = GetFunctionAddress("glVertexAttribIPointer");

			var VertexAttribPointerAddress = GetFunctionAddress("glVertexAttribPointer");

			var ViewportAddress = GetFunctionAddress("glViewport");

			var WaitSyncAddress = GetFunctionAddress("glWaitSync");

			var BindFragDataLocationIndexedAddress = GetFunctionAddress("glBindFragDataLocationIndexed");

			var GetFragDataIndexAddress = GetFunctionAddress("glGetFragDataIndex");

			var GenSamplersAddress = GetFunctionAddress("glGenSamplers");

			var DeleteSamplersAddress = GetFunctionAddress("glDeleteSamplers");

			var IsSamplerAddress = GetFunctionAddress("glIsSampler");

			var BindSamplerAddress = GetFunctionAddress("glBindSampler");

			var SamplerParameteriAddress = GetFunctionAddress("glSamplerParameteri");

			var SamplerParameterivAddress = GetFunctionAddress("glSamplerParameteriv");

			var SamplerParameterfAddress = GetFunctionAddress("glSamplerParameterf");

			var SamplerParameterfvAddress = GetFunctionAddress("glSamplerParameterfv");

			var SamplerParameterIivAddress = GetFunctionAddress("glSamplerParameterIiv");

			var SamplerParameterIuivAddress = GetFunctionAddress("glSamplerParameterIuiv");

			var GetSamplerParameterivAddress = GetFunctionAddress("glGetSamplerParameteriv");

			var GetSamplerParameterIivAddress = GetFunctionAddress("glGetSamplerParameterIiv");

			var GetSamplerParameterfvAddress = GetFunctionAddress("glGetSamplerParameterfv");

			var GetSamplerParameterIuivAddress = GetFunctionAddress("glGetSamplerParameterIuiv");

			var QueryCounterAddress = GetFunctionAddress("glQueryCounter");

			var GetQueryObjecti64vAddress = GetFunctionAddress("glGetQueryObjecti64v");

			var GetQueryObjectui64vAddress = GetFunctionAddress("glGetQueryObjectui64v");

			var VertexAttribDivisorAddress = GetFunctionAddress("glVertexAttribDivisor");

			var VertexAttribP1uiAddress = GetFunctionAddress("glVertexAttribP1ui");

			var VertexAttribP1uivAddress = GetFunctionAddress("glVertexAttribP1uiv");

			var VertexAttribP2uiAddress = GetFunctionAddress("glVertexAttribP2ui");

			var VertexAttribP2uivAddress = GetFunctionAddress("glVertexAttribP2uiv");

			var VertexAttribP3uiAddress = GetFunctionAddress("glVertexAttribP3ui");

			var VertexAttribP3uivAddress = GetFunctionAddress("glVertexAttribP3uiv");

			var VertexAttribP4uiAddress = GetFunctionAddress("glVertexAttribP4ui");

			var VertexAttribP4uivAddress = GetFunctionAddress("glVertexAttribP4uiv");


			m_ActiveTexture_0 = (Delegate_ActiveTexture_0)GetDelegateForAddress(ActiveTextureAddress, typeof(Delegate_ActiveTexture_0));

			m_AttachShader_0 = (Delegate_AttachShader_0)GetDelegateForAddress(AttachShaderAddress, typeof(Delegate_AttachShader_0));

			m_BeginConditionalRender_0 = (Delegate_BeginConditionalRender_0)GetDelegateForAddress(BeginConditionalRenderAddress, typeof(Delegate_BeginConditionalRender_0));

			m_BeginQuery_0 = (Delegate_BeginQuery_0)GetDelegateForAddress(BeginQueryAddress, typeof(Delegate_BeginQuery_0));

			m_BeginTransformFeedback_0 = (Delegate_BeginTransformFeedback_0)GetDelegateForAddress(BeginTransformFeedbackAddress, typeof(Delegate_BeginTransformFeedback_0));

			m_BindAttribLocation_0 = (Delegate_BindAttribLocation_0)GetDelegateForAddress(BindAttribLocationAddress, typeof(Delegate_BindAttribLocation_0));

			m_BindBuffer_0 = (Delegate_BindBuffer_0)GetDelegateForAddress(BindBufferAddress, typeof(Delegate_BindBuffer_0));

			m_BindBufferBase_0 = (Delegate_BindBufferBase_0)GetDelegateForAddress(BindBufferBaseAddress, typeof(Delegate_BindBufferBase_0));

			m_BindBufferRange_0 = (Delegate_BindBufferRange_0)GetDelegateForAddress(BindBufferRangeAddress, typeof(Delegate_BindBufferRange_0));

			m_BindFragDataLocation_0 = (Delegate_BindFragDataLocation_0)GetDelegateForAddress(BindFragDataLocationAddress, typeof(Delegate_BindFragDataLocation_0));

			m_BindFramebuffer_0 = (Delegate_BindFramebuffer_0)GetDelegateForAddress(BindFramebufferAddress, typeof(Delegate_BindFramebuffer_0));

			m_BindRenderbuffer_0 = (Delegate_BindRenderbuffer_0)GetDelegateForAddress(BindRenderbufferAddress, typeof(Delegate_BindRenderbuffer_0));

			m_BindTexture_0 = (Delegate_BindTexture_0)GetDelegateForAddress(BindTextureAddress, typeof(Delegate_BindTexture_0));

			m_BindVertexArray_0 = (Delegate_BindVertexArray_0)GetDelegateForAddress(BindVertexArrayAddress, typeof(Delegate_BindVertexArray_0));

			m_BlendColor_0 = (Delegate_BlendColor_0)GetDelegateForAddress(BlendColorAddress, typeof(Delegate_BlendColor_0));

			m_BlendColor_1 = (Delegate_BlendColor_1)GetDelegateForAddress(BlendColorAddress, typeof(Delegate_BlendColor_1));

			m_BlendEquation_0 = (Delegate_BlendEquation_0)GetDelegateForAddress(BlendEquationAddress, typeof(Delegate_BlendEquation_0));

			m_BlendEquationSeparate_0 = (Delegate_BlendEquationSeparate_0)GetDelegateForAddress(BlendEquationSeparateAddress, typeof(Delegate_BlendEquationSeparate_0));

			m_BlendFunc_0 = (Delegate_BlendFunc_0)GetDelegateForAddress(BlendFuncAddress, typeof(Delegate_BlendFunc_0));

			m_BlendFuncSeparate_0 = (Delegate_BlendFuncSeparate_0)GetDelegateForAddress(BlendFuncSeparateAddress, typeof(Delegate_BlendFuncSeparate_0));

			m_BlitFramebuffer_0 = (Delegate_BlitFramebuffer_0)GetDelegateForAddress(BlitFramebufferAddress, typeof(Delegate_BlitFramebuffer_0));

			m_BlitFramebuffer_1 = (Delegate_BlitFramebuffer_1)GetDelegateForAddress(BlitFramebufferAddress, typeof(Delegate_BlitFramebuffer_1));

			m_BufferData_0 = (Delegate_BufferData_0)GetDelegateForAddress(BufferDataAddress, typeof(Delegate_BufferData_0));

			m_BufferSubData_0 = (Delegate_BufferSubData_0)GetDelegateForAddress(BufferSubDataAddress, typeof(Delegate_BufferSubData_0));

			m_CheckFramebufferStatus_0 = (Delegate_CheckFramebufferStatus_0)GetDelegateForAddress(CheckFramebufferStatusAddress, typeof(Delegate_CheckFramebufferStatus_0));

			m_ClampColor_0 = (Delegate_ClampColor_0)GetDelegateForAddress(ClampColorAddress, typeof(Delegate_ClampColor_0));

			m_Clear_0 = (Delegate_Clear_0)GetDelegateForAddress(ClearAddress, typeof(Delegate_Clear_0));

			m_ClearBufferfi_0 = (Delegate_ClearBufferfi_0)GetDelegateForAddress(ClearBufferfiAddress, typeof(Delegate_ClearBufferfi_0));

			m_ClearBufferfv_0 = (Delegate_ClearBufferfv_0)GetDelegateForAddress(ClearBufferfvAddress, typeof(Delegate_ClearBufferfv_0));

			m_ClearBufferfv_1 = (Delegate_ClearBufferfv_1)GetDelegateForAddress(ClearBufferfvAddress, typeof(Delegate_ClearBufferfv_1));

			m_ClearBufferfv_2 = (Delegate_ClearBufferfv_2)GetDelegateForAddress(ClearBufferfvAddress, typeof(Delegate_ClearBufferfv_2));

			m_ClearBufferiv_0 = (Delegate_ClearBufferiv_0)GetDelegateForAddress(ClearBufferivAddress, typeof(Delegate_ClearBufferiv_0));

			m_ClearBufferiv_1 = (Delegate_ClearBufferiv_1)GetDelegateForAddress(ClearBufferivAddress, typeof(Delegate_ClearBufferiv_1));

			m_ClearBufferiv_2 = (Delegate_ClearBufferiv_2)GetDelegateForAddress(ClearBufferivAddress, typeof(Delegate_ClearBufferiv_2));

			m_ClearBufferuiv_0 = (Delegate_ClearBufferuiv_0)GetDelegateForAddress(ClearBufferuivAddress, typeof(Delegate_ClearBufferuiv_0));

			m_ClearBufferuiv_1 = (Delegate_ClearBufferuiv_1)GetDelegateForAddress(ClearBufferuivAddress, typeof(Delegate_ClearBufferuiv_1));

			m_ClearBufferuiv_2 = (Delegate_ClearBufferuiv_2)GetDelegateForAddress(ClearBufferuivAddress, typeof(Delegate_ClearBufferuiv_2));

			m_ClearColor_0 = (Delegate_ClearColor_0)GetDelegateForAddress(ClearColorAddress, typeof(Delegate_ClearColor_0));

			m_ClearColor_1 = (Delegate_ClearColor_1)GetDelegateForAddress(ClearColorAddress, typeof(Delegate_ClearColor_1));

			m_ClearDepth_0 = (Delegate_ClearDepth_0)GetDelegateForAddress(ClearDepthAddress, typeof(Delegate_ClearDepth_0));

			m_ClearStencil_0 = (Delegate_ClearStencil_0)GetDelegateForAddress(ClearStencilAddress, typeof(Delegate_ClearStencil_0));

			m_ClientWaitSync_0 = (Delegate_ClientWaitSync_0)GetDelegateForAddress(ClientWaitSyncAddress, typeof(Delegate_ClientWaitSync_0));

			m_ColorMask_0 = (Delegate_ColorMask_0)GetDelegateForAddress(ColorMaskAddress, typeof(Delegate_ColorMask_0));

			m_ColorMaski_0 = (Delegate_ColorMaski_0)GetDelegateForAddress(ColorMaskiAddress, typeof(Delegate_ColorMaski_0));

			m_CompileShader_0 = (Delegate_CompileShader_0)GetDelegateForAddress(CompileShaderAddress, typeof(Delegate_CompileShader_0));

			m_CompressedTexImage1D_0 = (Delegate_CompressedTexImage1D_0)GetDelegateForAddress(CompressedTexImage1DAddress, typeof(Delegate_CompressedTexImage1D_0));

			m_CompressedTexImage2D_0 = (Delegate_CompressedTexImage2D_0)GetDelegateForAddress(CompressedTexImage2DAddress, typeof(Delegate_CompressedTexImage2D_0));

			m_CompressedTexImage3D_0 = (Delegate_CompressedTexImage3D_0)GetDelegateForAddress(CompressedTexImage3DAddress, typeof(Delegate_CompressedTexImage3D_0));

			m_CompressedTexSubImage1D_0 = (Delegate_CompressedTexSubImage1D_0)GetDelegateForAddress(CompressedTexSubImage1DAddress, typeof(Delegate_CompressedTexSubImage1D_0));

			m_CompressedTexSubImage2D_0 = (Delegate_CompressedTexSubImage2D_0)GetDelegateForAddress(CompressedTexSubImage2DAddress, typeof(Delegate_CompressedTexSubImage2D_0));

			m_CompressedTexSubImage2D_1 = (Delegate_CompressedTexSubImage2D_1)GetDelegateForAddress(CompressedTexSubImage2DAddress, typeof(Delegate_CompressedTexSubImage2D_1));

			m_CompressedTexSubImage3D_0 = (Delegate_CompressedTexSubImage3D_0)GetDelegateForAddress(CompressedTexSubImage3DAddress, typeof(Delegate_CompressedTexSubImage3D_0));

			m_CompressedTexSubImage3D_1 = (Delegate_CompressedTexSubImage3D_1)GetDelegateForAddress(CompressedTexSubImage3DAddress, typeof(Delegate_CompressedTexSubImage3D_1));

			m_CopyBufferSubData_0 = (Delegate_CopyBufferSubData_0)GetDelegateForAddress(CopyBufferSubDataAddress, typeof(Delegate_CopyBufferSubData_0));

			m_CopyTexImage1D_0 = (Delegate_CopyTexImage1D_0)GetDelegateForAddress(CopyTexImage1DAddress, typeof(Delegate_CopyTexImage1D_0));

			m_CopyTexImage1D_1 = (Delegate_CopyTexImage1D_1)GetDelegateForAddress(CopyTexImage1DAddress, typeof(Delegate_CopyTexImage1D_1));

			m_CopyTexImage2D_0 = (Delegate_CopyTexImage2D_0)GetDelegateForAddress(CopyTexImage2DAddress, typeof(Delegate_CopyTexImage2D_0));

			m_CopyTexImage2D_1 = (Delegate_CopyTexImage2D_1)GetDelegateForAddress(CopyTexImage2DAddress, typeof(Delegate_CopyTexImage2D_1));

			m_CopyTexImage2D_2 = (Delegate_CopyTexImage2D_2)GetDelegateForAddress(CopyTexImage2DAddress, typeof(Delegate_CopyTexImage2D_2));

			m_CopyTexSubImage1D_0 = (Delegate_CopyTexSubImage1D_0)GetDelegateForAddress(CopyTexSubImage1DAddress, typeof(Delegate_CopyTexSubImage1D_0));

			m_CopyTexSubImage1D_1 = (Delegate_CopyTexSubImage1D_1)GetDelegateForAddress(CopyTexSubImage1DAddress, typeof(Delegate_CopyTexSubImage1D_1));

			m_CopyTexSubImage2D_0 = (Delegate_CopyTexSubImage2D_0)GetDelegateForAddress(CopyTexSubImage2DAddress, typeof(Delegate_CopyTexSubImage2D_0));

			m_CopyTexSubImage2D_1 = (Delegate_CopyTexSubImage2D_1)GetDelegateForAddress(CopyTexSubImage2DAddress, typeof(Delegate_CopyTexSubImage2D_1));

			m_CopyTexSubImage3D_0 = (Delegate_CopyTexSubImage3D_0)GetDelegateForAddress(CopyTexSubImage3DAddress, typeof(Delegate_CopyTexSubImage3D_0));

			m_CopyTexSubImage3D_1 = (Delegate_CopyTexSubImage3D_1)GetDelegateForAddress(CopyTexSubImage3DAddress, typeof(Delegate_CopyTexSubImage3D_1));

			m_CreateProgram_0 = (Delegate_CreateProgram_0)GetDelegateForAddress(CreateProgramAddress, typeof(Delegate_CreateProgram_0));

			m_CreateShader_0 = (Delegate_CreateShader_0)GetDelegateForAddress(CreateShaderAddress, typeof(Delegate_CreateShader_0));

			m_CullFace_0 = (Delegate_CullFace_0)GetDelegateForAddress(CullFaceAddress, typeof(Delegate_CullFace_0));

			m_DeleteBuffers_0 = (Delegate_DeleteBuffers_0)GetDelegateForAddress(DeleteBuffersAddress, typeof(Delegate_DeleteBuffers_0));

			m_DeleteBuffers_1 = (Delegate_DeleteBuffers_1)GetDelegateForAddress(DeleteBuffersAddress, typeof(Delegate_DeleteBuffers_1));

			m_DeleteBuffers_2 = (Delegate_DeleteBuffers_2)GetDelegateForAddress(DeleteBuffersAddress, typeof(Delegate_DeleteBuffers_2));

			m_DeleteFramebuffers_0 = (Delegate_DeleteFramebuffers_0)GetDelegateForAddress(DeleteFramebuffersAddress, typeof(Delegate_DeleteFramebuffers_0));

			m_DeleteFramebuffers_1 = (Delegate_DeleteFramebuffers_1)GetDelegateForAddress(DeleteFramebuffersAddress, typeof(Delegate_DeleteFramebuffers_1));

			m_DeleteFramebuffers_2 = (Delegate_DeleteFramebuffers_2)GetDelegateForAddress(DeleteFramebuffersAddress, typeof(Delegate_DeleteFramebuffers_2));

			m_DeleteProgram_0 = (Delegate_DeleteProgram_0)GetDelegateForAddress(DeleteProgramAddress, typeof(Delegate_DeleteProgram_0));

			m_DeleteQueries_0 = (Delegate_DeleteQueries_0)GetDelegateForAddress(DeleteQueriesAddress, typeof(Delegate_DeleteQueries_0));

			m_DeleteQueries_1 = (Delegate_DeleteQueries_1)GetDelegateForAddress(DeleteQueriesAddress, typeof(Delegate_DeleteQueries_1));

			m_DeleteQueries_2 = (Delegate_DeleteQueries_2)GetDelegateForAddress(DeleteQueriesAddress, typeof(Delegate_DeleteQueries_2));

			m_DeleteRenderbuffers_0 = (Delegate_DeleteRenderbuffers_0)GetDelegateForAddress(DeleteRenderbuffersAddress, typeof(Delegate_DeleteRenderbuffers_0));

			m_DeleteRenderbuffers_1 = (Delegate_DeleteRenderbuffers_1)GetDelegateForAddress(DeleteRenderbuffersAddress, typeof(Delegate_DeleteRenderbuffers_1));

			m_DeleteRenderbuffers_2 = (Delegate_DeleteRenderbuffers_2)GetDelegateForAddress(DeleteRenderbuffersAddress, typeof(Delegate_DeleteRenderbuffers_2));

			m_DeleteShader_0 = (Delegate_DeleteShader_0)GetDelegateForAddress(DeleteShaderAddress, typeof(Delegate_DeleteShader_0));

			m_DeleteSync_0 = (Delegate_DeleteSync_0)GetDelegateForAddress(DeleteSyncAddress, typeof(Delegate_DeleteSync_0));

			m_DeleteTextures_0 = (Delegate_DeleteTextures_0)GetDelegateForAddress(DeleteTexturesAddress, typeof(Delegate_DeleteTextures_0));

			m_DeleteTextures_1 = (Delegate_DeleteTextures_1)GetDelegateForAddress(DeleteTexturesAddress, typeof(Delegate_DeleteTextures_1));

			m_DeleteTextures_2 = (Delegate_DeleteTextures_2)GetDelegateForAddress(DeleteTexturesAddress, typeof(Delegate_DeleteTextures_2));

			m_DeleteVertexArrays_0 = (Delegate_DeleteVertexArrays_0)GetDelegateForAddress(DeleteVertexArraysAddress, typeof(Delegate_DeleteVertexArrays_0));

			m_DeleteVertexArrays_1 = (Delegate_DeleteVertexArrays_1)GetDelegateForAddress(DeleteVertexArraysAddress, typeof(Delegate_DeleteVertexArrays_1));

			m_DeleteVertexArrays_2 = (Delegate_DeleteVertexArrays_2)GetDelegateForAddress(DeleteVertexArraysAddress, typeof(Delegate_DeleteVertexArrays_2));

			m_DepthFunc_0 = (Delegate_DepthFunc_0)GetDelegateForAddress(DepthFuncAddress, typeof(Delegate_DepthFunc_0));

			m_DepthMask_0 = (Delegate_DepthMask_0)GetDelegateForAddress(DepthMaskAddress, typeof(Delegate_DepthMask_0));

			m_DepthRange_0 = (Delegate_DepthRange_0)GetDelegateForAddress(DepthRangeAddress, typeof(Delegate_DepthRange_0));

			m_DetachShader_0 = (Delegate_DetachShader_0)GetDelegateForAddress(DetachShaderAddress, typeof(Delegate_DetachShader_0));

			m_Disable_0 = (Delegate_Disable_0)GetDelegateForAddress(DisableAddress, typeof(Delegate_Disable_0));

			m_Disablei_0 = (Delegate_Disablei_0)GetDelegateForAddress(DisableiAddress, typeof(Delegate_Disablei_0));

			m_DisableVertexAttribArray_0 = (Delegate_DisableVertexAttribArray_0)GetDelegateForAddress(DisableVertexAttribArrayAddress, typeof(Delegate_DisableVertexAttribArray_0));

			m_DrawArrays_0 = (Delegate_DrawArrays_0)GetDelegateForAddress(DrawArraysAddress, typeof(Delegate_DrawArrays_0));

			m_DrawArraysInstanced_0 = (Delegate_DrawArraysInstanced_0)GetDelegateForAddress(DrawArraysInstancedAddress, typeof(Delegate_DrawArraysInstanced_0));

			m_DrawBuffer_0 = (Delegate_DrawBuffer_0)GetDelegateForAddress(DrawBufferAddress, typeof(Delegate_DrawBuffer_0));

			m_DrawBuffers_0 = (Delegate_DrawBuffers_0)GetDelegateForAddress(DrawBuffersAddress, typeof(Delegate_DrawBuffers_0));

			m_DrawBuffers_1 = (Delegate_DrawBuffers_1)GetDelegateForAddress(DrawBuffersAddress, typeof(Delegate_DrawBuffers_1));

			m_DrawBuffers_2 = (Delegate_DrawBuffers_2)GetDelegateForAddress(DrawBuffersAddress, typeof(Delegate_DrawBuffers_2));

			m_DrawElements_0 = (Delegate_DrawElements_0)GetDelegateForAddress(DrawElementsAddress, typeof(Delegate_DrawElements_0));

			m_DrawElements_1 = (Delegate_DrawElements_1)GetDelegateForAddress(DrawElementsAddress, typeof(Delegate_DrawElements_1));

			m_DrawElements_2 = (Delegate_DrawElements_2)GetDelegateForAddress(DrawElementsAddress, typeof(Delegate_DrawElements_2));

			m_DrawElements_3 = (Delegate_DrawElements_3)GetDelegateForAddress(DrawElementsAddress, typeof(Delegate_DrawElements_3));

			m_DrawElementsBaseVertex_0 = (Delegate_DrawElementsBaseVertex_0)GetDelegateForAddress(DrawElementsBaseVertexAddress, typeof(Delegate_DrawElementsBaseVertex_0));

			m_DrawElementsBaseVertex_1 = (Delegate_DrawElementsBaseVertex_1)GetDelegateForAddress(DrawElementsBaseVertexAddress, typeof(Delegate_DrawElementsBaseVertex_1));

			m_DrawElementsBaseVertex_2 = (Delegate_DrawElementsBaseVertex_2)GetDelegateForAddress(DrawElementsBaseVertexAddress, typeof(Delegate_DrawElementsBaseVertex_2));

			m_DrawElementsBaseVertex_3 = (Delegate_DrawElementsBaseVertex_3)GetDelegateForAddress(DrawElementsBaseVertexAddress, typeof(Delegate_DrawElementsBaseVertex_3));

			m_DrawElementsInstanced_0 = (Delegate_DrawElementsInstanced_0)GetDelegateForAddress(DrawElementsInstancedAddress, typeof(Delegate_DrawElementsInstanced_0));

			m_DrawElementsInstanced_1 = (Delegate_DrawElementsInstanced_1)GetDelegateForAddress(DrawElementsInstancedAddress, typeof(Delegate_DrawElementsInstanced_1));

			m_DrawElementsInstanced_2 = (Delegate_DrawElementsInstanced_2)GetDelegateForAddress(DrawElementsInstancedAddress, typeof(Delegate_DrawElementsInstanced_2));

			m_DrawElementsInstanced_3 = (Delegate_DrawElementsInstanced_3)GetDelegateForAddress(DrawElementsInstancedAddress, typeof(Delegate_DrawElementsInstanced_3));

			m_DrawElementsInstancedBaseVertex_0 = (Delegate_DrawElementsInstancedBaseVertex_0)GetDelegateForAddress(DrawElementsInstancedBaseVertexAddress, typeof(Delegate_DrawElementsInstancedBaseVertex_0));

			m_DrawElementsInstancedBaseVertex_1 = (Delegate_DrawElementsInstancedBaseVertex_1)GetDelegateForAddress(DrawElementsInstancedBaseVertexAddress, typeof(Delegate_DrawElementsInstancedBaseVertex_1));

			m_DrawElementsInstancedBaseVertex_2 = (Delegate_DrawElementsInstancedBaseVertex_2)GetDelegateForAddress(DrawElementsInstancedBaseVertexAddress, typeof(Delegate_DrawElementsInstancedBaseVertex_2));

			m_DrawElementsInstancedBaseVertex_3 = (Delegate_DrawElementsInstancedBaseVertex_3)GetDelegateForAddress(DrawElementsInstancedBaseVertexAddress, typeof(Delegate_DrawElementsInstancedBaseVertex_3));

			m_DrawRangeElements_0 = (Delegate_DrawRangeElements_0)GetDelegateForAddress(DrawRangeElementsAddress, typeof(Delegate_DrawRangeElements_0));

			m_DrawRangeElements_1 = (Delegate_DrawRangeElements_1)GetDelegateForAddress(DrawRangeElementsAddress, typeof(Delegate_DrawRangeElements_1));

			m_DrawRangeElements_2 = (Delegate_DrawRangeElements_2)GetDelegateForAddress(DrawRangeElementsAddress, typeof(Delegate_DrawRangeElements_2));

			m_DrawRangeElements_3 = (Delegate_DrawRangeElements_3)GetDelegateForAddress(DrawRangeElementsAddress, typeof(Delegate_DrawRangeElements_3));

			m_DrawRangeElementsBaseVertex_0 = (Delegate_DrawRangeElementsBaseVertex_0)GetDelegateForAddress(DrawRangeElementsBaseVertexAddress, typeof(Delegate_DrawRangeElementsBaseVertex_0));

			m_DrawRangeElementsBaseVertex_1 = (Delegate_DrawRangeElementsBaseVertex_1)GetDelegateForAddress(DrawRangeElementsBaseVertexAddress, typeof(Delegate_DrawRangeElementsBaseVertex_1));

			m_DrawRangeElementsBaseVertex_2 = (Delegate_DrawRangeElementsBaseVertex_2)GetDelegateForAddress(DrawRangeElementsBaseVertexAddress, typeof(Delegate_DrawRangeElementsBaseVertex_2));

			m_DrawRangeElementsBaseVertex_3 = (Delegate_DrawRangeElementsBaseVertex_3)GetDelegateForAddress(DrawRangeElementsBaseVertexAddress, typeof(Delegate_DrawRangeElementsBaseVertex_3));

			m_Enable_0 = (Delegate_Enable_0)GetDelegateForAddress(EnableAddress, typeof(Delegate_Enable_0));

			m_Enablei_0 = (Delegate_Enablei_0)GetDelegateForAddress(EnableiAddress, typeof(Delegate_Enablei_0));

			m_EnableVertexAttribArray_0 = (Delegate_EnableVertexAttribArray_0)GetDelegateForAddress(EnableVertexAttribArrayAddress, typeof(Delegate_EnableVertexAttribArray_0));

			m_EndConditionalRender_0 = (Delegate_EndConditionalRender_0)GetDelegateForAddress(EndConditionalRenderAddress, typeof(Delegate_EndConditionalRender_0));

			m_EndQuery_0 = (Delegate_EndQuery_0)GetDelegateForAddress(EndQueryAddress, typeof(Delegate_EndQuery_0));

			m_EndTransformFeedback_0 = (Delegate_EndTransformFeedback_0)GetDelegateForAddress(EndTransformFeedbackAddress, typeof(Delegate_EndTransformFeedback_0));

			m_FenceSync_0 = (Delegate_FenceSync_0)GetDelegateForAddress(FenceSyncAddress, typeof(Delegate_FenceSync_0));

			m_Finish_0 = (Delegate_Finish_0)GetDelegateForAddress(FinishAddress, typeof(Delegate_Finish_0));

			m_Flush_0 = (Delegate_Flush_0)GetDelegateForAddress(FlushAddress, typeof(Delegate_Flush_0));

			m_FlushMappedBufferRange_0 = (Delegate_FlushMappedBufferRange_0)GetDelegateForAddress(FlushMappedBufferRangeAddress, typeof(Delegate_FlushMappedBufferRange_0));

			m_FramebufferRenderbuffer_0 = (Delegate_FramebufferRenderbuffer_0)GetDelegateForAddress(FramebufferRenderbufferAddress, typeof(Delegate_FramebufferRenderbuffer_0));

			m_FramebufferTexture_0 = (Delegate_FramebufferTexture_0)GetDelegateForAddress(FramebufferTextureAddress, typeof(Delegate_FramebufferTexture_0));

			m_FramebufferTexture1D_0 = (Delegate_FramebufferTexture1D_0)GetDelegateForAddress(FramebufferTexture1DAddress, typeof(Delegate_FramebufferTexture1D_0));

			m_FramebufferTexture2D_0 = (Delegate_FramebufferTexture2D_0)GetDelegateForAddress(FramebufferTexture2DAddress, typeof(Delegate_FramebufferTexture2D_0));

			m_FramebufferTexture3D_0 = (Delegate_FramebufferTexture3D_0)GetDelegateForAddress(FramebufferTexture3DAddress, typeof(Delegate_FramebufferTexture3D_0));

			m_FramebufferTextureLayer_0 = (Delegate_FramebufferTextureLayer_0)GetDelegateForAddress(FramebufferTextureLayerAddress, typeof(Delegate_FramebufferTextureLayer_0));

			m_FrontFace_0 = (Delegate_FrontFace_0)GetDelegateForAddress(FrontFaceAddress, typeof(Delegate_FrontFace_0));

			m_GenBuffers_0 = (Delegate_GenBuffers_0)GetDelegateForAddress(GenBuffersAddress, typeof(Delegate_GenBuffers_0));

			m_GenBuffers_1 = (Delegate_GenBuffers_1)GetDelegateForAddress(GenBuffersAddress, typeof(Delegate_GenBuffers_1));

			m_GenBuffers_2 = (Delegate_GenBuffers_2)GetDelegateForAddress(GenBuffersAddress, typeof(Delegate_GenBuffers_2));

			m_GenerateMipmap_0 = (Delegate_GenerateMipmap_0)GetDelegateForAddress(GenerateMipmapAddress, typeof(Delegate_GenerateMipmap_0));

			m_GenFramebuffers_0 = (Delegate_GenFramebuffers_0)GetDelegateForAddress(GenFramebuffersAddress, typeof(Delegate_GenFramebuffers_0));

			m_GenFramebuffers_1 = (Delegate_GenFramebuffers_1)GetDelegateForAddress(GenFramebuffersAddress, typeof(Delegate_GenFramebuffers_1));

			m_GenFramebuffers_2 = (Delegate_GenFramebuffers_2)GetDelegateForAddress(GenFramebuffersAddress, typeof(Delegate_GenFramebuffers_2));

			m_GenQueries_0 = (Delegate_GenQueries_0)GetDelegateForAddress(GenQueriesAddress, typeof(Delegate_GenQueries_0));

			m_GenQueries_1 = (Delegate_GenQueries_1)GetDelegateForAddress(GenQueriesAddress, typeof(Delegate_GenQueries_1));

			m_GenQueries_2 = (Delegate_GenQueries_2)GetDelegateForAddress(GenQueriesAddress, typeof(Delegate_GenQueries_2));

			m_GenRenderbuffers_0 = (Delegate_GenRenderbuffers_0)GetDelegateForAddress(GenRenderbuffersAddress, typeof(Delegate_GenRenderbuffers_0));

			m_GenRenderbuffers_1 = (Delegate_GenRenderbuffers_1)GetDelegateForAddress(GenRenderbuffersAddress, typeof(Delegate_GenRenderbuffers_1));

			m_GenRenderbuffers_2 = (Delegate_GenRenderbuffers_2)GetDelegateForAddress(GenRenderbuffersAddress, typeof(Delegate_GenRenderbuffers_2));

			m_GenTextures_0 = (Delegate_GenTextures_0)GetDelegateForAddress(GenTexturesAddress, typeof(Delegate_GenTextures_0));

			m_GenTextures_1 = (Delegate_GenTextures_1)GetDelegateForAddress(GenTexturesAddress, typeof(Delegate_GenTextures_1));

			m_GenTextures_2 = (Delegate_GenTextures_2)GetDelegateForAddress(GenTexturesAddress, typeof(Delegate_GenTextures_2));

			m_GenVertexArrays_0 = (Delegate_GenVertexArrays_0)GetDelegateForAddress(GenVertexArraysAddress, typeof(Delegate_GenVertexArrays_0));

			m_GenVertexArrays_1 = (Delegate_GenVertexArrays_1)GetDelegateForAddress(GenVertexArraysAddress, typeof(Delegate_GenVertexArrays_1));

			m_GenVertexArrays_2 = (Delegate_GenVertexArrays_2)GetDelegateForAddress(GenVertexArraysAddress, typeof(Delegate_GenVertexArrays_2));

			m_GetActiveAttrib_0 = (Delegate_GetActiveAttrib_0)GetDelegateForAddress(GetActiveAttribAddress, typeof(Delegate_GetActiveAttrib_0));

			m_GetActiveAttrib_1 = (Delegate_GetActiveAttrib_1)GetDelegateForAddress(GetActiveAttribAddress, typeof(Delegate_GetActiveAttrib_1));

			m_GetActiveUniform_0 = (Delegate_GetActiveUniform_0)GetDelegateForAddress(GetActiveUniformAddress, typeof(Delegate_GetActiveUniform_0));

			m_GetActiveUniform_1 = (Delegate_GetActiveUniform_1)GetDelegateForAddress(GetActiveUniformAddress, typeof(Delegate_GetActiveUniform_1));

			m_GetActiveUniformBlockiv_0 = (Delegate_GetActiveUniformBlockiv_0)GetDelegateForAddress(GetActiveUniformBlockivAddress, typeof(Delegate_GetActiveUniformBlockiv_0));

			m_GetActiveUniformBlockiv_1 = (Delegate_GetActiveUniformBlockiv_1)GetDelegateForAddress(GetActiveUniformBlockivAddress, typeof(Delegate_GetActiveUniformBlockiv_1));

			m_GetActiveUniformBlockiv_2 = (Delegate_GetActiveUniformBlockiv_2)GetDelegateForAddress(GetActiveUniformBlockivAddress, typeof(Delegate_GetActiveUniformBlockiv_2));

			m_GetActiveUniformBlockName_0 = (Delegate_GetActiveUniformBlockName_0)GetDelegateForAddress(GetActiveUniformBlockNameAddress, typeof(Delegate_GetActiveUniformBlockName_0));

			m_GetActiveUniformBlockName_1 = (Delegate_GetActiveUniformBlockName_1)GetDelegateForAddress(GetActiveUniformBlockNameAddress, typeof(Delegate_GetActiveUniformBlockName_1));

			m_GetActiveUniformName_0 = (Delegate_GetActiveUniformName_0)GetDelegateForAddress(GetActiveUniformNameAddress, typeof(Delegate_GetActiveUniformName_0));

			m_GetActiveUniformName_1 = (Delegate_GetActiveUniformName_1)GetDelegateForAddress(GetActiveUniformNameAddress, typeof(Delegate_GetActiveUniformName_1));

			m_GetActiveUniformsiv_0 = (Delegate_GetActiveUniformsiv_0)GetDelegateForAddress(GetActiveUniformsivAddress, typeof(Delegate_GetActiveUniformsiv_0));

			m_GetActiveUniformsiv_1 = (Delegate_GetActiveUniformsiv_1)GetDelegateForAddress(GetActiveUniformsivAddress, typeof(Delegate_GetActiveUniformsiv_1));

			m_GetActiveUniformsiv_2 = (Delegate_GetActiveUniformsiv_2)GetDelegateForAddress(GetActiveUniformsivAddress, typeof(Delegate_GetActiveUniformsiv_2));

			m_GetActiveUniformsiv_3 = (Delegate_GetActiveUniformsiv_3)GetDelegateForAddress(GetActiveUniformsivAddress, typeof(Delegate_GetActiveUniformsiv_3));

			m_GetActiveUniformsiv_4 = (Delegate_GetActiveUniformsiv_4)GetDelegateForAddress(GetActiveUniformsivAddress, typeof(Delegate_GetActiveUniformsiv_4));

			m_GetAttachedShaders_0 = (Delegate_GetAttachedShaders_0)GetDelegateForAddress(GetAttachedShadersAddress, typeof(Delegate_GetAttachedShaders_0));

			m_GetAttachedShaders_1 = (Delegate_GetAttachedShaders_1)GetDelegateForAddress(GetAttachedShadersAddress, typeof(Delegate_GetAttachedShaders_1));

			m_GetAttribLocation_0 = (Delegate_GetAttribLocation_0)GetDelegateForAddress(GetAttribLocationAddress, typeof(Delegate_GetAttribLocation_0));

			m_GetAttribLocation_1 = (Delegate_GetAttribLocation_1)GetDelegateForAddress(GetAttribLocationAddress, typeof(Delegate_GetAttribLocation_1));

			m_GetAttribLocation_2 = (Delegate_GetAttribLocation_2)GetDelegateForAddress(GetAttribLocationAddress, typeof(Delegate_GetAttribLocation_2));

			m_GetBooleani_v_0 = (Delegate_GetBooleani_v_0)GetDelegateForAddress(GetBooleani_vAddress, typeof(Delegate_GetBooleani_v_0));

			m_GetBooleani_v_1 = (Delegate_GetBooleani_v_1)GetDelegateForAddress(GetBooleani_vAddress, typeof(Delegate_GetBooleani_v_1));

			m_GetBooleanv_0 = (Delegate_GetBooleanv_0)GetDelegateForAddress(GetBooleanvAddress, typeof(Delegate_GetBooleanv_0));

			m_GetBooleanv_1 = (Delegate_GetBooleanv_1)GetDelegateForAddress(GetBooleanvAddress, typeof(Delegate_GetBooleanv_1));

			m_GetBufferParameteri64v_0 = (Delegate_GetBufferParameteri64v_0)GetDelegateForAddress(GetBufferParameteri64vAddress, typeof(Delegate_GetBufferParameteri64v_0));

			m_GetBufferParameteri64v_1 = (Delegate_GetBufferParameteri64v_1)GetDelegateForAddress(GetBufferParameteri64vAddress, typeof(Delegate_GetBufferParameteri64v_1));

			m_GetBufferParameteriv_0 = (Delegate_GetBufferParameteriv_0)GetDelegateForAddress(GetBufferParameterivAddress, typeof(Delegate_GetBufferParameteriv_0));

			m_GetBufferParameteriv_1 = (Delegate_GetBufferParameteriv_1)GetDelegateForAddress(GetBufferParameterivAddress, typeof(Delegate_GetBufferParameteriv_1));

			m_GetBufferPointerv_0 = (Delegate_GetBufferPointerv_0)GetDelegateForAddress(GetBufferPointervAddress, typeof(Delegate_GetBufferPointerv_0));

			m_GetBufferPointerv_1 = (Delegate_GetBufferPointerv_1)GetDelegateForAddress(GetBufferPointervAddress, typeof(Delegate_GetBufferPointerv_1));

			m_GetBufferSubData_0 = (Delegate_GetBufferSubData_0)GetDelegateForAddress(GetBufferSubDataAddress, typeof(Delegate_GetBufferSubData_0));

			m_GetCompressedTexImage_0 = (Delegate_GetCompressedTexImage_0)GetDelegateForAddress(GetCompressedTexImageAddress, typeof(Delegate_GetCompressedTexImage_0));

			m_GetDoublev_0 = (Delegate_GetDoublev_0)GetDelegateForAddress(GetDoublevAddress, typeof(Delegate_GetDoublev_0));

			m_GetDoublev_1 = (Delegate_GetDoublev_1)GetDelegateForAddress(GetDoublevAddress, typeof(Delegate_GetDoublev_1));

			m_GetDoublev_2 = (Delegate_GetDoublev_2)GetDelegateForAddress(GetDoublevAddress, typeof(Delegate_GetDoublev_2));

			m_GetDoublev_3 = (Delegate_GetDoublev_3)GetDelegateForAddress(GetDoublevAddress, typeof(Delegate_GetDoublev_3));

			m_GetDoublev_4 = (Delegate_GetDoublev_4)GetDelegateForAddress(GetDoublevAddress, typeof(Delegate_GetDoublev_4));

			m_GetDoublev_5 = (Delegate_GetDoublev_5)GetDelegateForAddress(GetDoublevAddress, typeof(Delegate_GetDoublev_5));

			m_GetDoublev_6 = (Delegate_GetDoublev_6)GetDelegateForAddress(GetDoublevAddress, typeof(Delegate_GetDoublev_6));

			m_GetDoublev_7 = (Delegate_GetDoublev_7)GetDelegateForAddress(GetDoublevAddress, typeof(Delegate_GetDoublev_7));

			m_GetDoublev_8 = (Delegate_GetDoublev_8)GetDelegateForAddress(GetDoublevAddress, typeof(Delegate_GetDoublev_8));

			m_GetDoublev_9 = (Delegate_GetDoublev_9)GetDelegateForAddress(GetDoublevAddress, typeof(Delegate_GetDoublev_9));

			m_GetError_0 = (Delegate_GetError_0)GetDelegateForAddress(GetErrorAddress, typeof(Delegate_GetError_0));

			m_GetFloatv_0 = (Delegate_GetFloatv_0)GetDelegateForAddress(GetFloatvAddress, typeof(Delegate_GetFloatv_0));

			m_GetFloatv_1 = (Delegate_GetFloatv_1)GetDelegateForAddress(GetFloatvAddress, typeof(Delegate_GetFloatv_1));

			m_GetFloatv_2 = (Delegate_GetFloatv_2)GetDelegateForAddress(GetFloatvAddress, typeof(Delegate_GetFloatv_2));

			m_GetFloatv_3 = (Delegate_GetFloatv_3)GetDelegateForAddress(GetFloatvAddress, typeof(Delegate_GetFloatv_3));

			m_GetFloatv_4 = (Delegate_GetFloatv_4)GetDelegateForAddress(GetFloatvAddress, typeof(Delegate_GetFloatv_4));

			m_GetFloatv_5 = (Delegate_GetFloatv_5)GetDelegateForAddress(GetFloatvAddress, typeof(Delegate_GetFloatv_5));

			m_GetFloatv_6 = (Delegate_GetFloatv_6)GetDelegateForAddress(GetFloatvAddress, typeof(Delegate_GetFloatv_6));

			m_GetFloatv_7 = (Delegate_GetFloatv_7)GetDelegateForAddress(GetFloatvAddress, typeof(Delegate_GetFloatv_7));

			m_GetFloatv_8 = (Delegate_GetFloatv_8)GetDelegateForAddress(GetFloatvAddress, typeof(Delegate_GetFloatv_8));

			m_GetFloatv_9 = (Delegate_GetFloatv_9)GetDelegateForAddress(GetFloatvAddress, typeof(Delegate_GetFloatv_9));

			m_GetFragDataLocation_0 = (Delegate_GetFragDataLocation_0)GetDelegateForAddress(GetFragDataLocationAddress, typeof(Delegate_GetFragDataLocation_0));

			m_GetFramebufferAttachmentParameteriv_0 = (Delegate_GetFramebufferAttachmentParameteriv_0)GetDelegateForAddress(GetFramebufferAttachmentParameterivAddress, typeof(Delegate_GetFramebufferAttachmentParameteriv_0));

			m_GetFramebufferAttachmentParameteriv_1 = (Delegate_GetFramebufferAttachmentParameteriv_1)GetDelegateForAddress(GetFramebufferAttachmentParameterivAddress, typeof(Delegate_GetFramebufferAttachmentParameteriv_1));

			m_GetInteger64i_v_0 = (Delegate_GetInteger64i_v_0)GetDelegateForAddress(GetInteger64i_vAddress, typeof(Delegate_GetInteger64i_v_0));

			m_GetInteger64i_v_1 = (Delegate_GetInteger64i_v_1)GetDelegateForAddress(GetInteger64i_vAddress, typeof(Delegate_GetInteger64i_v_1));

			m_GetInteger64i_v_2 = (Delegate_GetInteger64i_v_2)GetDelegateForAddress(GetInteger64i_vAddress, typeof(Delegate_GetInteger64i_v_2));

			m_GetInteger64v_0 = (Delegate_GetInteger64v_0)GetDelegateForAddress(GetInteger64vAddress, typeof(Delegate_GetInteger64v_0));

			m_GetInteger64v_1 = (Delegate_GetInteger64v_1)GetDelegateForAddress(GetInteger64vAddress, typeof(Delegate_GetInteger64v_1));

			m_GetInteger64v_2 = (Delegate_GetInteger64v_2)GetDelegateForAddress(GetInteger64vAddress, typeof(Delegate_GetInteger64v_2));

			m_GetIntegeri_v_0 = (Delegate_GetIntegeri_v_0)GetDelegateForAddress(GetIntegeri_vAddress, typeof(Delegate_GetIntegeri_v_0));

			m_GetIntegeri_v_1 = (Delegate_GetIntegeri_v_1)GetDelegateForAddress(GetIntegeri_vAddress, typeof(Delegate_GetIntegeri_v_1));

			m_GetIntegeri_v_2 = (Delegate_GetIntegeri_v_2)GetDelegateForAddress(GetIntegeri_vAddress, typeof(Delegate_GetIntegeri_v_2));

			m_GetIntegerv_0 = (Delegate_GetIntegerv_0)GetDelegateForAddress(GetIntegervAddress, typeof(Delegate_GetIntegerv_0));

			m_GetIntegerv_1 = (Delegate_GetIntegerv_1)GetDelegateForAddress(GetIntegervAddress, typeof(Delegate_GetIntegerv_1));

			m_GetIntegerv_2 = (Delegate_GetIntegerv_2)GetDelegateForAddress(GetIntegervAddress, typeof(Delegate_GetIntegerv_2));

			m_GetMultisamplefv_0 = (Delegate_GetMultisamplefv_0)GetDelegateForAddress(GetMultisamplefvAddress, typeof(Delegate_GetMultisamplefv_0));

			m_GetMultisamplefv_1 = (Delegate_GetMultisamplefv_1)GetDelegateForAddress(GetMultisamplefvAddress, typeof(Delegate_GetMultisamplefv_1));

			m_GetProgramInfoLog_0 = (Delegate_GetProgramInfoLog_0)GetDelegateForAddress(GetProgramInfoLogAddress, typeof(Delegate_GetProgramInfoLog_0));

			m_GetProgramInfoLog_1 = (Delegate_GetProgramInfoLog_1)GetDelegateForAddress(GetProgramInfoLogAddress, typeof(Delegate_GetProgramInfoLog_1));

			m_GetProgramiv_0 = (Delegate_GetProgramiv_0)GetDelegateForAddress(GetProgramivAddress, typeof(Delegate_GetProgramiv_0));

			m_GetProgramiv_1 = (Delegate_GetProgramiv_1)GetDelegateForAddress(GetProgramivAddress, typeof(Delegate_GetProgramiv_1));

			m_GetProgramiv_2 = (Delegate_GetProgramiv_2)GetDelegateForAddress(GetProgramivAddress, typeof(Delegate_GetProgramiv_2));

			m_GetQueryiv_0 = (Delegate_GetQueryiv_0)GetDelegateForAddress(GetQueryivAddress, typeof(Delegate_GetQueryiv_0));

			m_GetQueryObjectiv_0 = (Delegate_GetQueryObjectiv_0)GetDelegateForAddress(GetQueryObjectivAddress, typeof(Delegate_GetQueryObjectiv_0));

			m_GetQueryObjectuiv_0 = (Delegate_GetQueryObjectuiv_0)GetDelegateForAddress(GetQueryObjectuivAddress, typeof(Delegate_GetQueryObjectuiv_0));

			m_GetRenderbufferParameteriv_0 = (Delegate_GetRenderbufferParameteriv_0)GetDelegateForAddress(GetRenderbufferParameterivAddress, typeof(Delegate_GetRenderbufferParameteriv_0));

			m_GetShaderInfoLog_0 = (Delegate_GetShaderInfoLog_0)GetDelegateForAddress(GetShaderInfoLogAddress, typeof(Delegate_GetShaderInfoLog_0));

			m_GetShaderInfoLog_1 = (Delegate_GetShaderInfoLog_1)GetDelegateForAddress(GetShaderInfoLogAddress, typeof(Delegate_GetShaderInfoLog_1));

			m_GetShaderiv_0 = (Delegate_GetShaderiv_0)GetDelegateForAddress(GetShaderivAddress, typeof(Delegate_GetShaderiv_0));

			m_GetShaderiv_1 = (Delegate_GetShaderiv_1)GetDelegateForAddress(GetShaderivAddress, typeof(Delegate_GetShaderiv_1));

			m_GetShaderiv_2 = (Delegate_GetShaderiv_2)GetDelegateForAddress(GetShaderivAddress, typeof(Delegate_GetShaderiv_2));

			m_GetShaderSource_0 = (Delegate_GetShaderSource_0)GetDelegateForAddress(GetShaderSourceAddress, typeof(Delegate_GetShaderSource_0));

			m_GetString_0 = (Delegate_GetString_0)GetDelegateForAddress(GetStringAddress, typeof(Delegate_GetString_0));

			m_GetStringi_0 = (Delegate_GetStringi_0)GetDelegateForAddress(GetStringiAddress, typeof(Delegate_GetStringi_0));

			m_GetSynciv_0 = (Delegate_GetSynciv_0)GetDelegateForAddress(GetSyncivAddress, typeof(Delegate_GetSynciv_0));

			m_GetTexImage_0 = (Delegate_GetTexImage_0)GetDelegateForAddress(GetTexImageAddress, typeof(Delegate_GetTexImage_0));

			m_GetTexLevelParameterfv_0 = (Delegate_GetTexLevelParameterfv_0)GetDelegateForAddress(GetTexLevelParameterfvAddress, typeof(Delegate_GetTexLevelParameterfv_0));

			m_GetTexLevelParameteriv_0 = (Delegate_GetTexLevelParameteriv_0)GetDelegateForAddress(GetTexLevelParameterivAddress, typeof(Delegate_GetTexLevelParameteriv_0));

			m_GetTexParameterfv_0 = (Delegate_GetTexParameterfv_0)GetDelegateForAddress(GetTexParameterfvAddress, typeof(Delegate_GetTexParameterfv_0));

			m_GetTexParameterIiv_0 = (Delegate_GetTexParameterIiv_0)GetDelegateForAddress(GetTexParameterIivAddress, typeof(Delegate_GetTexParameterIiv_0));

			m_GetTexParameterIuiv_0 = (Delegate_GetTexParameterIuiv_0)GetDelegateForAddress(GetTexParameterIuivAddress, typeof(Delegate_GetTexParameterIuiv_0));

			m_GetTexParameteriv_0 = (Delegate_GetTexParameteriv_0)GetDelegateForAddress(GetTexParameterivAddress, typeof(Delegate_GetTexParameteriv_0));

			m_GetTransformFeedbackVarying_0 = (Delegate_GetTransformFeedbackVarying_0)GetDelegateForAddress(GetTransformFeedbackVaryingAddress, typeof(Delegate_GetTransformFeedbackVarying_0));

			m_GetUniformBlockIndex_0 = (Delegate_GetUniformBlockIndex_0)GetDelegateForAddress(GetUniformBlockIndexAddress, typeof(Delegate_GetUniformBlockIndex_0));

			m_GetUniformfv_0 = (Delegate_GetUniformfv_0)GetDelegateForAddress(GetUniformfvAddress, typeof(Delegate_GetUniformfv_0));

			m_GetUniformIndices_0 = (Delegate_GetUniformIndices_0)GetDelegateForAddress(GetUniformIndicesAddress, typeof(Delegate_GetUniformIndices_0));

			m_GetUniformiv_0 = (Delegate_GetUniformiv_0)GetDelegateForAddress(GetUniformivAddress, typeof(Delegate_GetUniformiv_0));

			m_GetUniformLocation_0 = (Delegate_GetUniformLocation_0)GetDelegateForAddress(GetUniformLocationAddress, typeof(Delegate_GetUniformLocation_0));

			m_GetUniformLocation_1 = (Delegate_GetUniformLocation_1)GetDelegateForAddress(GetUniformLocationAddress, typeof(Delegate_GetUniformLocation_1));

			m_GetUniformLocation_2 = (Delegate_GetUniformLocation_2)GetDelegateForAddress(GetUniformLocationAddress, typeof(Delegate_GetUniformLocation_2));

			m_GetUniformuiv_0 = (Delegate_GetUniformuiv_0)GetDelegateForAddress(GetUniformuivAddress, typeof(Delegate_GetUniformuiv_0));

			m_GetVertexAttribdv_0 = (Delegate_GetVertexAttribdv_0)GetDelegateForAddress(GetVertexAttribdvAddress, typeof(Delegate_GetVertexAttribdv_0));

			m_GetVertexAttribfv_0 = (Delegate_GetVertexAttribfv_0)GetDelegateForAddress(GetVertexAttribfvAddress, typeof(Delegate_GetVertexAttribfv_0));

			m_GetVertexAttribIiv_0 = (Delegate_GetVertexAttribIiv_0)GetDelegateForAddress(GetVertexAttribIivAddress, typeof(Delegate_GetVertexAttribIiv_0));

			m_GetVertexAttribIuiv_0 = (Delegate_GetVertexAttribIuiv_0)GetDelegateForAddress(GetVertexAttribIuivAddress, typeof(Delegate_GetVertexAttribIuiv_0));

			m_GetVertexAttribiv_0 = (Delegate_GetVertexAttribiv_0)GetDelegateForAddress(GetVertexAttribivAddress, typeof(Delegate_GetVertexAttribiv_0));

			m_GetVertexAttribPointerv_0 = (Delegate_GetVertexAttribPointerv_0)GetDelegateForAddress(GetVertexAttribPointervAddress, typeof(Delegate_GetVertexAttribPointerv_0));

			m_Hint_0 = (Delegate_Hint_0)GetDelegateForAddress(HintAddress, typeof(Delegate_Hint_0));

			m_IsBuffer_0 = (Delegate_IsBuffer_0)GetDelegateForAddress(IsBufferAddress, typeof(Delegate_IsBuffer_0));

			m_IsEnabled_0 = (Delegate_IsEnabled_0)GetDelegateForAddress(IsEnabledAddress, typeof(Delegate_IsEnabled_0));

			m_IsEnabledi_0 = (Delegate_IsEnabledi_0)GetDelegateForAddress(IsEnablediAddress, typeof(Delegate_IsEnabledi_0));

			m_IsFramebuffer_0 = (Delegate_IsFramebuffer_0)GetDelegateForAddress(IsFramebufferAddress, typeof(Delegate_IsFramebuffer_0));

			m_IsProgram_0 = (Delegate_IsProgram_0)GetDelegateForAddress(IsProgramAddress, typeof(Delegate_IsProgram_0));

			m_IsQuery_0 = (Delegate_IsQuery_0)GetDelegateForAddress(IsQueryAddress, typeof(Delegate_IsQuery_0));

			m_IsRenderbuffer_0 = (Delegate_IsRenderbuffer_0)GetDelegateForAddress(IsRenderbufferAddress, typeof(Delegate_IsRenderbuffer_0));

			m_IsShader_0 = (Delegate_IsShader_0)GetDelegateForAddress(IsShaderAddress, typeof(Delegate_IsShader_0));

			m_IsSync_0 = (Delegate_IsSync_0)GetDelegateForAddress(IsSyncAddress, typeof(Delegate_IsSync_0));

			m_IsTexture_0 = (Delegate_IsTexture_0)GetDelegateForAddress(IsTextureAddress, typeof(Delegate_IsTexture_0));

			m_IsVertexArray_0 = (Delegate_IsVertexArray_0)GetDelegateForAddress(IsVertexArrayAddress, typeof(Delegate_IsVertexArray_0));

			m_LineWidth_0 = (Delegate_LineWidth_0)GetDelegateForAddress(LineWidthAddress, typeof(Delegate_LineWidth_0));

			m_LinkProgram_0 = (Delegate_LinkProgram_0)GetDelegateForAddress(LinkProgramAddress, typeof(Delegate_LinkProgram_0));

			m_LogicOp_0 = (Delegate_LogicOp_0)GetDelegateForAddress(LogicOpAddress, typeof(Delegate_LogicOp_0));

			m_MapBuffer_0 = (Delegate_MapBuffer_0)GetDelegateForAddress(MapBufferAddress, typeof(Delegate_MapBuffer_0));

			m_MapBufferRange_0 = (Delegate_MapBufferRange_0)GetDelegateForAddress(MapBufferRangeAddress, typeof(Delegate_MapBufferRange_0));

			m_MultiDrawArrays_0 = (Delegate_MultiDrawArrays_0)GetDelegateForAddress(MultiDrawArraysAddress, typeof(Delegate_MultiDrawArrays_0));

			m_MultiDrawElements_0 = (Delegate_MultiDrawElements_0)GetDelegateForAddress(MultiDrawElementsAddress, typeof(Delegate_MultiDrawElements_0));

			m_MultiDrawElementsBaseVertex_0 = (Delegate_MultiDrawElementsBaseVertex_0)GetDelegateForAddress(MultiDrawElementsBaseVertexAddress, typeof(Delegate_MultiDrawElementsBaseVertex_0));

			m_PixelStoref_0 = (Delegate_PixelStoref_0)GetDelegateForAddress(PixelStorefAddress, typeof(Delegate_PixelStoref_0));

			m_PixelStorei_0 = (Delegate_PixelStorei_0)GetDelegateForAddress(PixelStoreiAddress, typeof(Delegate_PixelStorei_0));

			m_PointParameterf_0 = (Delegate_PointParameterf_0)GetDelegateForAddress(PointParameterfAddress, typeof(Delegate_PointParameterf_0));

			m_PointParameterfv_0 = (Delegate_PointParameterfv_0)GetDelegateForAddress(PointParameterfvAddress, typeof(Delegate_PointParameterfv_0));

			m_PointParameteri_0 = (Delegate_PointParameteri_0)GetDelegateForAddress(PointParameteriAddress, typeof(Delegate_PointParameteri_0));

			m_PointParameteriv_0 = (Delegate_PointParameteriv_0)GetDelegateForAddress(PointParameterivAddress, typeof(Delegate_PointParameteriv_0));

			m_PointSize_0 = (Delegate_PointSize_0)GetDelegateForAddress(PointSizeAddress, typeof(Delegate_PointSize_0));

			m_PolygonMode_0 = (Delegate_PolygonMode_0)GetDelegateForAddress(PolygonModeAddress, typeof(Delegate_PolygonMode_0));

			m_PolygonOffset_0 = (Delegate_PolygonOffset_0)GetDelegateForAddress(PolygonOffsetAddress, typeof(Delegate_PolygonOffset_0));

			m_PrimitiveRestartIndex_0 = (Delegate_PrimitiveRestartIndex_0)GetDelegateForAddress(PrimitiveRestartIndexAddress, typeof(Delegate_PrimitiveRestartIndex_0));

			m_ProvokingVertex_0 = (Delegate_ProvokingVertex_0)GetDelegateForAddress(ProvokingVertexAddress, typeof(Delegate_ProvokingVertex_0));

			m_ReadBuffer_0 = (Delegate_ReadBuffer_0)GetDelegateForAddress(ReadBufferAddress, typeof(Delegate_ReadBuffer_0));

			m_ReadPixels_0 = (Delegate_ReadPixels_0)GetDelegateForAddress(ReadPixelsAddress, typeof(Delegate_ReadPixels_0));

			m_RenderbufferStorage_0 = (Delegate_RenderbufferStorage_0)GetDelegateForAddress(RenderbufferStorageAddress, typeof(Delegate_RenderbufferStorage_0));

			m_RenderbufferStorageMultisample_0 = (Delegate_RenderbufferStorageMultisample_0)GetDelegateForAddress(RenderbufferStorageMultisampleAddress, typeof(Delegate_RenderbufferStorageMultisample_0));

			m_SampleCoverage_0 = (Delegate_SampleCoverage_0)GetDelegateForAddress(SampleCoverageAddress, typeof(Delegate_SampleCoverage_0));

			m_SampleMaski_0 = (Delegate_SampleMaski_0)GetDelegateForAddress(SampleMaskiAddress, typeof(Delegate_SampleMaski_0));

			m_Scissor_0 = (Delegate_Scissor_0)GetDelegateForAddress(ScissorAddress, typeof(Delegate_Scissor_0));

			m_ShaderSource_0 = (Delegate_ShaderSource_0)GetDelegateForAddress(ShaderSourceAddress, typeof(Delegate_ShaderSource_0));

			m_ShaderSource_1 = (Delegate_ShaderSource_1)GetDelegateForAddress(ShaderSourceAddress, typeof(Delegate_ShaderSource_1));

			m_StencilFunc_0 = (Delegate_StencilFunc_0)GetDelegateForAddress(StencilFuncAddress, typeof(Delegate_StencilFunc_0));

			m_StencilFuncSeparate_0 = (Delegate_StencilFuncSeparate_0)GetDelegateForAddress(StencilFuncSeparateAddress, typeof(Delegate_StencilFuncSeparate_0));

			m_StencilMask_0 = (Delegate_StencilMask_0)GetDelegateForAddress(StencilMaskAddress, typeof(Delegate_StencilMask_0));

			m_StencilMaskSeparate_0 = (Delegate_StencilMaskSeparate_0)GetDelegateForAddress(StencilMaskSeparateAddress, typeof(Delegate_StencilMaskSeparate_0));

			m_StencilOp_0 = (Delegate_StencilOp_0)GetDelegateForAddress(StencilOpAddress, typeof(Delegate_StencilOp_0));

			m_StencilOpSeparate_0 = (Delegate_StencilOpSeparate_0)GetDelegateForAddress(StencilOpSeparateAddress, typeof(Delegate_StencilOpSeparate_0));

			m_TexBuffer_0 = (Delegate_TexBuffer_0)GetDelegateForAddress(TexBufferAddress, typeof(Delegate_TexBuffer_0));

			m_TexImage1D_0 = (Delegate_TexImage1D_0)GetDelegateForAddress(TexImage1DAddress, typeof(Delegate_TexImage1D_0));

			m_TexImage2D_0 = (Delegate_TexImage2D_0)GetDelegateForAddress(TexImage2DAddress, typeof(Delegate_TexImage2D_0));

			m_TexImage2DMultisample_0 = (Delegate_TexImage2DMultisample_0)GetDelegateForAddress(TexImage2DMultisampleAddress, typeof(Delegate_TexImage2DMultisample_0));

			m_TexImage3D_0 = (Delegate_TexImage3D_0)GetDelegateForAddress(TexImage3DAddress, typeof(Delegate_TexImage3D_0));

			m_TexImage3DMultisample_0 = (Delegate_TexImage3DMultisample_0)GetDelegateForAddress(TexImage3DMultisampleAddress, typeof(Delegate_TexImage3DMultisample_0));

			m_TexParameterf_0 = (Delegate_TexParameterf_0)GetDelegateForAddress(TexParameterfAddress, typeof(Delegate_TexParameterf_0));

			m_TexParameterfv_0 = (Delegate_TexParameterfv_0)GetDelegateForAddress(TexParameterfvAddress, typeof(Delegate_TexParameterfv_0));

			m_TexParameteri_0 = (Delegate_TexParameteri_0)GetDelegateForAddress(TexParameteriAddress, typeof(Delegate_TexParameteri_0));

			m_TexParameterIiv_0 = (Delegate_TexParameterIiv_0)GetDelegateForAddress(TexParameterIivAddress, typeof(Delegate_TexParameterIiv_0));

			m_TexParameterIuiv_0 = (Delegate_TexParameterIuiv_0)GetDelegateForAddress(TexParameterIuivAddress, typeof(Delegate_TexParameterIuiv_0));

			m_TexParameteriv_0 = (Delegate_TexParameteriv_0)GetDelegateForAddress(TexParameterivAddress, typeof(Delegate_TexParameteriv_0));

			m_TexSubImage1D_0 = (Delegate_TexSubImage1D_0)GetDelegateForAddress(TexSubImage1DAddress, typeof(Delegate_TexSubImage1D_0));

			m_TexSubImage2D_0 = (Delegate_TexSubImage2D_0)GetDelegateForAddress(TexSubImage2DAddress, typeof(Delegate_TexSubImage2D_0));

			m_TexSubImage3D_0 = (Delegate_TexSubImage3D_0)GetDelegateForAddress(TexSubImage3DAddress, typeof(Delegate_TexSubImage3D_0));

			m_TransformFeedbackVaryings_0 = (Delegate_TransformFeedbackVaryings_0)GetDelegateForAddress(TransformFeedbackVaryingsAddress, typeof(Delegate_TransformFeedbackVaryings_0));

			m_Uniform1f_0 = (Delegate_Uniform1f_0)GetDelegateForAddress(Uniform1fAddress, typeof(Delegate_Uniform1f_0));

			m_Uniform1fv_0 = (Delegate_Uniform1fv_0)GetDelegateForAddress(Uniform1fvAddress, typeof(Delegate_Uniform1fv_0));

			m_Uniform1i_0 = (Delegate_Uniform1i_0)GetDelegateForAddress(Uniform1iAddress, typeof(Delegate_Uniform1i_0));

			m_Uniform1iv_0 = (Delegate_Uniform1iv_0)GetDelegateForAddress(Uniform1ivAddress, typeof(Delegate_Uniform1iv_0));

			m_Uniform1ui_0 = (Delegate_Uniform1ui_0)GetDelegateForAddress(Uniform1uiAddress, typeof(Delegate_Uniform1ui_0));

			m_Uniform1uiv_0 = (Delegate_Uniform1uiv_0)GetDelegateForAddress(Uniform1uivAddress, typeof(Delegate_Uniform1uiv_0));

			m_Uniform2f_0 = (Delegate_Uniform2f_0)GetDelegateForAddress(Uniform2fAddress, typeof(Delegate_Uniform2f_0));

			m_Uniform2fv_0 = (Delegate_Uniform2fv_0)GetDelegateForAddress(Uniform2fvAddress, typeof(Delegate_Uniform2fv_0));

			m_Uniform2i_0 = (Delegate_Uniform2i_0)GetDelegateForAddress(Uniform2iAddress, typeof(Delegate_Uniform2i_0));

			m_Uniform2iv_0 = (Delegate_Uniform2iv_0)GetDelegateForAddress(Uniform2ivAddress, typeof(Delegate_Uniform2iv_0));

			m_Uniform2ui_0 = (Delegate_Uniform2ui_0)GetDelegateForAddress(Uniform2uiAddress, typeof(Delegate_Uniform2ui_0));

			m_Uniform2uiv_0 = (Delegate_Uniform2uiv_0)GetDelegateForAddress(Uniform2uivAddress, typeof(Delegate_Uniform2uiv_0));

			m_Uniform3f_0 = (Delegate_Uniform3f_0)GetDelegateForAddress(Uniform3fAddress, typeof(Delegate_Uniform3f_0));

			m_Uniform3fv_0 = (Delegate_Uniform3fv_0)GetDelegateForAddress(Uniform3fvAddress, typeof(Delegate_Uniform3fv_0));

			m_Uniform3i_0 = (Delegate_Uniform3i_0)GetDelegateForAddress(Uniform3iAddress, typeof(Delegate_Uniform3i_0));

			m_Uniform3iv_0 = (Delegate_Uniform3iv_0)GetDelegateForAddress(Uniform3ivAddress, typeof(Delegate_Uniform3iv_0));

			m_Uniform3ui_0 = (Delegate_Uniform3ui_0)GetDelegateForAddress(Uniform3uiAddress, typeof(Delegate_Uniform3ui_0));

			m_Uniform3uiv_0 = (Delegate_Uniform3uiv_0)GetDelegateForAddress(Uniform3uivAddress, typeof(Delegate_Uniform3uiv_0));

			m_Uniform4f_0 = (Delegate_Uniform4f_0)GetDelegateForAddress(Uniform4fAddress, typeof(Delegate_Uniform4f_0));

			m_Uniform4fv_0 = (Delegate_Uniform4fv_0)GetDelegateForAddress(Uniform4fvAddress, typeof(Delegate_Uniform4fv_0));

			m_Uniform4i_0 = (Delegate_Uniform4i_0)GetDelegateForAddress(Uniform4iAddress, typeof(Delegate_Uniform4i_0));

			m_Uniform4iv_0 = (Delegate_Uniform4iv_0)GetDelegateForAddress(Uniform4ivAddress, typeof(Delegate_Uniform4iv_0));

			m_Uniform4ui_0 = (Delegate_Uniform4ui_0)GetDelegateForAddress(Uniform4uiAddress, typeof(Delegate_Uniform4ui_0));

			m_Uniform4uiv_0 = (Delegate_Uniform4uiv_0)GetDelegateForAddress(Uniform4uivAddress, typeof(Delegate_Uniform4uiv_0));

			m_UniformBlockBinding_0 = (Delegate_UniformBlockBinding_0)GetDelegateForAddress(UniformBlockBindingAddress, typeof(Delegate_UniformBlockBinding_0));

			m_UniformMatrix2fv_0 = (Delegate_UniformMatrix2fv_0)GetDelegateForAddress(UniformMatrix2fvAddress, typeof(Delegate_UniformMatrix2fv_0));

			m_UniformMatrix2fv_1 = (Delegate_UniformMatrix2fv_1)GetDelegateForAddress(UniformMatrix2fvAddress, typeof(Delegate_UniformMatrix2fv_1));

			m_UniformMatrix2fv_2 = (Delegate_UniformMatrix2fv_2)GetDelegateForAddress(UniformMatrix2fvAddress, typeof(Delegate_UniformMatrix2fv_2));

			m_UniformMatrix2x3fv_0 = (Delegate_UniformMatrix2x3fv_0)GetDelegateForAddress(UniformMatrix2x3fvAddress, typeof(Delegate_UniformMatrix2x3fv_0));

			m_UniformMatrix2x4fv_0 = (Delegate_UniformMatrix2x4fv_0)GetDelegateForAddress(UniformMatrix2x4fvAddress, typeof(Delegate_UniformMatrix2x4fv_0));

			m_UniformMatrix3fv_0 = (Delegate_UniformMatrix3fv_0)GetDelegateForAddress(UniformMatrix3fvAddress, typeof(Delegate_UniformMatrix3fv_0));

			m_UniformMatrix3fv_1 = (Delegate_UniformMatrix3fv_1)GetDelegateForAddress(UniformMatrix3fvAddress, typeof(Delegate_UniformMatrix3fv_1));

			m_UniformMatrix3fv_2 = (Delegate_UniformMatrix3fv_2)GetDelegateForAddress(UniformMatrix3fvAddress, typeof(Delegate_UniformMatrix3fv_2));

			m_UniformMatrix3x2fv_0 = (Delegate_UniformMatrix3x2fv_0)GetDelegateForAddress(UniformMatrix3x2fvAddress, typeof(Delegate_UniformMatrix3x2fv_0));

			m_UniformMatrix3x4fv_0 = (Delegate_UniformMatrix3x4fv_0)GetDelegateForAddress(UniformMatrix3x4fvAddress, typeof(Delegate_UniformMatrix3x4fv_0));

			m_UniformMatrix4fv_0 = (Delegate_UniformMatrix4fv_0)GetDelegateForAddress(UniformMatrix4fvAddress, typeof(Delegate_UniformMatrix4fv_0));

			m_UniformMatrix4fv_1 = (Delegate_UniformMatrix4fv_1)GetDelegateForAddress(UniformMatrix4fvAddress, typeof(Delegate_UniformMatrix4fv_1));

			m_UniformMatrix4fv_2 = (Delegate_UniformMatrix4fv_2)GetDelegateForAddress(UniformMatrix4fvAddress, typeof(Delegate_UniformMatrix4fv_2));

			m_UniformMatrix4x2fv_0 = (Delegate_UniformMatrix4x2fv_0)GetDelegateForAddress(UniformMatrix4x2fvAddress, typeof(Delegate_UniformMatrix4x2fv_0));

			m_UniformMatrix4x3fv_0 = (Delegate_UniformMatrix4x3fv_0)GetDelegateForAddress(UniformMatrix4x3fvAddress, typeof(Delegate_UniformMatrix4x3fv_0));

			m_UnmapBuffer_0 = (Delegate_UnmapBuffer_0)GetDelegateForAddress(UnmapBufferAddress, typeof(Delegate_UnmapBuffer_0));

			m_UseProgram_0 = (Delegate_UseProgram_0)GetDelegateForAddress(UseProgramAddress, typeof(Delegate_UseProgram_0));

			m_ValidateProgram_0 = (Delegate_ValidateProgram_0)GetDelegateForAddress(ValidateProgramAddress, typeof(Delegate_ValidateProgram_0));

			m_VertexAttrib1d_0 = (Delegate_VertexAttrib1d_0)GetDelegateForAddress(VertexAttrib1dAddress, typeof(Delegate_VertexAttrib1d_0));

			m_VertexAttrib1dv_0 = (Delegate_VertexAttrib1dv_0)GetDelegateForAddress(VertexAttrib1dvAddress, typeof(Delegate_VertexAttrib1dv_0));

			m_VertexAttrib1f_0 = (Delegate_VertexAttrib1f_0)GetDelegateForAddress(VertexAttrib1fAddress, typeof(Delegate_VertexAttrib1f_0));

			m_VertexAttrib1fv_0 = (Delegate_VertexAttrib1fv_0)GetDelegateForAddress(VertexAttrib1fvAddress, typeof(Delegate_VertexAttrib1fv_0));

			m_VertexAttrib1s_0 = (Delegate_VertexAttrib1s_0)GetDelegateForAddress(VertexAttrib1sAddress, typeof(Delegate_VertexAttrib1s_0));

			m_VertexAttrib1sv_0 = (Delegate_VertexAttrib1sv_0)GetDelegateForAddress(VertexAttrib1svAddress, typeof(Delegate_VertexAttrib1sv_0));

			m_VertexAttrib2d_0 = (Delegate_VertexAttrib2d_0)GetDelegateForAddress(VertexAttrib2dAddress, typeof(Delegate_VertexAttrib2d_0));

			m_VertexAttrib2dv_0 = (Delegate_VertexAttrib2dv_0)GetDelegateForAddress(VertexAttrib2dvAddress, typeof(Delegate_VertexAttrib2dv_0));

			m_VertexAttrib2f_0 = (Delegate_VertexAttrib2f_0)GetDelegateForAddress(VertexAttrib2fAddress, typeof(Delegate_VertexAttrib2f_0));

			m_VertexAttrib2fv_0 = (Delegate_VertexAttrib2fv_0)GetDelegateForAddress(VertexAttrib2fvAddress, typeof(Delegate_VertexAttrib2fv_0));

			m_VertexAttrib2s_0 = (Delegate_VertexAttrib2s_0)GetDelegateForAddress(VertexAttrib2sAddress, typeof(Delegate_VertexAttrib2s_0));

			m_VertexAttrib2sv_0 = (Delegate_VertexAttrib2sv_0)GetDelegateForAddress(VertexAttrib2svAddress, typeof(Delegate_VertexAttrib2sv_0));

			m_VertexAttrib3d_0 = (Delegate_VertexAttrib3d_0)GetDelegateForAddress(VertexAttrib3dAddress, typeof(Delegate_VertexAttrib3d_0));

			m_VertexAttrib3dv_0 = (Delegate_VertexAttrib3dv_0)GetDelegateForAddress(VertexAttrib3dvAddress, typeof(Delegate_VertexAttrib3dv_0));

			m_VertexAttrib3f_0 = (Delegate_VertexAttrib3f_0)GetDelegateForAddress(VertexAttrib3fAddress, typeof(Delegate_VertexAttrib3f_0));

			m_VertexAttrib3fv_0 = (Delegate_VertexAttrib3fv_0)GetDelegateForAddress(VertexAttrib3fvAddress, typeof(Delegate_VertexAttrib3fv_0));

			m_VertexAttrib3s_0 = (Delegate_VertexAttrib3s_0)GetDelegateForAddress(VertexAttrib3sAddress, typeof(Delegate_VertexAttrib3s_0));

			m_VertexAttrib3sv_0 = (Delegate_VertexAttrib3sv_0)GetDelegateForAddress(VertexAttrib3svAddress, typeof(Delegate_VertexAttrib3sv_0));

			m_VertexAttrib4bv_0 = (Delegate_VertexAttrib4bv_0)GetDelegateForAddress(VertexAttrib4bvAddress, typeof(Delegate_VertexAttrib4bv_0));

			m_VertexAttrib4d_0 = (Delegate_VertexAttrib4d_0)GetDelegateForAddress(VertexAttrib4dAddress, typeof(Delegate_VertexAttrib4d_0));

			m_VertexAttrib4dv_0 = (Delegate_VertexAttrib4dv_0)GetDelegateForAddress(VertexAttrib4dvAddress, typeof(Delegate_VertexAttrib4dv_0));

			m_VertexAttrib4f_0 = (Delegate_VertexAttrib4f_0)GetDelegateForAddress(VertexAttrib4fAddress, typeof(Delegate_VertexAttrib4f_0));

			m_VertexAttrib4fv_0 = (Delegate_VertexAttrib4fv_0)GetDelegateForAddress(VertexAttrib4fvAddress, typeof(Delegate_VertexAttrib4fv_0));

			m_VertexAttrib4iv_0 = (Delegate_VertexAttrib4iv_0)GetDelegateForAddress(VertexAttrib4ivAddress, typeof(Delegate_VertexAttrib4iv_0));

			m_VertexAttrib4Nbv_0 = (Delegate_VertexAttrib4Nbv_0)GetDelegateForAddress(VertexAttrib4NbvAddress, typeof(Delegate_VertexAttrib4Nbv_0));

			m_VertexAttrib4Niv_0 = (Delegate_VertexAttrib4Niv_0)GetDelegateForAddress(VertexAttrib4NivAddress, typeof(Delegate_VertexAttrib4Niv_0));

			m_VertexAttrib4Nsv_0 = (Delegate_VertexAttrib4Nsv_0)GetDelegateForAddress(VertexAttrib4NsvAddress, typeof(Delegate_VertexAttrib4Nsv_0));

			m_VertexAttrib4Nub_0 = (Delegate_VertexAttrib4Nub_0)GetDelegateForAddress(VertexAttrib4NubAddress, typeof(Delegate_VertexAttrib4Nub_0));

			m_VertexAttrib4Nubv_0 = (Delegate_VertexAttrib4Nubv_0)GetDelegateForAddress(VertexAttrib4NubvAddress, typeof(Delegate_VertexAttrib4Nubv_0));

			m_VertexAttrib4Nuiv_0 = (Delegate_VertexAttrib4Nuiv_0)GetDelegateForAddress(VertexAttrib4NuivAddress, typeof(Delegate_VertexAttrib4Nuiv_0));

			m_VertexAttrib4Nusv_0 = (Delegate_VertexAttrib4Nusv_0)GetDelegateForAddress(VertexAttrib4NusvAddress, typeof(Delegate_VertexAttrib4Nusv_0));

			m_VertexAttrib4s_0 = (Delegate_VertexAttrib4s_0)GetDelegateForAddress(VertexAttrib4sAddress, typeof(Delegate_VertexAttrib4s_0));

			m_VertexAttrib4sv_0 = (Delegate_VertexAttrib4sv_0)GetDelegateForAddress(VertexAttrib4svAddress, typeof(Delegate_VertexAttrib4sv_0));

			m_VertexAttrib4ubv_0 = (Delegate_VertexAttrib4ubv_0)GetDelegateForAddress(VertexAttrib4ubvAddress, typeof(Delegate_VertexAttrib4ubv_0));

			m_VertexAttrib4uiv_0 = (Delegate_VertexAttrib4uiv_0)GetDelegateForAddress(VertexAttrib4uivAddress, typeof(Delegate_VertexAttrib4uiv_0));

			m_VertexAttrib4usv_0 = (Delegate_VertexAttrib4usv_0)GetDelegateForAddress(VertexAttrib4usvAddress, typeof(Delegate_VertexAttrib4usv_0));

			m_VertexAttribI1i_0 = (Delegate_VertexAttribI1i_0)GetDelegateForAddress(VertexAttribI1iAddress, typeof(Delegate_VertexAttribI1i_0));

			m_VertexAttribI1iv_0 = (Delegate_VertexAttribI1iv_0)GetDelegateForAddress(VertexAttribI1ivAddress, typeof(Delegate_VertexAttribI1iv_0));

			m_VertexAttribI1ui_0 = (Delegate_VertexAttribI1ui_0)GetDelegateForAddress(VertexAttribI1uiAddress, typeof(Delegate_VertexAttribI1ui_0));

			m_VertexAttribI1uiv_0 = (Delegate_VertexAttribI1uiv_0)GetDelegateForAddress(VertexAttribI1uivAddress, typeof(Delegate_VertexAttribI1uiv_0));

			m_VertexAttribI2i_0 = (Delegate_VertexAttribI2i_0)GetDelegateForAddress(VertexAttribI2iAddress, typeof(Delegate_VertexAttribI2i_0));

			m_VertexAttribI2iv_0 = (Delegate_VertexAttribI2iv_0)GetDelegateForAddress(VertexAttribI2ivAddress, typeof(Delegate_VertexAttribI2iv_0));

			m_VertexAttribI2ui_0 = (Delegate_VertexAttribI2ui_0)GetDelegateForAddress(VertexAttribI2uiAddress, typeof(Delegate_VertexAttribI2ui_0));

			m_VertexAttribI2uiv_0 = (Delegate_VertexAttribI2uiv_0)GetDelegateForAddress(VertexAttribI2uivAddress, typeof(Delegate_VertexAttribI2uiv_0));

			m_VertexAttribI3i_0 = (Delegate_VertexAttribI3i_0)GetDelegateForAddress(VertexAttribI3iAddress, typeof(Delegate_VertexAttribI3i_0));

			m_VertexAttribI3iv_0 = (Delegate_VertexAttribI3iv_0)GetDelegateForAddress(VertexAttribI3ivAddress, typeof(Delegate_VertexAttribI3iv_0));

			m_VertexAttribI3ui_0 = (Delegate_VertexAttribI3ui_0)GetDelegateForAddress(VertexAttribI3uiAddress, typeof(Delegate_VertexAttribI3ui_0));

			m_VertexAttribI3uiv_0 = (Delegate_VertexAttribI3uiv_0)GetDelegateForAddress(VertexAttribI3uivAddress, typeof(Delegate_VertexAttribI3uiv_0));

			m_VertexAttribI4bv_0 = (Delegate_VertexAttribI4bv_0)GetDelegateForAddress(VertexAttribI4bvAddress, typeof(Delegate_VertexAttribI4bv_0));

			m_VertexAttribI4i_0 = (Delegate_VertexAttribI4i_0)GetDelegateForAddress(VertexAttribI4iAddress, typeof(Delegate_VertexAttribI4i_0));

			m_VertexAttribI4iv_0 = (Delegate_VertexAttribI4iv_0)GetDelegateForAddress(VertexAttribI4ivAddress, typeof(Delegate_VertexAttribI4iv_0));

			m_VertexAttribI4sv_0 = (Delegate_VertexAttribI4sv_0)GetDelegateForAddress(VertexAttribI4svAddress, typeof(Delegate_VertexAttribI4sv_0));

			m_VertexAttribI4ubv_0 = (Delegate_VertexAttribI4ubv_0)GetDelegateForAddress(VertexAttribI4ubvAddress, typeof(Delegate_VertexAttribI4ubv_0));

			m_VertexAttribI4ui_0 = (Delegate_VertexAttribI4ui_0)GetDelegateForAddress(VertexAttribI4uiAddress, typeof(Delegate_VertexAttribI4ui_0));

			m_VertexAttribI4uiv_0 = (Delegate_VertexAttribI4uiv_0)GetDelegateForAddress(VertexAttribI4uivAddress, typeof(Delegate_VertexAttribI4uiv_0));

			m_VertexAttribI4usv_0 = (Delegate_VertexAttribI4usv_0)GetDelegateForAddress(VertexAttribI4usvAddress, typeof(Delegate_VertexAttribI4usv_0));

			m_VertexAttribIPointer_0 = (Delegate_VertexAttribIPointer_0)GetDelegateForAddress(VertexAttribIPointerAddress, typeof(Delegate_VertexAttribIPointer_0));

			m_VertexAttribPointer_0 = (Delegate_VertexAttribPointer_0)GetDelegateForAddress(VertexAttribPointerAddress, typeof(Delegate_VertexAttribPointer_0));

			m_Viewport_0 = (Delegate_Viewport_0)GetDelegateForAddress(ViewportAddress, typeof(Delegate_Viewport_0));

			m_Viewport_1 = (Delegate_Viewport_1)GetDelegateForAddress(ViewportAddress, typeof(Delegate_Viewport_1));

			m_WaitSync_0 = (Delegate_WaitSync_0)GetDelegateForAddress(WaitSyncAddress, typeof(Delegate_WaitSync_0));

			m_BindFragDataLocationIndexed_0 = (Delegate_BindFragDataLocationIndexed_0)GetDelegateForAddress(BindFragDataLocationIndexedAddress, typeof(Delegate_BindFragDataLocationIndexed_0));

			m_GetFragDataIndex_0 = (Delegate_GetFragDataIndex_0)GetDelegateForAddress(GetFragDataIndexAddress, typeof(Delegate_GetFragDataIndex_0));

			m_GenSamplers_0 = (Delegate_GenSamplers_0)GetDelegateForAddress(GenSamplersAddress, typeof(Delegate_GenSamplers_0));

			m_GenSamplers_1 = (Delegate_GenSamplers_1)GetDelegateForAddress(GenSamplersAddress, typeof(Delegate_GenSamplers_1));

			m_GenSamplers_2 = (Delegate_GenSamplers_2)GetDelegateForAddress(GenSamplersAddress, typeof(Delegate_GenSamplers_2));

			m_DeleteSamplers_0 = (Delegate_DeleteSamplers_0)GetDelegateForAddress(DeleteSamplersAddress, typeof(Delegate_DeleteSamplers_0));

			m_DeleteSamplers_1 = (Delegate_DeleteSamplers_1)GetDelegateForAddress(DeleteSamplersAddress, typeof(Delegate_DeleteSamplers_1));

			m_DeleteSamplers_2 = (Delegate_DeleteSamplers_2)GetDelegateForAddress(DeleteSamplersAddress, typeof(Delegate_DeleteSamplers_2));

			m_IsSampler_0 = (Delegate_IsSampler_0)GetDelegateForAddress(IsSamplerAddress, typeof(Delegate_IsSampler_0));

			m_BindSampler_0 = (Delegate_BindSampler_0)GetDelegateForAddress(BindSamplerAddress, typeof(Delegate_BindSampler_0));

			m_SamplerParameteri_0 = (Delegate_SamplerParameteri_0)GetDelegateForAddress(SamplerParameteriAddress, typeof(Delegate_SamplerParameteri_0));

			m_SamplerParameteriv_0 = (Delegate_SamplerParameteriv_0)GetDelegateForAddress(SamplerParameterivAddress, typeof(Delegate_SamplerParameteriv_0));

			m_SamplerParameterf_0 = (Delegate_SamplerParameterf_0)GetDelegateForAddress(SamplerParameterfAddress, typeof(Delegate_SamplerParameterf_0));

			m_SamplerParameterfv_0 = (Delegate_SamplerParameterfv_0)GetDelegateForAddress(SamplerParameterfvAddress, typeof(Delegate_SamplerParameterfv_0));

			m_SamplerParameterIiv_0 = (Delegate_SamplerParameterIiv_0)GetDelegateForAddress(SamplerParameterIivAddress, typeof(Delegate_SamplerParameterIiv_0));

			m_SamplerParameterIuiv_0 = (Delegate_SamplerParameterIuiv_0)GetDelegateForAddress(SamplerParameterIuivAddress, typeof(Delegate_SamplerParameterIuiv_0));

			m_GetSamplerParameteriv_0 = (Delegate_GetSamplerParameteriv_0)GetDelegateForAddress(GetSamplerParameterivAddress, typeof(Delegate_GetSamplerParameteriv_0));

			m_GetSamplerParameterIiv_0 = (Delegate_GetSamplerParameterIiv_0)GetDelegateForAddress(GetSamplerParameterIivAddress, typeof(Delegate_GetSamplerParameterIiv_0));

			m_GetSamplerParameterfv_0 = (Delegate_GetSamplerParameterfv_0)GetDelegateForAddress(GetSamplerParameterfvAddress, typeof(Delegate_GetSamplerParameterfv_0));

			m_GetSamplerParameterIuiv_0 = (Delegate_GetSamplerParameterIuiv_0)GetDelegateForAddress(GetSamplerParameterIuivAddress, typeof(Delegate_GetSamplerParameterIuiv_0));

			m_QueryCounter_0 = (Delegate_QueryCounter_0)GetDelegateForAddress(QueryCounterAddress, typeof(Delegate_QueryCounter_0));

			m_GetQueryObjecti64v_0 = (Delegate_GetQueryObjecti64v_0)GetDelegateForAddress(GetQueryObjecti64vAddress, typeof(Delegate_GetQueryObjecti64v_0));

			m_GetQueryObjectui64v_0 = (Delegate_GetQueryObjectui64v_0)GetDelegateForAddress(GetQueryObjectui64vAddress, typeof(Delegate_GetQueryObjectui64v_0));

			m_VertexAttribDivisor_0 = (Delegate_VertexAttribDivisor_0)GetDelegateForAddress(VertexAttribDivisorAddress, typeof(Delegate_VertexAttribDivisor_0));

			m_VertexAttribP1ui_0 = (Delegate_VertexAttribP1ui_0)GetDelegateForAddress(VertexAttribP1uiAddress, typeof(Delegate_VertexAttribP1ui_0));

			m_VertexAttribP1uiv_0 = (Delegate_VertexAttribP1uiv_0)GetDelegateForAddress(VertexAttribP1uivAddress, typeof(Delegate_VertexAttribP1uiv_0));

			m_VertexAttribP2ui_0 = (Delegate_VertexAttribP2ui_0)GetDelegateForAddress(VertexAttribP2uiAddress, typeof(Delegate_VertexAttribP2ui_0));

			m_VertexAttribP2uiv_0 = (Delegate_VertexAttribP2uiv_0)GetDelegateForAddress(VertexAttribP2uivAddress, typeof(Delegate_VertexAttribP2uiv_0));

			m_VertexAttribP3ui_0 = (Delegate_VertexAttribP3ui_0)GetDelegateForAddress(VertexAttribP3uiAddress, typeof(Delegate_VertexAttribP3ui_0));

			m_VertexAttribP3uiv_0 = (Delegate_VertexAttribP3uiv_0)GetDelegateForAddress(VertexAttribP3uivAddress, typeof(Delegate_VertexAttribP3uiv_0));

			m_VertexAttribP4ui_0 = (Delegate_VertexAttribP4ui_0)GetDelegateForAddress(VertexAttribP4uiAddress, typeof(Delegate_VertexAttribP4ui_0));

			m_VertexAttribP4uiv_0 = (Delegate_VertexAttribP4uiv_0)GetDelegateForAddress(VertexAttribP4uivAddress, typeof(Delegate_VertexAttribP4uiv_0));

		}


		public void ActiveTexture(uint texture)
		{
			m_ActiveTexture_0(texture);
		}


		public void AttachShader(uint program, uint shader)
		{
			m_AttachShader_0(program, shader);
		}


		public void BeginConditionalRender(uint id, uint mode)
		{
			m_BeginConditionalRender_0(id, mode);
		}


		public void BeginQuery(uint target, uint id)
		{
			m_BeginQuery_0(target, id);
		}


		public void BeginTransformFeedback(uint primitiveMode)
		{
			m_BeginTransformFeedback_0(primitiveMode);
		}


		public void BindAttribLocation(uint program, uint index, string name)
		{
			m_BindAttribLocation_0(program, index, name);
		}


		public void BindBuffer(uint target, uint buffer)
		{
			m_BindBuffer_0(target, buffer);
		}


		public void BindBufferBase(uint target, uint index, uint buffer)
		{
			m_BindBufferBase_0(target, index, buffer);
		}


		public void BindBufferRange(uint target, uint index, uint buffer, System.IntPtr offset, System.IntPtr size)
		{
			m_BindBufferRange_0(target, index, buffer, offset, size);
		}


		public void BindFragDataLocation(uint program, uint color, string name)
		{
			m_BindFragDataLocation_0(program, color, name);
		}


		public void BindFramebuffer(uint target, uint framebuffer)
		{
			m_BindFramebuffer_0(target, framebuffer);
		}


		public void BindRenderbuffer(uint target, uint renderbuffer)
		{
			m_BindRenderbuffer_0(target, renderbuffer);
		}


		public void BindTexture(uint target, uint texture)
		{
			m_BindTexture_0(target, texture);
		}


		public void BindVertexArray(uint array)
		{
			m_BindVertexArray_0(array);
		}


		public void BlendColor(float red, float green, float blue, float alpha)
		{
			m_BlendColor_0(red, green, blue, alpha);
		}


		public void BlendColor(Color4 color)
		{
			m_BlendColor_1(color);
		}


		public void BlendEquation(uint mode)
		{
			m_BlendEquation_0(mode);
		}


		public void BlendEquationSeparate(uint modeRGB, uint modeAlpha)
		{
			m_BlendEquationSeparate_0(modeRGB, modeAlpha);
		}


		public void BlendFunc(uint sfactor, uint dfactor)
		{
			m_BlendFunc_0(sfactor, dfactor);
		}


		public void BlendFuncSeparate(uint sfactorRGB, uint dfactorRGB, uint sfactorAlpha, uint dfactorAlpha)
		{
			m_BlendFuncSeparate_0(sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha);
		}


		public void BlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter)
		{
			m_BlitFramebuffer_0(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
		}


		public void BlitFramebuffer(Vector2i src0, Vector2i src1, Vector2i dst0, Vector2i dst1, uint mask, uint filter)
		{
			m_BlitFramebuffer_1(src0, src1, dst0, dst1, mask, filter);
		}


		public void BufferData(uint target, System.IntPtr size, System.IntPtr data, uint usage)
		{
			m_BufferData_0(target, size, data, usage);
		}


		public void BufferSubData(uint target, System.IntPtr offset, System.IntPtr size, System.IntPtr data)
		{
			m_BufferSubData_0(target, offset, size, data);
		}


		public uint CheckFramebufferStatus(uint target)
		{
			return m_CheckFramebufferStatus_0(target);
		}


		public void ClampColor(uint target, uint clamp)
		{
			m_ClampColor_0(target, clamp);
		}


		public void Clear(uint mask)
		{
			m_Clear_0(mask);
		}


		public void ClearBufferfi(uint buffer, int drawbuffer, float depth, int stencil)
		{
			m_ClearBufferfi_0(buffer, drawbuffer, depth, stencil);
		}


		public void ClearBufferfv(uint buffer, int drawbuffer, System.IntPtr value)
		{
			m_ClearBufferfv_0(buffer, drawbuffer, value);
		}


		public void ClearBufferfv(uint buffer, int drawbuffer, ref Color4 value)
		{
			m_ClearBufferfv_1(buffer, drawbuffer, ref value);
		}


		public void ClearBufferfv(uint buffer, int drawbuffer, ref float value)
		{
			m_ClearBufferfv_2(buffer, drawbuffer, ref value);
		}


		public void ClearBufferiv(uint buffer, int drawbuffer, System.IntPtr value)
		{
			m_ClearBufferiv_0(buffer, drawbuffer, value);
		}


		public void ClearBufferiv(uint buffer, int drawbuffer, ref Color4i value)
		{
			m_ClearBufferiv_1(buffer, drawbuffer, ref value);
		}


		public void ClearBufferiv(uint buffer, int drawbuffer, ref int value)
		{
			m_ClearBufferiv_2(buffer, drawbuffer, ref value);
		}


		public void ClearBufferuiv(uint buffer, int drawbuffer, System.IntPtr value)
		{
			m_ClearBufferuiv_0(buffer, drawbuffer, value);
		}


		public void ClearBufferuiv(uint buffer, int drawbuffer, ref Color4ui value)
		{
			m_ClearBufferuiv_1(buffer, drawbuffer, ref value);
		}


		public void ClearBufferuiv(uint buffer, int drawbuffer, ref uint value)
		{
			m_ClearBufferuiv_2(buffer, drawbuffer, ref value);
		}


		public void ClearColor(float red, float green, float blue, float alpha)
		{
			m_ClearColor_0(red, green, blue, alpha);
		}


		public void ClearColor(Color4 color)
		{
			m_ClearColor_1(color);
		}


		public void ClearDepth(double depth)
		{
			m_ClearDepth_0(depth);
		}


		public void ClearStencil(int s)
		{
			m_ClearStencil_0(s);
		}


		public uint ClientWaitSync(System.IntPtr sync, uint flags, ulong timeout)
		{
			return m_ClientWaitSync_0(sync, flags, timeout);
		}


		public void ColorMask(bool red, bool green, bool blue, bool alpha)
		{
			m_ColorMask_0(red, green, blue, alpha);
		}


		public void ColorMaski(uint index, bool r, bool g, bool b, bool a)
		{
			m_ColorMaski_0(index, r, g, b, a);
		}


		public void CompileShader(uint shader)
		{
			m_CompileShader_0(shader);
		}


		public void CompressedTexImage1D(uint target, int level, uint internalformat, int width, int border, int imageSize, System.IntPtr data)
		{
			m_CompressedTexImage1D_0(target, level, internalformat, width, border, imageSize, data);
		}


		public void CompressedTexImage2D(uint target, int level, uint internalformat, int width, int height, int border, int imageSize, System.IntPtr data)
		{
			m_CompressedTexImage2D_0(target, level, internalformat, width, height, border, imageSize, data);
		}


		public void CompressedTexImage3D(uint target, int level, uint internalformat, int width, int height, int depth, int border, int imageSize, System.IntPtr data)
		{
			m_CompressedTexImage3D_0(target, level, internalformat, width, height, depth, border, imageSize, data);
		}


		public void CompressedTexSubImage1D(uint target, int level, int xoffset, int width, uint format, int imageSize, System.IntPtr data)
		{
			m_CompressedTexSubImage1D_0(target, level, xoffset, width, format, imageSize, data);
		}


		public void CompressedTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, System.IntPtr data)
		{
			m_CompressedTexSubImage2D_0(target, level, xoffset, yoffset, width, height, format, imageSize, data);
		}


		public void CompressedTexSubImage2D(uint target, int level, Box2i imagePosition, uint format, int imageSize, System.IntPtr data)
		{
			m_CompressedTexSubImage2D_1(target, level, imagePosition, format, imageSize, data);
		}


		public void CompressedTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, System.IntPtr data)
		{
			m_CompressedTexSubImage3D_0(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
		}


		public void CompressedTexSubImage3D(uint target, int level, Box3i imagePosition, uint format, int imageSize, System.IntPtr data)
		{
			m_CompressedTexSubImage3D_1(target, level, imagePosition, format, imageSize, data);
		}


		public void CopyBufferSubData(uint readTarget, uint writeTarget, System.IntPtr readOffset, System.IntPtr writeOffset, System.IntPtr size)
		{
			m_CopyBufferSubData_0(readTarget, writeTarget, readOffset, writeOffset, size);
		}


		public void CopyTexImage1D(uint target, int level, uint internalformat, int x, int y, int width, int border)
		{
			m_CopyTexImage1D_0(target, level, internalformat, x, y, width, border);
		}


		public void CopyTexImage1D(uint target, int level, uint internalformat, Vector2i imagePosition, int width, int border)
		{
			m_CopyTexImage1D_1(target, level, internalformat, imagePosition, width, border);
		}


		public void CopyTexImage2D(uint target, int level, uint internalformat, int x, int y, int width, int height, int border)
		{
			m_CopyTexImage2D_0(target, level, internalformat, x, y, width, height, border);
		}


		public void CopyTexImage2D(uint target, int level, uint internalformat, Vector2i imagePosition, Vector2i imageSize, int border)
		{
			m_CopyTexImage2D_1(target, level, internalformat, imagePosition, imageSize, border);
		}


		public void CopyTexImage2D(uint target, int level, uint internalformat, Box2i image, int border)
		{
			m_CopyTexImage2D_2(target, level, internalformat, image, border);
		}


		public void CopyTexSubImage1D(uint target, int level, int xoffset, int x, int y, int width)
		{
			m_CopyTexSubImage1D_0(target, level, xoffset, x, y, width);
		}


		public void CopyTexSubImage1D(uint target, int level, int xoffset, Vector2i imagePosition, int width)
		{
			m_CopyTexSubImage1D_1(target, level, xoffset, imagePosition, width);
		}


		public void CopyTexSubImage2D(uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height)
		{
			m_CopyTexSubImage2D_0(target, level, xoffset, yoffset, x, y, width, height);
		}


		public void CopyTexSubImage2D(uint target, int level, Vector2i texturePosition, Vector2i imagePosition, Vector2i size)
		{
			m_CopyTexSubImage2D_1(target, level, texturePosition, imagePosition, size);
		}


		public void CopyTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height)
		{
			m_CopyTexSubImage3D_0(target, level, xoffset, yoffset, zoffset, x, y, width, height);
		}


		public void CopyTexSubImage3D(uint target, int level, Vector3i texturePosition, Vector2i imagePosition, Vector2i size)
		{
			m_CopyTexSubImage3D_1(target, level, texturePosition, imagePosition, size);
		}


		public uint CreateProgram()
		{
			return m_CreateProgram_0();
		}


		public uint CreateShader(uint type)
		{
			return m_CreateShader_0(type);
		}


		public void CullFace(uint mode)
		{
			m_CullFace_0(mode);
		}


		public void DeleteBuffers(int n, System.IntPtr buffers)
		{
			m_DeleteBuffers_0(n, buffers);
		}


		public void DeleteBuffers(int n, uint[] buffers)
		{
			m_DeleteBuffers_1(n, buffers);
		}


		public void DeleteBuffers(int n, ref uint buffers)
		{
			m_DeleteBuffers_2(n, ref buffers);
		}


		public void DeleteFramebuffers(int n, System.IntPtr framebuffers)
		{
			m_DeleteFramebuffers_0(n, framebuffers);
		}


		public void DeleteFramebuffers(int n, uint[] framebuffers)
		{
			m_DeleteFramebuffers_1(n, framebuffers);
		}


		public void DeleteFramebuffers(int n, ref uint framebuffers)
		{
			m_DeleteFramebuffers_2(n, ref framebuffers);
		}


		public void DeleteProgram(uint program)
		{
			m_DeleteProgram_0(program);
		}


		public void DeleteQueries(int n, System.IntPtr ids)
		{
			m_DeleteQueries_0(n, ids);
		}


		public void DeleteQueries(int n, uint[] ids)
		{
			m_DeleteQueries_1(n, ids);
		}


		public void DeleteQueries(int n, ref uint ids)
		{
			m_DeleteQueries_2(n, ref ids);
		}


		public void DeleteRenderbuffers(int n, System.IntPtr renderbuffers)
		{
			m_DeleteRenderbuffers_0(n, renderbuffers);
		}


		public void DeleteRenderbuffers(int n, uint[] renderbuffers)
		{
			m_DeleteRenderbuffers_1(n, renderbuffers);
		}


		public void DeleteRenderbuffers(int n, ref uint renderbuffers)
		{
			m_DeleteRenderbuffers_2(n, ref renderbuffers);
		}


		public void DeleteShader(uint shader)
		{
			m_DeleteShader_0(shader);
		}


		public void DeleteSync(System.IntPtr sync)
		{
			m_DeleteSync_0(sync);
		}


		public void DeleteTextures(int n, System.IntPtr textures)
		{
			m_DeleteTextures_0(n, textures);
		}


		public void DeleteTextures(int n, uint[] textures)
		{
			m_DeleteTextures_1(n, textures);
		}


		public void DeleteTextures(int n, ref uint textures)
		{
			m_DeleteTextures_2(n, ref textures);
		}


		public void DeleteVertexArrays(int n, System.IntPtr arrays)
		{
			m_DeleteVertexArrays_0(n, arrays);
		}


		public void DeleteVertexArrays(int n, uint[] arrays)
		{
			m_DeleteVertexArrays_1(n, arrays);
		}


		public void DeleteVertexArrays(int n, ref uint arrays)
		{
			m_DeleteVertexArrays_2(n, ref arrays);
		}


		public void DepthFunc(uint func)
		{
			m_DepthFunc_0(func);
		}


		public void DepthMask(bool flag)
		{
			m_DepthMask_0(flag);
		}


		public void DepthRange(double near, double far)
		{
			m_DepthRange_0(near, far);
		}


		public void DetachShader(uint program, uint shader)
		{
			m_DetachShader_0(program, shader);
		}


		public void Disable(uint cap)
		{
			m_Disable_0(cap);
		}


		public void Disablei(uint target, uint index)
		{
			m_Disablei_0(target, index);
		}


		public void DisableVertexAttribArray(uint index)
		{
			m_DisableVertexAttribArray_0(index);
		}


		public void DrawArrays(uint mode, int first, int count)
		{
			m_DrawArrays_0(mode, first, count);
		}


		public void DrawArraysInstanced(uint mode, int first, int count, int instancecount)
		{
			m_DrawArraysInstanced_0(mode, first, count, instancecount);
		}


		public void DrawBuffer(uint mode)
		{
			m_DrawBuffer_0(mode);
		}


		public void DrawBuffers(int n, System.IntPtr bufs)
		{
			m_DrawBuffers_0(n, bufs);
		}


		public void DrawBuffers(int n, uint[] bufs)
		{
			m_DrawBuffers_1(n, bufs);
		}


		public void DrawBuffers(int n, ref uint bufs)
		{
			m_DrawBuffers_2(n, ref bufs);
		}


		public void DrawElements(uint mode, int count, uint type, System.IntPtr indices)
		{
			m_DrawElements_0(mode, count, type, indices);
		}


		public void DrawElements(uint mode, int count, uint type, byte[] indices)
		{
			m_DrawElements_1(mode, count, type, indices);
		}


		public void DrawElements(uint mode, int count, uint type, ushort[] indices)
		{
			m_DrawElements_2(mode, count, type, indices);
		}


		public void DrawElements(uint mode, int count, uint type, uint[] indices)
		{
			m_DrawElements_3(mode, count, type, indices);
		}


		public void DrawElementsBaseVertex(uint mode, int count, uint type, System.IntPtr indices, int basevertex)
		{
			m_DrawElementsBaseVertex_0(mode, count, type, indices, basevertex);
		}


		public void DrawElementsBaseVertex(uint mode, int count, uint type, byte[] indices, int basevertex)
		{
			m_DrawElementsBaseVertex_1(mode, count, type, indices, basevertex);
		}


		public void DrawElementsBaseVertex(uint mode, int count, uint type, ushort[] indices, int basevertex)
		{
			m_DrawElementsBaseVertex_2(mode, count, type, indices, basevertex);
		}


		public void DrawElementsBaseVertex(uint mode, int count, uint type, uint[] indices, int basevertex)
		{
			m_DrawElementsBaseVertex_3(mode, count, type, indices, basevertex);
		}


		public void DrawElementsInstanced(uint mode, int count, uint type, System.IntPtr indices, int instancecount)
		{
			m_DrawElementsInstanced_0(mode, count, type, indices, instancecount);
		}


		public void DrawElementsInstanced(uint mode, int count, uint type, byte[] indices, int instancecount)
		{
			m_DrawElementsInstanced_1(mode, count, type, indices, instancecount);
		}


		public void DrawElementsInstanced(uint mode, int count, uint type, ushort[] indices, int instancecount)
		{
			m_DrawElementsInstanced_2(mode, count, type, indices, instancecount);
		}


		public void DrawElementsInstanced(uint mode, int count, uint type, uint[] indices, int instancecount)
		{
			m_DrawElementsInstanced_3(mode, count, type, indices, instancecount);
		}


		public void DrawElementsInstancedBaseVertex(uint mode, int count, uint type, System.IntPtr indices, int instancecount, int basevertex)
		{
			m_DrawElementsInstancedBaseVertex_0(mode, count, type, indices, instancecount, basevertex);
		}


		public void DrawElementsInstancedBaseVertex(uint mode, int count, uint type, byte[] indices, int instancecount, int basevertex)
		{
			m_DrawElementsInstancedBaseVertex_1(mode, count, type, indices, instancecount, basevertex);
		}


		public void DrawElementsInstancedBaseVertex(uint mode, int count, uint type, ushort[] indices, int instancecount, int basevertex)
		{
			m_DrawElementsInstancedBaseVertex_2(mode, count, type, indices, instancecount, basevertex);
		}


		public void DrawElementsInstancedBaseVertex(uint mode, int count, uint type, uint[] indices, int instancecount, int basevertex)
		{
			m_DrawElementsInstancedBaseVertex_3(mode, count, type, indices, instancecount, basevertex);
		}


		public void DrawRangeElements(uint mode, uint start, uint end, int count, uint type, System.IntPtr indices)
		{
			m_DrawRangeElements_0(mode, start, end, count, type, indices);
		}


		public void DrawRangeElements(uint mode, uint start, uint end, int count, uint type, byte[] indices)
		{
			m_DrawRangeElements_1(mode, start, end, count, type, indices);
		}


		public void DrawRangeElements(uint mode, uint start, uint end, int count, uint type, ushort[] indices)
		{
			m_DrawRangeElements_2(mode, start, end, count, type, indices);
		}


		public void DrawRangeElements(uint mode, uint start, uint end, int count, uint type, uint[] indices)
		{
			m_DrawRangeElements_3(mode, start, end, count, type, indices);
		}


		public void DrawRangeElementsBaseVertex(uint mode, uint start, uint end, int count, uint type, System.IntPtr indices, int basevertex)
		{
			m_DrawRangeElementsBaseVertex_0(mode, start, end, count, type, indices, basevertex);
		}


		public void DrawRangeElementsBaseVertex(uint mode, uint start, uint end, int count, uint type, byte[] indices, int basevertex)
		{
			m_DrawRangeElementsBaseVertex_1(mode, start, end, count, type, indices, basevertex);
		}


		public void DrawRangeElementsBaseVertex(uint mode, uint start, uint end, int count, uint type, ushort[] indices, int basevertex)
		{
			m_DrawRangeElementsBaseVertex_2(mode, start, end, count, type, indices, basevertex);
		}


		public void DrawRangeElementsBaseVertex(uint mode, uint start, uint end, int count, uint type, uint[] indices, int basevertex)
		{
			m_DrawRangeElementsBaseVertex_3(mode, start, end, count, type, indices, basevertex);
		}


		public void Enable(uint cap)
		{
			m_Enable_0(cap);
		}


		public void Enablei(uint target, uint index)
		{
			m_Enablei_0(target, index);
		}


		public void EnableVertexAttribArray(uint index)
		{
			m_EnableVertexAttribArray_0(index);
		}


		public void EndConditionalRender()
		{
			m_EndConditionalRender_0();
		}


		public void EndQuery(uint target)
		{
			m_EndQuery_0(target);
		}


		public void EndTransformFeedback()
		{
			m_EndTransformFeedback_0();
		}


		public System.IntPtr FenceSync(uint condition, uint flags)
		{
			return m_FenceSync_0(condition, flags);
		}


		public void Finish()
		{
			m_Finish_0();
		}


		public void Flush()
		{
			m_Flush_0();
		}


		public void FlushMappedBufferRange(uint target, System.IntPtr offset, System.IntPtr length)
		{
			m_FlushMappedBufferRange_0(target, offset, length);
		}


		public void FramebufferRenderbuffer(uint target, uint attachment, uint renderbuffertarget, uint renderbuffer)
		{
			m_FramebufferRenderbuffer_0(target, attachment, renderbuffertarget, renderbuffer);
		}


		public void FramebufferTexture(uint target, uint attachment, uint texture, int level)
		{
			m_FramebufferTexture_0(target, attachment, texture, level);
		}


		public void FramebufferTexture1D(uint target, uint attachment, uint textarget, uint texture, int level)
		{
			m_FramebufferTexture1D_0(target, attachment, textarget, texture, level);
		}


		public void FramebufferTexture2D(uint target, uint attachment, uint textarget, uint texture, int level)
		{
			m_FramebufferTexture2D_0(target, attachment, textarget, texture, level);
		}


		public void FramebufferTexture3D(uint target, uint attachment, uint textarget, uint texture, int level, int zoffset)
		{
			m_FramebufferTexture3D_0(target, attachment, textarget, texture, level, zoffset);
		}


		public void FramebufferTextureLayer(uint target, uint attachment, uint texture, int level, int layer)
		{
			m_FramebufferTextureLayer_0(target, attachment, texture, level, layer);
		}


		public void FrontFace(uint mode)
		{
			m_FrontFace_0(mode);
		}


		public void GenBuffers(int n, System.IntPtr buffers)
		{
			m_GenBuffers_0(n, buffers);
		}


		public void GenBuffers(int n, uint[] buffers)
		{
			m_GenBuffers_1(n, buffers);
		}


		public void GenBuffers(int n, out uint buffers)
		{
			m_GenBuffers_2(n, out buffers);
		}


		public void GenerateMipmap(uint target)
		{
			m_GenerateMipmap_0(target);
		}


		public void GenFramebuffers(int n, System.IntPtr framebuffers)
		{
			m_GenFramebuffers_0(n, framebuffers);
		}


		public void GenFramebuffers(int n, uint[] framebuffers)
		{
			m_GenFramebuffers_1(n, framebuffers);
		}


		public void GenFramebuffers(int n, out uint framebuffers)
		{
			m_GenFramebuffers_2(n, out framebuffers);
		}


		public void GenQueries(int n, System.IntPtr ids)
		{
			m_GenQueries_0(n, ids);
		}


		public void GenQueries(int n, uint[] ids)
		{
			m_GenQueries_1(n, ids);
		}


		public void GenQueries(int n, out uint ids)
		{
			m_GenQueries_2(n, out ids);
		}


		public void GenRenderbuffers(int n, System.IntPtr renderbuffers)
		{
			m_GenRenderbuffers_0(n, renderbuffers);
		}


		public void GenRenderbuffers(int n, uint[] renderbuffers)
		{
			m_GenRenderbuffers_1(n, renderbuffers);
		}


		public void GenRenderbuffers(int n, out uint renderbuffers)
		{
			m_GenRenderbuffers_2(n, out renderbuffers);
		}


		public void GenTextures(int n, System.IntPtr textures)
		{
			m_GenTextures_0(n, textures);
		}


		public void GenTextures(int n, uint[] textures)
		{
			m_GenTextures_1(n, textures);
		}


		public void GenTextures(int n, out uint textures)
		{
			m_GenTextures_2(n, out textures);
		}


		public void GenVertexArrays(int n, System.IntPtr arrays)
		{
			m_GenVertexArrays_0(n, arrays);
		}


		public void GenVertexArrays(int n, uint[] arrays)
		{
			m_GenVertexArrays_1(n, arrays);
		}


		public void GenVertexArrays(int n, out uint arrays)
		{
			m_GenVertexArrays_2(n, out arrays);
		}


		public void GetActiveAttrib(uint program, uint index, int bufSize, System.IntPtr length, System.IntPtr size, System.IntPtr type, string name)
		{
			m_GetActiveAttrib_0(program, index, bufSize, length, size, type, name);
		}


		public void GetActiveAttrib(uint program, uint index, int bufSize, out int length, out int size, out uint type, byte[] name)
		{
			m_GetActiveAttrib_1(program, index, bufSize, out length, out size, out type, name);
		}


		public void GetActiveUniform(uint program, uint index, int bufSize, System.IntPtr length, System.IntPtr size, System.IntPtr type, string name)
		{
			m_GetActiveUniform_0(program, index, bufSize, length, size, type, name);
		}


		public void GetActiveUniform(uint program, uint index, int bufSize, out int length, out int size, out uint type, byte[] name)
		{
			m_GetActiveUniform_1(program, index, bufSize, out length, out size, out type, name);
		}


		public void GetActiveUniformBlockiv(uint program, uint uniformBlockIndex, uint pname, System.IntPtr _params)
		{
			m_GetActiveUniformBlockiv_0(program, uniformBlockIndex, pname, _params);
		}


		public void GetActiveUniformBlockiv(uint program, uint uniformBlockIndex, uint pname, int[] _params)
		{
			m_GetActiveUniformBlockiv_1(program, uniformBlockIndex, pname, _params);
		}


		public void GetActiveUniformBlockiv(uint program, uint uniformBlockIndex, uint pname, out int _params)
		{
			m_GetActiveUniformBlockiv_2(program, uniformBlockIndex, pname, out _params);
		}


		public void GetActiveUniformBlockName(uint program, uint uniformBlockIndex, int bufSize, System.IntPtr length, System.IntPtr uniformBlockName)
		{
			m_GetActiveUniformBlockName_0(program, uniformBlockIndex, bufSize, length, uniformBlockName);
		}


		public void GetActiveUniformBlockName(uint program, uint uniformBlockIndex, int bufSize, out int length, byte[] uniformBlockName)
		{
			m_GetActiveUniformBlockName_1(program, uniformBlockIndex, bufSize, out length, uniformBlockName);
		}


		public void GetActiveUniformName(uint program, uint uniformIndex, int bufSize, System.IntPtr length, System.IntPtr uniformName)
		{
			m_GetActiveUniformName_0(program, uniformIndex, bufSize, length, uniformName);
		}


		public void GetActiveUniformName(uint program, uint uniformIndex, int bufSize, out int length, byte[] uniformName)
		{
			m_GetActiveUniformName_1(program, uniformIndex, bufSize, out length, uniformName);
		}


		public void GetActiveUniformsiv(uint program, int uniformCount, System.IntPtr uniformIndices, uint pname, System.IntPtr _params)
		{
			m_GetActiveUniformsiv_0(program, uniformCount, uniformIndices, pname, _params);
		}


		public void GetActiveUniformsiv(uint program, int uniformCount, uint[] uniformIndices, uint pname, int[] _params)
		{
			m_GetActiveUniformsiv_1(program, uniformCount, uniformIndices, pname, _params);
		}


		public void GetActiveUniformsiv(uint program, int uniformCount, out int uniformIndices, uint pname, int[] _params)
		{
			m_GetActiveUniformsiv_2(program, uniformCount, out uniformIndices, pname, _params);
		}


		public void GetActiveUniformsiv(uint program, int uniformCount, uint[] uniformIndices, uint pname, ref int _params)
		{
			m_GetActiveUniformsiv_3(program, uniformCount, uniformIndices, pname, ref _params);
		}


		public void GetActiveUniformsiv(uint program, int uniformCount, out int uniformIndices, uint pname, ref int _params)
		{
			m_GetActiveUniformsiv_4(program, uniformCount, out uniformIndices, pname, ref _params);
		}


		public void GetAttachedShaders(uint program, int maxCount, System.IntPtr count, System.IntPtr shaders)
		{
			m_GetAttachedShaders_0(program, maxCount, count, shaders);
		}


		public void GetAttachedShaders(uint program, int maxCount, uint count, uint[] shaders)
		{
			m_GetAttachedShaders_1(program, maxCount, count, shaders);
		}


		public int GetAttribLocation(uint program, System.IntPtr name)
		{
			return m_GetAttribLocation_0(program, name);
		}


		public int GetAttribLocation(uint program, byte[] name)
		{
			return m_GetAttribLocation_1(program, name);
		}


		public int GetAttribLocation(uint program, string name)
		{
			return m_GetAttribLocation_2(program, name);
		}


		public void GetBooleani_v(uint target, uint index, System.IntPtr data)
		{
			m_GetBooleani_v_0(target, index, data);
		}


		public void GetBooleani_v(uint target, uint index, out bool data)
		{
			m_GetBooleani_v_1(target, index, out data);
		}


		public void GetBooleanv(uint pname, System.IntPtr data)
		{
			m_GetBooleanv_0(pname, data);
		}


		public void GetBooleanv(uint pname, out bool data)
		{
			m_GetBooleanv_1(pname, out data);
		}


		public void GetBufferParameteri64v(uint target, uint pname, System.IntPtr _params)
		{
			m_GetBufferParameteri64v_0(target, pname, _params);
		}


		public void GetBufferParameteri64v(uint target, uint pname, out long _params)
		{
			m_GetBufferParameteri64v_1(target, pname, out _params);
		}


		public void GetBufferParameteriv(uint target, uint pname, System.IntPtr _params)
		{
			m_GetBufferParameteriv_0(target, pname, _params);
		}


		public void GetBufferParameteriv(uint target, uint pname, out int _params)
		{
			m_GetBufferParameteriv_1(target, pname, out _params);
		}


		public void GetBufferPointerv(uint target, uint pname, System.IntPtr _params)
		{
			m_GetBufferPointerv_0(target, pname, _params);
		}


		public void GetBufferPointerv(uint target, uint pname, out System.IntPtr _params)
		{
			m_GetBufferPointerv_1(target, pname, out _params);
		}


		public void GetBufferSubData(uint target, System.IntPtr offset, System.IntPtr size, System.IntPtr data)
		{
			m_GetBufferSubData_0(target, offset, size, data);
		}


		public void GetCompressedTexImage(uint target, int level, System.IntPtr img)
		{
			m_GetCompressedTexImage_0(target, level, img);
		}


		public void GetDoublev(uint pname, System.IntPtr data)
		{
			m_GetDoublev_0(pname, data);
		}


		public void GetDoublev(uint pname, double[] data)
		{
			m_GetDoublev_1(pname, data);
		}


		public void GetDoublev(uint pname, out double data)
		{
			m_GetDoublev_2(pname, out data);
		}


		public void GetDoublev(uint pname, out Vector2d data)
		{
			m_GetDoublev_3(pname, out data);
		}


		public void GetDoublev(uint pname, out Vector3d data)
		{
			m_GetDoublev_4(pname, out data);
		}


		public void GetDoublev(uint pname, out Vector4d data)
		{
			m_GetDoublev_5(pname, out data);
		}


		public void GetDoublev(uint pname, out Color3d data)
		{
			m_GetDoublev_6(pname, out data);
		}


		public void GetDoublev(uint pname, out Color4d data)
		{
			m_GetDoublev_7(pname, out data);
		}


		public void GetDoublev(uint pname, out Box2d data)
		{
			m_GetDoublev_8(pname, out data);
		}


		public void GetDoublev(uint pname, out Box3d data)
		{
			m_GetDoublev_9(pname, out data);
		}


		public uint GetError()
		{
			return m_GetError_0();
		}


		public void GetFloatv(uint pname, System.IntPtr data)
		{
			m_GetFloatv_0(pname, data);
		}


		public void GetFloatv(uint pname, float[] data)
		{
			m_GetFloatv_1(pname, data);
		}


		public void GetFloatv(uint pname, out float data)
		{
			m_GetFloatv_2(pname, out data);
		}


		public void GetFloatv(uint pname, out Vector2 data)
		{
			m_GetFloatv_3(pname, out data);
		}


		public void GetFloatv(uint pname, out Vector3 data)
		{
			m_GetFloatv_4(pname, out data);
		}


		public void GetFloatv(uint pname, out Vector4 data)
		{
			m_GetFloatv_5(pname, out data);
		}


		public void GetFloatv(uint pname, out Color3 data)
		{
			m_GetFloatv_6(pname, out data);
		}


		public void GetFloatv(uint pname, out Color4 data)
		{
			m_GetFloatv_7(pname, out data);
		}


		public void GetFloatv(uint pname, out Box2 data)
		{
			m_GetFloatv_8(pname, out data);
		}


		public void GetFloatv(uint pname, out Box3 data)
		{
			m_GetFloatv_9(pname, out data);
		}


		public int GetFragDataLocation(uint program, string name)
		{
			return m_GetFragDataLocation_0(program, name);
		}


		public void GetFramebufferAttachmentParameteriv(uint target, uint attachment, uint pname, System.IntPtr _params)
		{
			m_GetFramebufferAttachmentParameteriv_0(target, attachment, pname, _params);
		}


		public void GetFramebufferAttachmentParameteriv(uint target, uint attachment, uint pname, out int _params)
		{
			m_GetFramebufferAttachmentParameteriv_1(target, attachment, pname, out _params);
		}


		public void GetInteger64i_v(uint target, uint index, System.IntPtr data)
		{
			m_GetInteger64i_v_0(target, index, data);
		}


		public void GetInteger64i_v(uint target, uint index, long[] data)
		{
			m_GetInteger64i_v_1(target, index, data);
		}


		public void GetInteger64i_v(uint target, uint index, out long data)
		{
			m_GetInteger64i_v_2(target, index, out data);
		}


		public void GetInteger64v(uint pname, System.IntPtr data)
		{
			m_GetInteger64v_0(pname, data);
		}


		public void GetInteger64v(uint pname, long[] data)
		{
			m_GetInteger64v_1(pname, data);
		}


		public void GetInteger64v(uint pname, out long data)
		{
			m_GetInteger64v_2(pname, out data);
		}


		public void GetIntegeri_v(uint target, uint index, System.IntPtr data)
		{
			m_GetIntegeri_v_0(target, index, data);
		}


		public void GetIntegeri_v(uint target, uint index, int[] data)
		{
			m_GetIntegeri_v_1(target, index, data);
		}


		public void GetIntegeri_v(uint target, uint index, out int data)
		{
			m_GetIntegeri_v_2(target, index, out data);
		}


		public void GetIntegerv(uint pname, System.IntPtr data)
		{
			m_GetIntegerv_0(pname, data);
		}


		public void GetIntegerv(uint pname, int[] data)
		{
			m_GetIntegerv_1(pname, data);
		}


		public void GetIntegerv(uint pname, out int data)
		{
			m_GetIntegerv_2(pname, out data);
		}


		public void GetMultisamplefv(uint pname, uint index, System.IntPtr val)
		{
			m_GetMultisamplefv_0(pname, index, val);
		}


		public void GetMultisamplefv(uint pname, uint index, out float val)
		{
			m_GetMultisamplefv_1(pname, index, out val);
		}


		public void GetProgramInfoLog(uint program, int bufSize, System.IntPtr length, string infoLog)
		{
			m_GetProgramInfoLog_0(program, bufSize, length, infoLog);
		}


		public void GetProgramInfoLog(uint program, int bufSize, out int length, byte[] infoLog)
		{
			m_GetProgramInfoLog_1(program, bufSize, out length, infoLog);
		}


		public void GetProgramiv(uint program, uint pname, System.IntPtr _params)
		{
			m_GetProgramiv_0(program, pname, _params);
		}


		public void GetProgramiv(uint program, uint pname, int[] _params)
		{
			m_GetProgramiv_1(program, pname, _params);
		}


		public void GetProgramiv(uint program, uint pname, out int _params)
		{
			m_GetProgramiv_2(program, pname, out _params);
		}


		public void GetQueryiv(uint target, uint pname, System.IntPtr _params)
		{
			m_GetQueryiv_0(target, pname, _params);
		}


		public void GetQueryObjectiv(uint id, uint pname, System.IntPtr _params)
		{
			m_GetQueryObjectiv_0(id, pname, _params);
		}


		public void GetQueryObjectuiv(uint id, uint pname, System.IntPtr _params)
		{
			m_GetQueryObjectuiv_0(id, pname, _params);
		}


		public void GetRenderbufferParameteriv(uint target, uint pname, System.IntPtr _params)
		{
			m_GetRenderbufferParameteriv_0(target, pname, _params);
		}


		public void GetShaderInfoLog(uint shader, int bufSize, System.IntPtr length, string infoLog)
		{
			m_GetShaderInfoLog_0(shader, bufSize, length, infoLog);
		}


		public void GetShaderInfoLog(uint shader, int bufSize, out int length, byte[] infoLog)
		{
			m_GetShaderInfoLog_1(shader, bufSize, out length, infoLog);
		}


		public void GetShaderiv(uint shader, uint pname, System.IntPtr _params)
		{
			m_GetShaderiv_0(shader, pname, _params);
		}


		public void GetShaderiv(uint shader, uint pname, int[] _params)
		{
			m_GetShaderiv_1(shader, pname, _params);
		}


		public void GetShaderiv(uint shader, uint pname, out int _params)
		{
			m_GetShaderiv_2(shader, pname, out _params);
		}


		public void GetShaderSource(uint shader, int bufSize, System.IntPtr length, string source)
		{
			m_GetShaderSource_0(shader, bufSize, length, source);
		}


		public System.IntPtr GetString(uint name)
		{
			return m_GetString_0(name);
		}


		public System.IntPtr GetStringi(uint name, uint index)
		{
			return m_GetStringi_0(name, index);
		}


		public void GetSynciv(System.IntPtr sync, uint pname, int bufSize, System.IntPtr length, System.IntPtr values)
		{
			m_GetSynciv_0(sync, pname, bufSize, length, values);
		}


		public void GetTexImage(uint target, int level, uint format, uint type, System.IntPtr pixels)
		{
			m_GetTexImage_0(target, level, format, type, pixels);
		}


		public void GetTexLevelParameterfv(uint target, int level, uint pname, System.IntPtr _params)
		{
			m_GetTexLevelParameterfv_0(target, level, pname, _params);
		}


		public void GetTexLevelParameteriv(uint target, int level, uint pname, System.IntPtr _params)
		{
			m_GetTexLevelParameteriv_0(target, level, pname, _params);
		}


		public void GetTexParameterfv(uint target, uint pname, System.IntPtr _params)
		{
			m_GetTexParameterfv_0(target, pname, _params);
		}


		public void GetTexParameterIiv(uint target, uint pname, System.IntPtr _params)
		{
			m_GetTexParameterIiv_0(target, pname, _params);
		}


		public void GetTexParameterIuiv(uint target, uint pname, System.IntPtr _params)
		{
			m_GetTexParameterIuiv_0(target, pname, _params);
		}


		public void GetTexParameteriv(uint target, uint pname, System.IntPtr _params)
		{
			m_GetTexParameteriv_0(target, pname, _params);
		}


		public void GetTransformFeedbackVarying(uint program, uint index, int bufSize, System.IntPtr length, System.IntPtr size, System.IntPtr type, string name)
		{
			m_GetTransformFeedbackVarying_0(program, index, bufSize, length, size, type, name);
		}


		public uint GetUniformBlockIndex(uint program, string uniformBlockName)
		{
			return m_GetUniformBlockIndex_0(program, uniformBlockName);
		}


		public void GetUniformfv(uint program, int location, System.IntPtr _params)
		{
			m_GetUniformfv_0(program, location, _params);
		}


		public void GetUniformIndices(uint program, int uniformCount, System.IntPtr uniformNames, System.IntPtr uniformIndices)
		{
			m_GetUniformIndices_0(program, uniformCount, uniformNames, uniformIndices);
		}


		public void GetUniformiv(uint program, int location, System.IntPtr _params)
		{
			m_GetUniformiv_0(program, location, _params);
		}


		public int GetUniformLocation(uint program, System.IntPtr name)
		{
			return m_GetUniformLocation_0(program, name);
		}


		public int GetUniformLocation(uint program, byte[] name)
		{
			return m_GetUniformLocation_1(program, name);
		}


		public int GetUniformLocation(uint program, string name)
		{
			return m_GetUniformLocation_2(program, name);
		}


		public void GetUniformuiv(uint program, int location, System.IntPtr _params)
		{
			m_GetUniformuiv_0(program, location, _params);
		}


		public void GetVertexAttribdv(uint index, uint pname, System.IntPtr _params)
		{
			m_GetVertexAttribdv_0(index, pname, _params);
		}


		public void GetVertexAttribfv(uint index, uint pname, System.IntPtr _params)
		{
			m_GetVertexAttribfv_0(index, pname, _params);
		}


		public void GetVertexAttribIiv(uint index, uint pname, System.IntPtr _params)
		{
			m_GetVertexAttribIiv_0(index, pname, _params);
		}


		public void GetVertexAttribIuiv(uint index, uint pname, System.IntPtr _params)
		{
			m_GetVertexAttribIuiv_0(index, pname, _params);
		}


		public void GetVertexAttribiv(uint index, uint pname, System.IntPtr _params)
		{
			m_GetVertexAttribiv_0(index, pname, _params);
		}


		public void GetVertexAttribPointerv(uint index, uint pname, System.IntPtr pointer)
		{
			m_GetVertexAttribPointerv_0(index, pname, pointer);
		}


		public void Hint(uint target, uint mode)
		{
			m_Hint_0(target, mode);
		}


		public bool IsBuffer(uint buffer)
		{
			return m_IsBuffer_0(buffer);
		}


		public bool IsEnabled(uint cap)
		{
			return m_IsEnabled_0(cap);
		}


		public bool IsEnabledi(uint target, uint index)
		{
			return m_IsEnabledi_0(target, index);
		}


		public bool IsFramebuffer(uint framebuffer)
		{
			return m_IsFramebuffer_0(framebuffer);
		}


		public bool IsProgram(uint program)
		{
			return m_IsProgram_0(program);
		}


		public bool IsQuery(uint id)
		{
			return m_IsQuery_0(id);
		}


		public bool IsRenderbuffer(uint renderbuffer)
		{
			return m_IsRenderbuffer_0(renderbuffer);
		}


		public bool IsShader(uint shader)
		{
			return m_IsShader_0(shader);
		}


		public bool IsSync(System.IntPtr sync)
		{
			return m_IsSync_0(sync);
		}


		public bool IsTexture(uint texture)
		{
			return m_IsTexture_0(texture);
		}


		public bool IsVertexArray(uint array)
		{
			return m_IsVertexArray_0(array);
		}


		public void LineWidth(float width)
		{
			m_LineWidth_0(width);
		}


		public void LinkProgram(uint program)
		{
			m_LinkProgram_0(program);
		}


		public void LogicOp(uint opcode)
		{
			m_LogicOp_0(opcode);
		}


		public System.IntPtr MapBuffer(uint target, uint access)
		{
			return m_MapBuffer_0(target, access);
		}


		public System.IntPtr MapBufferRange(uint target, System.IntPtr offset, System.IntPtr length, uint access)
		{
			return m_MapBufferRange_0(target, offset, length, access);
		}


		public void MultiDrawArrays(uint mode, System.IntPtr first, System.IntPtr count, int drawcount)
		{
			m_MultiDrawArrays_0(mode, first, count, drawcount);
		}


		public void MultiDrawElements(uint mode, System.IntPtr count, uint type, System.IntPtr indices, int drawcount)
		{
			m_MultiDrawElements_0(mode, count, type, indices, drawcount);
		}


		public void MultiDrawElementsBaseVertex(uint mode, System.IntPtr count, uint type, System.IntPtr indices, int drawcount, System.IntPtr basevertex)
		{
			m_MultiDrawElementsBaseVertex_0(mode, count, type, indices, drawcount, basevertex);
		}


		public void PixelStoref(uint pname, float param)
		{
			m_PixelStoref_0(pname, param);
		}


		public void PixelStorei(uint pname, int param)
		{
			m_PixelStorei_0(pname, param);
		}


		public void PointParameterf(uint pname, float param)
		{
			m_PointParameterf_0(pname, param);
		}


		public void PointParameterfv(uint pname, System.IntPtr _params)
		{
			m_PointParameterfv_0(pname, _params);
		}


		public void PointParameteri(uint pname, int param)
		{
			m_PointParameteri_0(pname, param);
		}


		public void PointParameteriv(uint pname, System.IntPtr _params)
		{
			m_PointParameteriv_0(pname, _params);
		}


		public void PointSize(float size)
		{
			m_PointSize_0(size);
		}


		public void PolygonMode(uint face, uint mode)
		{
			m_PolygonMode_0(face, mode);
		}


		public void PolygonOffset(float factor, float units)
		{
			m_PolygonOffset_0(factor, units);
		}


		public void PrimitiveRestartIndex(uint index)
		{
			m_PrimitiveRestartIndex_0(index);
		}


		public void ProvokingVertex(uint mode)
		{
			m_ProvokingVertex_0(mode);
		}


		public void ReadBuffer(uint mode)
		{
			m_ReadBuffer_0(mode);
		}


		public void ReadPixels(int x, int y, int width, int height, uint format, uint type, System.IntPtr pixels)
		{
			m_ReadPixels_0(x, y, width, height, format, type, pixels);
		}


		public void RenderbufferStorage(uint target, uint internalformat, int width, int height)
		{
			m_RenderbufferStorage_0(target, internalformat, width, height);
		}


		public void RenderbufferStorageMultisample(uint target, int samples, uint internalformat, int width, int height)
		{
			m_RenderbufferStorageMultisample_0(target, samples, internalformat, width, height);
		}


		public void SampleCoverage(float value, bool invert)
		{
			m_SampleCoverage_0(value, invert);
		}


		public void SampleMaski(uint index, uint mask)
		{
			m_SampleMaski_0(index, mask);
		}


		public void Scissor(int x, int y, int width, int height)
		{
			m_Scissor_0(x, y, width, height);
		}


		public void ShaderSource(uint shader, int count, System.IntPtr _string, System.IntPtr length)
		{
			m_ShaderSource_0(shader, count, _string, length);
		}


		public void ShaderSource(uint shader, int count, IntPtr[] _string, int[] length)
		{
			m_ShaderSource_1(shader, count, _string, length);
		}


		public void StencilFunc(uint func, int _ref, uint mask)
		{
			m_StencilFunc_0(func, _ref, mask);
		}


		public void StencilFuncSeparate(uint face, uint func, int _ref, uint mask)
		{
			m_StencilFuncSeparate_0(face, func, _ref, mask);
		}


		public void StencilMask(uint mask)
		{
			m_StencilMask_0(mask);
		}


		public void StencilMaskSeparate(uint face, uint mask)
		{
			m_StencilMaskSeparate_0(face, mask);
		}


		public void StencilOp(uint fail, uint zfail, uint zpass)
		{
			m_StencilOp_0(fail, zfail, zpass);
		}


		public void StencilOpSeparate(uint face, uint sfail, uint dpfail, uint dppass)
		{
			m_StencilOpSeparate_0(face, sfail, dpfail, dppass);
		}


		public void TexBuffer(uint target, uint internalformat, uint buffer)
		{
			m_TexBuffer_0(target, internalformat, buffer);
		}


		public void TexImage1D(uint target, int level, int internalformat, int width, int border, uint format, uint type, System.IntPtr pixels)
		{
			m_TexImage1D_0(target, level, internalformat, width, border, format, type, pixels);
		}


		public void TexImage2D(uint target, int level, int internalformat, int width, int height, int border, uint format, uint type, System.IntPtr pixels)
		{
			m_TexImage2D_0(target, level, internalformat, width, height, border, format, type, pixels);
		}


		public void TexImage2DMultisample(uint target, int samples, uint internalformat, int width, int height, bool fixedsamplelocations)
		{
			m_TexImage2DMultisample_0(target, samples, internalformat, width, height, fixedsamplelocations);
		}


		public void TexImage3D(uint target, int level, int internalformat, int width, int height, int depth, int border, uint format, uint type, System.IntPtr pixels)
		{
			m_TexImage3D_0(target, level, internalformat, width, height, depth, border, format, type, pixels);
		}


		public void TexImage3DMultisample(uint target, int samples, uint internalformat, int width, int height, int depth, bool fixedsamplelocations)
		{
			m_TexImage3DMultisample_0(target, samples, internalformat, width, height, depth, fixedsamplelocations);
		}


		public void TexParameterf(uint target, uint pname, float param)
		{
			m_TexParameterf_0(target, pname, param);
		}


		public void TexParameterfv(uint target, uint pname, System.IntPtr _params)
		{
			m_TexParameterfv_0(target, pname, _params);
		}


		public void TexParameteri(uint target, uint pname, int param)
		{
			m_TexParameteri_0(target, pname, param);
		}


		public void TexParameterIiv(uint target, uint pname, System.IntPtr _params)
		{
			m_TexParameterIiv_0(target, pname, _params);
		}


		public void TexParameterIuiv(uint target, uint pname, System.IntPtr _params)
		{
			m_TexParameterIuiv_0(target, pname, _params);
		}


		public void TexParameteriv(uint target, uint pname, System.IntPtr _params)
		{
			m_TexParameteriv_0(target, pname, _params);
		}


		public void TexSubImage1D(uint target, int level, int xoffset, int width, uint format, uint type, System.IntPtr pixels)
		{
			m_TexSubImage1D_0(target, level, xoffset, width, format, type, pixels);
		}


		public void TexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, System.IntPtr pixels)
		{
			m_TexSubImage2D_0(target, level, xoffset, yoffset, width, height, format, type, pixels);
		}


		public void TexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, System.IntPtr pixels)
		{
			m_TexSubImage3D_0(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
		}


		public void TransformFeedbackVaryings(uint program, int count, System.IntPtr varyings, uint bufferMode)
		{
			m_TransformFeedbackVaryings_0(program, count, varyings, bufferMode);
		}


		public void Uniform1f(int location, float v0)
		{
			m_Uniform1f_0(location, v0);
		}


		public void Uniform1fv(int location, int count, System.IntPtr value)
		{
			m_Uniform1fv_0(location, count, value);
		}


		public void Uniform1i(int location, int v0)
		{
			m_Uniform1i_0(location, v0);
		}


		public void Uniform1iv(int location, int count, System.IntPtr value)
		{
			m_Uniform1iv_0(location, count, value);
		}


		public void Uniform1ui(int location, uint v0)
		{
			m_Uniform1ui_0(location, v0);
		}


		public void Uniform1uiv(int location, int count, System.IntPtr value)
		{
			m_Uniform1uiv_0(location, count, value);
		}


		public void Uniform2f(int location, float v0, float v1)
		{
			m_Uniform2f_0(location, v0, v1);
		}


		public void Uniform2fv(int location, int count, System.IntPtr value)
		{
			m_Uniform2fv_0(location, count, value);
		}


		public void Uniform2i(int location, int v0, int v1)
		{
			m_Uniform2i_0(location, v0, v1);
		}


		public void Uniform2iv(int location, int count, System.IntPtr value)
		{
			m_Uniform2iv_0(location, count, value);
		}


		public void Uniform2ui(int location, uint v0, uint v1)
		{
			m_Uniform2ui_0(location, v0, v1);
		}


		public void Uniform2uiv(int location, int count, System.IntPtr value)
		{
			m_Uniform2uiv_0(location, count, value);
		}


		public void Uniform3f(int location, float v0, float v1, float v2)
		{
			m_Uniform3f_0(location, v0, v1, v2);
		}


		public void Uniform3fv(int location, int count, System.IntPtr value)
		{
			m_Uniform3fv_0(location, count, value);
		}


		public void Uniform3i(int location, int v0, int v1, int v2)
		{
			m_Uniform3i_0(location, v0, v1, v2);
		}


		public void Uniform3iv(int location, int count, System.IntPtr value)
		{
			m_Uniform3iv_0(location, count, value);
		}


		public void Uniform3ui(int location, uint v0, uint v1, uint v2)
		{
			m_Uniform3ui_0(location, v0, v1, v2);
		}


		public void Uniform3uiv(int location, int count, System.IntPtr value)
		{
			m_Uniform3uiv_0(location, count, value);
		}


		public void Uniform4f(int location, float v0, float v1, float v2, float v3)
		{
			m_Uniform4f_0(location, v0, v1, v2, v3);
		}


		public void Uniform4fv(int location, int count, System.IntPtr value)
		{
			m_Uniform4fv_0(location, count, value);
		}


		public void Uniform4i(int location, int v0, int v1, int v2, int v3)
		{
			m_Uniform4i_0(location, v0, v1, v2, v3);
		}


		public void Uniform4iv(int location, int count, System.IntPtr value)
		{
			m_Uniform4iv_0(location, count, value);
		}


		public void Uniform4ui(int location, uint v0, uint v1, uint v2, uint v3)
		{
			m_Uniform4ui_0(location, v0, v1, v2, v3);
		}


		public void Uniform4uiv(int location, int count, System.IntPtr value)
		{
			m_Uniform4uiv_0(location, count, value);
		}


		public void UniformBlockBinding(uint program, uint uniformBlockIndex, uint uniformBlockBinding)
		{
			m_UniformBlockBinding_0(program, uniformBlockIndex, uniformBlockBinding);
		}


		public void UniformMatrix2fv(int location, int count, bool transpose, System.IntPtr value)
		{
			m_UniformMatrix2fv_0(location, count, transpose, value);
		}


		public void UniformMatrix2fv(int location, int count, bool transpose, float[] value)
		{
			m_UniformMatrix2fv_1(location, count, transpose, value);
		}


		public void UniformMatrix2fv(int location, int count, bool transpose, ref Matrix2 value)
		{
			m_UniformMatrix2fv_2(location, count, transpose, ref value);
		}


		public void UniformMatrix2x3fv(int location, int count, bool transpose, System.IntPtr value)
		{
			m_UniformMatrix2x3fv_0(location, count, transpose, value);
		}


		public void UniformMatrix2x4fv(int location, int count, bool transpose, System.IntPtr value)
		{
			m_UniformMatrix2x4fv_0(location, count, transpose, value);
		}


		public void UniformMatrix3fv(int location, int count, bool transpose, System.IntPtr value)
		{
			m_UniformMatrix3fv_0(location, count, transpose, value);
		}


		public void UniformMatrix3fv(int location, int count, bool transpose, float[] value)
		{
			m_UniformMatrix3fv_1(location, count, transpose, value);
		}


		public void UniformMatrix3fv(int location, int count, bool transpose, ref Matrix3 value)
		{
			m_UniformMatrix3fv_2(location, count, transpose, ref value);
		}


		public void UniformMatrix3x2fv(int location, int count, bool transpose, System.IntPtr value)
		{
			m_UniformMatrix3x2fv_0(location, count, transpose, value);
		}


		public void UniformMatrix3x4fv(int location, int count, bool transpose, System.IntPtr value)
		{
			m_UniformMatrix3x4fv_0(location, count, transpose, value);
		}


		public void UniformMatrix4fv(int location, int count, bool transpose, System.IntPtr value)
		{
			m_UniformMatrix4fv_0(location, count, transpose, value);
		}


		public void UniformMatrix4fv(int location, int count, bool transpose, float[] value)
		{
			m_UniformMatrix4fv_1(location, count, transpose, value);
		}


		public void UniformMatrix4fv(int location, int count, bool transpose, ref Matrix4 value)
		{
			m_UniformMatrix4fv_2(location, count, transpose, ref value);
		}


		public void UniformMatrix4x2fv(int location, int count, bool transpose, System.IntPtr value)
		{
			m_UniformMatrix4x2fv_0(location, count, transpose, value);
		}


		public void UniformMatrix4x3fv(int location, int count, bool transpose, System.IntPtr value)
		{
			m_UniformMatrix4x3fv_0(location, count, transpose, value);
		}


		public bool UnmapBuffer(uint target)
		{
			return m_UnmapBuffer_0(target);
		}


		public void UseProgram(uint program)
		{
			m_UseProgram_0(program);
		}


		public void ValidateProgram(uint program)
		{
			m_ValidateProgram_0(program);
		}


		public void VertexAttrib1d(uint index, double x)
		{
			m_VertexAttrib1d_0(index, x);
		}


		public void VertexAttrib1dv(uint index, System.IntPtr v)
		{
			m_VertexAttrib1dv_0(index, v);
		}


		public void VertexAttrib1f(uint index, float x)
		{
			m_VertexAttrib1f_0(index, x);
		}


		public void VertexAttrib1fv(uint index, System.IntPtr v)
		{
			m_VertexAttrib1fv_0(index, v);
		}


		public void VertexAttrib1s(uint index, short x)
		{
			m_VertexAttrib1s_0(index, x);
		}


		public void VertexAttrib1sv(uint index, System.IntPtr v)
		{
			m_VertexAttrib1sv_0(index, v);
		}


		public void VertexAttrib2d(uint index, double x, double y)
		{
			m_VertexAttrib2d_0(index, x, y);
		}


		public void VertexAttrib2dv(uint index, System.IntPtr v)
		{
			m_VertexAttrib2dv_0(index, v);
		}


		public void VertexAttrib2f(uint index, float x, float y)
		{
			m_VertexAttrib2f_0(index, x, y);
		}


		public void VertexAttrib2fv(uint index, System.IntPtr v)
		{
			m_VertexAttrib2fv_0(index, v);
		}


		public void VertexAttrib2s(uint index, short x, short y)
		{
			m_VertexAttrib2s_0(index, x, y);
		}


		public void VertexAttrib2sv(uint index, System.IntPtr v)
		{
			m_VertexAttrib2sv_0(index, v);
		}


		public void VertexAttrib3d(uint index, double x, double y, double z)
		{
			m_VertexAttrib3d_0(index, x, y, z);
		}


		public void VertexAttrib3dv(uint index, System.IntPtr v)
		{
			m_VertexAttrib3dv_0(index, v);
		}


		public void VertexAttrib3f(uint index, float x, float y, float z)
		{
			m_VertexAttrib3f_0(index, x, y, z);
		}


		public void VertexAttrib3fv(uint index, System.IntPtr v)
		{
			m_VertexAttrib3fv_0(index, v);
		}


		public void VertexAttrib3s(uint index, short x, short y, short z)
		{
			m_VertexAttrib3s_0(index, x, y, z);
		}


		public void VertexAttrib3sv(uint index, System.IntPtr v)
		{
			m_VertexAttrib3sv_0(index, v);
		}


		public void VertexAttrib4bv(uint index, System.IntPtr v)
		{
			m_VertexAttrib4bv_0(index, v);
		}


		public void VertexAttrib4d(uint index, double x, double y, double z, double w)
		{
			m_VertexAttrib4d_0(index, x, y, z, w);
		}


		public void VertexAttrib4dv(uint index, System.IntPtr v)
		{
			m_VertexAttrib4dv_0(index, v);
		}


		public void VertexAttrib4f(uint index, float x, float y, float z, float w)
		{
			m_VertexAttrib4f_0(index, x, y, z, w);
		}


		public void VertexAttrib4fv(uint index, System.IntPtr v)
		{
			m_VertexAttrib4fv_0(index, v);
		}


		public void VertexAttrib4iv(uint index, System.IntPtr v)
		{
			m_VertexAttrib4iv_0(index, v);
		}


		public void VertexAttrib4Nbv(uint index, System.IntPtr v)
		{
			m_VertexAttrib4Nbv_0(index, v);
		}


		public void VertexAttrib4Niv(uint index, System.IntPtr v)
		{
			m_VertexAttrib4Niv_0(index, v);
		}


		public void VertexAttrib4Nsv(uint index, System.IntPtr v)
		{
			m_VertexAttrib4Nsv_0(index, v);
		}


		public void VertexAttrib4Nub(uint index, byte x, byte y, byte z, byte w)
		{
			m_VertexAttrib4Nub_0(index, x, y, z, w);
		}


		public void VertexAttrib4Nubv(uint index, System.IntPtr v)
		{
			m_VertexAttrib4Nubv_0(index, v);
		}


		public void VertexAttrib4Nuiv(uint index, System.IntPtr v)
		{
			m_VertexAttrib4Nuiv_0(index, v);
		}


		public void VertexAttrib4Nusv(uint index, System.IntPtr v)
		{
			m_VertexAttrib4Nusv_0(index, v);
		}


		public void VertexAttrib4s(uint index, short x, short y, short z, short w)
		{
			m_VertexAttrib4s_0(index, x, y, z, w);
		}


		public void VertexAttrib4sv(uint index, System.IntPtr v)
		{
			m_VertexAttrib4sv_0(index, v);
		}


		public void VertexAttrib4ubv(uint index, System.IntPtr v)
		{
			m_VertexAttrib4ubv_0(index, v);
		}


		public void VertexAttrib4uiv(uint index, System.IntPtr v)
		{
			m_VertexAttrib4uiv_0(index, v);
		}


		public void VertexAttrib4usv(uint index, System.IntPtr v)
		{
			m_VertexAttrib4usv_0(index, v);
		}


		public void VertexAttribI1i(uint index, int x)
		{
			m_VertexAttribI1i_0(index, x);
		}


		public void VertexAttribI1iv(uint index, System.IntPtr v)
		{
			m_VertexAttribI1iv_0(index, v);
		}


		public void VertexAttribI1ui(uint index, uint x)
		{
			m_VertexAttribI1ui_0(index, x);
		}


		public void VertexAttribI1uiv(uint index, System.IntPtr v)
		{
			m_VertexAttribI1uiv_0(index, v);
		}


		public void VertexAttribI2i(uint index, int x, int y)
		{
			m_VertexAttribI2i_0(index, x, y);
		}


		public void VertexAttribI2iv(uint index, System.IntPtr v)
		{
			m_VertexAttribI2iv_0(index, v);
		}


		public void VertexAttribI2ui(uint index, uint x, uint y)
		{
			m_VertexAttribI2ui_0(index, x, y);
		}


		public void VertexAttribI2uiv(uint index, System.IntPtr v)
		{
			m_VertexAttribI2uiv_0(index, v);
		}


		public void VertexAttribI3i(uint index, int x, int y, int z)
		{
			m_VertexAttribI3i_0(index, x, y, z);
		}


		public void VertexAttribI3iv(uint index, System.IntPtr v)
		{
			m_VertexAttribI3iv_0(index, v);
		}


		public void VertexAttribI3ui(uint index, uint x, uint y, uint z)
		{
			m_VertexAttribI3ui_0(index, x, y, z);
		}


		public void VertexAttribI3uiv(uint index, System.IntPtr v)
		{
			m_VertexAttribI3uiv_0(index, v);
		}


		public void VertexAttribI4bv(uint index, System.IntPtr v)
		{
			m_VertexAttribI4bv_0(index, v);
		}


		public void VertexAttribI4i(uint index, int x, int y, int z, int w)
		{
			m_VertexAttribI4i_0(index, x, y, z, w);
		}


		public void VertexAttribI4iv(uint index, System.IntPtr v)
		{
			m_VertexAttribI4iv_0(index, v);
		}


		public void VertexAttribI4sv(uint index, System.IntPtr v)
		{
			m_VertexAttribI4sv_0(index, v);
		}


		public void VertexAttribI4ubv(uint index, System.IntPtr v)
		{
			m_VertexAttribI4ubv_0(index, v);
		}


		public void VertexAttribI4ui(uint index, uint x, uint y, uint z, uint w)
		{
			m_VertexAttribI4ui_0(index, x, y, z, w);
		}


		public void VertexAttribI4uiv(uint index, System.IntPtr v)
		{
			m_VertexAttribI4uiv_0(index, v);
		}


		public void VertexAttribI4usv(uint index, System.IntPtr v)
		{
			m_VertexAttribI4usv_0(index, v);
		}


		public void VertexAttribIPointer(uint index, int size, uint type, int stride, System.IntPtr pointer)
		{
			m_VertexAttribIPointer_0(index, size, type, stride, pointer);
		}


		public void VertexAttribPointer(uint index, int size, uint type, bool normalized, int stride, System.IntPtr pointer)
		{
			m_VertexAttribPointer_0(index, size, type, normalized, stride, pointer);
		}


		public void Viewport(int x, int y, int width, int height)
		{
			m_Viewport_0(x, y, width, height);
		}


		public void Viewport(Box2i dimensions)
		{
			m_Viewport_1(dimensions);
		}


		public void WaitSync(System.IntPtr sync, uint flags, ulong timeout)
		{
			m_WaitSync_0(sync, flags, timeout);
		}


		public void BindFragDataLocationIndexed(uint program, uint colorNumber, uint index, System.IntPtr name)
		{
			m_BindFragDataLocationIndexed_0(program, colorNumber, index, name);
		}


		public int GetFragDataIndex(uint program, System.IntPtr name)
		{
			return m_GetFragDataIndex_0(program, name);
		}


		public void GenSamplers(int count, System.IntPtr samplers)
		{
			m_GenSamplers_0(count, samplers);
		}


		public void GenSamplers(int n, uint[] samplers)
		{
			m_GenSamplers_1(n, samplers);
		}


		public void GenSamplers(int n, out uint samplers)
		{
			m_GenSamplers_2(n, out samplers);
		}


		public void DeleteSamplers(int count, System.IntPtr samplers)
		{
			m_DeleteSamplers_0(count, samplers);
		}


		public void DeleteSamplers(int n, uint[] samplers)
		{
			m_DeleteSamplers_1(n, samplers);
		}


		public void DeleteSamplers(int n, ref uint samplers)
		{
			m_DeleteSamplers_2(n, ref samplers);
		}


		public bool IsSampler(uint shader)
		{
			return m_IsSampler_0(shader);
		}


		public void BindSampler(uint unit, uint sampler)
		{
			m_BindSampler_0(unit, sampler);
		}


		public void SamplerParameteri(uint sampler, uint pname, int param)
		{
			m_SamplerParameteri_0(sampler, pname, param);
		}


		public void SamplerParameteriv(uint sampler, uint pname, System.IntPtr param)
		{
			m_SamplerParameteriv_0(sampler, pname, param);
		}


		public void SamplerParameterf(uint sampler, uint pname, float param)
		{
			m_SamplerParameterf_0(sampler, pname, param);
		}


		public void SamplerParameterfv(uint sampler, uint pname, System.IntPtr param)
		{
			m_SamplerParameterfv_0(sampler, pname, param);
		}


		public void SamplerParameterIiv(uint sampler, uint pname, System.IntPtr param)
		{
			m_SamplerParameterIiv_0(sampler, pname, param);
		}


		public void SamplerParameterIuiv(uint sampler, uint pname, System.IntPtr param)
		{
			m_SamplerParameterIuiv_0(sampler, pname, param);
		}


		public void GetSamplerParameteriv(uint sampler, uint pname, System.IntPtr _params)
		{
			m_GetSamplerParameteriv_0(sampler, pname, _params);
		}


		public void GetSamplerParameterIiv(uint sampler, uint pname, System.IntPtr _params)
		{
			m_GetSamplerParameterIiv_0(sampler, pname, _params);
		}


		public void GetSamplerParameterfv(uint sampler, uint pname, System.IntPtr _params)
		{
			m_GetSamplerParameterfv_0(sampler, pname, _params);
		}


		public void GetSamplerParameterIuiv(uint sampler, uint pname, System.IntPtr _params)
		{
			m_GetSamplerParameterIuiv_0(sampler, pname, _params);
		}


		public void QueryCounter(uint id, uint target)
		{
			m_QueryCounter_0(id, target);
		}


		public void GetQueryObjecti64v(uint id, uint pname, System.IntPtr _params)
		{
			m_GetQueryObjecti64v_0(id, pname, _params);
		}


		public void GetQueryObjectui64v(uint id, uint pname, System.IntPtr _params)
		{
			m_GetQueryObjectui64v_0(id, pname, _params);
		}


		public void VertexAttribDivisor(uint index, uint divisor)
		{
			m_VertexAttribDivisor_0(index, divisor);
		}


		public void VertexAttribP1ui(uint index, uint type, bool normalized, uint value)
		{
			m_VertexAttribP1ui_0(index, type, normalized, value);
		}


		public void VertexAttribP1uiv(uint index, uint type, bool normalized, System.IntPtr value)
		{
			m_VertexAttribP1uiv_0(index, type, normalized, value);
		}


		public void VertexAttribP2ui(uint index, uint type, bool normalized, uint value)
		{
			m_VertexAttribP2ui_0(index, type, normalized, value);
		}


		public void VertexAttribP2uiv(uint index, uint type, bool normalized, System.IntPtr value)
		{
			m_VertexAttribP2uiv_0(index, type, normalized, value);
		}


		public void VertexAttribP3ui(uint index, uint type, bool normalized, uint value)
		{
			m_VertexAttribP3ui_0(index, type, normalized, value);
		}


		public void VertexAttribP3uiv(uint index, uint type, bool normalized, System.IntPtr value)
		{
			m_VertexAttribP3uiv_0(index, type, normalized, value);
		}


		public void VertexAttribP4ui(uint index, uint type, bool normalized, uint value)
		{
			m_VertexAttribP4ui_0(index, type, normalized, value);
		}


		public void VertexAttribP4uiv(uint index, uint type, bool normalized, System.IntPtr value)
		{
			m_VertexAttribP4uiv_0(index, type, normalized, value);
		}



	}
}

