<template>
    <div class="shopping-list">
        <h1>My Shopping List</h1>
        <ul>
            <li v-for="item in groceries" v-bind:key="item.id" v-bind:class="{ completed: item.completed }" v-on:click="handleClick(item.id)" style="cursor: pointer">
                <input type="checkbox" v-model="item.completed" />
                {{item.name}} 
                <i class="far fa-check-circle" v-bind:class="{ completed: item.completed }"></i>
            </li>
        </ul>
    </div>
</template>

<script>
export default {
    data() {
        return {
            groceries: [
                { name: 'Oatmeal', completed: false, id: "oatmeal" },
                { name: 'Milk', completed: false, id: "milk" },
                { name: 'Banana', completed: false, id: "banana" },
                { name: 'Strawberries', completed: false, id: "strawberries" },
                { name: 'Lunch Meat', completed: false, id: "lunch-meat" },
                { name: 'Bread', completed: false, id: "bread" },
                { name: 'Grapes', completed: false, id: "grapes" },
                { name: 'Steak', completed: false, id: "steak" },
                { name: 'Salad', completed: false, id: "salad" }
            ]
        }
    },
    methods: {
        handleClick(elementId){
            let groceryItem = this.groceries.find(item =>{return item.id == elementId});
            groceryItem.completed = !groceryItem.completed;
        }
    }
}
</script>

<style>
.shopping-list {
    width:450px;
    background: #fff;
    margin: 50px auto;
    font-family: 'Roboto Condensed', sans-serif;
    border-radius: 10px;
}
h1 {
    background:#f2f2f2;
    color:#5c8578;
    padding:10px;
    font-size:24px;
    text-transform: uppercase;
    text-align: center;
    margin-bottom: 0px;
    border-top-left-radius: 10px;
    border-top-right-radius: 10px;
}
ul {
    list-style-type: none;
    margin:0px;
    padding:0px;
}
li {
    font-size: 24px;
    border-bottom:1px solid #f2f2f2;
    padding:10px 20px;
}
li:last-child{
    border:0px;
}
li.completed {
    text-decoration: line-through;
    color:darkgrey;
}
i.far.fa-check-circle { 
    float:right;
    color: darkgray;
}

i.far.fa-check-circle.completed {
    color:green;
}
input[type="checkbox"] {
    font-size:40px;
    vertical-align: middle;
    margin-top:0px;
}
</style>
