CREATE TABLE "Roles"(
    "Id" INT NOT NULL,
    "Name" VARCHAR NOT NULL
);
ALTER TABLE
    "Roles" ADD CONSTRAINT "roles_id_primary" PRIMARY KEY("Id");
CREATE TABLE "UserRoles"(
    "RoleId" INT NOT NULL,
    "UserId" INT NOT NULL
);
ALTER TABLE
    "UserRoles" ADD CONSTRAINT "userroles_roleid_primary" PRIMARY KEY("RoleId");
ALTER TABLE
    "UserRoles" ADD CONSTRAINT "userroles_userid_primary" PRIMARY KEY("UserId");
CREATE TABLE "Users"("Id" INT NOT NULL);
ALTER TABLE
    "Users" ADD CONSTRAINT "users_id_primary" PRIMARY KEY("Id");
CREATE TABLE "Permissions"(
    "CommandId" INT NOT NULL,
    "FunctionId" INT NOT NULL,
    "RoleId" INT NOT NULL
);
ALTER TABLE
    "Permissions" ADD CONSTRAINT "permissions_commandid_primary" PRIMARY KEY("CommandId");
ALTER TABLE
    "Permissions" ADD CONSTRAINT "permissions_functionid_primary" PRIMARY KEY("FunctionId");
ALTER TABLE
    "Permissions" ADD CONSTRAINT "permissions_roleid_primary" PRIMARY KEY("RoleId");
CREATE TABLE "Functions"(
    "Id" INT NOT NULL,
    "Name" VARCHAR NOT NULL,
    "Url" VARCHAR NOT NULL,
    "SortOrder" INT NOT NULL,
    "ParentId" INT NOT NULL
);
ALTER TABLE
    "Functions" ADD CONSTRAINT "functions_id_primary" PRIMARY KEY("Id");
CREATE TABLE "Commands"(
    "Id" INT NOT NULL,
    "Name" BIGINT NOT NULL
);
ALTER TABLE
    "Commands" ADD CONSTRAINT "commands_id_primary" PRIMARY KEY("Id");
CREATE TABLE "CommandInFunctions"(
    "CommandId" INT NOT NULL,
    "FunctionId" INT NOT NULL
);
ALTER TABLE
    "CommandInFunctions" ADD CONSTRAINT "commandinfunctions_commandid_primary" PRIMARY KEY("CommandId");
ALTER TABLE
    "CommandInFunctions" ADD CONSTRAINT "commandinfunctions_functionid_primary" PRIMARY KEY("FunctionId");
CREATE TABLE "Languages"(
    "Id" VARCHAR NOT NULL,
    "Name" NVARCHAR(255) NOT NULL
);
ALTER TABLE
    "Languages" ADD CONSTRAINT "languages_id_primary" PRIMARY KEY("Id");
CREATE TABLE "ProductCategories"(
    "Id" INT NOT NULL,
    "Name" BIGINT NOT NULL,
    "ParentId" INT NOT NULL
);
ALTER TABLE
    "ProductCategories" ADD CONSTRAINT "productcategories_id_primary" PRIMARY KEY("Id");
CREATE TABLE "Products"("Id" INT NOT NULL);
ALTER TABLE
    "Products" ADD CONSTRAINT "products_id_primary" PRIMARY KEY("Id");
CREATE TABLE "ProductInProductCategories"(
    "ProductId" INT NOT NULL,
    "ProductCategoryId" INT NOT NULL
);
ALTER TABLE
    "ProductInProductCategories" ADD CONSTRAINT "productinproductcategories_productid_primary" PRIMARY KEY("ProductId");
ALTER TABLE
    "ProductInProductCategories" ADD CONSTRAINT "productinproductcategories_productcategoryid_primary" PRIMARY KEY("ProductCategoryId");
CREATE TABLE "ProductTranslates"(
    "Id" INT NOT NULL,
    "ProductId" INT NOT NULL,
    "LangId" VARCHAR NOT NULL
);
ALTER TABLE
    "ProductTranslates" ADD CONSTRAINT "producttranslates_id_primary" PRIMARY KEY("Id");
ALTER TABLE
    "ProductTranslates" ADD CONSTRAINT "producttranslates_productid_primary" PRIMARY KEY("ProductId");
ALTER TABLE
    "ProductTranslates" ADD CONSTRAINT "producttranslates_langid_primary" PRIMARY KEY("LangId");
CREATE TABLE "ProductCategoryTranslates"(
    "Id" INT NOT NULL,
    "ProductCategoryId" INT NOT NULL,
    "LangId" VARCHAR NOT NULL
);
ALTER TABLE
    "ProductCategoryTranslates" ADD CONSTRAINT "productcategorytranslates_id_primary" PRIMARY KEY("Id");
ALTER TABLE
    "ProductCategoryTranslates" ADD CONSTRAINT "productcategorytranslates_productcategoryid_primary" PRIMARY KEY("ProductCategoryId");
ALTER TABLE
    "ProductCategoryTranslates" ADD CONSTRAINT "productcategorytranslates_langid_primary" PRIMARY KEY("LangId");
CREATE TABLE "SystemConfigs"(
    "Name" VARCHAR NOT NULL,
    "Value" NVARCHAR(255) NOT NULL
);
ALTER TABLE
    "SystemConfigs" ADD CONSTRAINT "systemconfigs_name_primary" PRIMARY KEY("Name");
CREATE TABLE "Activities"(
    "Id" INT NOT NULL,
    "Name" NVARCHAR(255) NOT NULL,
    "Url" BIGINT NOT NULL,
    "Description" NVARCHAR(255) NOT NULL,
    "UserId" INT NOT NULL
);
ALTER TABLE
    "Activities" ADD CONSTRAINT "activities_id_primary" PRIMARY KEY("Id");
ALTER TABLE
    "Activities" ADD CONSTRAINT "activities_userid_foreign" FOREIGN KEY("UserId") REFERENCES "Users"("Id");
ALTER TABLE
    "ProductCategories" ADD CONSTRAINT "productcategories_parentid_foreign" FOREIGN KEY("ParentId") REFERENCES "ProductCategories"("Id");