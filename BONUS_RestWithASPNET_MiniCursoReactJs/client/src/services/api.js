import axios from "axios";

const api = axios.create({
    baseURL: 'https://localhost:7295'
})

export default api;