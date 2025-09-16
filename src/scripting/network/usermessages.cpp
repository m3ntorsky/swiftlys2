/************************************************************************************************
 * SwiftlyS2 is a scripting framework for Source2-based games.
 * Copyright (C) 2025 Swiftly Solution SRL via Sava Andrei-Sebastian and it's contributors
 *
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <https://www.gnu.org/licenses/>.
 ************************************************************************************************/

#include <api/interfaces/manager.h>
#include <scripting/scripting.h>

#include <public/networksystem/inetworkmessages.h>
#include <public/engine/igameeventsystem.h>

#include <api/sdk/recipientfilter.h>

#ifdef GetMessage
#undef GetMessage
#endif

#define GETCHECK_FIELD(return_value)                                                                                          \
    if (!msg)                                                                                                     \
        return return_value;                                                                                                  \
    const google::protobuf::FieldDescriptor *field = msg->GetDescriptor()->FindFieldByName(fieldName);         \
    if (!field)                                                                                                               \
    {                                                                                                                         \
        return return_value;                                                                                                  \
    }

#define GETCHECK_FIELD_VOID()                                                                                          \
    if (!msg)                                                                                                     \
        return;                                                                                                  \
    const google::protobuf::FieldDescriptor *field = msg->GetDescriptor()->FindFieldByName(fieldName);         \
    if (!field)                                                                                                               \
    {                                                                                                                         \
        return;                                                                                                  \
    }

#define CHECK_FIELD_NOT_REPEATED_VOID()                               \
    if (field->label() == google::protobuf::FieldDescriptor::LABEL_REPEATED) \
    {                                                                        \
        return;                                                 \
    }

#define CHECK_FIELD_NOT_REPEATED(return_value)                               \
    if (field->label() == google::protobuf::FieldDescriptor::LABEL_REPEATED) \
    {                                                                        \
        return return_value;                                                 \
    }

#define CHECK_FIELD_TYPE_VOID(type)                                             \
    if (field->cpp_type() != google::protobuf::FieldDescriptor::CPPTYPE_##type) \
    {                                                                           \
        return;                                                                 \
    }

#define CHECK_FIELD_TYPE(type, return_value)                                    \
    if (field->cpp_type() != google::protobuf::FieldDescriptor::CPPTYPE_##type) \
    {                                                                           \
        return return_value;                                                    \
    }

#define CHECK_FIELD_TYPE2_VOID(type1, type2)                                                                                                \
    google::protobuf::FieldDescriptor::CppType fieldType = field->cpp_type();                                                               \
    if (fieldType != google::protobuf::FieldDescriptor::CPPTYPE_##type1 && fieldType != google::protobuf::FieldDescriptor::CPPTYPE_##type2) \
    {                                                                                                                                       \
        return;                                                                                                                             \
    }

#define CHECK_FIELD_TYPE2(type1, type2, return_value)                                                                                       \
    google::protobuf::FieldDescriptor::CppType fieldType = field->cpp_type();                                                               \
    if (fieldType != google::protobuf::FieldDescriptor::CPPTYPE_##type1 && fieldType != google::protobuf::FieldDescriptor::CPPTYPE_##type2) \
    {                                                                                                                                       \
        return return_value;                                                                                                                \
    }

#define CHECK_FIELD_REPEATED_VOID()                                   \
    if (field->label() != google::protobuf::FieldDescriptor::LABEL_REPEATED) \
    {                                                                        \
        return;                                                 \
    }

#define CHECK_FIELD_REPEATED(return_value)                                   \
    if (field->label() != google::protobuf::FieldDescriptor::LABEL_REPEATED) \
    {                                                                        \
        return return_value;                                                 \
    }

#define CHECK_REPEATED_ELEMENT_VOID(idx)                                                  \
    int elemCount = msg->GetReflection()->FieldSize(*msg, field); \
    if (elemCount == 0 || idx >= elemCount || idx < 0)                                    \
    {                                                                                     \
        return;                                                                           \
    }

#define CHECK_REPEATED_ELEMENT(idx, return_value)                                         \
    int elemCount = msg->GetReflection()->FieldSize(*msg, field); \
    if (elemCount == 0 || idx >= elemCount || idx < 0)                                    \
    {                                                                                     \
        return return_value;                                                              \
    }

void* Bridge_UserMessages_AllocateNetMessageByID(int msgid)
{
    auto networkMessages = g_ifaceService.FetchInterface<INetworkMessages>(NETWORKMESSAGES_INTERFACE_VERSION);
    auto netmsg = networkMessages->FindNetworkMessageById(msgid);
    if (!netmsg) return nullptr;

    return netmsg->AllocateMessage()->ToPB<google::protobuf::Message>();
}

void* Bridge_UserMessages_AllocateNetMessageByPartialName(const char* name)
{
    auto networkMessages = g_ifaceService.FetchInterface<INetworkMessages>(NETWORKMESSAGES_INTERFACE_VERSION);
    auto netmsg = networkMessages->FindNetworkMessagePartial(name);
    if (!netmsg) return nullptr;

    return netmsg->AllocateMessage()->ToPB<google::protobuf::Message>();
}

void Bridge_UserMessages_DeallocateNetMessage(void* msg)
{
    if (!msg) return;
    delete (CNetMessagePB<google::protobuf::Message>*)msg;
}

bool Bridge_UserMessages_HasField(void* pmsg, const char* fieldName)
{
    CNetMessagePB<google::protobuf::Message>* msg = (CNetMessagePB<google::protobuf::Message>*)pmsg;
    GETCHECK_FIELD(false);
    CHECK_FIELD_NOT_REPEATED(false);
    return msg->GetReflection()->HasField(*msg, field);
}

int Bridge_UserMessages_GetInt32(void* pmsg, const char* fieldName)
{
    CNetMessagePB<google::protobuf::Message>* msg = (CNetMessagePB<google::protobuf::Message>*)pmsg;
    GETCHECK_FIELD(0);
    CHECK_FIELD_NOT_REPEATED(0);
    return msg->GetReflection()->GetInt32(*msg, field);
}

int Bridge_UserMessages_GetRepeatedInt32(void* pmsg, const char* fieldName, int index)
{
    CNetMessagePB<google::protobuf::Message>* msg = (CNetMessagePB<google::protobuf::Message>*)pmsg;
    GETCHECK_FIELD(0);
    CHECK_FIELD_REPEATED(0);
    CHECK_REPEATED_ELEMENT(index, 0);
    return msg->GetReflection()->GetRepeatedInt32(*msg, field, index);
}

void Bridge_UserMessages_SetInt32(void* pmsg, const char* fieldName, int value)
{
    CNetMessagePB<google::protobuf::Message>* msg = (CNetMessagePB<google::protobuf::Message>*)pmsg;
    GETCHECK_FIELD_VOID();
    CHECK_FIELD_NOT_REPEATED_VOID();
    msg->GetReflection()->SetInt32(msg, field, value);
}

void Bridge_UserMessages_SetRepeatedInt32(void* pmsg, const char* fieldName, int index, int value)
{
    CNetMessagePB<google::protobuf::Message>* msg = (CNetMessagePB<google::protobuf::Message>*)pmsg;
    GETCHECK_FIELD_VOID();
    CHECK_FIELD_REPEATED_VOID();
    CHECK_REPEATED_ELEMENT_VOID(index);
    msg->GetReflection()->SetRepeatedInt32(msg, field, index, value);
}

void Bridge_UserMessages_AddInt32(void* pmsg, const char* fieldName, int value)
{
    CNetMessagePB<google::protobuf::Message>* msg = (CNetMessagePB<google::protobuf::Message>*)pmsg;
    GETCHECK_FIELD_VOID();
    CHECK_FIELD_REPEATED_VOID();
    msg->GetReflection()->AddInt32(msg, field, value);
}

int64_t Bridge_UserMessages_GetInt64(void* pmsg, const char* fieldName)
{
    CNetMessagePB<google::protobuf::Message>* msg = (CNetMessagePB<google::protobuf::Message>*)pmsg;
    GETCHECK_FIELD(0);
    CHECK_FIELD_NOT_REPEATED(0);
    return msg->GetReflection()->GetInt64(*msg, field);
}

int64_t Bridge_UserMessages_GetRepeatedInt64(void* pmsg, const char* fieldName, int index)
{
    CNetMessagePB<google::protobuf::Message>* msg = (CNetMessagePB<google::protobuf::Message>*)pmsg;
    GETCHECK_FIELD(0);
    CHECK_FIELD_REPEATED(0);
    CHECK_REPEATED_ELEMENT(index, 0);
    return msg->GetReflection()->GetRepeatedInt64(*msg, field, index);
}

void Bridge_UserMessages_SetInt64(void* pmsg, const char* fieldName, int64_t value)
{
    CNetMessagePB<google::protobuf::Message>* msg = (CNetMessagePB<google::protobuf::Message>*)pmsg;
    GETCHECK_FIELD_VOID();
    CHECK_FIELD_NOT_REPEATED_VOID();
    msg->GetReflection()->SetInt64(msg, field, value);
}

void Bridge_UserMessages_SetRepeatedInt64(void* pmsg, const char* fieldName, int index, int64_t value)
{
    CNetMessagePB<google::protobuf::Message>* msg = (CNetMessagePB<google::protobuf::Message>*)pmsg;
    GETCHECK_FIELD_VOID();
    CHECK_FIELD_REPEATED_VOID();
    CHECK_REPEATED_ELEMENT_VOID(index);
    msg->GetReflection()->SetRepeatedInt64(msg, field, index, value);
}

void Bridge_UserMessages_AddInt64(void* pmsg, const char* fieldName, int64_t value)
{
    CNetMessagePB<google::protobuf::Message>* msg = (CNetMessagePB<google::protobuf::Message>*)pmsg;
    GETCHECK_FIELD_VOID();
    CHECK_FIELD_REPEATED_VOID();
    msg->GetReflection()->AddInt64(msg, field, value);
}

uint32_t Bridge_UserMessages_GetUInt32(void* pmsg, const char* fieldName)
{
    CNetMessagePB<google::protobuf::Message>* msg = (CNetMessagePB<google::protobuf::Message>*)pmsg;
    GETCHECK_FIELD(0);
    CHECK_FIELD_NOT_REPEATED(0);
    return msg->GetReflection()->GetUInt32(*msg, field);
}

uint32_t Bridge_UserMessages_GetRepeatedUInt32(void* pmsg, const char* fieldName, int index)
{
    CNetMessagePB<google::protobuf::Message>* msg = (CNetMessagePB<google::protobuf::Message>*)pmsg;
    GETCHECK_FIELD(0);
    CHECK_FIELD_REPEATED(0);
    CHECK_REPEATED_ELEMENT(index, 0);
    return msg->GetReflection()->GetRepeatedUInt32(*msg, field, index);
}

void Bridge_UserMessages_SetUInt32(void* pmsg, const char* fieldName, uint32_t value)
{
    CNetMessagePB<google::protobuf::Message>* msg = (CNetMessagePB<google::protobuf::Message>*)pmsg;
    GETCHECK_FIELD_VOID();
    CHECK_FIELD_NOT_REPEATED_VOID();
    msg->GetReflection()->SetUInt32(msg, field, value);
}

void Bridge_UserMessages_SetRepeatedUInt32(void* pmsg, const char* fieldName, int index, uint32_t value)
{
    CNetMessagePB<google::protobuf::Message>* msg = (CNetMessagePB<google::protobuf::Message>*)pmsg;
    GETCHECK_FIELD_VOID();
    CHECK_FIELD_REPEATED_VOID();
    CHECK_REPEATED_ELEMENT_VOID(index);
    msg->GetReflection()->SetRepeatedUInt32(msg, field, index, value);
}

void Bridge_UserMessages_AddUInt32(void* pmsg, const char* fieldName, uint32_t value)
{
    CNetMessagePB<google::protobuf::Message>* msg = (CNetMessagePB<google::protobuf::Message>*)pmsg;
    GETCHECK_FIELD_VOID();
    CHECK_FIELD_REPEATED_VOID();
    msg->GetReflection()->AddUInt32(msg, field, value);
}

uint64_t Bridge_UserMessages_GetUInt64(void* pmsg, const char* fieldName)
{
    CNetMessagePB<google::protobuf::Message>* msg = (CNetMessagePB<google::protobuf::Message>*)pmsg;
    GETCHECK_FIELD(0);
    CHECK_FIELD_NOT_REPEATED(0);
    return msg->GetReflection()->GetUInt64(*msg, field);
}

uint64_t Bridge_UserMessages_GetRepeatedUInt64(void* pmsg, const char* fieldName, int index)
{
    CNetMessagePB<google::protobuf::Message>* msg = (CNetMessagePB<google::protobuf::Message>*)pmsg;
    GETCHECK_FIELD(0);
    CHECK_FIELD_REPEATED(0);
    CHECK_REPEATED_ELEMENT(index, 0);
    return msg->GetReflection()->GetRepeatedUInt64(*msg, field, index);
}

void Bridge_UserMessages_SetUInt64(void* pmsg, const char* fieldName, uint64_t value)
{
    CNetMessagePB<google::protobuf::Message>* msg = (CNetMessagePB<google::protobuf::Message>*)pmsg;
    GETCHECK_FIELD_VOID();
    CHECK_FIELD_NOT_REPEATED_VOID();
    msg->GetReflection()->SetUInt64(msg, field, value);
}

void Bridge_UserMessages_SetRepeatedUInt64(void* pmsg, const char* fieldName, int index, uint64_t value)
{
    CNetMessagePB<google::protobuf::Message>* msg = (CNetMessagePB<google::protobuf::Message>*)pmsg;
    GETCHECK_FIELD_VOID();
    CHECK_FIELD_REPEATED_VOID();
    CHECK_REPEATED_ELEMENT_VOID(index);
    msg->GetReflection()->SetRepeatedUInt64(msg, field, index, value);
}

void Bridge_UserMessages_AddUInt64(void* pmsg, const char* fieldName, uint64_t value)
{
    CNetMessagePB<google::protobuf::Message>* msg = (CNetMessagePB<google::protobuf::Message>*)pmsg;
    GETCHECK_FIELD_VOID();
    CHECK_FIELD_REPEATED_VOID();
    msg->GetReflection()->AddUInt64(msg, field, value);
}

bool Bridge_UserMessages_GetBool(void* pmsg, const char* fieldName)
{
    CNetMessagePB<google::protobuf::Message>* msg = (CNetMessagePB<google::protobuf::Message>*)pmsg;
    GETCHECK_FIELD(false);
    CHECK_FIELD_NOT_REPEATED(false);
    return msg->GetReflection()->GetBool(*msg, field);
}

bool Bridge_UserMessages_GetRepeatedBool(void* pmsg, const char* fieldName, int index)
{
    CNetMessagePB<google::protobuf::Message>* msg = (CNetMessagePB<google::protobuf::Message>*)pmsg;
    GETCHECK_FIELD(false);
    CHECK_FIELD_REPEATED(false);
    CHECK_REPEATED_ELEMENT(index, false);
    return msg->GetReflection()->GetRepeatedBool(*msg, field, index);
}

void Bridge_UserMessages_SetBool(void* pmsg, const char* fieldName, bool value)
{
    CNetMessagePB<google::protobuf::Message>* msg = (CNetMessagePB<google::protobuf::Message>*)pmsg;
    GETCHECK_FIELD_VOID();
    CHECK_FIELD_NOT_REPEATED_VOID();
    msg->GetReflection()->SetBool(msg, field, value);
}

void Bridge_UserMessages_SetRepeatedBool(void* pmsg, const char* fieldName, int index, bool value)
{
    CNetMessagePB<google::protobuf::Message>* msg = (CNetMessagePB<google::protobuf::Message>*)pmsg;
    GETCHECK_FIELD_VOID();
    CHECK_FIELD_REPEATED_VOID();
    CHECK_REPEATED_ELEMENT_VOID(index);
    msg->GetReflection()->SetRepeatedBool(msg, field, index, value);
}

void Bridge_UserMessages_AddBool(void* pmsg, const char* fieldName, bool value)
{
    CNetMessagePB<google::protobuf::Message>* msg = (CNetMessagePB<google::protobuf::Message>*)pmsg;
    GETCHECK_FIELD_VOID();
    CHECK_FIELD_REPEATED_VOID();
    msg->GetReflection()->AddBool(msg, field, value);
}

float Bridge_UserMessages_GetFloat(void* pmsg, const char* fieldName)
{
    CNetMessagePB<google::protobuf::Message>* msg = (CNetMessagePB<google::protobuf::Message>*)pmsg;
    GETCHECK_FIELD(0.0f);
    CHECK_FIELD_NOT_REPEATED(0.0f);
    return msg->GetReflection()->GetFloat(*msg, field);
}

float Bridge_UserMessages_GetRepeatedFloat(void* pmsg, const char* fieldName, int index)
{
    CNetMessagePB<google::protobuf::Message>* msg = (CNetMessagePB<google::protobuf::Message>*)pmsg;
    GETCHECK_FIELD(0.0f);
    CHECK_FIELD_REPEATED(0.0f);
    CHECK_REPEATED_ELEMENT(index, 0.0f);
    return msg->GetReflection()->GetRepeatedFloat(*msg, field, index);
}

void Bridge_UserMessages_SetFloat(void* pmsg, const char* fieldName, float value)
{
    CNetMessagePB<google::protobuf::Message>* msg = (CNetMessagePB<google::protobuf::Message>*)pmsg;
    GETCHECK_FIELD_VOID();
    CHECK_FIELD_NOT_REPEATED_VOID();
    msg->GetReflection()->SetFloat(msg, field, value);
}

void Bridge_UserMessages_SetRepeatedFloat(void* pmsg, const char* fieldName, int index, float value)
{
    CNetMessagePB<google::protobuf::Message>* msg = (CNetMessagePB<google::protobuf::Message>*)pmsg;
    GETCHECK_FIELD_VOID();
    CHECK_FIELD_REPEATED_VOID();
    CHECK_REPEATED_ELEMENT_VOID(index);
    msg->GetReflection()->SetRepeatedFloat(msg, field, index, value);
}

void Bridge_UserMessages_AddFloat(void* pmsg, const char* fieldName, float value)
{
    CNetMessagePB<google::protobuf::Message>* msg = (CNetMessagePB<google::protobuf::Message>*)pmsg;
    GETCHECK_FIELD_VOID();
    CHECK_FIELD_REPEATED_VOID();
    msg->GetReflection()->AddFloat(msg, field, value);
}

double Bridge_UserMessages_GetDouble(void* pmsg, const char* fieldName)
{
    CNetMessagePB<google::protobuf::Message>* msg = (CNetMessagePB<google::protobuf::Message>*)pmsg;
    GETCHECK_FIELD(0.0);
    CHECK_FIELD_NOT_REPEATED(0.0);
    return msg->GetReflection()->GetDouble(*msg, field);
}

double Bridge_UserMessages_GetRepeatedDouble(void* pmsg, const char* fieldName, int index)
{
    CNetMessagePB<google::protobuf::Message>* msg = (CNetMessagePB<google::protobuf::Message>*)pmsg;
    GETCHECK_FIELD(0.0);
    CHECK_FIELD_REPEATED(0.0);
    CHECK_REPEATED_ELEMENT(index, 0.0);
    return msg->GetReflection()->GetRepeatedDouble(*msg, field, index);
}

void Bridge_UserMessages_SetDouble(void* pmsg, const char* fieldName, double value)
{
    CNetMessagePB<google::protobuf::Message>* msg = (CNetMessagePB<google::protobuf::Message>*)pmsg;
    GETCHECK_FIELD_VOID();
    CHECK_FIELD_NOT_REPEATED_VOID();
    msg->GetReflection()->SetDouble(msg, field, value);
}

void Bridge_UserMessages_SetRepeatedDouble(void* pmsg, const char* fieldName, int index, double value)
{
    CNetMessagePB<google::protobuf::Message>* msg = (CNetMessagePB<google::protobuf::Message>*)pmsg;
    GETCHECK_FIELD_VOID();
    CHECK_FIELD_REPEATED_VOID();
    CHECK_REPEATED_ELEMENT_VOID(index);
    msg->GetReflection()->SetRepeatedDouble(msg, field, index, value);
}

void Bridge_UserMessages_AddDouble(void* pmsg, const char* fieldName, double value)
{
    CNetMessagePB<google::protobuf::Message>* msg = (CNetMessagePB<google::protobuf::Message>*)pmsg;
    GETCHECK_FIELD_VOID();
    CHECK_FIELD_REPEATED_VOID();
    msg->GetReflection()->AddDouble(msg, field, value);
}

int Bridge_UserMessages_GetString(char* out, void* pmsg, const char* fieldName)
{
    CNetMessagePB<google::protobuf::Message>* msg = (CNetMessagePB<google::protobuf::Message>*)pmsg;
    GETCHECK_FIELD(0);
    CHECK_FIELD_NOT_REPEATED(0);

    static std::string s;
    s = msg->GetReflection()->GetString(*msg, field);

    if (out != nullptr) strcpy(out, s.c_str());

    return s.size();
}

int Bridge_UserMessages_GetRepeatedString(char* out, void* pmsg, const char* fieldName, int index)
{
    CNetMessagePB<google::protobuf::Message>* msg = (CNetMessagePB<google::protobuf::Message>*)pmsg;
    GETCHECK_FIELD(0);
    CHECK_FIELD_REPEATED(0);
    CHECK_REPEATED_ELEMENT(index, 0);

    static std::string s;
    s = msg->GetReflection()->GetRepeatedString(*msg, field, index);

    if (out != nullptr) strcpy(out, s.c_str());

    return s.size();
}

void Bridge_UserMessages_SetString(void* pmsg, const char* fieldName, const char* value)
{
    CNetMessagePB<google::protobuf::Message>* msg = (CNetMessagePB<google::protobuf::Message>*)pmsg;
    GETCHECK_FIELD_VOID();
    CHECK_FIELD_NOT_REPEATED_VOID();
    msg->GetReflection()->SetString(msg, field, value);
}

void Bridge_UserMessages_SetRepeatedString(void* pmsg, const char* fieldName, int index, const char* value)
{
    CNetMessagePB<google::protobuf::Message>* msg = (CNetMessagePB<google::protobuf::Message>*)pmsg;
    GETCHECK_FIELD_VOID();
    CHECK_FIELD_REPEATED_VOID();
    CHECK_REPEATED_ELEMENT_VOID(index);
    msg->GetReflection()->SetRepeatedString(msg, field, index, value);
}

void Bridge_UserMessages_AddString(void* pmsg, const char* fieldName, const char* value)
{
    CNetMessagePB<google::protobuf::Message>* msg = (CNetMessagePB<google::protobuf::Message>*)pmsg;
    GETCHECK_FIELD_VOID();
    CHECK_FIELD_REPEATED_VOID();
    msg->GetReflection()->AddString(msg, field, value);
}

Vector2D Bridge_UserMessages_GetVector2D(void* pmsg, const char* fieldName)
{
    CNetMessagePB<google::protobuf::Message>* msg = (CNetMessagePB<google::protobuf::Message>*)pmsg;
    Vector2D vec{ 0.0f, 0.0f };
    GETCHECK_FIELD(vec);
    CHECK_FIELD_NOT_REPEATED(vec);

    const CMsgVector2D* msgVec2d = (const CMsgVector2D*)&msg->GetReflection()->GetMessage(*msg, field);
    vec.x = msgVec2d->x();
    vec.y = msgVec2d->y();
    return vec;
}

Vector2D Bridge_UserMessages_GetRepeatedVector2D(void* pmsg, const char* fieldName, int index)
{
    CNetMessagePB<google::protobuf::Message>* msg = (CNetMessagePB<google::protobuf::Message>*)pmsg;

    Vector2D vec{ 0.0f, 0.0f };
    GETCHECK_FIELD(vec);
    CHECK_FIELD_REPEATED(vec);
    CHECK_REPEATED_ELEMENT(index, vec);

    const CMsgVector2D* msgVec2d = (const CMsgVector2D*)&msg->GetReflection()->GetRepeatedMessage(*msg, field, index);
    vec.x = msgVec2d->x();
    vec.y = msgVec2d->y();
    return vec;
}

void Bridge_UserMessages_SetVector2D(void* pmsg, const char* fieldName, Vector2D value)
{
    CNetMessagePB<google::protobuf::Message>* msg = (CNetMessagePB<google::protobuf::Message>*)pmsg;
    GETCHECK_FIELD_VOID();
    CHECK_FIELD_NOT_REPEATED_VOID();

    CMsgVector2D* msgVec2d = (CMsgVector2D*)msg->GetReflection()->MutableMessage(msg, field);
    msgVec2d->set_x(value.x);
    msgVec2d->set_y(value.y);
}

void Bridge_UserMessages_SetRepeatedVector2D(void* pmsg, const char* fieldName, int index, Vector2D value)
{
    CNetMessagePB<google::protobuf::Message>* msg = (CNetMessagePB<google::protobuf::Message>*)pmsg;
    GETCHECK_FIELD_VOID();
    CHECK_FIELD_REPEATED_VOID();
    CHECK_REPEATED_ELEMENT_VOID(index);

    CMsgVector2D* msgVec2d = (CMsgVector2D*)msg->GetReflection()->MutableRepeatedMessage(msg, field, index);
    msgVec2d->set_x(value.x);
    msgVec2d->set_y(value.y);
}

void Bridge_UserMessages_AddVector2D(void* pmsg, const char* fieldName, Vector2D value)
{
    CNetMessagePB<google::protobuf::Message>* msg = (CNetMessagePB<google::protobuf::Message>*)pmsg;
    GETCHECK_FIELD_VOID();
    CHECK_FIELD_REPEATED_VOID();

    CMsgVector2D* msgVec2d = (CMsgVector2D*)msg->GetReflection()->AddMessage(msg, field);
    msgVec2d->set_x(value.x);
    msgVec2d->set_y(value.y);
}

Vector Bridge_UserMessages_GetVector(void* pmsg, const char* fieldName)
{
    CNetMessagePB<google::protobuf::Message>* msg = (CNetMessagePB<google::protobuf::Message>*)pmsg;
    Vector vec{ 0.0f, 0.0f, 0.0f };
    GETCHECK_FIELD(vec);
    CHECK_FIELD_NOT_REPEATED(vec);

    const CMsgVector* msgVec = (const CMsgVector*)&msg->GetReflection()->GetMessage(*msg, field);
    vec.x = msgVec->x();
    vec.y = msgVec->y();
    vec.z = msgVec->z();
    return vec;
}

Vector Bridge_UserMessages_GetRepeatedVector(void* pmsg, const char* fieldName, int index)
{
    CNetMessagePB<google::protobuf::Message>* msg = (CNetMessagePB<google::protobuf::Message>*)pmsg;

    Vector vec{ 0.0f, 0.0f, 0.0f };
    GETCHECK_FIELD(vec);
    CHECK_FIELD_REPEATED(vec);
    CHECK_REPEATED_ELEMENT(index, vec);

    const CMsgVector* msgVec = (const CMsgVector*)&msg->GetReflection()->GetRepeatedMessage(*msg, field, index);
    vec.x = msgVec->x();
    vec.y = msgVec->y();
    vec.z = msgVec->z();
    return vec;
}

void Bridge_UserMessages_SetVector(void* pmsg, const char* fieldName, Vector value)
{
    CNetMessagePB<google::protobuf::Message>* msg = (CNetMessagePB<google::protobuf::Message>*)pmsg;
    GETCHECK_FIELD_VOID();
    CHECK_FIELD_NOT_REPEATED_VOID();

    CMsgVector* msgVec = (CMsgVector*)msg->GetReflection()->MutableMessage(msg, field);
    msgVec->set_x(value.x);
    msgVec->set_y(value.y);
    msgVec->set_z(value.z);
}

void Bridge_UserMessages_SetRepeatedVector(void* pmsg, const char* fieldName, int index, Vector value)
{
    CNetMessagePB<google::protobuf::Message>* msg = (CNetMessagePB<google::protobuf::Message>*)pmsg;
    GETCHECK_FIELD_VOID();
    CHECK_FIELD_REPEATED_VOID();
    CHECK_REPEATED_ELEMENT_VOID(index);

    CMsgVector* msgVec = (CMsgVector*)msg->GetReflection()->MutableRepeatedMessage(msg, field, index);
    msgVec->set_x(value.x);
    msgVec->set_y(value.y);
    msgVec->set_z(value.z);
}

void Bridge_UserMessages_AddVector(void* pmsg, const char* fieldName, Vector value)
{
    CNetMessagePB<google::protobuf::Message>* msg = (CNetMessagePB<google::protobuf::Message>*)pmsg;
    GETCHECK_FIELD_VOID();
    CHECK_FIELD_REPEATED_VOID();

    CMsgVector* msgVec = (CMsgVector*)msg->GetReflection()->AddMessage(msg, field);
    msgVec->set_x(value.x);
    msgVec->set_y(value.y);
    msgVec->set_z(value.z);
}

Color Bridge_UserMessages_GetColor(void* pmsg, const char* fieldName)
{
    CNetMessagePB<google::protobuf::Message>* msg = (CNetMessagePB<google::protobuf::Message>*)pmsg;
    Color color{ 255,255,255,255 };
    GETCHECK_FIELD(color);
    CHECK_FIELD_NOT_REPEATED(color);

    const CMsgRGBA* msgColor = (const CMsgRGBA*)&msg->GetReflection()->GetMessage(*msg, field);
    color.SetColor(msgColor->r(), msgColor->g(), msgColor->b(), msgColor->a());
    return color;
}

Color Bridge_UserMessages_GetRepeatedColor(void* pmsg, const char* fieldName, int index)
{
    CNetMessagePB<google::protobuf::Message>* msg = (CNetMessagePB<google::protobuf::Message>*)pmsg;

    Color color{ 255,255,255,255 };
    GETCHECK_FIELD(color);
    CHECK_FIELD_REPEATED(color);
    CHECK_REPEATED_ELEMENT(index, color);

    const CMsgRGBA* msgColor = (const CMsgRGBA*)&msg->GetReflection()->GetRepeatedMessage(*msg, field, index);
    color.SetColor(msgColor->r(), msgColor->g(), msgColor->b(), msgColor->a());
    return color;
}

void Bridge_UserMessages_SetColor(void* pmsg, const char* fieldName, Color value)
{
    CNetMessagePB<google::protobuf::Message>* msg = (CNetMessagePB<google::protobuf::Message>*)pmsg;
    GETCHECK_FIELD_VOID();
    CHECK_FIELD_NOT_REPEATED_VOID();

    CMsgRGBA* msgColor = (CMsgRGBA*)msg->GetReflection()->MutableMessage(msg, field);
    msgColor->set_r(value.r());
    msgColor->set_g(value.g());
    msgColor->set_b(value.b());
    msgColor->set_a(value.a());
}

void Bridge_UserMessages_SetRepeatedColor(void* pmsg, const char* fieldName, int index, Color value)
{
    CNetMessagePB<google::protobuf::Message>* msg = (CNetMessagePB<google::protobuf::Message>*)pmsg;
    GETCHECK_FIELD_VOID();
    CHECK_FIELD_REPEATED_VOID();
    CHECK_REPEATED_ELEMENT_VOID(index);

    CMsgRGBA* msgColor = (CMsgRGBA*)msg->GetReflection()->MutableRepeatedMessage(msg, field, index);
    msgColor->set_r(value.r());
    msgColor->set_g(value.g());
    msgColor->set_b(value.b());
    msgColor->set_a(value.a());
}

void Bridge_UserMessages_AddColor(void* pmsg, const char* fieldName, Color value)
{
    CNetMessagePB<google::protobuf::Message>* msg = (CNetMessagePB<google::protobuf::Message>*)pmsg;
    GETCHECK_FIELD_VOID();
    CHECK_FIELD_REPEATED_VOID();

    CMsgRGBA* msgColor = (CMsgRGBA*)msg->GetReflection()->AddMessage(msg, field);
    msgColor->set_r(value.r());
    msgColor->set_g(value.g());
    msgColor->set_b(value.b());
    msgColor->set_a(value.a());
}

QAngle Bridge_UserMessages_GetQAngle(void* pmsg, const char* fieldName)
{
    CNetMessagePB<google::protobuf::Message>* msg = (CNetMessagePB<google::protobuf::Message>*)pmsg;
    QAngle angle{ 0.0f,0.0f,0.0f };
    GETCHECK_FIELD(angle);
    CHECK_FIELD_NOT_REPEATED(angle);

    const CMsgQAngle* msgAngle = (const CMsgQAngle*)&msg->GetReflection()->GetMessage(*msg, field);
    angle.x = msgAngle->x();
    angle.y = msgAngle->y();
    angle.z = msgAngle->z();
    return angle;
}

QAngle Bridge_UserMessages_GetRepeatedQAngle(void* pmsg, const char* fieldName, int index)
{
    CNetMessagePB<google::protobuf::Message>* msg = (CNetMessagePB<google::protobuf::Message>*)pmsg;

    QAngle angle{ 0.0f,0.0f,0.0f };
    GETCHECK_FIELD(angle);
    CHECK_FIELD_REPEATED(angle);
    CHECK_REPEATED_ELEMENT(index, angle);

    const CMsgQAngle* msgAngle = (const CMsgQAngle*)&msg->GetReflection()->GetRepeatedMessage(*msg, field, index);
    angle.x = msgAngle->x();
    angle.y = msgAngle->y();
    angle.z = msgAngle->z();
    return angle;
}

void Bridge_UserMessages_SetQAngle(void* pmsg, const char* fieldName, QAngle value)
{
    CNetMessagePB<google::protobuf::Message>* msg = (CNetMessagePB<google::protobuf::Message>*)pmsg;
    GETCHECK_FIELD_VOID();
    CHECK_FIELD_NOT_REPEATED_VOID();

    CMsgQAngle* msgAngle = (CMsgQAngle*)msg->GetReflection()->MutableMessage(msg, field);
    msgAngle->set_x(value.x);
    msgAngle->set_y(value.y);
    msgAngle->set_z(value.z);
}

void Bridge_UserMessages_SetRepeatedQAngle(void* pmsg, const char* fieldName, int index, QAngle value)
{
    CNetMessagePB<google::protobuf::Message>* msg = (CNetMessagePB<google::protobuf::Message>*)pmsg;
    GETCHECK_FIELD_VOID();
    CHECK_FIELD_REPEATED_VOID();
    CHECK_REPEATED_ELEMENT_VOID(index);

    CMsgQAngle* msgAngle = (CMsgQAngle*)msg->GetReflection()->MutableRepeatedMessage(msg, field, index);
    msgAngle->set_x(value.x);
    msgAngle->set_y(value.y);
    msgAngle->set_z(value.z);
}

void Bridge_UserMessages_AddQAngle(void* pmsg, const char* fieldName, QAngle value)
{
    CNetMessagePB<google::protobuf::Message>* msg = (CNetMessagePB<google::protobuf::Message>*)pmsg;
    GETCHECK_FIELD_VOID();
    CHECK_FIELD_REPEATED_VOID();

    CMsgQAngle* msgAngle = (CMsgQAngle*)msg->GetReflection()->AddMessage(msg, field);
    msgAngle->set_x(value.x);
    msgAngle->set_y(value.y);
    msgAngle->set_z(value.z);
}

int Bridge_UserMessages_GetBytes(uint8_t* out, void* pmsg, const char* fieldName)
{
    CNetMessagePB<google::protobuf::Message>* msg = (CNetMessagePB<google::protobuf::Message>*)pmsg;
    GETCHECK_FIELD(0);
    CHECK_FIELD_NOT_REPEATED(0);

    static std::string s;
    s = msg->GetReflection()->GetString(*msg, field);

    if (out != nullptr) strcpy((char*)out, s.c_str());

    return s.size();
}

int Bridge_UserMessages_GetRepeatedBytes(uint8_t* out, void* pmsg, const char* fieldName, int index)
{
    CNetMessagePB<google::protobuf::Message>* msg = (CNetMessagePB<google::protobuf::Message>*)pmsg;
    GETCHECK_FIELD(0);
    CHECK_FIELD_REPEATED(0);
    CHECK_REPEATED_ELEMENT(index, 0);

    static std::string s;
    s = msg->GetReflection()->GetRepeatedString(*msg, field, index);

    if (out != nullptr) strcpy((char*)out, s.c_str());

    return s.size();
}

void Bridge_UserMessages_SetBytes(void* pmsg, const char* fieldName, uint8_t* value)
{
    CNetMessagePB<google::protobuf::Message>* msg = (CNetMessagePB<google::protobuf::Message>*)pmsg;
    GETCHECK_FIELD_VOID();
    CHECK_FIELD_NOT_REPEATED_VOID();
    msg->GetReflection()->SetString(msg, field, (char*)value);
}

void Bridge_UserMessages_SetRepeatedBytes(void* pmsg, const char* fieldName, int index, uint8_t* value)
{
    CNetMessagePB<google::protobuf::Message>* msg = (CNetMessagePB<google::protobuf::Message>*)pmsg;
    GETCHECK_FIELD_VOID();
    CHECK_FIELD_REPEATED_VOID();
    CHECK_REPEATED_ELEMENT_VOID(index);
    msg->GetReflection()->SetRepeatedString(msg, field, index, (char*)value);
}

void Bridge_UserMessages_AddBytes(void* pmsg, const char* fieldName, uint8_t* value)
{
    CNetMessagePB<google::protobuf::Message>* msg = (CNetMessagePB<google::protobuf::Message>*)pmsg;
    GETCHECK_FIELD_VOID();
    CHECK_FIELD_REPEATED_VOID();
    msg->GetReflection()->AddString(msg, field, (char*)value);
}

void* Bridge_UserMessages_GetNestedMessage(void* pmsg, const char* fieldName)
{
    CNetMessagePB<google::protobuf::Message>* msg = (CNetMessagePB<google::protobuf::Message>*)pmsg;
    GETCHECK_FIELD(nullptr);
    CHECK_FIELD_NOT_REPEATED(nullptr);
    return (void*)(&msg->GetReflection()->GetMessage(*msg, field));
}

void* Bridge_UserMessages_GetRepeatedNestedMessage(void* pmsg, const char* fieldName, int index)
{
    CNetMessagePB<google::protobuf::Message>* msg = (CNetMessagePB<google::protobuf::Message>*)pmsg;

    GETCHECK_FIELD(nullptr);
    CHECK_FIELD_REPEATED(nullptr);
    CHECK_REPEATED_ELEMENT(index, nullptr);

    return (void*)&msg->GetReflection()->GetRepeatedMessage(*msg, field, index);
}

void* Bridge_UserMessages_AddNestedMessage(void* pmsg, const char* fieldName)
{
    CNetMessagePB<google::protobuf::Message>* msg = (CNetMessagePB<google::protobuf::Message>*)pmsg;
    GETCHECK_FIELD(nullptr);
    CHECK_FIELD_REPEATED(nullptr);

    return (void*)msg->GetReflection()->AddMessage(msg, field);
}

void Bridge_UserMessages_SendMessage(void* pmsg, int msgid, int playerid)
{
    CNetMessagePB<google::protobuf::Message>* msg = (CNetMessagePB<google::protobuf::Message>*)pmsg;

    auto networkMessages = g_ifaceService.FetchInterface<INetworkMessages>(NETWORKMESSAGES_INTERFACE_VERSION);
    auto gameEventSystem = g_ifaceService.FetchInterface<IGameEventSystem>(GAMEEVENTSYSTEM_INTERFACE_VERSION);

    auto netmsg = networkMessages->FindNetworkMessageById(msgid);
    if (!netmsg) return;

    CSingleRecipientFilter filter(playerid);
    gameEventSystem->PostEventAbstract(-1, false, &filter, netmsg, msg, 0);
}

void Bridge_UserMessages_SendMessageToPlayers(void* pmsg, int msgid, uint64_t playermask)
{
    CNetMessagePB<google::protobuf::Message>* msg = (CNetMessagePB<google::protobuf::Message>*)pmsg;

    auto networkMessages = g_ifaceService.FetchInterface<INetworkMessages>(NETWORKMESSAGES_INTERFACE_VERSION);
    auto gameEventSystem = g_ifaceService.FetchInterface<IGameEventSystem>(GAMEEVENTSYSTEM_INTERFACE_VERSION);

    auto netmsg = networkMessages->FindNetworkMessageById(msgid);
    if (!netmsg) return;

    CRecipientFilter filter;
    for (int i = 0; i < 64; i++)
        if (playermask & (1ULL << i))
            filter.AddRecipient(i);

    gameEventSystem->PostEventAbstract(-1, false, &filter, netmsg, msg, 0);
}

DEFINE_NATIVE("UserMessages.AllocateNetMessageByID", Bridge_UserMessages_AllocateNetMessageByID);
DEFINE_NATIVE("UserMessages.AllocateNetMessageByPartialName", Bridge_UserMessages_AllocateNetMessageByPartialName);
DEFINE_NATIVE("UserMessages.DeallocateNetMessage", Bridge_UserMessages_DeallocateNetMessage);
DEFINE_NATIVE("UserMessages.HasField", Bridge_UserMessages_HasField);
DEFINE_NATIVE("UserMessages.GetInt32", Bridge_UserMessages_GetInt32);
DEFINE_NATIVE("UserMessages.GetRepeatedInt32", Bridge_UserMessages_GetRepeatedInt32);
DEFINE_NATIVE("UserMessages.SetInt32", Bridge_UserMessages_SetInt32);
DEFINE_NATIVE("UserMessages.SetRepeatedInt32", Bridge_UserMessages_SetRepeatedInt32);
DEFINE_NATIVE("UserMessages.AddInt32", Bridge_UserMessages_AddInt32);
DEFINE_NATIVE("UserMessages.GetInt64", Bridge_UserMessages_GetInt64);
DEFINE_NATIVE("UserMessages.GetRepeatedInt64", Bridge_UserMessages_GetRepeatedInt64);
DEFINE_NATIVE("UserMessages.SetInt64", Bridge_UserMessages_SetInt64);
DEFINE_NATIVE("UserMessages.SetRepeatedInt64", Bridge_UserMessages_SetRepeatedInt64);
DEFINE_NATIVE("UserMessages.AddInt64", Bridge_UserMessages_AddInt64);
DEFINE_NATIVE("UserMessages.GetUInt32", Bridge_UserMessages_GetUInt32);
DEFINE_NATIVE("UserMessages.GetRepeatedUInt32", Bridge_UserMessages_GetRepeatedUInt32);
DEFINE_NATIVE("UserMessages.SetUInt32", Bridge_UserMessages_SetUInt32);
DEFINE_NATIVE("UserMessages.SetRepeatedUInt32", Bridge_UserMessages_SetRepeatedUInt32);
DEFINE_NATIVE("UserMessages.AddUInt32", Bridge_UserMessages_AddUInt32);
DEFINE_NATIVE("UserMessages.GetUInt64", Bridge_UserMessages_GetUInt64);
DEFINE_NATIVE("UserMessages.GetRepeatedUInt64", Bridge_UserMessages_GetRepeatedUInt64);
DEFINE_NATIVE("UserMessages.SetUInt64", Bridge_UserMessages_SetUInt64);
DEFINE_NATIVE("UserMessages.SetRepeatedUInt64", Bridge_UserMessages_SetRepeatedUInt64);
DEFINE_NATIVE("UserMessages.AddUInt64", Bridge_UserMessages_AddUInt64);
DEFINE_NATIVE("UserMessages.GetBool", Bridge_UserMessages_GetBool);
DEFINE_NATIVE("UserMessages.GetRepeatedBool", Bridge_UserMessages_GetRepeatedBool);
DEFINE_NATIVE("UserMessages.SetBool", Bridge_UserMessages_SetBool);
DEFINE_NATIVE("UserMessages.SetRepeatedBool", Bridge_UserMessages_SetRepeatedBool);
DEFINE_NATIVE("UserMessages.AddBool", Bridge_UserMessages_AddBool);
DEFINE_NATIVE("UserMessages.GetFloat", Bridge_UserMessages_GetFloat);
DEFINE_NATIVE("UserMessages.GetRepeatedFloat", Bridge_UserMessages_GetRepeatedFloat);
DEFINE_NATIVE("UserMessages.SetFloat", Bridge_UserMessages_SetFloat);
DEFINE_NATIVE("UserMessages.SetRepeatedFloat", Bridge_UserMessages_SetRepeatedFloat);
DEFINE_NATIVE("UserMessages.AddFloat", Bridge_UserMessages_AddFloat);
DEFINE_NATIVE("UserMessages.GetDouble", Bridge_UserMessages_GetDouble);
DEFINE_NATIVE("UserMessages.GetRepeatedDouble", Bridge_UserMessages_GetRepeatedDouble);
DEFINE_NATIVE("UserMessages.SetDouble", Bridge_UserMessages_SetDouble);
DEFINE_NATIVE("UserMessages.SetRepeatedDouble", Bridge_UserMessages_SetRepeatedDouble);
DEFINE_NATIVE("UserMessages.AddDouble", Bridge_UserMessages_AddDouble);
DEFINE_NATIVE("UserMessages.GetString", Bridge_UserMessages_GetString);
DEFINE_NATIVE("UserMessages.GetRepeatedString", Bridge_UserMessages_GetRepeatedString);
DEFINE_NATIVE("UserMessages.SetString", Bridge_UserMessages_SetString);
DEFINE_NATIVE("UserMessages.SetRepeatedString", Bridge_UserMessages_SetRepeatedString);
DEFINE_NATIVE("UserMessages.AddString", Bridge_UserMessages_AddString);
DEFINE_NATIVE("UserMessages.GetVector2D", Bridge_UserMessages_GetVector2D);
DEFINE_NATIVE("UserMessages.GetRepeatedVector2D", Bridge_UserMessages_GetRepeatedVector2D);
DEFINE_NATIVE("UserMessages.SetVector2D", Bridge_UserMessages_SetVector2D);
DEFINE_NATIVE("UserMessages.SetRepeatedVector2D", Bridge_UserMessages_SetRepeatedVector2D);
DEFINE_NATIVE("UserMessages.AddVector2D", Bridge_UserMessages_AddVector2D);
DEFINE_NATIVE("UserMessages.GetVector", Bridge_UserMessages_GetVector);
DEFINE_NATIVE("UserMessages.GetRepeatedVector", Bridge_UserMessages_GetRepeatedVector);
DEFINE_NATIVE("UserMessages.SetVector", Bridge_UserMessages_SetVector);
DEFINE_NATIVE("UserMessages.SetRepeatedVector", Bridge_UserMessages_SetRepeatedVector);
DEFINE_NATIVE("UserMessages.AddVector", Bridge_UserMessages_AddVector);
DEFINE_NATIVE("UserMessages.GetColor", Bridge_UserMessages_GetColor);
DEFINE_NATIVE("UserMessages.GetRepeatedColor", Bridge_UserMessages_GetRepeatedColor);
DEFINE_NATIVE("UserMessages.SetColor", Bridge_UserMessages_SetColor);
DEFINE_NATIVE("UserMessages.SetRepeatedColor", Bridge_UserMessages_SetRepeatedColor);
DEFINE_NATIVE("UserMessages.AddColor", Bridge_UserMessages_AddColor);
DEFINE_NATIVE("UserMessages.GetQAngle", Bridge_UserMessages_GetQAngle);
DEFINE_NATIVE("UserMessages.GetRepeatedQAngle", Bridge_UserMessages_GetRepeatedQAngle);
DEFINE_NATIVE("UserMessages.SetQAngle", Bridge_UserMessages_SetQAngle);
DEFINE_NATIVE("UserMessages.SetRepeatedQAngle", Bridge_UserMessages_SetRepeatedQAngle);
DEFINE_NATIVE("UserMessages.AddQAngle", Bridge_UserMessages_AddQAngle);
DEFINE_NATIVE("UserMessages.GetBytes", Bridge_UserMessages_GetBytes);
DEFINE_NATIVE("UserMessages.GetRepeatedBytes", Bridge_UserMessages_GetRepeatedBytes);
DEFINE_NATIVE("UserMessages.SetBytes", Bridge_UserMessages_SetBytes);
DEFINE_NATIVE("UserMessages.SetRepeatedBytes", Bridge_UserMessages_SetRepeatedBytes);
DEFINE_NATIVE("UserMessages.AddBytes", Bridge_UserMessages_AddBytes);
DEFINE_NATIVE("UserMessages.GetNestedMessage", Bridge_UserMessages_GetNestedMessage);
DEFINE_NATIVE("UserMessages.GetRepeatedNestedMessage", Bridge_UserMessages_GetRepeatedNestedMessage);
DEFINE_NATIVE("UserMessages.AddNestedMessage", Bridge_UserMessages_AddNestedMessage);
DEFINE_NATIVE("UserMessages.SendMessage", Bridge_UserMessages_SendMessage);
DEFINE_NATIVE("UserMessages.SendMessageToPlayers", Bridge_UserMessages_SendMessageToPlayers);