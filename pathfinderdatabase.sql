USE master;
GO
ALTER DATABASE pathfinder_characters
SET SINGLE_USER
WITH ROLLBACK IMMEDIATE;

IF DB_ID('pathfinder_characters') IS NOT NULL
BEGIN
	ALTER DATABASE pathfinder_characters SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
	DROP DATABASE pathfinder_characters;
END

CREATE DATABASE pathfinder_characters
GO

USE pathfinder_characters
GO

--create tables

CREATE TABLE character_base(
character_id INT IDENTITY(1,1)NOT NULL,
character_name VARCHAR (200) NOT NULL,
player_name VARCHAR (200) NOT NULL,
character_backstory VARCHAR(MAX) NOT NULL,
hit_points INT NOT NULL,
character_size VARCHAR (200) NOT NULL,
level INT NOT NULL,
race VARCHAR(200) NOT NULL,
strength_unmodified INT NOT NULL,
dexterity_unmodified INT NOT NULL,
constitution_unmodified INT NOT NULL,
intelligence_unmodified INT NOT NULL,
wisdowm_unmodified INT NOT NULL,
charisma_unmodified INT NOT NULL,
CONSTRAINT pk_character_base PRIMARY KEY (character_id)
);

CREATE TABLE skills(
skill_id INT IDENTITY(1,1)NOT NULL,
skill_name VARCHAR (200) NOT NULL,
skill_description VARCHAR(MAX) NOT NULL,
skill_class VARCHAR(200) NOT NULL,
skill_ranks INT NOT NULL,
skill_modifier INT NOT NULL,
CONSTRAINT pk_skills PRIMARY KEY (skill_id)
);

CREATE TABLE spells(
spell_id INT IDENTITY(1,1) NOT NULL,
spell_level INT NOT NULL,
spell_type VARCHAR (200) NOT NULL,
spell_name VARCHAR (200) NOT NULL,
spell_description VARCHAR (MAX) NOT NULL,
spell_dc INT NOT NULL,
CONSTRAINT pk_spells PRIMARY KEY (spell_id)
);

CREATE TABLE armor(
armor_id INT IDENTITY (1,1) NOT NULL,
armor_weight_class VARCHAR(200) NOT NULL,
armor_description VARCHAR(max) NOT NULL,
armor_name VARCHAR(200) NOT NULL,
is_magical BIT,
is_masterwork BIT,
magical_modifier INT NULL,
armor_class INT NOT NULL,
CONSTRAINT pk_armor PRIMARY KEY (armor_id),
);

CREATE TABLE weapons(
weapon_id INT IDENTITY (1,1) NOT NULL,
weapon_size VARCHAR(200) NOT NULL,
weapon_name VARCHAR(200) NOT NULL,
is_melee BIT NOT NULL,
is_ranged BIT NOT NULL,
is_piercing BIT NOT NULL,
is_slashing BIT NOT NULL,
is_bludgeoning BIT NOT NULL,
is_magical BIT NOT NULL,
is_masterwork BIT NOT NULL,
magical_modifier INT NULL,
weapon_damage VARCHAR(200) NOT NULL,
CONSTRAINT pk_weapon PRIMARY KEY (weapon_id)
);

CREATE TABLE feats(
feat_id INT IDENTITY (1,1) NOT NULL,
feat_name VARCHAR (200),
feat_description VARCHAR (MAX),
CONSTRAINT pk_feats PRIMARY KEY (feat_id)
);

CREATE TABLE traits(
trait_id INT IDENTITY (1,1) NOT NULL,
trait_name VARCHAR (200),
trait_description VARCHAR (MAX),
CONSTRAINT pk_traits PRIMARY KEY (trait_id)
);

CREATE TABLE special_abilities(
ability_id INT IDENTITY (1,1) NOT NULL,
ability_name VARCHAR (200),
ability_description VARCHAR(MAX)
CONSTRAINT pk_special_abilities PRIMARY KEY (ability_id)
);

CREATE TABLE character_skills(
character_id INT NOT NULL,
skill_id INT NOT NULL
CONSTRAINT pk_character_skills PRIMARY KEY (character_id, skill_id),
CONSTRAINT fk_character_id FOREIGN KEY (character_id) REFERENCES [character_base] (character_id),
CONSTRAINT fk_skill_id FOREIGN KEY (skill_id) REFERENCES [skills] (skill_id),
);

CREATE TABLE character_spells(
character_id INT NOT NULL,
spell_id INT NOT NULL,
CONSTRAINT pk_character_spells PRIMARY KEY (character_id, spell_id),
CONSTRAINT fk_character_id1 FOREIGN KEY (character_id) REFERENCES [character_base] (character_id),
CONSTRAINT fk_spell_id FOREIGN KEY (spell_id) REFERENCES [spells] (spell_id),
);

CREATE TABLE character_weapon(
character_id INT NOT NULL,
weapon_id INT NOT NULL,
CONSTRAINT pk_character_weapon PRIMARY KEY (character_id, weapon_id),
CONSTRAINT fk_character_id2 FOREIGN KEY (character_id) REFERENCES [character_base] (character_id),
CONSTRAINT fk_weapon_id FOREIGN KEY (weapon_id) REFERENCES [weapons] (weapon_id)
);

CREATE TABLE character_armor(
character_id INT NOT NULL,
armor_id INT NOT NULL,
CONSTRAINT pk_character_armor PRIMARY KEY (character_id, armor_id),
CONSTRAINT fk_character_id3 FOREIGN KEY (character_id) REFERENCES [character_base] (character_id),
CONSTRAINT fk_armor_id FOREIGN KEY (armor_id) REFERENCES [armor] (armor_id),
);

CREATE TABLE character_feats(
character_id INT NOT NULL,
feat_id INT NOT NULL,
CONSTRAINT pk_character_feats PRIMARY KEY (character_id, feat_id),
CONSTRAINT fk_character_id4 FOREIGN KEY (character_id) REFERENCES [character_base] (character_id),
CONSTRAINT fk_feat_id FOREIGN KEY (feat_id) REFERENCES [feats] (feat_id)
);

CREATE TABLE character_abilities(
character_id INT NOT NULL,
ability_id INT NOT NULL,
CONSTRAINT pk_character_abilities PRIMARY KEY (character_id, ability_id),
CONSTRAINT fk_character_id5 FOREIGN KEY (character_id) REFERENCES [character_base] (character_id),
CONSTRAINT fk_ability_id FOREIGN KEY (ability_id) REFERENCES [special_abilities] (ability_id)
);

CREATE TABLE character_traits(
character_id INT NOT NULL,
trait_id INT NOT NULL,
CONSTRAINT pk_character_traits PRIMARY KEY (character_id, trait_id),
CONSTRAINT fk_character_id6 FOREIGN KEY (character_id) REFERENCES [character_base] (character_id),
CONSTRAINT fk_trait_id FOREIGN KEY (trait_id) REFERENCES [traits] (trait_id)
);