class storage{

    #innerStorage = [];

    add(data, id = this.#innerStorage.length){
        id = id.toString();
        this.#innerStorage.push({key:id, data});
    }

    getById(Id){
        if(Id){
            Id = Id.toString();
            let result =  this.#innerStorage?.find(i=>i.key == Id).data;
            if(result){
                return result;
            } else{
                return null;
            }
        } else{
            return null;
        }
    }

    getAll(){
        let result = [];
        for(let i = 0; i < this.#innerStorage.length; i++){
            result[i] = this.#innerStorage[i].data;
            }
        return result;
    }

    deleteById(Id){
        if(Id){
            Id = Id.toString();
            let result =  this.getById(Id);
            if(result){
                return this.#innerStorage.splice(this.#innerStorage.findIndex(i => result), 1);
            } else{
                return null;
            }
        } else{
            return null;
        }
    }

    updateById(){

    }
}
