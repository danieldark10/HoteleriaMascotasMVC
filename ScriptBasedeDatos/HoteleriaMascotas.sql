/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2008                    */
/* Created on:     21-07-2022 11:49:10                          */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ADMINISTRACIONSOLICITUD') and o.name = 'FK_ADMINIST_ADMINISTR_TRABAJAD')
alter table ADMINISTRACIONSOLICITUD
   drop constraint FK_ADMINIST_ADMINISTR_TRABAJAD
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ADMINISTRACIONSOLICITUD') and o.name = 'FK_ADMINIST_TIENEADMI_SOLICITU')
alter table ADMINISTRACIONSOLICITUD
   drop constraint FK_ADMINIST_TIENEADMI_SOLICITU
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('AGENDABANOS') and o.name = 'FK_AGENDABA_REALIZABA_TRABAJAD')
alter table AGENDABANOS
   drop constraint FK_AGENDABA_REALIZABA_TRABAJAD
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('AGENDABANOS') and o.name = 'FK_AGENDABA_TIENEAGEN_SOLICITU')
alter table AGENDABANOS
   drop constraint FK_AGENDABA_TIENEAGEN_SOLICITU
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CLIENTE') and o.name = 'FK_CLIENTE_CLIENTETI_ROL')
alter table CLIENTE
   drop constraint FK_CLIENTE_CLIENTETI_ROL
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CLIENTE') and o.name = 'FK_CLIENTE_ISADOS_PERSONA')
alter table CLIENTE
   drop constraint FK_CLIENTE_ISADOS_PERSONA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('MASCOTA') and o.name = 'FK_MASCOTA_TIENEMASC_CLIENTE')
alter table MASCOTA
   drop constraint FK_MASCOTA_TIENEMASC_CLIENTE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PAGOSS') and o.name = 'FK_PAGOSS_GENERA_ADMINIST')
alter table PAGOSS
   drop constraint FK_PAGOSS_GENERA_ADMINIST
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PREGUNTAS') and o.name = 'FK_PREGUNTA_TIENEPREG_SOLICITU')
alter table PREGUNTAS
   drop constraint FK_PREGUNTA_TIENEPREG_SOLICITU
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('RESERVA') and o.name = 'FK_RESERVA_TIENEHABI_HABITACI')
alter table RESERVA
   drop constraint FK_RESERVA_TIENEHABI_HABITACI
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('RESERVA') and o.name = 'FK_RESERVA_TIENERESE_SOLICITU')
alter table RESERVA
   drop constraint FK_RESERVA_TIENERESE_SOLICITU
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('RESPUESTAS') and o.name = 'FK_RESPUEST_TIENE_PREGUNTA')
alter table RESPUESTAS
   drop constraint FK_RESPUEST_TIENE_PREGUNTA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SOLICITUD') and o.name = 'FK_SOLICITU_DETERMINA_TIPODESO')
alter table SOLICITUD
   drop constraint FK_SOLICITU_DETERMINA_TIPODESO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SOLICITUD') and o.name = 'FK_SOLICITU_ESTAEN_MASCOTA')
alter table SOLICITUD
   drop constraint FK_SOLICITU_ESTAEN_MASCOTA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SOLICITUD') and o.name = 'FK_SOLICITU_PIDE_CLIENTE')
alter table SOLICITUD
   drop constraint FK_SOLICITU_PIDE_CLIENTE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('STATUS') and o.name = 'FK_STATUS_TIENESTAT_MASCOTA')
alter table STATUS
   drop constraint FK_STATUS_TIENESTAT_MASCOTA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TRABAJADOR') and o.name = 'FK_TRABAJAD_ISAUNO_PERSONA')
alter table TRABAJADOR
   drop constraint FK_TRABAJAD_ISAUNO_PERSONA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TRABAJADOR') and o.name = 'FK_TRABAJAD_TRABAJADO_ROL')
alter table TRABAJADOR
   drop constraint FK_TRABAJAD_TRABAJADO_ROL
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('USUARIO') and o.name = 'FK_USUARIO_DETERMINA_ROL')
alter table USUARIO
   drop constraint FK_USUARIO_DETERMINA_ROL
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ADMINISTRACIONSOLICITUD')
            and   name  = 'TIENEADMINISTRACION_FK'
            and   indid > 0
            and   indid < 255)
   drop index ADMINISTRACIONSOLICITUD.TIENEADMINISTRACION_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ADMINISTRACIONSOLICITUD')
            and   name  = 'ADMINISTRA_FK'
            and   indid > 0
            and   indid < 255)
   drop index ADMINISTRACIONSOLICITUD.ADMINISTRA_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ADMINISTRACIONSOLICITUD')
            and   type = 'U')
   drop table ADMINISTRACIONSOLICITUD
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('AGENDABANOS')
            and   name  = 'REALIZABANO_FK'
            and   indid > 0
            and   indid < 255)
   drop index AGENDABANOS.REALIZABANO_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('AGENDABANOS')
            and   name  = 'TIENEAGENDABANOS_FK'
            and   indid > 0
            and   indid < 255)
   drop index AGENDABANOS.TIENEAGENDABANOS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('AGENDABANOS')
            and   type = 'U')
   drop table AGENDABANOS
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CLIENTE')
            and   name  = 'CLIENTETIENE_FK'
            and   indid > 0
            and   indid < 255)
   drop index CLIENTE.CLIENTETIENE_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CLIENTE')
            and   name  = 'ISADOS_FK'
            and   indid > 0
            and   indid < 255)
   drop index CLIENTE.ISADOS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CLIENTE')
            and   type = 'U')
   drop table CLIENTE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('HABITACION')
            and   type = 'U')
   drop table HABITACION
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('MASCOTA')
            and   name  = 'TIENEMASCOTA_FK'
            and   indid > 0
            and   indid < 255)
   drop index MASCOTA.TIENEMASCOTA_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('MASCOTA')
            and   type = 'U')
   drop table MASCOTA
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PAGOSS')
            and   name  = 'GENERA_FK'
            and   indid > 0
            and   indid < 255)
   drop index PAGOSS.GENERA_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PAGOSS')
            and   type = 'U')
   drop table PAGOSS
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PERSONA')
            and   type = 'U')
   drop table PERSONA
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PREGUNTAS')
            and   name  = 'TIENEPREGUNTAS_FK'
            and   indid > 0
            and   indid < 255)
   drop index PREGUNTAS.TIENEPREGUNTAS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PREGUNTAS')
            and   type = 'U')
   drop table PREGUNTAS
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('RESERVA')
            and   name  = 'TIENEHABITACION_FK'
            and   indid > 0
            and   indid < 255)
   drop index RESERVA.TIENEHABITACION_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('RESERVA')
            and   name  = 'TIENERESERVA_FK'
            and   indid > 0
            and   indid < 255)
   drop index RESERVA.TIENERESERVA_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('RESERVA')
            and   type = 'U')
   drop table RESERVA
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('RESPUESTAS')
            and   name  = 'TIENE_FK'
            and   indid > 0
            and   indid < 255)
   drop index RESPUESTAS.TIENE_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('RESPUESTAS')
            and   type = 'U')
   drop table RESPUESTAS
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ROL')
            and   type = 'U')
   drop table ROL
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('SOLICITUD')
            and   name  = 'PIDE_FK'
            and   indid > 0
            and   indid < 255)
   drop index SOLICITUD.PIDE_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('SOLICITUD')
            and   name  = 'DETERMINASOLICITUD_FK'
            and   indid > 0
            and   indid < 255)
   drop index SOLICITUD.DETERMINASOLICITUD_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('SOLICITUD')
            and   name  = 'ESTAEN_FK'
            and   indid > 0
            and   indid < 255)
   drop index SOLICITUD.ESTAEN_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('SOLICITUD')
            and   type = 'U')
   drop table SOLICITUD
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('STATUS')
            and   name  = 'TIENESTATUS_FK'
            and   indid > 0
            and   indid < 255)
   drop index STATUS.TIENESTATUS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('STATUS')
            and   type = 'U')
   drop table STATUS
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TIPODESOLICITUD')
            and   type = 'U')
   drop table TIPODESOLICITUD
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TRABAJADOR')
            and   name  = 'TRABAJADORTIENE_FK'
            and   indid > 0
            and   indid < 255)
   drop index TRABAJADOR.TRABAJADORTIENE_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TRABAJADOR')
            and   name  = 'ISAUNO_FK'
            and   indid > 0
            and   indid < 255)
   drop index TRABAJADOR.ISAUNO_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TRABAJADOR')
            and   type = 'U')
   drop table TRABAJADOR
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('USUARIO')
            and   name  = 'DETERMINA_FK'
            and   indid > 0
            and   indid < 255)
   drop index USUARIO.DETERMINA_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('USUARIO')
            and   type = 'U')
   drop table USUARIO
go

/*==============================================================*/
/* Table: ADMINISTRACIONSOLICITUD                               */
/*==============================================================*/
create table ADMINISTRACIONSOLICITUD (
   IDSOLICITUD          int                  not null,
   OBSERVACIONES        char(50)             not null,
   RESPUESTA            char(50)             not null,
   IDADMINISTACIONSOLICITUD int                  identity,
   IDTRABAJADOR         int                  not null,
   ESTADO               bit                  not null,
   constraint PK_ADMINISTRACIONSOLICITUD primary key nonclustered (IDADMINISTACIONSOLICITUD)
)
go

/*==============================================================*/
/* Index: ADMINISTRA_FK                                         */
/*==============================================================*/
create index ADMINISTRA_FK on ADMINISTRACIONSOLICITUD (
IDTRABAJADOR ASC
)
go

/*==============================================================*/
/* Index: TIENEADMINISTRACION_FK                                */
/*==============================================================*/
create index TIENEADMINISTRACION_FK on ADMINISTRACIONSOLICITUD (
IDSOLICITUD ASC
)
go

/*==============================================================*/
/* Table: AGENDABANOS                                           */
/*==============================================================*/
create table AGENDABANOS (
   IDSOLICITUD          int                  not null,
   IDAGENDABANOS        int                  identity,
   IDTRABAJADOR         int                  not null,
   FECHABANO            datetime             not null,
   HORARIOBANOINICIO    datetime             not null,
   HORARIOBANOTERMINO   datetime             not null,
   PRECIOPORBANO        decimal              not null,
   constraint PK_AGENDABANOS primary key nonclustered (IDAGENDABANOS)
)
go

/*==============================================================*/
/* Index: TIENEAGENDABANOS_FK                                   */
/*==============================================================*/
create index TIENEAGENDABANOS_FK on AGENDABANOS (
IDSOLICITUD ASC
)
go

/*==============================================================*/
/* Index: REALIZABANO_FK                                        */
/*==============================================================*/
create index REALIZABANO_FK on AGENDABANOS (
IDTRABAJADOR ASC
)
go

/*==============================================================*/
/* Table: CLIENTE                                               */
/*==============================================================*/
create table CLIENTE (
   IDCLIENTE            int                  identity,
   IDPERSONA            int                  not null,
   IDROL                int                  not null,
   NUMEROPAGOS          int                  not null,
   constraint PK_CLIENTE primary key nonclustered (IDCLIENTE)
)
go

/*==============================================================*/
/* Index: ISADOS_FK                                             */
/*==============================================================*/
create index ISADOS_FK on CLIENTE (
IDPERSONA ASC
)
go

/*==============================================================*/
/* Index: CLIENTETIENE_FK                                       */
/*==============================================================*/
create index CLIENTETIENE_FK on CLIENTE (
IDROL ASC
)
go

/*==============================================================*/
/* Table: HABITACION                                            */
/*==============================================================*/
create table HABITACION (
   IDHABITACION         int                  identity,
   TIPOHABITACION       char(15)             not null,
   NUMEROHABITACION     char(4)              not null,
   PRECIOHORA           decimal(8)           not null,
   CARACTERISTICAS      char(50)             not null,
   ESTADO               char(15)             not null,
   constraint PK_HABITACION primary key nonclustered (IDHABITACION)
)
go

/*==============================================================*/
/* Table: MASCOTA                                               */
/*==============================================================*/
create table MASCOTA (
   IDMASCOTA            int                  identity,
   IDCLIENTE            int                  not null,
   NOMBRE               char(15)             not null,
   EDAD                 float(15)            not null,
   CHIP                 int                  not null,
   RAZA                 char(15)             not null,
   TIPOANIMAL           char(15)             not null,
   PERSONALIDAD         char(15)             not null,
   constraint PK_MASCOTA primary key nonclustered (IDMASCOTA)
)
go

/*==============================================================*/
/* Index: TIENEMASCOTA_FK                                       */
/*==============================================================*/
create index TIENEMASCOTA_FK on MASCOTA (
IDCLIENTE ASC
)
go

/*==============================================================*/
/* Table: PAGOSS                                                */
/*==============================================================*/
create table PAGOSS (
   IDPAGO               int                  identity,
   IDADMINISTACIONSOLICITUD int                  not null,
   FECHAPAGO            datetime             not null,
   MONTOPAGO            decimal              not null,
   ESTADO               bit                  not null,
   NUMEROCOMPROBANTE    char(12)             not null,
   FECHAEMISION         datetime             not null,
   constraint PK_PAGOSS primary key nonclustered (IDPAGO)
)
go

/*==============================================================*/
/* Index: GENERA_FK                                             */
/*==============================================================*/
create index GENERA_FK on PAGOSS (
IDADMINISTACIONSOLICITUD ASC
)
go

/*==============================================================*/
/* Table: PERSONA                                               */
/*==============================================================*/
create table PERSONA (
   IDPERSONA            int                  identity,
   SEXO                 char(15)             not null,
   NOMBRE               char(15)             not null,
   APELLIDO             char(15)             not null,
   RUT                  char(15)             not null,
   EMAIL                char(15)             not null,
   DIRECCION            char(15)             not null,
   TELEFONO             int                  not null,
   constraint PK_PERSONA primary key nonclustered (IDPERSONA)
)
go

/*==============================================================*/
/* Table: PREGUNTAS                                             */
/*==============================================================*/
create table PREGUNTAS (
   IDPREGUNTA           int                  identity,
   IDSOLICITUD          int                  not null,
   TEXTOPREGUNTA        char(50)             not null,
   constraint PK_PREGUNTAS primary key nonclustered (IDPREGUNTA)
)
go

/*==============================================================*/
/* Index: TIENEPREGUNTAS_FK                                     */
/*==============================================================*/
create index TIENEPREGUNTAS_FK on PREGUNTAS (
IDSOLICITUD ASC
)
go

/*==============================================================*/
/* Table: RESERVA                                               */
/*==============================================================*/
create table RESERVA (
   IDRESERVA            int                  identity,
   IDSOLICITUD          int                  not null,
   IDHABITACION         int                  not null,
   FECHAENTRADA         datetime             not null,
   FECHASALIDA          datetime             not null,
   HORARIOENTRADA       datetime             not null,
   HORARIOSALIDA        datetime             not null,
   FECHARESERVA         datetime             not null,
   ESTADO               char(15)             not null,
   PRECIO               decimal              not null,
   constraint PK_RESERVA primary key nonclustered (IDRESERVA)
)
go

/*==============================================================*/
/* Index: TIENERESERVA_FK                                       */
/*==============================================================*/
create index TIENERESERVA_FK on RESERVA (
IDSOLICITUD ASC
)
go

/*==============================================================*/
/* Index: TIENEHABITACION_FK                                    */
/*==============================================================*/
create index TIENEHABITACION_FK on RESERVA (
IDHABITACION ASC
)
go

/*==============================================================*/
/* Table: RESPUESTAS                                            */
/*==============================================================*/
create table RESPUESTAS (
   IDRESPUESTA          int                  identity,
   IDPREGUNTA           int                  not null,
   TEXTORESPUESTA       char(50)             not null,
   constraint PK_RESPUESTAS primary key nonclustered (IDRESPUESTA)
)
go

/*==============================================================*/
/* Index: TIENE_FK                                              */
/*==============================================================*/
create index TIENE_FK on RESPUESTAS (
IDPREGUNTA ASC
)
go

/*==============================================================*/
/* Table: ROL                                                   */
/*==============================================================*/
create table ROL (
   IDROL                int                  identity,
   NOMBREROL            char(15)             not null,
   constraint PK_ROL primary key nonclustered (IDROL)
)
go

/*==============================================================*/
/* Table: SOLICITUD                                             */
/*==============================================================*/
create table SOLICITUD (
   IDSOLICITUD          int                  identity,
   IDMASCOTA            int                  not null,
   IDTIPODESOLICITUD    int                  not null,
   IDCLIENTE            int                  not null,
   DESCRIPCIONSOLICITUD char(15)             not null,
   constraint PK_SOLICITUD primary key nonclustered (IDSOLICITUD)
)
go

/*==============================================================*/
/* Index: ESTAEN_FK                                             */
/*==============================================================*/
create index ESTAEN_FK on SOLICITUD (
IDMASCOTA ASC
)
go

/*==============================================================*/
/* Index: DETERMINASOLICITUD_FK                                 */
/*==============================================================*/
create index DETERMINASOLICITUD_FK on SOLICITUD (
IDTIPODESOLICITUD ASC
)
go

/*==============================================================*/
/* Index: PIDE_FK                                               */
/*==============================================================*/
create index PIDE_FK on SOLICITUD (
IDCLIENTE ASC
)
go

/*==============================================================*/
/* Table: STATUS                                                */
/*==============================================================*/
create table STATUS (
   IDSTATUS             int                  identity,
   IDMASCOTA            int                  not null,
   NOMBRESTATUS         char(15)             not null,
   constraint PK_STATUS primary key nonclustered (IDSTATUS)
)
go

/*==============================================================*/
/* Index: TIENESTATUS_FK                                        */
/*==============================================================*/
create index TIENESTATUS_FK on STATUS (
IDMASCOTA ASC
)
go

/*==============================================================*/
/* Table: TIPODESOLICITUD                                       */
/*==============================================================*/
create table TIPODESOLICITUD (
   IDTIPODESOLICITUD    int                  identity,
   NOMBRESOLICITUD      char(15)             not null,
   constraint PK_TIPODESOLICITUD primary key nonclustered (IDTIPODESOLICITUD)
)
go

/*==============================================================*/
/* Table: TRABAJADOR                                            */
/*==============================================================*/
create table TRABAJADOR (
   IDTRABAJADOR         int                  identity,
   IDPERSONA            int                  not null,
   IDROL                int                  not null,
   FECHAINGRESO         datetime             not null,
   AREA                 char(15)             not null,
   constraint PK_TRABAJADOR primary key nonclustered (IDTRABAJADOR)
)
go

/*==============================================================*/
/* Index: ISAUNO_FK                                             */
/*==============================================================*/
create index ISAUNO_FK on TRABAJADOR (
IDPERSONA ASC
)
go

/*==============================================================*/
/* Index: TRABAJADORTIENE_FK                                    */
/*==============================================================*/
create index TRABAJADORTIENE_FK on TRABAJADOR (
IDROL ASC
)
go

/*==============================================================*/
/* Table: USUARIO                                               */
/*==============================================================*/
create table USUARIO (
   IDUSUARIO            int                  identity,
   IDROL                int                  not null,
   NOMBREUSUARIO        char(15)             not null,
   CONTRASENA           char(15)             not null,
   constraint PK_USUARIO primary key nonclustered (IDUSUARIO)
)
go

/*==============================================================*/
/* Index: DETERMINA_FK                                          */
/*==============================================================*/
create index DETERMINA_FK on USUARIO (
IDROL ASC
)
go

alter table ADMINISTRACIONSOLICITUD
   add constraint FK_ADMINIST_ADMINISTR_TRABAJAD foreign key (IDTRABAJADOR)
      references TRABAJADOR (IDTRABAJADOR)
go

alter table ADMINISTRACIONSOLICITUD
   add constraint FK_ADMINIST_TIENEADMI_SOLICITU foreign key (IDSOLICITUD)
      references SOLICITUD (IDSOLICITUD)
go

alter table AGENDABANOS
   add constraint FK_AGENDABA_REALIZABA_TRABAJAD foreign key (IDTRABAJADOR)
      references TRABAJADOR (IDTRABAJADOR)
go

alter table AGENDABANOS
   add constraint FK_AGENDABA_TIENEAGEN_SOLICITU foreign key (IDSOLICITUD)
      references SOLICITUD (IDSOLICITUD)
go

alter table CLIENTE
   add constraint FK_CLIENTE_CLIENTETI_ROL foreign key (IDROL)
      references ROL (IDROL)
go

alter table CLIENTE
   add constraint FK_CLIENTE_ISADOS_PERSONA foreign key (IDPERSONA)
      references PERSONA (IDPERSONA)
go

alter table MASCOTA
   add constraint FK_MASCOTA_TIENEMASC_CLIENTE foreign key (IDCLIENTE)
      references CLIENTE (IDCLIENTE)
go

alter table PAGOSS
   add constraint FK_PAGOSS_GENERA_ADMINIST foreign key (IDADMINISTACIONSOLICITUD)
      references ADMINISTRACIONSOLICITUD (IDADMINISTACIONSOLICITUD)
go

alter table PREGUNTAS
   add constraint FK_PREGUNTA_TIENEPREG_SOLICITU foreign key (IDSOLICITUD)
      references SOLICITUD (IDSOLICITUD)
go

alter table RESERVA
   add constraint FK_RESERVA_TIENEHABI_HABITACI foreign key (IDHABITACION)
      references HABITACION (IDHABITACION)
go

alter table RESERVA
   add constraint FK_RESERVA_TIENERESE_SOLICITU foreign key (IDSOLICITUD)
      references SOLICITUD (IDSOLICITUD)
go

alter table RESPUESTAS
   add constraint FK_RESPUEST_TIENE_PREGUNTA foreign key (IDPREGUNTA)
      references PREGUNTAS (IDPREGUNTA)
go

alter table SOLICITUD
   add constraint FK_SOLICITU_DETERMINA_TIPODESO foreign key (IDTIPODESOLICITUD)
      references TIPODESOLICITUD (IDTIPODESOLICITUD)
go

alter table SOLICITUD
   add constraint FK_SOLICITU_ESTAEN_MASCOTA foreign key (IDMASCOTA)
      references MASCOTA (IDMASCOTA)
go

alter table SOLICITUD
   add constraint FK_SOLICITU_PIDE_CLIENTE foreign key (IDCLIENTE)
      references CLIENTE (IDCLIENTE)
go

alter table STATUS
   add constraint FK_STATUS_TIENESTAT_MASCOTA foreign key (IDMASCOTA)
      references MASCOTA (IDMASCOTA)
go

alter table TRABAJADOR
   add constraint FK_TRABAJAD_ISAUNO_PERSONA foreign key (IDPERSONA)
      references PERSONA (IDPERSONA)
go

alter table TRABAJADOR
   add constraint FK_TRABAJAD_TRABAJADO_ROL foreign key (IDROL)
      references ROL (IDROL)
go

alter table USUARIO
   add constraint FK_USUARIO_DETERMINA_ROL foreign key (IDROL)
      references ROL (IDROL)
go

