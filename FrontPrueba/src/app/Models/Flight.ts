import { Transport } from "./Transport";

export interface Flight{
    Origin: string;
    Destination: string;
    Price: number;
    Transport: Transport;
}