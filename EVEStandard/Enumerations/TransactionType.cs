﻿namespace EVEStandard.Enumerations
{
    /// <summary>
    /// Transaction type, different type of transaction will populate different fields in `extra_info` Note: If you have an existing XML API application that is using ref_types, you will need to know which string ESI ref_type maps to which integer. You can use the following gist to see string->int mappings: https://gist.github.com/ccp-zoetrope/c03db66d90c2148724c06171bc52e0ec
    /// </summary>
    /// <value>Transaction type, different type of transaction will populate different fields in `extra_info` Note: If you have an existing XML API application that is using ref_types, you will need to know which string ESI ref_type maps to which integer. You can use the following gist to see string->int mappings: https://gist.github.com/ccp-zoetrope/c03db66d90c2148724c06171bc52e0ec</value>
    public enum TransactionType
    {
        acceleration_gate_fee = 1,
        advertisement_listing_fee = 2,
        agent_donation = 3,
        agent_location_services = 4,
        agent_miscellaneous = 5,
        agent_mission_collateral_paid = 6,
        agent_mission_collateral_refunded = 7,
        agent_mission_reward = 8,
        agent_mission_reward_corporation_tax = 9,
        agent_mission_time_bonus_reward = 10,
        agent_mission_time_bonus_reward_corporation_tax = 11,
        agent_security_services = 12,
        agent_services_rendered = 13,
        agents_preward = 14,
        alliance_maintainance_fee = 15,
        alliance_registration_fee = 16,
        asset_safety_recovery_tax = 17,
        bounty = 18,
        bounty_prize = 19,
        bounty_prize_corporation_tax = 20,
        bounty_prizes = 21,
        bounty_reimbursement = 22,
        bounty_surcharge = 23,
        brokers_fee = 24,
        clone_activation = 25,
        clone_transfer = 26,
        contraband_fine = 27,
        contract_auction_bid = 28,
        contract_auction_bid_corp = 29,
        contract_auction_bid_refund = 30,
        contract_auction_sold = 31,
        contract_brokers_fee = 32,
        contract_brokers_fee_corp = 33,
        contract_collateral = 34,
        contract_collateral_deposited_corp = 35,
        contract_collateral_payout = 36,
        contract_collateral_refund = 37,
        contract_deposit = 38,
        contract_deposit_corp = 39,
        contract_deposit_refund = 40,
        contract_deposit_sales_tax = 41,
        contract_price = 42,
        contract_price_payment_corp = 43,
        contract_reversal = 44,
        contract_reward = 45,
        contract_reward_deposited = 46,
        contract_reward_deposited_corp = 47,
        contract_reward_refund = 48,
        contract_sales_tax = 49,
        copying = 50,
        corporate_reward_payout = 51,
        corporate_reward_tax = 52,
        corporation_account_withdrawal = 53,
        corporation_bulk_payment = 54,
        corporation_dividend_payment = 55,
        corporation_liquidation = 56,
        corporation_logo_change_cost = 57,
        corporation_payment = 58,
        corporation_registration_fee = 59,
        courier_mission_escrow = 60,
        cspa = 61,
        cspaofflinerefund = 62,
        datacore_fee = 63,
        dna_modification_fee = 64,
        docking_fee = 65,
        duel_wager_escrow = 66,
        duel_wager_payment = 67,
        duel_wager_refund = 68,
        factory_slot_rental_fee = 69,
        gm_cash_transfer = 70,
        industry_job_tax = 71,
        infrastructure_hub_maintenance = 72,
        inheritance = 73,
        insurance = 74,
        jump_clone_activation_fee = 75,
        jump_clone_installation_fee = 76,
        kill_right_fee = 77,
        lp_store = 78,
        manufacturing = 79,
        market_escrow = 80,
        market_fine_paid = 81,
        market_transaction = 82,
        medal_creation = 83,
        medal_issued = 84,
        mission_completion = 85,
        mission_cost = 86,
        mission_expiration = 87,
        mission_reward = 88,
        office_rental_fee = 89,
        operation_bonus = 90,
        opportunity_reward = 91,
        planetary_construction = 92,
        planetary_export_tax = 93,
        planetary_import_tax = 94,
        player_donation = 95,
        player_trading = 96,
        project_discovery_reward = 97,
        project_discovery_tax = 98,
        reaction = 99,
        release_of_impounded_property = 100,
        repair_bill = 101,
        reprocessing_tax = 102,
        researching_material_productivity = 103,
        researching_technology = 104,
        researching_time_productivity = 105,
        resource_wars_reward = 106,
        reverse_engineering = 107,
        security_processing_fee = 108,
        shares = 109,
        sovereignity_bill = 110,
        store_purchase = 111,
        store_purchase_refund = 112,
        transaction_tax = 113,
        upkeep_adjustment_fee = 114,
        war_ally_contract = 115,
        war_fee = 116,
        war_fee_surrender = 117,
        structure_gate_jump = 118
    }
}
