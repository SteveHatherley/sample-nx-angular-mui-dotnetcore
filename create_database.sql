-- Table: public.inventory_items

-- DROP TABLE IF EXISTS public.inventory_items;

CREATE TABLE IF NOT EXISTS public.inventory_items
(
    id uuid NOT NULL,
    description text COLLATE pg_catalog."default" NOT NULL,
    quantity smallint NOT NULL DEFAULT '0'::smallint,
    CONSTRAINT inventory_items_pkey PRIMARY KEY (id)
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.inventory_items
    OWNER to postgres;