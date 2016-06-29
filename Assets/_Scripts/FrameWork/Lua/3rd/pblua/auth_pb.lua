-- Generated By protoc-gen-lua Do not Edit
local protobuf = require "protobuf"
local result_pb = require("3rd/pblua/result_pb")
module('auth_pb')


local CLIENTLOGIN = protobuf.Descriptor();
local CLIENTLOGIN_ACCOUNT_FIELD = protobuf.FieldDescriptor();
local CLIENTLOGIN_CHANNEL_ID_FIELD = protobuf.FieldDescriptor();
local CLIENTLOGIN_TOKEN_FIELD = protobuf.FieldDescriptor();
local SERVERLOGIN = protobuf.Descriptor();
local SERVERLOGIN_RESULT_FIELD = protobuf.FieldDescriptor();
local SERVERLOGIN_IS_REGISTER_FIELD = protobuf.FieldDescriptor();

CLIENTLOGIN_ACCOUNT_FIELD.name = "account"
CLIENTLOGIN_ACCOUNT_FIELD.full_name = ".Protocol.ClientLogin.account"
CLIENTLOGIN_ACCOUNT_FIELD.number = 1
CLIENTLOGIN_ACCOUNT_FIELD.index = 0
CLIENTLOGIN_ACCOUNT_FIELD.label = 2
CLIENTLOGIN_ACCOUNT_FIELD.has_default_value = false
CLIENTLOGIN_ACCOUNT_FIELD.default_value = ""
CLIENTLOGIN_ACCOUNT_FIELD.type = 9
CLIENTLOGIN_ACCOUNT_FIELD.cpp_type = 9

CLIENTLOGIN_CHANNEL_ID_FIELD.name = "channel_id"
CLIENTLOGIN_CHANNEL_ID_FIELD.full_name = ".Protocol.ClientLogin.channel_id"
CLIENTLOGIN_CHANNEL_ID_FIELD.number = 2
CLIENTLOGIN_CHANNEL_ID_FIELD.index = 1
CLIENTLOGIN_CHANNEL_ID_FIELD.label = 1
CLIENTLOGIN_CHANNEL_ID_FIELD.has_default_value = false
CLIENTLOGIN_CHANNEL_ID_FIELD.default_value = ""
CLIENTLOGIN_CHANNEL_ID_FIELD.type = 9
CLIENTLOGIN_CHANNEL_ID_FIELD.cpp_type = 9

CLIENTLOGIN_TOKEN_FIELD.name = "token"
CLIENTLOGIN_TOKEN_FIELD.full_name = ".Protocol.ClientLogin.token"
CLIENTLOGIN_TOKEN_FIELD.number = 3
CLIENTLOGIN_TOKEN_FIELD.index = 2
CLIENTLOGIN_TOKEN_FIELD.label = 1
CLIENTLOGIN_TOKEN_FIELD.has_default_value = false
CLIENTLOGIN_TOKEN_FIELD.default_value = ""
CLIENTLOGIN_TOKEN_FIELD.type = 9
CLIENTLOGIN_TOKEN_FIELD.cpp_type = 9

CLIENTLOGIN.name = "ClientLogin"
CLIENTLOGIN.full_name = ".Protocol.ClientLogin"
CLIENTLOGIN.nested_types = {}
CLIENTLOGIN.enum_types = {}
CLIENTLOGIN.fields = {CLIENTLOGIN_ACCOUNT_FIELD, CLIENTLOGIN_CHANNEL_ID_FIELD, CLIENTLOGIN_TOKEN_FIELD}
CLIENTLOGIN.is_extendable = false
CLIENTLOGIN.extensions = {}
SERVERLOGIN_RESULT_FIELD.name = "result"
SERVERLOGIN_RESULT_FIELD.full_name = ".Protocol.ServerLogin.result"
SERVERLOGIN_RESULT_FIELD.number = 1
SERVERLOGIN_RESULT_FIELD.index = 0
SERVERLOGIN_RESULT_FIELD.label = 2
SERVERLOGIN_RESULT_FIELD.has_default_value = false
SERVERLOGIN_RESULT_FIELD.default_value = nil
SERVERLOGIN_RESULT_FIELD.enum_type = RESULT_PB_RESULT
SERVERLOGIN_RESULT_FIELD.type = 14
SERVERLOGIN_RESULT_FIELD.cpp_type = 8

SERVERLOGIN_IS_REGISTER_FIELD.name = "is_register"
SERVERLOGIN_IS_REGISTER_FIELD.full_name = ".Protocol.ServerLogin.is_register"
SERVERLOGIN_IS_REGISTER_FIELD.number = 2
SERVERLOGIN_IS_REGISTER_FIELD.index = 1
SERVERLOGIN_IS_REGISTER_FIELD.label = 1
SERVERLOGIN_IS_REGISTER_FIELD.has_default_value = false
SERVERLOGIN_IS_REGISTER_FIELD.default_value = 0
SERVERLOGIN_IS_REGISTER_FIELD.type = 5
SERVERLOGIN_IS_REGISTER_FIELD.cpp_type = 1

SERVERLOGIN.name = "ServerLogin"
SERVERLOGIN.full_name = ".Protocol.ServerLogin"
SERVERLOGIN.nested_types = {}
SERVERLOGIN.enum_types = {}
SERVERLOGIN.fields = {SERVERLOGIN_RESULT_FIELD, SERVERLOGIN_IS_REGISTER_FIELD}
SERVERLOGIN.is_extendable = false
SERVERLOGIN.extensions = {}

ClientLogin = protobuf.Message(CLIENTLOGIN)
ServerLogin = protobuf.Message(SERVERLOGIN)
