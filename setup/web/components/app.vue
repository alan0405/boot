<template>
    <div class="app">
        <div class="title">新建Boot项目</div>
        <div class="content">
            <span> 名称:</span>
            <input
                ref="name"
                v-model="name"
            >
        </div>
        <div class="content">
            <span> 路径: </span>
            <input v-model="path">
            <button @click="openFolder">...</button>
        </div>
        <div class="btn">
            <button @click="create">生成</button>
        </div>
    </div>
</template>

<script>
    {
        name: "app",
        data:function(){return{            
            name:"",
            path:""
        }},
        methods: {                  
            openFolder:function(param){                  
                this.path = boot.openFolder();
            },
            create:function(){
                if(this.name.trim()==""){
                    boot.Msg("请输入项目名称");
                    return;                    
                }
                if(this.path.trim()==""){
                    boot.Msg("请选择项目目录");
                    return;
                }
                localStorage.setItem("lastpath",this.path);
                boot.Create(this.path+"/"+this.name);               
            },
        },
        created:function(){                   
            this.path = localStorage.getItem('lastpath')                                       ;
            if(this.path == undefined){
                this.path = "";
            }
            this.$nextTick(function(){
                this.$refs.name.focus();
            })
        },
    }
</script>
<style>
.app {
    height: 100%;
    font-family: Verdana, Geneva, Tahoma, sans-serif, 微软雅黑;
}
.title {
    border-bottom: 1px solid lightblue;
    margin-bottom: 5px;
    padding: 10px;
}
.content {
    padding: 10px;
    display: flex;
}
input {
    width: 75%;
}

.btn {
    display: flex;
    flex-direction: row;
    justify-content: flex-end;
    align-items: center;
    height: 100%;
    padding-top: 20px;
    padding-right: 20px;
}
.btn button {
    width: 80px;
    height: 40px;
}
</style>